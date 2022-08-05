<%@ Page Title="" Language="C#" MasterPageFile="~/DomainSite.Master" AutoEventWireup="true" CodeBehind="WfUploadFile.aspx.cs" Inherits="ATISWeb.FilesManagement.WfUploadFile" %>

<%@ Register Src="~/FilesManagement/WCUploadFile.ascx" TagName="WCUploadFile" TagPrefix="TWebControl" %>
<%@ Register Src="~/LoginManagement/WCViewerNSSSoftwareUser.ascx" TagName="WCViewerNSSSoftwareUser" TagPrefix="TWebControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager131" runat="server"></asp:ScriptManager>
    <div class="container-fluid">
        <div class="container-fluid  text-right">
            <div class="d-flex flex-column">
                <span class="" style="font-family: BHoma; font-size: 40px">بارگذاری فایل</span>
            </div>
        </div>
        <div class="container-fluid p-0 mb-1">
            <TWebControl:WCViewerNSSSoftwareUser runat="server" ID="WCViewerNSSSoftwareUser" />
        </div>
        <div class="container-fluid p-0 mb-1">
            <TWebControl:WCUploadFile runat="server" ID="WCUploadFile" />
        </div>
    </div>



</asp:Content>
