<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WcLoadCapacitorLoadsCollectionSummaryIntelligently.ascx.cs" Inherits="ATISWeb.TransportationAndLoadNotification.LoadCapacitorManagement.WcLoadCapacitorLoadsCollectionSummaryIntelligently" %>

<div class="container-fluid p-0" style="">
    <div class="d-flex flex-row-reverse">
        <div class="input-group col-lg-6 col-sm-6" style="">
            <button runat="server" id="BtnRenew" class="btn btn-group-sm" style="background-color: greenyellow; color: black"><i class="fa fa-refresh" style="background-color: greenyellow; color: black"></i></button>
            <asp:DropDownList runat="server" ID="DropDownListLoads" CssClass="form-control R2FontBHomaSmall" OnSelectedIndexChanged="OnSelectedIndexChanged" Style="direction: rtl;" AutoPostBack="True" />
            <div class="input-group-append">
                <asp:Label runat="server" ID="LblCaption" CssClass="input-group-text R2FontBHomaSmall" Style="background-color: greenyellow; color: black" Text="لیست بار"></asp:Label>
            </div>
        </div>
    </div>
</div>
