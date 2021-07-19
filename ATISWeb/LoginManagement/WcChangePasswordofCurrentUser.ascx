<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WcChangePasswordofCurrentUser.ascx.cs" Inherits="ATISWeb.LoginManagement.WcChangePasswordofCurrentUser" %>
<%@ Register TagPrefix="TWebControl" TagName="WCPasswordStrengthViewer" Src="~/SecurityAlgorithmsManagement/WCPasswordStrengthViewer.ascx" %>

<div class="container">
    <div class="card m-auto" style="width: 25rem;">
        <img class="card-img-top" src="/Images/Header1.jpg" alt="Card image cap" style="min-height: 10rem;" />
        <div class="card-body">
            <h6 class="card-title text-center" style="font-size: 10px">پرتال یکپارچه خدمات الکترونیک و اطلاع رسانی بار</h6>
            <h6 class="card-title text-center R2FontBHomaLarge" style="font-size: 25px">آتیس وب</h6>
            <h4 class="card-text text-center">ATIS Web</h4>
            <br />
            <h6 class="card-title text-center R2FontBHomaLarge">تغییر رمز عبور کاربر</h6>
            <h6 class="card-title text-center" style="font-size: 10px">رمز عبور باید شامل حداقل 8 حرف و حروف بزرگ ، کوچک و اعداد باشد</h6>
            <div class="input-group mb-2">
                <asp:TextBox runat="server" ID="TxtNewUserPassword" class="form-control R2FontBHomaSmall  text-center" TextMode="Password"></asp:TextBox>
                <div class="input-group-append">
                    <span class="input-group-text R2FontBYekanSmall bg-success text-white">رمزعبور جدید</span>
                </div>
            </div>
            <div class="input-group mb-2">
                <asp:TextBox runat="server" ID="TxtNewUserPasswordConfirm" class="form-control R2FontBHomaSmall  text-center" TextMode="Password"></asp:TextBox>
                <div class="input-group-append">
                    <span class="input-group-text R2FontBYekanSmall bg-success text-white">رمزعبور جدید - تکرار</span>
                </div>
            </div>
            <div class="input-group mb-2">
                <asp:TextBox runat="server" ID="TxtCurrentUserPassword" class="form-control R2FontBHomaSmall  text-center" TextMode="Password"></asp:TextBox>
                <div class="input-group-append">
                    <span class="input-group-text R2FontBYekanSmall bg-success text-white">رمز عبور فعلی</span>
                </div>
            </div>
            <div class="input-group">
                <asp:Button runat="server" ID="BtnSubmit" CssClass="btn btn-success R2FontBYekanSmall" Text="تغییر رمز عبور" />
            </div>
        </div>
        <br />
    </div>
</div>

