<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="R2WebPrimaryTest._Default" %>

<%@ Register Src="~/UserControls/UCLogin.ascx" TagName="UCLogin" TagPrefix="TWebControl" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div style="margin-left: auto; margin-right: auto; background-color: whitesmoke; width: 30%">
        <TWebControl:UCLogin  ID="UCLogin" runat="server"></TWebControl:UCLogin>
    </div>
    <div style="margin-left: auto; margin-right: auto; background-color: whitesmoke; width: 30%">
        <asp:Button ID="BtnLoadRegistering" runat="server" Text="ثبت بار شرکت حمل و نقل" />
        <asp:Button ID="BtnLoadAllocationLoadPermission" runat="server" Text="تخصیص بار و صدور مجوز بارگیری" />
    </div>
</asp:Content>
