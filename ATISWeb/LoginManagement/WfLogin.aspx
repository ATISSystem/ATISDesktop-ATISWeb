<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WfLogin.aspx.cs" Inherits="ATISWeb.LoginManagement.WfLogin" %>
<%@ Register Src="~/LoginManagement/WcLogin.ascx" TagName="WcLogin" TagPrefix="TWebControl" %>
<%@ Register TagPrefix="TWebControl" TagName="WcAlertShower" Src="~/AlertManagement/WcAlertShower.ascx" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>آتیس وب | ورود به آتیس وب</title>

    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width,initial-scale=1" />
    <link href="~/Content/ATISFonts.css" rel="stylesheet" />
    <link href="~/Content/font-awesome.css" rel="stylesheet">
    
    <link href="/Content/bootstrap.min.css" rel="stylesheet" />
    <script src="/Scripts/jquery-3.5.1.min.js"></script>
    <script src="/Scripts/umd/popper.min.js"></script>
    <script src="/Scripts/bootstrap.min.js"></script>

</head>
<body class="bg-light">
    <form id="form1" runat="server">
        <TWebControl:WcAlertShower runat="server" ID="WcAlertShower" />

        <div class="h-100">
            <br />
            <div class="container w-50">
                <TWebControl:WcLogin ID="WcLogin" runat="server"></TWebControl:WcLogin>
            </div>
        </div>
    </form>
    <script src="~/Scripts/popper.js"></script>
    <script src="~/Scripts/popper.min.js"></script>
    <script src="~/Scripts/bootstrap.min.js"></script>
    <script src="~/Scripts/bootstrap.js"></script>
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
    <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

</body>
</html>
