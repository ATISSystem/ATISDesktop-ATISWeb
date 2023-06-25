<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WfATISCall.aspx.cs" Inherits="ATISWeb.ATISStartManagement.WfATISCall" %>

<%@ Register TagPrefix="TWebControl" TagName="WcAlertShower" Src="~/AlertManagement/WcAlertShower.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>آتیس - تماس با ما</title>
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
                        <h6 class="card-title text-center R2FontBHomaLarge" style="font-size: 10px">روش های تماس با مدیریت و کارشناسان سامانه آتیس</h6>
                        <h6 class="card-title text-center R2FontBHomaLarge" style="font-size: 25px">مدیریت سامانه : 03134721839</h6>
                        <h6 class="card-title text-center R2FontBHomaLarge" style="font-size: 25px">دفتر شکایات : 03134721839</h6>
                        <h6 class="card-title text-center R2FontBHomaLarge">کارشناس فنی : 03133870111</h6>
                        <h6 class="card-title text-center text-success R2FontBHomaLarge">پشتیبانی : 03133863070 و 03133869114</h6>
                        <h6 class="card-title text-center text-success R2FontBHomaLarge">استان: اصفهان، شهرستان : اصفهان، بخش : مرکزی، شهر: اصفهان، محله: پوریای ولی، کوچه سادات، بن بست بعثت، پلاک: 35.0، طبقه: همکف</h6>
                    </div>
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
