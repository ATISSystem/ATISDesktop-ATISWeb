<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WCDriverSelfDeclarationViewer.ascx.cs" Inherits="ATISWeb.TransportationAndLoadNotification.DriverSelfDeclaration.WCDriverSelfDeclarationViewer" %>

<div class="container-fluid p-1 border border-primary d-flex flex-column">
    <div class="container-fluid text-right bg-primary mb-1" style="height: 40px">
        <asp:Label runat="server" ID="Label2" CssClass="R2FontBHomaLarge text-white">مشخصات خوداظهاری ناوگان باری که توسط راننده ارسال شده است</asp:Label>
    </div>
    <div class="table table-responsive-lg border">
        <asp:Table ID="TblDSDs" runat="server" CssClass="table table-striped table-hover table-borderless text-center border-white" HorizontalAlign="Center" CellSpacing="0">
            <asp:TableHeaderRow runat="server" CssClass="bg-primary" ForeColor="White">
                <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">مشخصه خوداظهاری</asp:TableHeaderCell>
            </asp:TableHeaderRow>
        </asp:Table>
    </div>
</div>
