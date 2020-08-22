<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WcLogin.ascx.cs" Inherits="ATISWeb.LoginManagement.WcLogin" %>

<div class="container">
    <div class="card m-auto" style="width: 25rem;">
        <img class="card-img-top" src="/Images/2-2.jpg" alt="Card image cap">
        <div class="card-body"> 
            <h6 class="card-title text-center" style="font-size: 10px">پرتال یکپارچه خدمات الکترونیک و اطلاع رسانی بار رانندگان</h6>
            <h6 class="card-title text-center R2FontBHomaLarge" style="font-size: 25px">آتیس وب</h6>
            <h6 class="card-title text-center">تایید هویت کاربر</h6>
            <div class="input-group mb-2">
                <asp:TextBox runat="server" ID="TxtUserShenaseh" class="form-control R2FontBHomaSmall  text-center"></asp:TextBox>
                <div class="input-group-append">
                    <span class="input-group-text R2FontBYekanSmall bg-success text-white">شناسه کاربر</span>
                </div>
            </div>
            <div class="input-group mb-2">
                <asp:TextBox runat="server" ID="TxtUserPassword" class="form-control R2FontBHomaSmall  text-center" TextMode="Password"></asp:TextBox>
                <div class="input-group-append">
                    <span class="input-group-text R2FontBYekanSmall bg-success text-white">رمزعبور کاربر</span>
                </div>
            </div>
            <div class="input-group">
                <asp:Button runat="server" ID="BtnSubmit" CssClass="btn btn-success R2FontBYekanSmall" Text="تایید" />
            </div>
        </div>
        <h4 class="card-text text-center">ATIS System</h4>
        <h6 class="card-text text-center">AmirKabir Tranportation Information System</h6>
        <br />
    </div>
</div>
