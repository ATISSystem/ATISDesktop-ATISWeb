<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WcLogin.ascx.cs" Inherits="ATISWeb.LoginManagement.WcLogin" %>

<div class="container">
    <div class="card m-auto" style="width: 25rem;">
        <img class="card-img-top" src="/Images/Header1.jpg" alt="Card image cap" style="min-height: 10rem;">
        <div class="card-body">
            <h6 class="card-title text-center" style="font-size: 10px">پرتال یکپارچه خدمات الکترونیک و اطلاع رسانی بار</h6>
            <h6 class="card-title text-center R2FontBHomaLarge" style="font-size: 25px">آتیس وب</h6>
            <h6 class="card-title text-center">تایید هویت کاربر</h6>
            <div class="input-group mb-2">
                <asp:TextBox runat="server" ID="TxtUserShenaseh" class="form-control R2FontBHomaSmall  text-center"></asp:TextBox>
                <div class="input-group-append">
                    <span class="input-group-text R2FontBYekanSmall bg-success text-white">شناسه کاربر</span>
                </div>
            </div>
            <div class="input-group mb-2">
                <asp:TextBox runat="server" ID="TxtUserPassword" class="form-control R2FontBHomaSmall  text-center" TextMode="Password" AutoCompleteType="Disabled"></asp:TextBox>
                <div class="input-group-append">
                    <span class="input-group-text R2FontBYekanSmall bg-success text-white">رمزعبور کاربر</span>
                </div>
            </div>
            <div class="input-group mb-2">
                <asp:TextBox runat="server" ID="TxtCaptcha" Style="font-size: 12px" placeholder="متن تصویر امنیتی را وارد نمایید" class="form-control R2FontBHomaSmall  text-center"></asp:TextBox>
                <div class="input-group-append">
                    <asp:ImageButton  ID="ImgBRecaptcha" runat="server"  Width="20" Height="15" ImageAlign="Bottom" class="img-rounded mt-2 ml-2 mr-2" ImageUrl="~/Images/refresh-icon (1).png"  />
                    <asp:Image runat="server" ID="ImgCaptcha" Width="150" Height="32" class="img-rounded" src="/Images/Captcha.jpg" alt="" />
                </div>
            </div>
            <div class="input-group">
                <asp:Button runat="server" ID="BtnSubmit" CssClass="btn btn-success R2FontBYekanSmall" Text="تایید" />
            </div>

        </div>
        <h4 class="card-text text-center">ATIS Web</h4>
        <br />
    </div>
</div>
