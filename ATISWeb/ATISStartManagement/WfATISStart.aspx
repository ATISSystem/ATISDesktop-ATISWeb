﻿<%@ Page Title="آتیس - صفحه اصلی" Language="C#" MasterPageFile="~/ATISSite.Master" AutoEventWireup="true" CodeBehind="WfATISStart.aspx.cs" Inherits="ATISWeb.ATISStartManagement.WfATISStart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="jumbotron w-25 bg-transparent mx-auto mt-0">
        <asp:linkbutton runat="server" id="DownloadATISMobile_" class="btn btn-primary R2FontBYekanMedium mb-2">دانلود آتیس موبایل</asp:linkbutton>
    </div>

    <div class="container-fluid p-0 mb-5">
        <div class="d-flex flex-row justify-content-around">
            <div class="col-lg-3">
                <div class="card border border-danger rounded bg-dark p-1" style="width: 18rem; height: 25rem;">
                    <img src="/Images/ATISMobile.jpg" class="card-img-top" alt="..." style="height: 15rem;">
                    <div class="card-body text-right mt-1" style="background-image: linear-gradient(to bottom left, grey , black )">
                        <h5 class="card-title text-right R2FontBHomaMedium text-white">آتیس موبایل</h5>
                        <asp:linkbutton runat="server" id="DownloadATISMobile" class="btn btn-dark R2FontBYekanMedium mb-2">دانلود آتیس موبایل</asp:linkbutton>
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
        <br />
        <br />
        <div class="text-center">
            <div class="d-flex flex-row justify-content-around">
                <div class="col-lg-3">
                    <div class="card rounded bg-dark p-1" style="width: 15rem; height: 18rem;">
                        <img id='rgvjwlaosizpesgtapfufukz' style='cursor: pointer' onclick='window.open("https://logo.samandehi.ir/Verify.aspx?id=349056&p=xlaoaodspfvlobpddshwgvka", "Popup","toolbar=no, scrollbars=no, location=no, statusbar=no, menubar=no, resizable=0, width=450, height=630, top=30")' alt='logo-samandehi' src='https://logo.samandehi.ir/logo.aspx?id=349056&p=qftishwlbsiylymaujynwlbq' />
                    </div>
                </div>
                <div class="col-lg-3">
                    <div class="card rounded bg-dark p-1" style="width: 15rem; height: 18rem;">
                        <a target="_blank" href="https://trustseal.enamad.ir/?id=342217&amp;Code=CAI3SyuVJ7eQj9Kg3GQO">
                            <img src="https://Trustseal.eNamad.ir/logo.aspx?id=342217&amp;Code=CAI3SyuVJ7eQj9Kg3GQO" alt="" style="cursor: pointer" id="CAI3SyuVJ7eQj9Kg3GQO"></a>
                    </div>
                </div>
                <div class="col-lg-3">
                    <div class="card rounded bg-dark p-1" style="width: 15rem; height: 18rem;">
                        <a href="https://logo.saramad.ir/verify.aspx?CodeShamad=1-1-877566-63-0-1" target="_blank">
                            <img src="/Images/Samandehi.jpg"></a>
                    </div>
                </div>
                <div class="col-lg-3"></div>
            </div>
        </div>
    </div>

    <div class="container-fluid " style="min-height: 500px;">
        <%--<h2 class="text-center R2FontBHomaMedium text-white">کلیه حقوق سایت متعلق است به اداره کل راهداری و حمل و نقل جاده ای استان اصفهان</h2>--%>
    </div>

</asp:Content>
