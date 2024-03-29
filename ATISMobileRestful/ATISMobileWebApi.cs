﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using System.Drawing;
using System.IO;


using R2Core.DateAndTimeManagement;
using ATISMobileRestful.Exceptions;
using R2Core.SecurityAlgorithmsManagement.Hashing;
using R2Core.LoggingManagement;
using R2CoreTransportationAndLoadNotification.Logging;
using R2Core.SoftwareUserManagement;
using R2Core.SoftwareUserManagement.Exceptions;
using ATISMobileRestful.Logging;
using R2Core.ConfigurationManagement;
using R2Core.SecurityAlgorithmsManagement.AESAlgorithms;
using R2Core.BlackIPs;
using R2Core.SecurityAlgorithmsManagement.ExpressionValidationAlgorithms;
using R2Core.PredefinedMessagesManagement;
using R2Core.MoneyWallet.PaymentRequests;

namespace ATISMobileRestful
{
    public class ATISMobileWebApi
    {
        R2DateTime _DateTime = new R2DateTime();

        public R2CoreStandardSoftwareUserStructure GetNSSSoftwareUser(HttpRequestMessage YourRequest)
        {
            try
            {
                var InstanceAES = new AESAlgorithmsManager();
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var Content = JsonConvert.DeserializeObject<string>(YourRequest.Content.ReadAsStringAsync().Result);
                var MobileNumber = InstanceAES.Decrypt(Content.Split(';')[0], InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                var InstanceEVA = new ExpressionValidationAlgorithmsManager();
                InstanceEVA.ValidationMobileNumber(MobileNumber);
                var NSSSoftwareuser = InstanceSoftwareusers.GetNSSUserChangeableData(new R2CoreSoftwareUserMobile(MobileNumber));
                return NSSSoftwareuser;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void AuthenticateClient(HttpRequestMessage YourRequest, Int64 YourLogId)
        {
            try
            {
                var InstanceLogging = new R2CoreInstanceLoggingManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceBlackIP = new R2CoreInstanceBlackIPsManager();
                var InstanceEVA = new ExpressionValidationAlgorithmsManager();
                var IP = GetClientIpAddress(YourRequest);
                if (InstanceLogging.GetNSSLogType(YourLogId).Active)
                { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, YourLogId, InstanceLogging.GetNSSLogType(YourLogId).LogTitle, IP, string.Empty, string.Empty, string.Empty, string.Empty, InstanceSoftwareusers.GetSystemUserId(), _DateTime.GetCurrentDateTimeMilladi(), null)); }
                InstanceBlackIP.AuthorizationIP(IP);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void AuthenticateClientRegisteringMobileNumber(HttpRequestMessage YourRequest)
        {
            try
            {
                var InstanceLogging = new R2CoreInstanceLoggingManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceBlackIP = new R2CoreInstanceBlackIPsManager();
                var IP = GetClientIpAddress(YourRequest);
                var MobileNumber = JsonConvert.DeserializeObject<string>(YourRequest.Content.ReadAsStringAsync().Result);
                if (InstanceLogging.GetNSSLogType(ATISMobileWebApiLogTypes.WebApiClientRegisterMobileNumberRequest).Active)
                { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, ATISMobileWebApiLogTypes.WebApiClientRegisterMobileNumberRequest, InstanceLogging.GetNSSLogType(ATISMobileWebApiLogTypes.WebApiClientRegisterMobileNumberRequest).LogTitle, IP, MobileNumber, string.Empty, string.Empty, string.Empty, InstanceSoftwareusers.GetSystemUserId(), _DateTime.GetCurrentDateTimeMilladi(), null)); }
                InstanceBlackIP.AuthorizationIP(IP);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void AuthenticateClientVerificationCode(HttpRequestMessage YourRequest)
        {
            try
            {
                var InstanceLogging = new R2CoreInstanceLoggingManager();
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceAES = new AESAlgorithmsManager();
                var InstanceHash = new SHAHasher();
                var InstanceBlackIP = new R2CoreInstanceBlackIPsManager();
                var Content = JsonConvert.DeserializeObject<string>(YourRequest.Content.ReadAsStringAsync().Result);
                var MobileNumber = Content.Split(';')[0];
                var Hash = Content.Split(';')[1];
                var IP = GetClientIpAddress(YourRequest);
                if (InstanceLogging.GetNSSLogType(ATISMobileWebApiLogTypes.WebApiClientLoginRequest).Active)
                { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, ATISMobileWebApiLogTypes.WebApiClientLoginRequest, InstanceLogging.GetNSSLogType(ATISMobileWebApiLogTypes.WebApiClientLoginRequest).LogTitle, IP, MobileNumber, Hash, string.Empty, string.Empty, InstanceSoftwareusers.GetSystemUserId(), _DateTime.GetCurrentDateTimeMilladi(), null)); }
                InstanceBlackIP.AuthorizationIP(IP);
                var NSSSoftwareuser = InstanceSoftwareusers.GetNSSUserChangeableData(new R2CoreSoftwareUserMobile(MobileNumber));
                if (_DateTime.GetCurrentDateTimeMilladi().Subtract(NSSSoftwareuser.VerificationCodeTimeStamp).TotalSeconds > InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 7))
                { throw new WebApiClientVerificationCodeExpiredException(); };
                if (NSSSoftwareuser.VerificationCodeCount == 0)
                { throw new WebApiClientVerificationCodeExpiredException(); }
                else
                { InstanceSoftwareusers.DecreaseVerificationCodeCountforSoftwareUser(NSSSoftwareuser); }
                if (Hash != InstanceHash.GenerateSHA256String(NSSSoftwareuser.VerificationCode))
                { throw new WebApiClientSecurityHashInvalidException(); };
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void AuthenticateClientGetPersonalNonce(HttpRequestMessage YourRequest)
        {
            try
            {
                var InstanceLogging = new R2CoreInstanceLoggingManager();
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceAES = new AESAlgorithmsManager();
                var InstanceHash = new SHAHasher();
                var InstanceBlackIP = new R2CoreInstanceBlackIPsManager();
                var IP = GetClientIpAddress(YourRequest);
                var Content = JsonConvert.DeserializeObject<string>(YourRequest.Content.ReadAsStringAsync().Result);
                var MobileNumber = InstanceAES.Decrypt(Content.Split(';')[0], InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                var Hash = Content.Split(';')[1];
                if (InstanceLogging.GetNSSLogType(ATISMobileWebApiLogTypes.WebApiClientPersonalNonceRequest).Active)
                { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, ATISMobileWebApiLogTypes.WebApiClientPersonalNonceRequest, InstanceLogging.GetNSSLogType(ATISMobileWebApiLogTypes.WebApiClientPersonalNonceRequest).LogTitle, IP, MobileNumber, Hash, string.Empty, string.Empty, InstanceSoftwareusers.GetSystemUserId(), _DateTime.GetCurrentDateTimeMilladi(), null)); }
                InstanceBlackIP.AuthorizationIP(IP);
                var NSSSoftwareuser = InstanceSoftwareusers.GetNSSUserChangeableData(new R2CoreSoftwareUserMobile(MobileNumber));
                if (_DateTime.GetCurrentDateTimeMilladi().Subtract(NSSSoftwareuser.NonceTimeStamp).TotalSeconds > InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 8))
                { throw new WebApiClientNonceExpiredException(); };
                if (NSSSoftwareuser.NonceCount == 0)
                { throw new WebApiClientNonceExpiredException(); }
                else
                { InstanceSoftwareusers.DecreaseNonceCountforSoftwareUser(NSSSoftwareuser); }
                if (DateTime.Compare(_DateTime.GetMilladiDateTimeFromDateShamsiFull(NSSSoftwareuser.APIKeyExpiration, "00:00:00"), _DateTime.GetCurrentDateTimeMilladi()) < 0)
                { throw new WebApiClientSoftwareUserAPIKeyExpiredException(); };
                if (DateTime.Compare(_DateTime.GetMilladiDateTimeFromDateShamsiFull(NSSSoftwareuser.UserPasswordExpiration, "00:00:00"), _DateTime.GetCurrentDateTimeMilladi()) < 0)
                { throw new WebApiClientSoftWareUserPasswordExpiredException(); };
                if (NSSSoftwareuser.UserStatus == "logout")
                { throw new WebApiClientSoftwareUserIsLogoutException(); };
                if (Hash != InstanceHash.GenerateSHA256String(InstanceAES.Encrypt(NSSSoftwareuser.ApiKey, InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3)) + NSSSoftwareuser.Nonce + NSSSoftwareuser.UserShenaseh + NSSSoftwareuser.UserPassword + NSSSoftwareuser.Captcha))
                { throw new WebApiClientSecurityHashInvalidException(); }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void AuthenticateClientGetNonce(HttpRequestMessage YourRequest, Int64 YourLogId)
        {
            try
            {
                var InstanceLogging = new R2CoreInstanceLoggingManager();
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceAES = new AESAlgorithmsManager();
                var InstanceBlackIP = new R2CoreInstanceBlackIPsManager();
                var InstanceHash = new SHAHasher();
                var IP = GetClientIpAddress(YourRequest);
                var Content = JsonConvert.DeserializeObject<string>(YourRequest.Content.ReadAsStringAsync().Result);
                var MobileNumber = InstanceAES.Decrypt(Content.Split(';')[0], InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                var Hash = Content.Split(';')[1];
                if (InstanceLogging.GetNSSLogType(YourLogId).Active)
                { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, YourLogId, InstanceLogging.GetNSSLogType(YourLogId).LogTitle, IP, MobileNumber, Hash, string.Empty, string.Empty, InstanceSoftwareusers.GetSystemUserId(), _DateTime.GetCurrentDateTimeMilladi(), null)); }
                InstanceBlackIP.AuthorizationIP(IP);
                var NSSSoftwareuser = GetNSSSoftwareUser(YourRequest);
                if (DateTime.Compare(_DateTime.GetMilladiDateTimeFromDateShamsiFull(NSSSoftwareuser.APIKeyExpiration, "00:00:00"), _DateTime.GetCurrentDateTimeMilladi()) < 0)
                { throw new WebApiClientSoftwareUserAPIKeyExpiredException(); };
                if (NSSSoftwareuser.UserStatus == "logout")
                { throw new WebApiClientSoftwareUserIsLogoutException(); };
                if (Hash != InstanceHash.GenerateSHA256String(InstanceAES.Encrypt(NSSSoftwareuser.ApiKey, InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3))))
                { throw new WebApiClientSecurityHashInvalidException(); }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void AuthenticateClientGetCaptcha(HttpRequestMessage YourRequest)
        {
            try
            {
                var InstanceLogging = new R2CoreInstanceLoggingManager();
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceAES = new AESAlgorithmsManager();
                var InstanceBlackIP = new R2CoreInstanceBlackIPsManager();
                var InstanceHash = new SHAHasher();
                var Content = JsonConvert.DeserializeObject<string>(YourRequest.Content.ReadAsStringAsync().Result);
                var MobileNumber = InstanceAES.Decrypt(Content.Split(';')[0], InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                var Hash = Content.Split(';')[1];
                var IP = GetClientIpAddress(YourRequest);
                if (InstanceLogging.GetNSSLogType(ATISMobileWebApiLogTypes.WebApiClientCaptchaRequest).Active)
                { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, ATISMobileWebApiLogTypes.WebApiClientCaptchaRequest, InstanceLogging.GetNSSLogType(ATISMobileWebApiLogTypes.WebApiClientCaptchaRequest).LogTitle, IP, MobileNumber, Hash, string.Empty, string.Empty, InstanceSoftwareusers.GetSystemUserId(), _DateTime.GetCurrentDateTimeMilladi(), null)); }
                InstanceBlackIP.AuthorizationIP(IP);
                var NSSSoftwareuser = GetNSSSoftwareUser(YourRequest);
                if (_DateTime.GetCurrentDateTimeMilladi().Subtract(NSSSoftwareuser.NonceTimeStamp).TotalSeconds > InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 8))
                { throw new WebApiClientNonceExpiredException(); };
                if (NSSSoftwareuser.NonceCount == 0)
                { throw new WebApiClientNonceExpiredException(); }
                else
                { InstanceSoftwareusers.DecreaseNonceCountforSoftwareUser(NSSSoftwareuser); }
                if (DateTime.Compare(_DateTime.GetMilladiDateTimeFromDateShamsiFull(NSSSoftwareuser.APIKeyExpiration, "00:00:00"), _DateTime.GetCurrentDateTimeMilladi()) < 0)
                { throw new WebApiClientSoftwareUserAPIKeyExpiredException(); };
                if (NSSSoftwareuser.UserStatus == "logout")
                { throw new WebApiClientSoftwareUserIsLogoutException(); };
                if (Hash != InstanceHash.GenerateSHA256String(InstanceAES.Encrypt(NSSSoftwareuser.ApiKey, InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3)) + NSSSoftwareuser.Nonce))
                { throw new WebApiClientSecurityHashInvalidException(); }

            }
            catch (Exception ex)
            { throw ex; }
        }

        public void AuthenticateClientApikeyNonce(HttpRequestMessage YourRequest, Int64 YourLogId)
        {
            try
            {
                var InstanceLogging = new R2CoreInstanceLoggingManager();
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceAES = new AESAlgorithmsManager();
                var InstanceBlackIP = new R2CoreInstanceBlackIPsManager();
                var InstanceHash = new SHAHasher();
                var Content = JsonConvert.DeserializeObject<string>(YourRequest.Content.ReadAsStringAsync().Result);
                var MobileNumber = InstanceAES.Decrypt(Content.Split(';')[0], InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                var Hash = Content.Split(';')[1];
                var IP = GetClientIpAddress(YourRequest);
                if (InstanceLogging.GetNSSLogType(YourLogId).Active)
                { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, YourLogId, InstanceLogging.GetNSSLogType(YourLogId).LogTitle, IP, MobileNumber, Hash, string.Empty, string.Empty, InstanceSoftwareusers.GetSystemUserId(), _DateTime.GetCurrentDateTimeMilladi(), null)); }
                InstanceBlackIP.AuthorizationIP(IP);
                var NSSSoftwareuser = GetNSSSoftwareUser(YourRequest);
                if (_DateTime.GetCurrentDateTimeMilladi().Subtract(NSSSoftwareuser.NonceTimeStamp).TotalSeconds > InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 8))
                { throw new WebApiClientNonceExpiredException(); };
                if (NSSSoftwareuser.NonceCount == 0)
                { throw new WebApiClientNonceExpiredException(); }
                else
                { InstanceSoftwareusers.DecreaseNonceCountforSoftwareUser(NSSSoftwareuser); }
                if (DateTime.Compare(_DateTime.GetMilladiDateTimeFromDateShamsiFull(NSSSoftwareuser.APIKeyExpiration, "00:00:00"), _DateTime.GetCurrentDateTimeMilladi()) < 0)
                { throw new WebApiClientSoftwareUserAPIKeyExpiredException(); };
                if (NSSSoftwareuser.UserStatus == "logout")
                { throw new WebApiClientSoftwareUserIsLogoutException(); };
                if (Hash != InstanceHash.GenerateSHA256String(InstanceAES.Encrypt(NSSSoftwareuser.ApiKey, InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3)) + NSSSoftwareuser.Nonce))
                { throw new WebApiClientSecurityHashInvalidException(); }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void AuthenticateClientApikeyNonceWith1Parameter(HttpRequestMessage YourRequest, Int64 YourLogId)
        {
            try
            {
                var InstanceLogging = new R2CoreInstanceLoggingManager();
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceAES = new AESAlgorithmsManager();
                var InstanceHash = new SHAHasher();
                var InstanceBlackIP = new R2CoreInstanceBlackIPsManager();
                var IP = GetClientIpAddress(YourRequest);
                var Content = JsonConvert.DeserializeObject<string>(YourRequest.Content.ReadAsStringAsync().Result);
                var MobileNumber = InstanceAES.Decrypt(Content.Split(';')[0], InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                var NSSSoftwareuser = InstanceSoftwareusers.GetNSSUserChangeableData(new R2CoreSoftwareUserMobile(MobileNumber));
                var Hash = Content.Split(';')[1];
                var Param = Content.Split(';')[2];
                if (InstanceLogging.GetNSSLogType(YourLogId).Active)
                { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, YourLogId, InstanceLogging.GetNSSLogType(YourLogId).LogTitle, IP, MobileNumber, Hash, "Param=" + Param, string.Empty, InstanceSoftwareusers.GetSystemUserId(), _DateTime.GetCurrentDateTimeMilladi(), null)); }
                InstanceBlackIP.AuthorizationIP(IP);
                if (_DateTime.GetCurrentDateTimeMilladi().Subtract(NSSSoftwareuser.NonceTimeStamp).TotalSeconds > InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 8))
                { throw new WebApiClientNonceExpiredException(); };
                if (NSSSoftwareuser.NonceCount == 0)
                { throw new WebApiClientNonceExpiredException(); }
                else
                { InstanceSoftwareusers.DecreaseNonceCountforSoftwareUser(NSSSoftwareuser); }
                if (DateTime.Compare(_DateTime.GetMilladiDateTimeFromDateShamsiFull(NSSSoftwareuser.APIKeyExpiration, "00:00:00"), _DateTime.GetCurrentDateTimeMilladi()) < 0)
                { throw new WebApiClientSoftwareUserAPIKeyExpiredException(); };
                if (NSSSoftwareuser.UserStatus == "logout")
                { throw new WebApiClientSoftwareUserIsLogoutException(); };
                if (Hash != InstanceHash.GenerateSHA256String(InstanceAES.Encrypt(NSSSoftwareuser.ApiKey, InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3)) + NSSSoftwareuser.Nonce + Param))
                { throw new WebApiClientSecurityHashInvalidException(); }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void AuthenticateClientApikeyNonceWith2Parameter(HttpRequestMessage YourRequest, Int64 YourLogId)
        {
            try
            {
                var InstanceLogging = new R2CoreInstanceLoggingManager();
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceAES = new AESAlgorithmsManager();
                var InstanceHash = new SHAHasher();
                var InstanceBlackIP = new R2CoreInstanceBlackIPsManager();
                var IP = GetClientIpAddress(YourRequest);
                var Content = JsonConvert.DeserializeObject<string>(YourRequest.Content.ReadAsStringAsync().Result);
                var MobileNumber = InstanceAES.Decrypt(Content.Split(';')[0], InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                var Hash = Content.Split(';')[1];
                var Param1 = Content.Split(';')[2];
                var Param2 = Content.Split(';')[3];
                if (InstanceLogging.GetNSSLogType(YourLogId).Active)
                { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, YourLogId, InstanceLogging.GetNSSLogType(YourLogId).LogTitle, IP, MobileNumber, Hash, "Param1=" + Param1 + ";" + "Param2=" + Param2, string.Empty, InstanceSoftwareusers.GetSystemUserId(), _DateTime.GetCurrentDateTimeMilladi(), null)); }
                InstanceBlackIP.AuthorizationIP(IP);
                var NSSSoftwareuser = InstanceSoftwareusers.GetNSSUserChangeableData(new R2CoreSoftwareUserMobile(MobileNumber));
                if (_DateTime.GetCurrentDateTimeMilladi().Subtract(NSSSoftwareuser.NonceTimeStamp).TotalSeconds > InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 8))
                { throw new WebApiClientNonceExpiredException(); };
                if (NSSSoftwareuser.NonceCount == 0)
                { throw new WebApiClientNonceExpiredException(); }
                else
                { InstanceSoftwareusers.DecreaseNonceCountforSoftwareUser(NSSSoftwareuser); }
                if (DateTime.Compare(_DateTime.GetMilladiDateTimeFromDateShamsiFull(NSSSoftwareuser.APIKeyExpiration, "00:00:00"), _DateTime.GetCurrentDateTimeMilladi()) < 0)
                { throw new WebApiClientSoftwareUserAPIKeyExpiredException(); };
                if (NSSSoftwareuser.UserStatus == "logout")
                { throw new WebApiClientSoftwareUserIsLogoutException(); };
                if (Hash != InstanceHash.GenerateSHA256String(InstanceAES.Encrypt(NSSSoftwareuser.ApiKey, InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3)) + NSSSoftwareuser.Nonce + Param1 + Param2))
                { throw new WebApiClientSecurityHashInvalidException(); }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void AuthenticateClientApikeyNonceWith3Parameter(HttpRequestMessage YourRequest, Int64 YourLogId)
        {
            try
            {
                var InstanceLogging = new R2CoreInstanceLoggingManager();
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceAES = new AESAlgorithmsManager();
                var InstanceHash = new SHAHasher();
                var InstanceBlackIP = new R2CoreInstanceBlackIPsManager();
                var IP = GetClientIpAddress(YourRequest);
                var Content = JsonConvert.DeserializeObject<string>(YourRequest.Content.ReadAsStringAsync().Result);
                var MobileNumber = InstanceAES.Decrypt(Content.Split(';')[0], InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                var Hash = Content.Split(';')[1];
                var Param1 = Content.Split(';')[2];
                var Param2 = Content.Split(';')[3];
                var Param3 = Content.Split(';')[4];
                if (InstanceLogging.GetNSSLogType(YourLogId).Active)
                { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, YourLogId, InstanceLogging.GetNSSLogType(YourLogId).LogTitle, IP, MobileNumber, Hash, "Param1=" + Param1 + ";" + "Param2=" + Param2 + ";" + "Param3=" + Param3, string.Empty, InstanceSoftwareusers.GetSystemUserId(), _DateTime.GetCurrentDateTimeMilladi(), null)); }
                InstanceBlackIP.AuthorizationIP(IP);
                var NSSSoftwareuser = InstanceSoftwareusers.GetNSSUserChangeableData(new R2CoreSoftwareUserMobile(MobileNumber));
                if (_DateTime.GetCurrentDateTimeMilladi().Subtract(NSSSoftwareuser.NonceTimeStamp).TotalSeconds > InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 8))
                { throw new WebApiClientNonceExpiredException(); };
                if (NSSSoftwareuser.NonceCount == 0)
                { throw new WebApiClientNonceExpiredException(); }
                else
                { InstanceSoftwareusers.DecreaseNonceCountforSoftwareUser(NSSSoftwareuser); }
                if (DateTime.Compare(_DateTime.GetMilladiDateTimeFromDateShamsiFull(NSSSoftwareuser.APIKeyExpiration, "00:00:00"), _DateTime.GetCurrentDateTimeMilladi()) < 0)
                { throw new WebApiClientSoftwareUserAPIKeyExpiredException(); };
                if (NSSSoftwareuser.UserStatus == "logout")
                { throw new WebApiClientSoftwareUserIsLogoutException(); };
                if (Hash != InstanceHash.GenerateSHA256String(InstanceAES.Encrypt(NSSSoftwareuser.ApiKey, InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3)) + NSSSoftwareuser.Nonce + Param1 + Param2 + Param3))
                { throw new WebApiClientSecurityHashInvalidException(); }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void AuthenticateClientApikeyNonceWith4Parameter(HttpRequestMessage YourRequest, Int64 YourLogId)
        {
            try
            {
                var InstanceLogging = new R2CoreInstanceLoggingManager();
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceAES = new AESAlgorithmsManager();
                var InstanceHash = new SHAHasher();
                var InstanceBlackIP = new R2CoreInstanceBlackIPsManager();
                var IP = GetClientIpAddress(YourRequest);
                var Content = JsonConvert.DeserializeObject<string>(YourRequest.Content.ReadAsStringAsync().Result);
                var MobileNumber = InstanceAES.Decrypt(Content.Split(';')[0], InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                var NSSSoftwareuser = InstanceSoftwareusers.GetNSSUserChangeableData(new R2CoreSoftwareUserMobile(MobileNumber));
                var Hash = Content.Split(';')[1];
                var Param1 = Content.Split(';')[2];
                var Param2 = Content.Split(';')[3];
                var Param3 = Content.Split(';')[4];
                var Param4 = Content.Split(';')[5];
                if (InstanceLogging.GetNSSLogType(YourLogId).Active)
                { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, YourLogId, InstanceLogging.GetNSSLogType(YourLogId).LogTitle, IP, MobileNumber, Hash, "Param1=" + Param1 + ";" + "Param2=" + Param2 + ";" + "Param3=" + Param3 + ";" + "Param4=" + Param4, string.Empty, InstanceSoftwareusers.GetSystemUserId(), _DateTime.GetCurrentDateTimeMilladi(), null)); }
                InstanceBlackIP.AuthorizationIP(IP);
                if (_DateTime.GetCurrentDateTimeMilladi().Subtract(NSSSoftwareuser.NonceTimeStamp).TotalSeconds > InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 8))
                { throw new WebApiClientNonceExpiredException(); };
                if (NSSSoftwareuser.NonceCount == 0)
                { throw new WebApiClientNonceExpiredException(); }
                else
                { InstanceSoftwareusers.DecreaseNonceCountforSoftwareUser(NSSSoftwareuser); }
                if (DateTime.Compare(_DateTime.GetMilladiDateTimeFromDateShamsiFull(NSSSoftwareuser.APIKeyExpiration, "00:00:00"), _DateTime.GetCurrentDateTimeMilladi()) < 0)
                { throw new WebApiClientSoftwareUserAPIKeyExpiredException(); };
                if (NSSSoftwareuser.UserStatus == "logout")
                { throw new WebApiClientSoftwareUserIsLogoutException(); };
                if (Hash != InstanceHash.GenerateSHA256String(InstanceAES.Encrypt(NSSSoftwareuser.ApiKey, InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3)) + NSSSoftwareuser.Nonce + Param1 + Param2 + Param3 + Param4))
                { throw new WebApiClientSecurityHashInvalidException(); }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void AuthenticateClientApikeyNoncePersonalNonce(HttpRequestMessage YourRequest, Int64 YourLogId)
        {
            try
            {
                var InstanceLogging = new R2CoreInstanceLoggingManager();
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceAES = new AESAlgorithmsManager();
                var InstanceHash = new SHAHasher();
                var InstanceBlackIP = new R2CoreInstanceBlackIPsManager();
                var IP = GetClientIpAddress(YourRequest);
                var Content = JsonConvert.DeserializeObject<string>(YourRequest.Content.ReadAsStringAsync().Result);
                var MobileNumber = InstanceAES.Decrypt(Content.Split(';')[0], InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                var Hash = Content.Split(';')[1];
                if (InstanceLogging.GetNSSLogType(YourLogId).Active)
                { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, YourLogId, InstanceLogging.GetNSSLogType(YourLogId).LogTitle, IP, MobileNumber, Hash, string.Empty, string.Empty, InstanceSoftwareusers.GetSystemUserId(), _DateTime.GetCurrentDateTimeMilladi(), null)); }
                InstanceBlackIP.AuthorizationIP(IP);
                var NSSSoftwareuser = InstanceSoftwareusers.GetNSSUserChangeableData(new R2CoreSoftwareUserMobile(MobileNumber));
                if (_DateTime.GetCurrentDateTimeMilladi().Subtract(NSSSoftwareuser.NonceTimeStamp).TotalSeconds > InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 8))
                { throw new WebApiClientNonceExpiredException(); };
                if (NSSSoftwareuser.NonceCount == 0)
                { throw new WebApiClientNonceExpiredException(); }
                else
                { InstanceSoftwareusers.DecreaseNonceCountforSoftwareUser(NSSSoftwareuser); }
                if (_DateTime.GetCurrentDateTimeMilladi().Subtract(NSSSoftwareuser.PersonalNonceTimeStamp).TotalSeconds > InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 5))
                { throw new WebApiClientPersonalNonceExpiredException(); };
                if (DateTime.Compare(_DateTime.GetMilladiDateTimeFromDateShamsiFull(NSSSoftwareuser.APIKeyExpiration, "00:00:00"), _DateTime.GetCurrentDateTimeMilladi()) < 0)
                { throw new WebApiClientSoftwareUserAPIKeyExpiredException(); };
                if (DateTime.Compare(_DateTime.GetMilladiDateTimeFromDateShamsiFull(NSSSoftwareuser.UserPasswordExpiration, "00:00:00"), _DateTime.GetCurrentDateTimeMilladi()) < 0)
                { throw new WebApiClientSoftWareUserPasswordExpiredException(); };
                if (NSSSoftwareuser.UserStatus == "logout")
                { throw new WebApiClientSoftwareUserIsLogoutException(); };
                if (Hash != InstanceHash.GenerateSHA256String(InstanceAES.Encrypt(NSSSoftwareuser.ApiKey, InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3)) + NSSSoftwareuser.Nonce + NSSSoftwareuser.PersonalNonce))
                { throw new WebApiClientSecurityHashInvalidException(); }
            }
            catch (Exception ex)
            { throw ex; }
        }
        public void AuthenticateClientApikeyNoncePersonalNonceWith1Parameter(HttpRequestMessage YourRequest, Int64 YourLogId)
        {
            try
            {
                var InstanceLogging = new R2CoreInstanceLoggingManager();
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceAES = new AESAlgorithmsManager();
                var InstanceHash = new SHAHasher();
                var InstanceBlackIP = new R2CoreInstanceBlackIPsManager();
                var IP = GetClientIpAddress(YourRequest);
                var Content = JsonConvert.DeserializeObject<string>(YourRequest.Content.ReadAsStringAsync().Result);
                var MobileNumber = InstanceAES.Decrypt(Content.Split(';')[0], InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                var Hash = Content.Split(';')[1];
                var Param = Content.Split(';')[2];
                if (InstanceLogging.GetNSSLogType(YourLogId).Active)
                { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, YourLogId, InstanceLogging.GetNSSLogType(YourLogId).LogTitle, IP, MobileNumber, Hash, string.Empty, string.Empty, InstanceSoftwareusers.GetSystemUserId(), _DateTime.GetCurrentDateTimeMilladi(), null)); }
                InstanceBlackIP.AuthorizationIP(IP);
                var NSSSoftwareuser = InstanceSoftwareusers.GetNSSUserChangeableData(new R2CoreSoftwareUserMobile(MobileNumber));
                if (_DateTime.GetCurrentDateTimeMilladi().Subtract(NSSSoftwareuser.NonceTimeStamp).TotalSeconds > InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 8))
                { throw new WebApiClientNonceExpiredException(); };
                if (NSSSoftwareuser.NonceCount == 0)
                { throw new WebApiClientNonceExpiredException(); }
                else
                { InstanceSoftwareusers.DecreaseNonceCountforSoftwareUser(NSSSoftwareuser); }
                if (_DateTime.GetCurrentDateTimeMilladi().Subtract(NSSSoftwareuser.PersonalNonceTimeStamp).TotalSeconds > InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 5))
                { throw new WebApiClientPersonalNonceExpiredException(); };
                if (DateTime.Compare(_DateTime.GetMilladiDateTimeFromDateShamsiFull(NSSSoftwareuser.APIKeyExpiration, "00:00:00"), _DateTime.GetCurrentDateTimeMilladi()) < 0)
                { throw new WebApiClientSoftwareUserAPIKeyExpiredException(); };
                if (DateTime.Compare(_DateTime.GetMilladiDateTimeFromDateShamsiFull(NSSSoftwareuser.UserPasswordExpiration, "00:00:00"), _DateTime.GetCurrentDateTimeMilladi()) < 0)
                { throw new WebApiClientSoftWareUserPasswordExpiredException(); };
                if (NSSSoftwareuser.UserStatus == "logout")
                { throw new WebApiClientSoftwareUserIsLogoutException(); };
                if (Hash != InstanceHash.GenerateSHA256String(InstanceAES.Encrypt(NSSSoftwareuser.ApiKey, InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3)) + NSSSoftwareuser.Nonce + NSSSoftwareuser.PersonalNonce + Param))
                { throw new WebApiClientSecurityHashInvalidException(); }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void AuthenticateClientApikeyNoncePersonalNonceWith2Parameter(HttpRequestMessage YourRequest, Int64 YourLogId)
        {
            try
            {
                var InstanceLogging = new R2CoreInstanceLoggingManager();
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceAES = new AESAlgorithmsManager();
                var InstanceHash = new SHAHasher();
                var InstanceBlackIP = new R2CoreInstanceBlackIPsManager();
                var IP = GetClientIpAddress(YourRequest);
                var Content = JsonConvert.DeserializeObject<string>(YourRequest.Content.ReadAsStringAsync().Result);
                var MobileNumber = InstanceAES.Decrypt(Content.Split(';')[0], InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                var Hash = Content.Split(';')[1];
                var Param1 = Content.Split(';')[2];
                var Param2 = Content.Split(';')[3];
                if (InstanceLogging.GetNSSLogType(YourLogId).Active)
                { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, YourLogId, InstanceLogging.GetNSSLogType(YourLogId).LogTitle, IP, MobileNumber, Hash, "Param=" + Param1 + "-" + Param2, string.Empty, InstanceSoftwareusers.GetSystemUserId(), _DateTime.GetCurrentDateTimeMilladi(), null)); }
                InstanceBlackIP.AuthorizationIP(IP);
                var NSSSoftwareuser = InstanceSoftwareusers.GetNSSUserChangeableData(new R2CoreSoftwareUserMobile(MobileNumber));
                if (_DateTime.GetCurrentDateTimeMilladi().Subtract(NSSSoftwareuser.NonceTimeStamp).TotalSeconds > InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 8))
                { throw new WebApiClientNonceExpiredException(); };
                if (NSSSoftwareuser.NonceCount == 0)
                { throw new WebApiClientNonceExpiredException(); }
                else
                { InstanceSoftwareusers.DecreaseNonceCountforSoftwareUser(NSSSoftwareuser); }
                if (_DateTime.GetCurrentDateTimeMilladi().Subtract(NSSSoftwareuser.PersonalNonceTimeStamp).TotalSeconds > InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 5))
                { throw new WebApiClientPersonalNonceExpiredException(); };
                if (DateTime.Compare(_DateTime.GetMilladiDateTimeFromDateShamsiFull(NSSSoftwareuser.APIKeyExpiration, "00:00:00"), _DateTime.GetCurrentDateTimeMilladi()) < 0)
                { throw new WebApiClientSoftwareUserAPIKeyExpiredException(); };
                if (DateTime.Compare(_DateTime.GetMilladiDateTimeFromDateShamsiFull(NSSSoftwareuser.UserPasswordExpiration, "00:00:00"), _DateTime.GetCurrentDateTimeMilladi()) < 0)
                { throw new WebApiClientSoftWareUserPasswordExpiredException(); };
                if (NSSSoftwareuser.UserStatus == "logout")
                { throw new WebApiClientSoftwareUserIsLogoutException(); };
                if (Hash != InstanceHash.GenerateSHA256String(InstanceAES.Encrypt(NSSSoftwareuser.ApiKey, InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3)) + NSSSoftwareuser.Nonce + NSSSoftwareuser.PersonalNonce + Param1 + Param2))
                { throw new WebApiClientSecurityHashInvalidException(); }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void AuthenticateClientApikeyNoncePersonalNonceWith3Parameter(HttpRequestMessage YourRequest, Int64 YourLogId)
        {
            try
            {
                var InstanceLogging = new R2CoreInstanceLoggingManager();
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceAES = new AESAlgorithmsManager();
                var InstanceHash = new SHAHasher();
                var InstanceBlackIP = new R2CoreInstanceBlackIPsManager();
                var IP = GetClientIpAddress(YourRequest);
                var Content = JsonConvert.DeserializeObject<string>(YourRequest.Content.ReadAsStringAsync().Result);
                var MobileNumber = InstanceAES.Decrypt(Content.Split(';')[0], InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                var Hash = Content.Split(';')[1];
                var Param1 = Content.Split(';')[2];
                var Param2 = Content.Split(';')[3];
                var Param3 = Content.Split(';')[4];
                if (InstanceLogging.GetNSSLogType(YourLogId).Active)
                { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, YourLogId, InstanceLogging.GetNSSLogType(YourLogId).LogTitle, IP, MobileNumber, Hash, "Param=" + Param1 + "-" + Param2 + "-" + Param3, string.Empty, InstanceSoftwareusers.GetSystemUserId(), _DateTime.GetCurrentDateTimeMilladi(), null)); }
                InstanceBlackIP.AuthorizationIP(IP);
                var NSSSoftwareuser = InstanceSoftwareusers.GetNSSUserChangeableData(new R2CoreSoftwareUserMobile(MobileNumber));
                if (_DateTime.GetCurrentDateTimeMilladi().Subtract(NSSSoftwareuser.NonceTimeStamp).TotalSeconds > InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 8))
                { throw new WebApiClientNonceExpiredException(); };
                if (NSSSoftwareuser.NonceCount == 0)
                { throw new WebApiClientNonceExpiredException(); }
                else
                { InstanceSoftwareusers.DecreaseNonceCountforSoftwareUser(NSSSoftwareuser); }
                if (_DateTime.GetCurrentDateTimeMilladi().Subtract(NSSSoftwareuser.PersonalNonceTimeStamp).TotalSeconds > InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 5))
                { throw new WebApiClientPersonalNonceExpiredException(); };
                if (DateTime.Compare(_DateTime.GetMilladiDateTimeFromDateShamsiFull(NSSSoftwareuser.APIKeyExpiration, "00:00:00"), _DateTime.GetCurrentDateTimeMilladi()) < 0)
                { throw new WebApiClientSoftwareUserAPIKeyExpiredException(); };
                if (DateTime.Compare(_DateTime.GetMilladiDateTimeFromDateShamsiFull(NSSSoftwareuser.UserPasswordExpiration, "00:00:00"), _DateTime.GetCurrentDateTimeMilladi()) < 0)
                { throw new WebApiClientSoftWareUserPasswordExpiredException(); };
                if (NSSSoftwareuser.UserStatus == "logout")
                { throw new WebApiClientSoftwareUserIsLogoutException(); };
                if (Hash != InstanceHash.GenerateSHA256String(InstanceAES.Encrypt(NSSSoftwareuser.ApiKey, InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3)) + NSSSoftwareuser.Nonce + NSSSoftwareuser.PersonalNonce + Param1 + Param2 + Param3))
                { throw new WebApiClientSecurityHashInvalidException(); }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void AuthenticateClientPaymentVerification(System.Web.HttpRequestBase YourRequest, string YourAuthority)
        {
            try
            {
                var InstanceLogging = new R2CoreInstanceLoggingManager();
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceBlackIP = new R2CoreInstanceBlackIPsManager();
                var IP = YourRequest.UserHostAddress;
                if (InstanceLogging.GetNSSLogType(ATISMobileWebApiLogTypes.WebApiClientMoneyWalletPaymentSucceededRequest).Active)
                { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, ATISMobileWebApiLogTypes.WebApiClientMoneyWalletPaymentSucceededRequest, InstanceLogging.GetNSSLogType(ATISMobileWebApiLogTypes.WebApiClientMoneyWalletPaymentSucceededRequest).LogTitle, IP, YourAuthority, string.Empty, string.Empty, string.Empty, InstanceSoftwareusers.GetSystemUserId(), _DateTime.GetCurrentDateTimeMilladi(), null)); }
                InstanceBlackIP.AuthorizationIP(IP);

                var InstancePaymentRequests = new R2CoreInstansePaymentRequestsManager();
                var NSSPaymentRequest = InstancePaymentRequests.GetNSSPayment(YourAuthority);
                if (_DateTime.GetCurrentDateTimeMilladi().Subtract(NSSPaymentRequest.DateTimeMilladi).TotalSeconds > InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.ShepaPaymentGate, 6))
                { throw new WebApiClientNonceExpiredException(); };
                if (NSSPaymentRequest.VerificationCount == 0)
                { throw new WebApiClientNonceExpiredException(); }
                else
                { InstancePaymentRequests.DecreaseVerificationCount(NSSPaymentRequest.PayId); }
            }
            catch (Exception ex)
            { throw ex; }
        }

        //public void AuthenticateClientPaymentVerificationZarrinPal(System.Web.HttpRequestBase YourRequest, string YourAuthority)
        //{
        //    try
        //    {
        //        var InstanceLogging = new R2CoreInstanceLoggingManager();
        //        var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
        //        var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
        //        var InstanceBlackIP = new R2CoreInstanceBlackIPsManager();
        //        var IP = YourRequest.UserHostAddress;
        //        if (InstanceLogging.GetNSSLogType(ATISMobileWebApiLogTypes.WebApiClientMoneyWalletPaymentSucceededRequest).Active)
        //        { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, ATISMobileWebApiLogTypes.WebApiClientMoneyWalletPaymentSucceededRequest, InstanceLogging.GetNSSLogType(ATISMobileWebApiLogTypes.WebApiClientMoneyWalletPaymentSucceededRequest).LogTitle, IP, YourAuthority, string.Empty, string.Empty, string.Empty, InstanceSoftwareusers.GetSystemUserId(), _DateTime.GetCurrentDateTimeMilladi(), null)); }
        //        InstanceBlackIP.AuthorizationIP(IP);

        //        var InstancePaymentRequests = new R2CoreInstansePaymentRequestsManager();
        //        var NSSPaymentRequest = InstancePaymentRequests.GetNSSPayment(YourAuthority);
        //        if (_DateTime.GetCurrentDateTimeMilladi().Subtract(NSSPaymentRequest.DateTimeMilladi).TotalSeconds > InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.ZarrinPalPaymentGate, 6))
        //        { throw new WebApiClientNonceExpiredException(); };
        //        if (NSSPaymentRequest.VerificationCount == 0)
        //        { throw new WebApiClientNonceExpiredException(); }
        //        else
        //        { InstancePaymentRequests.DecreaseVerificationCount(NSSPaymentRequest.PayId); }
        //    }
        //    catch (Exception ex)
        //    { throw ex; }
        //}

        public HttpResponseMessage CreateErrorContentMessage(Exception YourException)
        {
            HttpResponseMessage response = new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError);
            response.Content = new StringContent(JsonConvert.SerializeObject(YourException.Message), Encoding.UTF8, "application/json");
            return response;
        }

        public HttpResponseMessage CreateErrorContentMessage(string YourMessage)
        {
            HttpResponseMessage response = new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError);
            response.Content = new StringContent(JsonConvert.SerializeObject(YourMessage), Encoding.UTF8, "application/json");
            return response;
        }

        public HttpResponseMessage CreateSuccessContentMessage(string YourMessage)
        {
            HttpResponseMessage response = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            response.Content = new StringContent(JsonConvert.SerializeObject(YourMessage), Encoding.UTF8, "application/json");
            return response;
        }

        public HttpResponseMessage CreateAPIKeyExpirationContentMessage(string YourMessage)
        {
            HttpResponseMessage response = new HttpResponseMessage(System.Net.HttpStatusCode.NonAuthoritativeInformation);
            response.Content = new StringContent(JsonConvert.SerializeObject(YourMessage), Encoding.UTF8, "application/json");
            return response;
        }

        private const string HttpContext = "MS_HttpContext";
        private const string RemoteEndpointMessage = "System.ServiceModel.Channels.RemoteEndpointMessageProperty";
        public string GetClientIpAddress(HttpRequestMessage request)
        {
            if (request.Properties.ContainsKey(HttpContext))
            {
                dynamic ctx = request.Properties[HttpContext];
                if (ctx != null)
                { return ctx.Request.UserHostAddress; }
            }

            if (request.Properties.ContainsKey(RemoteEndpointMessage))
            {
                dynamic remoteEndpoint = request.Properties[RemoteEndpointMessage];
                if (remoteEndpoint != null)
                { return remoteEndpoint.Address; }
            }

            return null;
        }


    }

    namespace Logging
    {
        public abstract class ATISMobileWebApiLogTypes : R2CoreTransportationAndLoadNotificationLogType
        {
            public static Int64 WebApiClientIp = 20;
            public static Int64 WebApiClientPublicMessageRequest = 22;
            public static Int64 WebApiClientVersionControlRequest = 23;
            public static Int64 WebApiClientConfirmAMUStatusRequest = 24;
            public static Int64 WebApiClientNonceRequest = 25;
            public static Int64 WebApiClientCaptchaRequest = 26;
            public static Int64 WebApiClientPersonalNonceRequest = 27;
            public static Int64 WebApiClientRegisterMobileNumberRequest = 28;
            public static Int64 WebApiClientLoginRequest = 29;
            public static Int64 WebApiClientMobileProccessesRequest = 30;
            public static Int64 WebApiClientExistPermissionRequest = 31;
            public static Int64 WebApiClientTruckRequest = 32;
            public static Int64 WebApiClientTruckDriverRequest = 33;
            public static Int64 WebApiClientTurnsRequest = 34;
            public static Int64 WebApiClientLoadsReviewRequest = 35;
            public static Int64 WebApiClientLoadAllocationRegisteringRequest = 36;
            public static Int64 WebApiClientLoadAllocationCancellingRequest = 37;
            public static Int64 WebApiClientIncreasePriorityRequest = 38;
            public static Int64 WebApiClientDecreasePriorityRequest = 39;
            public static Int64 WebApiClientLoadAllocationsRequest = 40;
            public static Int64 WebApiClientProvincesRequest = 41;
            public static Int64 WebApiClientLoadPermissionsIssuedOrderByPriorityReportRequest = 42;
            public static Int64 WebApiClientAnnouncementHallSubGroupsRequest = 43;
            public static Int64 WebApiClientMoneyWalletIDandReminderChargeRequest = 44;
            public static Int64 WebApiClientMoneyWalletAccountingRequest = 45;
            public static Int64 WebApiClientMoneyWalletPaymentRequest = 46;
            public static Int64 WebApiClientMoneyWalletPaymentSucceededRequest = 47;
            public static Int64 WebApiClientLogoutSoftwareUserRequest = 48;
            public static Int64 WebApiClientIsWebAPIAliveRequest = 49;
            public static Int64 WebApiClientRealTimeTurnRegisterRequest = 53;
            public static Int64 WebApiClientTruckDriverInqueryWithLicensePlate = 54;
            public static Int64 WebApiClientTurnsCancellation = 55;
            public static Int64 WebApiClientSendTruckDriverChangeMessageRequest = 56;
            public static Int64 WebApiClientSendTruckChangeMessageRequest = 57;
            public static Int64 WebApiClientGetLastTurnIdWhichCancelledDuringTurnsCancellationProcess = 58;
            public static Int64 WebApiClientGetLoadPermissionsViaLicensePlate = 59;
            public static Int64 WebApiClientTurnCancellation = 60;
            public static Int64 WebApiClientRequestAnnouncedLoadsReportClearanceLoadsReport = 62;
            public static Int64 WebApiClientGetDriverSelfDeclarations = 64;
            public static Int64 WebApiClientSetDriverSelfDeclarations = 65;
            public static Int64 WebApiClientSaveDSDImage = 66;
            public static Int64 WebApiClientIsVirtualTurnsActive = 68;
        }

    }

    namespace BlackIPs
    {
        public class BlackIPs
        {
            public void AuthorizationIP(string YourIP)
            { }
        }
    }

    namespace SecurityAlgorithms
    {
        public class ImageRawData
        { public byte[] IRawData; }

        public class JsonImage
        {
            private AESAlgorithms _AESAlgorithms = new AESAlgorithms();
            public string hash { get; set; } = string.Empty;
            public int len { get; set; } = 0;
            public string image { get; set; } = string.Empty;
            public JsonImage() { }
            public JsonImage(Image value)
            {
                byte[] img_sources = _AESAlgorithms.ImageToBytes(value);
                hash = _AESAlgorithms.StringHash(img_sources);
                len = img_sources.Length;
                image = _AESAlgorithms.EncodeBytes(img_sources);
            }
            public byte[] GetRawData()
            {
                byte[] data = _AESAlgorithms.DecodeBytes(image);

                if (data.Length != len) throw new Exception("Error data len");
                if (!_AESAlgorithms.StringHash(data).Equals(hash)) throw new Exception("Error hash");

                return data;
            }

        }

        public class AESAlgorithms
        {
            public byte[] ImageToBytes(Image value)
            {
                ImageConverter converter = new ImageConverter();
                byte[] arr = (byte[])converter.ConvertTo(value, typeof(byte[]));
                return arr;
            }
            public Image BytesToImage(byte[] value)
            {
                using (var ms = new MemoryStream(value))
                {
                    return Image.FromStream(ms);
                }
            }
            public string EncodeBytes(byte[] value) => Convert.ToBase64String(value);
            public byte[] DecodeBytes(string value) => Convert.FromBase64String(value);
            public string StringHash(byte[] value)
            {
                using (System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create())
                {
                    byte[] hashBytes = sha256.ComputeHash(value);
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < hashBytes.Length; i++)
                    {
                        sb.Append(hashBytes[i].ToString("X2"));
                    }
                    return sb.ToString().ToLower();
                }
            }
        }


    }

    namespace Exceptions
    {
        public class WebApiClientCaptchaInvalidException : ApplicationException
        {
            public override string Message
            { get { return (new R2CoreMClassPredefinedMessagesManager()).GetNSS(R2CorePredefinedMessages.CaptchaInvalid).MsgContent; } }
        }

        public class WebApiClientNonceExpiredException : ApplicationException
        {
            public override string Message
            { get { return (new R2CoreMClassPredefinedMessagesManager()).GetNSS(R2CorePredefinedMessages.NonceExpired).MsgContent; } }
        }

        public class WebApiClientPersonalNonceExpiredException : ApplicationException
        {
            public override string Message
            { get { return (new R2CoreMClassPredefinedMessagesManager()).GetNSS(R2CorePredefinedMessages.PersonalNonceExpired).MsgContent; } }
        }

        public class WebApiClientSoftWareUserPasswordExpiredException : ApplicationException
        {
            public override string Message
            { get { return (new R2CoreMClassPredefinedMessagesManager()).GetNSS(R2CorePredefinedMessages.SoftWareUserPasswordExpired).MsgContent; } }
        }

        public class WebApiClientSoftwareUserAPIKeyExpiredException : ApplicationException
        {
            public override string Message
            { get { return (new R2CoreMClassPredefinedMessagesManager()).GetNSS(R2CorePredefinedMessages.SoftwareUserAPIKeyExpired).MsgContent; } }

        }

        public class WebApiClientSoftwareUserIsLogoutException : ApplicationException
        {
            public override string Message
            { get { return (new R2CoreMClassPredefinedMessagesManager()).GetNSS(R2CorePredefinedMessages.SoftwareUserIsLogout).MsgContent; } }
        }

        public class WebApiClientSecurityHashInvalidException : ApplicationException
        {
            public override string Message
            { get { return (new R2CoreMClassPredefinedMessagesManager()).GetNSS(R2CorePredefinedMessages.SecurityHashInvalid).MsgContent; } }
        }

        public class WebApiClientVerificationCodeExpiredException : ApplicationException
        {
            public override string Message
            { get { return (new R2CoreMClassPredefinedMessagesManager()).GetNSS(R2CorePredefinedMessages.VerificationCodeExpired).MsgContent; } }
        }

        public class WebApiClientMobileNumberIsInvalidException : ApplicationException
        {
            public override string Message
            { get { return (new R2CoreMClassPredefinedMessagesManager()).GetNSS(R2CorePredefinedMessages.MobileNumberIsInvalid).MsgContent; } }
        }

        public class WebApiClientMobileNumberNotFoundExceptionException : ApplicationException
        {
            public override string Message
            { get { return (new R2CoreMClassPredefinedMessagesManager()).GetNSS(R2CorePredefinedMessages.MobileNumberNotFoundException).MsgContent; } }
        }

        public class WebApiClientPaymentVerificationException : ApplicationException
        {
            R2CoreInstanceConfigurationManager InstanceConfiguration = new R2CoreInstanceConfigurationManager();

            private string _Message = string.Empty;
            public WebApiClientPaymentVerificationException(string YourMessage)
            { _Message = YourMessage; }

            public override string Message
            { get { return InstanceConfiguration.GetConfigString(R2CoreConfigurations.ApplicationDomainDisplayTitle, 3) + " PaymentVerificationError:" + _Message; } }
        }

    }
}