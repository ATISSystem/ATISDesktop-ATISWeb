<%@ Page Title="آتیس وب | اعلام بار" Language="C#" MasterPageFile="~/DomainSite.Master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeBehind="WfLoadCapacitorLoadManipulation.aspx.cs" Inherits="ATISWeb.TransportationAndLoadNotification.LoadCapacitorManagement.WfLoadCapacitorLoadManipulation" %>

<%@ Register Src="~/TransportationAndLoadNotification/LoadCapacitorManagement/WcViewerNSSLoadCapacitorLoad.ascx" TagName="WcViewerNSSLoadCapacitorLoad" TagPrefix="TWebControl" %>
<%@ Register Src="~/TransportationAndLoadNotification/LoadCapacitorManagement/WcLoadCapacitorLoadsCollectionIntelligently.ascx" TagName="WcLoadCapacitorLoadsCollectionIntelligently" TagPrefix="TWebControl" %>
<%@ Register Src="~/TransportationAndLoadNotification/LoadCapacitorManagement/WcLoadCapacitorLoadManipulation.ascx" TagName="WcLoadCapacitorLoadManipulation" TagPrefix="TWebControl" %>
<%@ Register Src="~/TransportationAndLoadNotification/SmartCards/WcSmartCardsInquiry.ascx" TagName="UCSmartCardsInquiry" TagPrefix="TWebControl" %>
<%@ Register Src="~/TransportationAndLoadNotification/LoadAllocationManagement/WcLoadCapacitorLoadLoadPermissionsIssued.ascx" TagName="WcLoadCapacitorLoadLoadPermissionsIssued" TagPrefix="TWebControl" %>
<%@ Register Src="~/TransportationAndLoadNotification/TransportCompanies/WcViewerNSSTransportCompanyIntelligently.ascx" TagName="WcViewerNSSTransportCompanyIntelligently" TagPrefix="TWebControl" %>
<%@ Register Src="~/LoginManagement/WCViewerNSSSoftwareUser.ascx" TagName="WCViewerNSSSoftwareUser" TagPrefix="TWebControl" %>
<%@ Register TagPrefix="TWebControl" TagName="WcAlertShower" Src="~/AlertManagement/WcAlertShower.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager131" runat="server"></asp:ScriptManager>

    <div class="container-fluid">
        <div class="container-fluid  text-right">
            <div class="d-flex flex-column">
                <span class="" style="font-family: BHoma; font-size: 40px">اعلام بار</span>
            </div>
        </div>
        <div class="container-fluid p-0 mb-1">
            <TWebControl:WCViewerNSSSoftwareUser runat="server" ID="WCViewerNSSSoftwareUser" />
        </div>
        <div class="container-fluid">
            <ul class="nav nav-tabs justify-content-end" role="tablist">
                <li class="nav-item">
                    <a class="nav-link R2FontBYekanMedium" data-toggle="tab" href="#LoadCapacitorLoadLoadPersmissionsIssued">مجوزهای صادر شده اخیر</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link R2FontBYekanMedium" data-toggle="tab" href="#LoadCapacitorLoadLoadPersmissionsIssuedforToday">مجوزهای صادر شده امروز</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link R2FontBYekanMedium" data-toggle="tab" href="#LoadCapacitorLoads">لیست بار</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link active R2FontBYekanMedium" data-toggle="tab" href="#LoadCapacitorLoadManipulation">ثبت و ویرایش بار</a>
                </li>
            </ul>
            <div class="tab-content">
                <div id="LoadCapacitorLoadManipulation" class="container-fluid tab-pane active">
                    <br />
                    <TWebControl:WcLoadCapacitorLoadManipulation runat="server" ID="WcLoadCapacitorLoadManipulation" />
                </div>
                <div id="LoadCapacitorLoads" class="container-fluid tab-pane fade">
                    <br />
                    <TWebControl:WcLoadCapacitorLoadsCollectionIntelligently runat="server" ID="WcLoadCapacitorLoadsCollectionIntelligently" />
                </div>
                <div id="LoadCapacitorLoadLoadPersmissionsIssuedforToday" class="container-fluid tab-pane fade ">
                    <br />
                    <TWebControl:WcLoadCapacitorLoadLoadPermissionsIssued runat="server" ID="WcLoadCapacitorLoadLoadPermissionsIssuedforToday" />
                </div>
                <div id="LoadCapacitorLoadLoadPersmissionsIssued" class="container-fluid tab-pane fade ">
                    <br />
                    <TWebControl:WcLoadCapacitorLoadLoadPermissionsIssued runat="server" ID="WcLoadCapacitorLoadLoadPermissionsIssued" />
                </div>

            </div>
        </div>
    </div>

</asp:Content>
