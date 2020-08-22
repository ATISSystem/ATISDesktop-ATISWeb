<%@ Page Title="آتیس وب | تغییر رمز عبور کاربر" Language="C#" MasterPageFile="~/DomainSite.Master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeBehind="WfChangePasswordofCurrentUser.aspx.cs" Inherits="ATISWeb.LoginManagement.WfChangePasswordofCurrentUser" %>
<%@ Register TagPrefix="TWebControl" TagName="WcChangePasswordofCurrentUser" Src="~/LoginManagement/WcChangePasswordofCurrentUser.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container w-50">
        <TWebControl:WcChangePasswordofCurrentUser ID="WcChangePasswordofCurrentUser" runat="server"></TWebControl:WcChangePasswordofCurrentUser>
    </div>


</asp:Content>
