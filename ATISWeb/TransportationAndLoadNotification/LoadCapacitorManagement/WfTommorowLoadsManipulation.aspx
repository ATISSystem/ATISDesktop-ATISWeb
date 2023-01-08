<%@ Page Title="آتیس وب | بار فردا" Language="C#" MasterPageFile="~/DomainSite.Master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeBehind="WfTommorowLoadsManipulation.aspx.cs" Inherits="ATISWeb.TransportationAndLoadNotification.LoadCapacitorManagement.WfTommorowLoadsManipulation" %>

<%@ Register TagPrefix="TWebControl" TagName="WcViewerNSSTransportCompanyIntelligently" Src="~/TransportationAndLoadNotification/TransportCompanies/WcViewerNSSTransportCompanyIntelligently.ascx" %>
<%@ Register TagPrefix="TWebControl" TagName="WcLoadCapacitorLoadManipulation" Src="~/TransportationAndLoadNotification/LoadCapacitorManagement/WcLoadCapacitorLoadManipulation.ascx" %>
<%@ Register TagPrefix="TWebControl" TagName="WcLoadCapacitorLoadsCollectionIntelligently" Src="~/TransportationAndLoadNotification/LoadCapacitorManagement/WcLoadCapacitorLoadsCollectionIntelligently.ascx" %>
<%@ Register Src="~/LoginManagement/WCViewerNSSSoftwareUser.ascx" TagName="WCViewerNSSSoftwareUser" TagPrefix="TWebControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager131" runat="server"></asp:ScriptManager>

    <div class="container-fluid">
        <div class="container-fluid  text-right">
            <div class="d-flex flex-column">
                <span class="" style="font-family: BHoma; font-size: 40px">بار فردا</span>
            </div>
        </div>
        <div class="container-fluid p-0 mb-1">
            <TWebControl:WCViewerNSSSoftwareUser runat="server" ID="WCViewerNSSSoftwareUser" />
        </div>
        <div class="container-fluid">
            <ul class="nav nav-tabs justify-content-end" role="tablist">
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
            </div>
        </div>
    </div>

</asp:Content>
