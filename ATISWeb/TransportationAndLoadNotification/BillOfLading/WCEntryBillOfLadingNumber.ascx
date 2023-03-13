<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WCEntryBillOfLadingNumber.ascx.cs" Inherits="ATISWeb.TransportationAndLoadNotification.LoadAllocationManagement.WCEntryBillOfLadingNumber" %>

<div class="container-fluid p-1 border border-primary rounded">
    <div class="container-fluid text-right bg-primary" style="height: 40px">
        <asp:Label runat="server" ID="Label2" CssClass="R2FontBHomaLarge text-white">شماره بارنامه صادر شده</asp:Label>
    </div>
    <div class="container-fluid p-1 border mb-1" style="border-color: gainsboro">
        <div class="d-flex flex-row-reverse">
            <div class="input-group col-lg-3 col-sm-3">
                <asp:TextBox runat="server" ID="TxtBillOfLadingNumber" class="form-control R2FontBHomaSmall  text-center"></asp:TextBox>
                <div class="input-group-append">
                    <span class="input-group-text R2FontBHomaSmall" style="background-color: greenyellow; color: black">شماره بارنامه</span>
                </div>
            </div>
        </div>
    </div>
</div>

