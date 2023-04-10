<%@ Page Title="" Language="C#" MasterPageFile="~/DomainSite.Master" AutoEventWireup="true" CodeBehind="WfMoneyWallet.aspx.cs" Inherits="ATISWeb.MoneyWalletManagement.WfMoneyWallet" %>

<%@ Register TagPrefix="TWebControl" TagName="WCMoneyWalletCharging" Src="~/MoneyWalletManagement/MoneyWalletChargingManagement/WCMoneyWalletCharging.ascx" %>
<%@ Register TagPrefix="TWebControl" TagName="WcAlertShower" Src="~/AlertManagement/WcAlertShower.ascx" %>
<%@ Register TagPrefix="TWebControl" TagName="WCViewerNSSSoftwareUser"  Src="~/LoginManagement/WCViewerNSSSoftwareUser.ascx"  %>
<%@ Register TagPrefix="TWebControl" TagName="WCMoneyWalletChargeRecordsCollectionInteligently" Src="~/MoneyWalletManagement/WCMoneyWalletChargeRecordsCollectionInteligently.ascx" %>
<%@ Register TagPrefix="TWebControl" TagName="WCMoneyWalletAccouning" Src="~/MoneyWalletManagement/WCMoneyWalletAccouning.ascx" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager131" runat="server"></asp:ScriptManager>

    <div class="container-fluid">
        <div class="container-fluid  text-right">
            <div class="d-flex flex-column">
                <span class="" style="font-family: BHoma; font-size: 40px">کیف پول</span>
            </div>
        </div>
        <div class="container-fluid p-0 mb-1">
            <TWebControl:WCViewerNSSSoftwareUser runat="server" ID="WCViewerNSSSoftwareUser" />
        </div>
        <div class="container-fluid">
            <ul class="nav nav-tabs justify-content-end" role="tablist">
                <li class="nav-item">
                    <a class="nav-link R2FontBYekanMedium" data-toggle="tab" href="#MoneyWalletAccounting">تراکنشهای کیف پول</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link R2FontBYekanMedium" data-toggle="tab" href="#MoneyWalletChargingRecords">سوابق شارژ کیف پول</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link active R2FontBYekanMedium" data-toggle="tab" href="#MoneyWalletChargingProcess">شارژ کیف پول</a>
                </li>
            </ul>
            <div class="tab-content">
                <div id="MoneyWalletChargingProcess" class="container-fluid tab-pane active">
                    <br />
                    <TWebControl:WCMoneyWalletCharging runat="server" ID="WCMoneyWalletCharging" />
                </div>
                <div id="MoneyWalletChargingRecords" class="container-fluid tab-pane fade">
                    <br />
                    <TWebControl:WCMoneyWalletChargeRecordsCollectionInteligently runat="server" ID="WCMoneyWalletChargeRecordsCollectionInteligently" />
                </div>
                <div id="MoneyWalletAccounting" class="container-fluid tab-pane fade ">
                    <br />
                    <TWebControl:WCMoneyWalletAccouning runat="server" ID="WCMoneyWalletAccouning" />
                </div>
            </div>
        </div>
    </div>





</asp:Content>
