<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WfLoadCapacitorMonitoringMuted.aspx.cs" Inherits="ATISWeb.TransportationAndLoadNotification.LoadCapacitorMonitoringManagement.WfLoadCapacitorMonitoringMuted" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
<body>
    <form id="form1" runat="server">

        <div class="container-fluid p-10 w-50 text-center col-sm-8  mx-auto " style="width: 200px;">
            <video class="video-fluid z-depth-1 w-auto" autoplay loop controls muted style="width: 1000px; height: 500px;">
                <source src="../../Images/ATISMobilePresentation.mp4" type="video/mp4" />
            </video>
        </div>

    </form>
</body>
</html>
