<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WcLoadCapacitorLoadLoadAllocationLoadPermissionIssue.ascx.cs" Inherits="ATISWeb.TransportationAndLoadNotification.LoadAllocationManagement.WcLoadCapacitorLoadLoadAllocationLoadPermissionIssue" %>
<%@ Register TagPrefix="TWebControl" TagName="WcViewerNSSLoadCapacitorLoad" Src="~/TransportationAndLoadNotification/LoadCapacitorManagement/WcViewerNSSLoadCapacitorLoad.ascx" %>
<%@ Register TagPrefix="TWebControl" TagName="WcSmartCardsInquiry" Src="~/TransportationAndLoadNotification/SmartCards/WcSmartCardsInquiry.ascx" %>
<%@ Register TagPrefix="TWebControl" TagName="WcLoadCapacitorLoadsCollectionSummaryIntelligently" Src="~/TransportationAndLoadNotification/LoadCapacitorManagement/WcLoadCapacitorLoadsCollectionSummaryIntelligently.ascx" %>
<%@ Register TagPrefix="TWebControl" TagName="WcEntryBillOfLadingNumber" Src="~/TransportationAndLoadNotification/BillOfLading/WCEntryBillOfLadingNumber.ascx" %>

<meta charset="utf-8" />
<meta http-equiv="X-UA-Compatible" content="IE=edge" />
<meta name="viewport" content="width=1">
<link href="~/Content/ATISFonts.css" rel="stylesheet" />
<link href="~/Content/font-awesome.css" rel="stylesheet">

<link href="/Content/bootstrap.min.css" rel="stylesheet" />
<script src="/Scripts/jquery-3.5.1.min.js"></script>
<script src="/Scripts/umd/popper.min.js"></script>
<script src="/Scripts/bootstrap.min.js"></script>


<div class="container-fluid p-1 border border-primary">
    <div class="container-fluid p-1">
        <div class="d-flex flex-row">
            <asp:Button runat="server" ID="BtnNewLoadAllocation" CssClass="btn  btn-secondary mr-3 R2FontBYekanSmall" Text="تخصیص جدید" />
        </div>
    </div>

    <asp:UpdatePanel ID="UpdatePanelWcViewerNSSLoadCapacitorLoad" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="True">
        <ContentTemplate>
            <div class="container-fluid mb-1 p-0">
                <TWebControl:WcLoadCapacitorLoadsCollectionSummaryIntelligently runat="server" ID="WcLoadCapacitorLoadsCollectionSummaryIntelligently" />
            </div>
            <div class="container-fluid mb-1 p-0">
                <TWebControl:WcViewerNSSLoadCapacitorLoad runat="server" ID="WcViewerNSSLoadCapacitorLoad" />
            </div>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="WcLoadCapacitorLoadsCollectionSummaryIntelligently" EventName="WcLoadCapacitorLoadSelectedEvent" />
        </Triggers>
    </asp:UpdatePanel>

    <TWebControl:WcSmartCardsInquiry runat="server" ID="WcSmartCardsInquiry" />
    <TWebControl:WcEntryBillOfLadingNumber runat="server" ID="WcEntryBillOfLadingNumber" />

    <br />
    <br />
    <asp:Panel runat="server" ID="PnlTurnStatus" CssClass="container-fluid p-1 text-center w-100">
        <asp:Label runat="server" ID="LblTurnStatus" CssClass=" R2FontBYekanLarge w-100" Style="color: white; background-color: transparent"></asp:Label>
    </asp:Panel>

    <div class="container-fluid p-1">
        <div class="d-flex flex-row">
            <asp:Button runat="server" ID="BtnLoadAllocation" CssClass="btn btn-info mr-3 R2FontBYekanSmall bg-danger" Text="تخصیص بار و صدور مجوز" />
        </div>
    </div>
</div>

