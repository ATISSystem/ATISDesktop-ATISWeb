<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WCMoneyWalletCharging.ascx.cs" Inherits="ATISWeb.MoneyWalletManagement.MoneyWalletChargingManagement.WCMoneyWalletCharging" %>

<%@ Register TagPrefix="TWebControl" TagName="WCMoneyWalletCurrentCharge" Src="~/MoneyWalletManagement/WCMoneyWalletCurrentCharge.ascx" %>


<div class="container-fluid p-1 border border-primary d-flex flex-column">
    <div class="container-fluid text-right bg-primary mb-1" style="height: 40px;">
        <asp:Label runat="server" ID="Label2" CssClass="R2FontBHomaLarge text-white">شارژ کیف پول</asp:Label>
    </div>
    <div class="container-fluid p-1 mb-2" style="background-color:  white">
        <TWebControl:WCMoneyWalletCurrentCharge runat="server" ID="WCMoneyWalletCurrentCharge" />
    </div>
    <div class="container-fluid p-1">
        <div style="text-align: right; background-color: white">
            <div class="form-check form-switch" style="text-align: right; width: 100%; margin: auto; background-color: white">
                <asp:RadioButtonList ID="RBListMoneyWalletChargingAmounts" runat="server" CssClass="R2FontBHomaLarge" BackColor="White" Style="text-align: right" AutoPostBack="true" CellPadding="0" CellSpacing="0" RepeatColumns="1" RepeatDirection="Vertical" RepeatLayout="Flow" TextAlign="Left" ForeColor="Black"></asp:RadioButtonList>
            </div>
        </div>
    </div>
    <div class="d-flex flex-row-reverse">
        <asp:Button runat="server" ID="BtnChargingg" CssClass="btn mr-2 R2FontBYekanSmall " Style="background-color:  yellow;color: black" Text="پرداخت" Width="10%" OnClientClick="target ='_blank';"/>
    </div>
    
</div>
