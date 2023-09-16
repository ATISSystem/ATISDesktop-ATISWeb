<%@ Page Title="آتیس وب | گزارش بار ثبت شده و ترخیص شده" Language="C#" MasterPageFile="~/DomainSite.Master" AutoEventWireup="true" CodeBehind="WfRegisteredAndReleasedLoadsReport.aspx.cs" Inherits="ATISWeb.ReportsManagement.WfRegisteredAndReleasedLoadsReport" %>

<%@ Register Src="~/ReportsManagement/WCRegisteredAndReleasedLoadsReport.ascx" TagName="WCRegisteredAndReleasedLoadsReport" TagPrefix="TWebControl" %>
<%@ Register Src="~/LoginManagement/WCViewerNSSSoftwareUser.ascx" TagName="WCViewerNSSSoftwareUser" TagPrefix="TWebControl" %>
<%@ Register TagPrefix="TWebControl" TagName="WcAlertShower" Src="~/AlertManagement/WcAlertShower.ascx" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1311" runat="server"></asp:ScriptManager>
    <div class="container-fluid">
        <div class="container-fluid  text-right">
            <div class="d-flex flex-column">
                <span class="" style="font-family: BHoma; font-size: 40px">گزارشات اعلام بار</span>
            </div>
        </div>
        <div class="container-fluid p-0 mb-1">
            <TWebControl:WCViewerNSSSoftwareUser runat="server" ID="WCViewerNSSSoftwareUser" />
        </div>
        <div class="container-fluid">
            <ul class="nav nav-tabs justify-content-end" role="tablist">
                <li class="nav-item">
                    <a class="nav-link R2FontBYekanMedium" data-toggle="tab" href="#TabLoadPermissionsReport">گزارش مجوزهای صادر شده</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link active R2FontBYekanMedium" data-toggle="tab" href="#TabRegisteredAndReleasedLoadsReport">گزارش بار ثبت شده و ترخیص شده</a>
                </li>
            </ul>
            <div class="tab-content">
                <div id="TabRegisteredAndReleasedLoadsReport" class="container-fluid tab-pane active">
                    <br />
                    <TWebControl:WCRegisteredAndReleasedLoadsReport runat="server" ID="WCRegisteredAndReleasedLoadsReport" />
                </div>
                <div id="TabLoadPermissionsReport" class="container-fluid tab-pane">
                    <br />
                </div>

            </div>
        </div>
    </div>

</asp:Content>
