<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" ViewStateMode="Enabled" CodeBehind="LoadCapacitorLoadManipulation.aspx.cs" Inherits="R2WebPrimaryTest.LoadCapacitorLoadManipulation" %>

<%@ Register Src="~/UserControls/UCLoadCapacitorLoadManipulation.ascx" TagName="UCLoadCapacitorLoadManipulation" TagPrefix="TWebControl" %>
<%@ Register Src="~/UserControls/UCLoadCapacitorLoadLoadPermissionsIssued.ascx" TagName="UCLoadCapacitorLoadLoadPermissionsIssued" TagPrefix="TWebControl" %>
<%@ Register Src="~/UserControls/UCViewerLoadCapacitorLoads.ascx" TagName="UCViewerLoadCapacitorLoads" TagPrefix="TWebControl" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="StyleSheets/StyleSheet1.css" rel="Stylesheet" type="text/css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>

    <asp:Panel ID="Panel8" runat="server">
        <h1 style="text-align: right; color: rebeccapurple">ثبت بار شرکت حمل و نقل</h1>
        <asp:Label runat="server" ID="TransportCompanyTitle" CssClass="TransportCompanyTitle" ForeColor="Red" Text="شرکت حمل و نقل" Width="50%"></asp:Label>
        <hr style="width: 100%; color: gray; height: 1px;" />
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel2" runat="server">
        <TWebControl:UCLoadCapacitorLoadManipulation ID="UCLoadCapacitorLoadManipulation" runat="server" ClientIDMode="Inherit" ValidateRequestMode="Inherit" ViewStateMode="Inherit"></TWebControl:UCLoadCapacitorLoadManipulation>
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel5" runat="server">
        <TWebControl:UCLoadCapacitorLoadLoadPermissionsIssued ID="UCLoadCapacitorLoadLoadPermissionsIssued" runat="server" ClientIDMode="Inherit" ValidateRequestMode="Inherit" ViewStateMode="Inherit" EnableTheming="True" EnableViewState="True"></TWebControl:UCLoadCapacitorLoadLoadPermissionsIssued>
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel4" runat="server" HorizontalAlign="Left" Width="100%">
        <asp:Button ID="BtnViewLoads" runat="server" UseSubmitBehavior="false" Text="نمایش مجدد لیست بار" />&nbsp;&nbsp;
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel3" runat="server">
        <TWebControl:UCViewerLoadCapacitorLoads ID="UCViewerLoadCapacitorLoads" runat="server" ClientIDMode="Inherit" ValidateRequestMode="Inherit" ViewStateMode="Inherit" EnableTheming="True" EnableViewState="True"></TWebControl:UCViewerLoadCapacitorLoads>
    </asp:Panel>




</asp:Content>
