<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WCTransportTarrifsParameters.ascx.cs" Inherits="ATISWeb.TransportationAndLoadNotification.LoadCapacitorManagement.WCTransportTarrifsParameters" %>

<div class="container-fluid p-1 border border-primary d-flex flex-column">
    <div class="container-fluid text-right bg-primary mb-1" style="height: 40px">
        <asp:Label runat="server" ID="Label2" CssClass="R2FontBHomaLarge text-white">تیک بزنید - پارامترهای موثر در تعرفه حمل بار</asp:Label>
    </div>
    <div class="container-fluid p-1 mb-2" style="background-color: gainsboro">
        <div class="d-flex flex-row-reverse">
            <div class="input-group col-lg-3">
                <asp:TextBox runat="server" ID="TxtLoaderType" class="form-control R2FontBHomaSmall  text-center" ReadOnly="True"></asp:TextBox>
                <div class="input-group-append">
                    <span class="input-group-text R2FontBHomaSmall" style="background-color: yellow; color: blue">بارگیر</span>
                </div>
            </div>
        </div>
    </div>

    <div style="text-align: right; background-color: white">
        <div class="form-check form-switch" style="text-align: right; width: 100%; margin: auto; background-color: white">
            <asp:CheckBoxList ID="ChkboxlistTPTParams" runat="server" CssClass="R2FontBHomaLarge"   BackColor="White" Style="text-align: right" AutoPostBack="true" CellPadding="0" CellSpacing="0" RepeatColumns="1" RepeatDirection="Vertical" RepeatLayout="Flow" TextAlign="Left" ForeColor="Blue"></asp:CheckBoxList>
        </div>
    </div>


</div>
