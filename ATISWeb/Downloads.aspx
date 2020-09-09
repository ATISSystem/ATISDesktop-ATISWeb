<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Downloads.aspx.cs" Inherits="ATISWeb.Downloads" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>آتیس | دانلود آتیس موبایل</title>
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
        <div class="container-fluid">
            <div class="d-flex justify-content-center mt-3">
                <asp:Button runat="server" ID="BtnDownloadATISMobile" CssClass="btn btn-primary R2FontBHomaMedium" Text="دانلود آتیس موبایل"/>
            </div>
        </div>
    </form>
</body>
</html>
