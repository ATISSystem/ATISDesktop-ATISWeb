<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WfAboutATIS.aspx.cs" Inherits="ATISWeb.ATISStartManagement.WfAboutATIS" %>
<%@ Register TagPrefix="TWebControl" TagName="WcAlertShower" Src="~/AlertManagement/WcAlertShower.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>آتیس - درباره آتیس</title>

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
        <TWebControl:WcAlertShower runat="server" ID="WcAlertShower" />

        <div class="h-100">
            <br />
            <div class="container w-70">
                <div class="card m-auto">
                    <img class="card-img-top" src="/Images/Header4.jpg" alt="Card image cap" style="min-height: 10rem;" />
                    <div class="card-body">
                        <h6 class="card-title text-center R2FontBHomaLarge">سامانه آتیس</h6>
                        <h6 class="card-title text-center" style="font-size: 10px">پرتال یکپارچه خدمات الکترونیک و اطلاع رسانی بار</h6>
                        <h6 class="card-title text-center R2FontBHomaLarge" style="font-size: 25px">سامانه آتیس در سال 1398 توسط اداره کل راهداری و حمل و نقل جاده ای استان اصفهان با همکاری صنوف حمل و نقل دراستان اصفهان راه اندازی گردید</h6>
                        <h6 class="card-title text-center">هدف اصلی سایت ارائه خدمات الکترونیکی ، اطلاع رسانی بار و اعلام بار مجازی است</h6>
                        <h6 class="card-title text-center text-success">هم اکنون کلیه بارهای آهن آلات مجتمع ذوب آهن اصفهان ، تولیدات مجتمع فولاد سبا و آهن آلات و میلگردانباری از طریق این سامانه به رانندگان عزیز اطلاع رسانی می شود</h6>
                        <h6 class="card-title text-center text-primary">قابل ذکر است ویژگی برتر این سامانه توانایی اعلام بار مجازی و صدور نوبت مجازی غیر حضوری است به نحوی که رانندگان از طریق اپلیکیشن آتیس موبایل امکان انتخاب بار و ثبت نوبت مجازی را خواهند داشت </h6>
                    </div>
                    <h4 class="card-text text-center">ATIS</h4>
                    <br />
                </div>

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
