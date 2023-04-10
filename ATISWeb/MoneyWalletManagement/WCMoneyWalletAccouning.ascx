<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WCMoneyWalletAccouning.ascx.cs" Inherits="ATISWeb.MoneyWalletManagement.WCMoneyWalletAccouning" %>

<div class="container-fluid p-1 border border-primary">
    <div class="container-fluid bg-primary mb-2" style="height: 50px">
        <div class="row">
            <div class="col-lg-6">
                <asp:Button runat="server" ID="BtnRefresh" CssClass="btn btn-primary R2FontBYekanSmall" Text="بروز رسانی" />
            </div>
            <div class="col-lg-6 text-right">
                <asp:Label runat="server" ID="LblCaption" CssClass="R2FontBHomaLarge text-white">تراکنش های کیف پول</asp:Label>
            </div>
        </div>
    </div>
    <div class="container-fluid p-1">
        <div class="d-flex flex-row">
        </div>
    </div>
    <asp:UpdatePanel ID="UpdatePanelMoneyWalletAccounting" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="False">
        <ContentTemplate>
            <div class="table table-responsive-lg border">
                <asp:Table ID="TblMoneyWalletAccounting" runat="server" CssClass="table table-striped table-hover table-borderless text-center border-white" HorizontalAlign="Center" CellSpacing="0">
                    <asp:TableHeaderRow runat="server" CssClass="" Style="background-color:yellow" ForeColor="Black">
                        <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">کاربر</asp:TableHeaderCell>
                        <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">درگاه</asp:TableHeaderCell>
                        <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">باقیمانده</asp:TableHeaderCell>
                        <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">مبلغ</asp:TableHeaderCell>
                        <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">موجودی</asp:TableHeaderCell>
                        <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">زمان</asp:TableHeaderCell>
                        <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">تاریخ</asp:TableHeaderCell>
                        <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">عملیات</asp:TableHeaderCell>
                    </asp:TableHeaderRow>
                </asp:Table>
            </div>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="BtnRefresh" EventName="Click" />
        </Triggers>
    </asp:UpdatePanel>

</div>
