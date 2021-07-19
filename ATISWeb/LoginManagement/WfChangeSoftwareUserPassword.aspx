<%@ Page Title="آتیس وب | تغییر رمز عبور کاربر" Language="C#" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeBehind="WfChangeSoftwareUserPassword.aspx.cs" Inherits="ATISWeb.LoginManagement.WfChangeSoftwareUserPassword" %>

<%@ Register TagPrefix="TWebControl" TagName="WcChangePasswordofCurrentUser" Src="~/LoginManagement/WcChangePasswordofCurrentUser.ascx" %>
<%@ Register TagPrefix="TWebControl" TagName="WcAlertShower" Src="~/AlertManagement/WcAlertShower.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width,initial-scale=1" />
    <link href="~/Content/ATISFonts.css" rel="stylesheet" />
    <link href="~/Content/font-awesome.css" rel="stylesheet" />

    <link href="/Content/bootstrap.min.css" rel="stylesheet" />
    <script src="/Scripts/jquery-3.5.1.min.js"></script>
    <script src="/Scripts/umd/popper.min.js"></script>
    <script src="/Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <TWebControl:WcAlertShower runat="server" ID="WcAlertShower" />
        <div class="container w-50">
            <TWebControl:WcChangePasswordofCurrentUser ID="WcChangePasswordofCurrentUser" runat="server"></TWebControl:WcChangePasswordofCurrentUser>
        </div>
    </form>
</body>
</html>
