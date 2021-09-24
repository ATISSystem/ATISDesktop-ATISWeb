<%@ Page Title="آتیس وب | تخصیص بار" Language="C#" MasterPageFile="~/DomainSite.Master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeBehind="WfLoadCapacitorLoadLoadAllocationLoadPermissionIssue.aspx.cs" Inherits="ATISWeb.TransportationAndLoadNotification.LoadAllocationManagement.WfLoadCapacitorLoadLoadAllocationLoadPermissionIssue" %>

<%@ Register Src="~/TransportationAndLoadNotification/LoadCapacitorManagement/WcLoadCapacitorLoadsCollectionIntelligently.ascx" TagName="WcLoadCapacitorLoadsCollectionIntelligently" TagPrefix="TWebControl" %>
<%@ Register Src="~/TransportationAndLoadNotification/LoadAllocationManagement/WcLoadCapacitorLoadLoadPermissionsIssued.ascx" TagName="WcLoadCapacitorLoadLoadPermissionsIssued" TagPrefix="TWebControl" %>
<%@ Register Src="~/TransportationAndLoadNotification/TransportCompanies/WcViewerNSSTransportCompanyIntelligently.ascx" TagName="WcViewerNSSTransportCompanyIntelligently" TagPrefix="TWebControl" %>
<%@ Register Src="~/AlertManagement/WcAlertShower.ascx" TagName="WcAlertShower" TagPrefix="TWebControl" %>
<%@ Register Src="~/TransportationAndLoadNotification/LoadAllocationManagement/WcLoadCapacitorLoadLoadAllocationLoadPermissionIssue.ascx" TagName="WcLoadCapacitorLoadLoadAllocationLoadPermissionIssue" TagPrefix="TWebControl" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <TWebControl:WcAlertShower runat="server" ID="WcAlertShower" />

    <div class="container-fluid">
        <div class="container-fluid  text-right">
            <div class="d-flex flex-column">
                <span class="" style="font-family: BHoma; font-size: 40px">بار رسوب شده</span>
            </div>
        </div>
        <div class="container-fluid p-0 mb-1">
            <TWebControl:WcViewerNSSTransportCompanyIntelligently runat="server" ID="WcViewerNSSTransportCompanyIntelligently" />
        </div>

        <div class="container-fluid">
            <ul class="nav nav-tabs justify-content-end" role="tablist">
                <li class="nav-item">
                    <a class="nav-link R2FontBYekanMedium " data-toggle="tab" href="#LoadCapacitorLoads">لیست بار</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link R2FontBYekanMedium" data-toggle="tab" href="#LoadCapacitorLoadLoadPersmissionsIssued">مجوزهای صادر شده</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link active R2FontBYekanMedium" data-toggle="tab" href="#LoadCapacitorLoadLoadAllocationLoadPermissionIssue">تخصیص بار</a>
                </li>
            </ul>
            <div class="tab-content">
                <div id="LoadCapacitorLoadLoadAllocationLoadPermissionIssue" class="container-fluid tab-pane active">
                    <br />
                    <TWebControl:WcLoadCapacitorLoadLoadAllocationLoadPermissionIssue runat="server" ID="WcLoadCapacitorLoadLoadAllocationLoadPermissionIssue" />
                </div>
                <div id="LoadCapacitorLoadLoadPersmissionsIssued" class="container-fluid tab-pane fade ">
                    <br />
                    <TWebControl:WcLoadCapacitorLoadLoadPermissionsIssued runat="server" ID="WcLoadCapacitorLoadLoadPermissionsIssued" />
                </div>
                <div id="LoadCapacitorLoads" class="container-fluid tab-pane">
                    <br />
                    <TWebControl:WcLoadCapacitorLoadsCollectionIntelligently runat="server" ID="WcLoadCapacitorLoadsCollectionIntelligently" />
                </div>
            </div>
        </div>
    </div>
    <br />
    <br />




</asp:Content>
