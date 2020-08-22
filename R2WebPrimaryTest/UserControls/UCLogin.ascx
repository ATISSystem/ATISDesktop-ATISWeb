<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCLogin.ascx.cs" Inherits="R2WebPrimaryTest.UserControls.UCLogin" %>
<div style="">
    <div style=" text-align: center">
        <h1>تایید هویت کاربر</h1>
        <asp:TextBox ID="TxtUserShenaseh" runat="server" Width="70%" style="" ></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text="شناسه"></asp:Label>
        <br />
        <asp:TextBox ID="TxtUserPassword" runat="server" Width="70%" ></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="رمزعبور"></asp:Label>
    </div>
    <div style=" text-align: center">
        <asp:Button ID="BtnSubmit" runat="server" Text="تایید" OnClick="BtnSubmit_Click" Width="84px"/>
        <br />
        <asp:Label ID="LblMessage" runat="server" Text="" Width="100%"></asp:Label>
    </div>
</div>

