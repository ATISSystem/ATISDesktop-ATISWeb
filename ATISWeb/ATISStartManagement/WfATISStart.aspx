<%@ Page Title="آتیس | صفحه اصلی" Language="C#" MasterPageFile="~/ATISSite.Master" AutoEventWireup="true" CodeBehind="WfATISStart.aspx.cs" Inherits="ATISWeb.ATISStartManagement.WfATISStart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="jumbotron w-25 bg-transparent mx-auto mt-0">
        <asp:LinkButton runat="server" ID="DownloadATISMobile_" class="btn btn-primary R2FontBYekanMedium mb-2">دانلود آتیس موبایل</asp:LinkButton>
    </div>

    <div class="container-fluid p-0 mb-5">
        <div class="d-flex flex-row justify-content-around">
            <div class="col-lg-3">
                <div class="card border border-danger rounded bg-dark p-1" style="width: 18rem; height: 25rem;">
                    <img src="/Images/ATISMobile.jpg" class="card-img-top" alt="..." style="height: 15rem;">
                    <div class="card-body text-right mt-1" style="background-image: linear-gradient(to bottom left, grey , black )">
                        <h5 class="card-title text-right R2FontBHomaMedium text-white">آتیس موبایل</h5>
                        <asp:LinkButton runat="server" ID="DownloadATISMobile" class="btn btn-dark R2FontBYekanMedium mb-2">دانلود آتیس موبایل</asp:LinkButton>
                    </div>
                </div>
            </div>
            <div class="col-lg-3">
                <div class="card border border-danger rounded bg-dark p-1" style="width: 18rem; height: 25rem;">
                    <img src="/Images/ATISDesktop.png" class="card-img-top" alt="..." style="height: 15rem;">
                    <div class="card-body text-right mt-1" style="background-image: linear-gradient(to bottom left, grey , black )">
                        <h5 class="card-title text-right R2FontBHomaMedium text-white">آتیس دسکتاپ</h5>
                        <a href="#" class="btn btn-dark R2FontBYekanMedium mb-2">دانلود آتیس دسکتاپ</a>
                    </div>
                </div>
            </div>
            <div class="col-lg-3">
                <div class="card border border-danger rounded bg-dark p-1" style="width: 18rem; height: 25rem;">
                    <img src="/Images/ATISWeb.jpg" class="card-img-top" alt="..." style="height: 15rem;">
                    <div class="card-body text-right mt-1" style="background-image: linear-gradient(to bottom left, grey , black )">
                        <h5 class="card-title text-right R2FontBHomaMedium text-white">آتیس وب</h5>
                        <a href="/LoginManagement/WfLogin.aspx" class="btn btn-dark R2FontBYekanMedium mb-2">انتقال به سایت آتیس وب</a>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="container-fluid " style="min-height: 500px;"></div>

</asp:Content>
