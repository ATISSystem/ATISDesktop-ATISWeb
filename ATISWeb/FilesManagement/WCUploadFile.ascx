<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WCUploadFile.ascx.cs" Inherits="ATISWeb.FilesManagement.WCUploadFile" %>

<div class="container">
    <div class="card m-auto" style="width: 25rem;">
        <img class="card-img-top" src="/Images/Header4.jpg" alt="Card image cap" style="min-height: 6rem;">
        <div class="card-body">
            <h6 class="card-title text-center" style="font-size: 12px">انتخاب فایل</h6>
            <div class="mb-2" >
                <asp:FileUpload ID="UpLoadFile" BorderStyle="Double" BorderWidth="2px" Font-Bold="true" ForeColor="Green"  BorderColor="Green" runat="server" />
            </div>
            <br />
            <br />
            <div class="input-group mb-2">
                <asp:TextBox runat="server" ID="TxtFileName" class="form-control R2FontBHomaSmall  text-center"></asp:TextBox>
                <div class="input-group-append">
                    <span class="input-group-text R2FontBYekanSmall bg-success text-white">نام و پسوند فایل</span>
                </div>
            </div>
            <div class="input-group">
                <asp:Button runat="server" ID="BtnSubmit" CssClass="btn btn-success R2FontBYekanSmall" Text="تایید" />
            </div>
        </div>
        <br />
    </div>
</div>

