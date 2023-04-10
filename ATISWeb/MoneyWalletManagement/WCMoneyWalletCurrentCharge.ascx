<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WCMoneyWalletCurrentCharge.ascx.cs" Inherits="ATISWeb.MoneyWalletManagement.WCMoneyWalletCurrentCharge" %>

<div class="container-fluid p-0">
    <div class="d-flex flex-row-reverse">
        <div class="input-group col-lg-4 p-0">
            <button runat="server" id="BtnRenew" class="btn btn-group-sm" style="background-color: yellow; color: black"><i class="fa fa-refresh" style="background-color: yellow; color: black"></i></button>
            <asp:TextBox runat="server" ID="TxtCurrentCharge" CssClass="form-control R2FontBHomaSmall text-center" ReadOnly="True" Text=""></asp:TextBox>
            <div class="input-group-append">
                <asp:Label runat="server" CssClass="input-group-text R2FontBHomaSmall" Style="background-color: yellow; color: black;">موجودی کیف پول(ریال)</asp:Label>
            </div>
        </div>
    </div>
</div>
