<%@ Page Title="" Language="C#" MasterPageFile="~/DomainSite.Master" AutoEventWireup="true" CodeBehind="WfMSCOThisDayAnnounce.aspx.cs" Inherits="ATISWeb.MSCOManagement.WfMSCOThisDayAnnounce" %>

<%@ Register TagPrefix="TWebControl" TagName="WCMSCOThisDayAnnounce" Src="~/MSCOManagement/WCMSCOThisDayAnnounce.ascx" %>
<%@ Register TagPrefix="TWebControl" TagName="WCViewerNSSSoftwareUser"  Src="~/LoginManagement/WCViewerNSSSoftwareUser.ascx"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
        <div class="container-fluid  text-right">
            <div class="d-flex flex-column">
                <span class="" style="font-family: BHoma; font-size: 40px">دانلود فایل اعلام بار فولاد</span>
            </div>
        </div>
        <div class="container-fluid p-0 mb-1">
            <TWebControl:WCViewerNSSSoftwareUser runat="server" ID="WCViewerNSSSoftwareUser" />
        </div>
        <div class="container-fluid">
            <ul class="nav nav-tabs justify-content-end" role="tablist">
                <li class="nav-item">
                    <a class="nav-link R2FontBYekanMedium" data-toggle="tab" href="#MSCOThisDayAnnounce">فایل اعلام بار فولاد</a>
                </li>
            </ul>
            <div class="tab-content">
                <div id="MSCOThisDayAnnounce" class="container-fluid tab-pane active">
                    <br />
                    <TWebControl:WCMSCOThisDayAnnounce runat="server" ID="WCMSCOThisDayAnnounce" />
                </div>
            </div>
        </div>
    </div>

</asp:Content>
