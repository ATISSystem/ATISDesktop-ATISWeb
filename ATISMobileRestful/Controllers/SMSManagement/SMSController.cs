
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

using ATISMobileRestful.Logging;
using R2Core.SecurityAlgorithmsManagement.AESAlgorithms;
using R2Core.SoftwareUserManagement;
using R2Core.ConfigurationManagement;
using R2Core.SMS.SMSOwners;
using ATISMobileRestful.Models;
using R2Core.SMS.SMSOwners.Exceptions;
using R2CoreParkingSystem.SMS.SMSOwners;
using R2Core.SoftwareUserManagement.Exceptions;
using R2CoreParkingSystem.MoneyWalletManagement;
using R2Core.MoneyWallet.Exceptions;

namespace ATISMobileRestful.Controllers.SMSManagement
{
    public class SMSController : ApiController
    {

    }
}
