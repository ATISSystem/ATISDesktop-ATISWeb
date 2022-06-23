<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WcLoadCapacitorLoadsCollectionIntelligently.ascx.cs" Inherits="ATISWeb.TransportationAndLoadNotification.LoadCapacitorManagement.WcLoadCapacitorLoadsCollectionIntelligently" %>

<div class="container-fluid p-1 border border-primary">
    <div class="container-fluid bg-primary mb-2" style="height: 50px">
        <div class="row">
            <div class="col-lg-6">
                <asp:Button runat="server" ID="BtnRefresh" CssClass="btn btn-primary R2FontBYekanSmall" Text="بروز رسانی لیست" />
            </div>
            <div class="col-lg-6 text-right">
                <asp:Label runat="server" ID="LblCaption" CssClass="R2FontBHomaLarge text-white">لیست بار</asp:Label>
            </div>
        </div>
    </div> 
    <div class="container-fluid p-1">
        <div class="d-flex flex-row">
        </div>
    </div>
    <asp:UpdatePanel ID="UpdatePanelTxtnEstelamIdTxtDateTimeofLoadRegistering" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="False">
        <ContentTemplate>
            <div class="table table-responsive-lg border" >
                <asp:Table ID="TblLoadCapacitorLoads" runat="server" CssClass="table table-striped table-hover table-borderless text-center border-white" HorizontalAlign="Center" CellSpacing="0">
                    <asp:TableHeaderRow runat="server" CssClass="bg-primary" ForeColor="White">
                        <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">آدرس</asp:TableHeaderCell>
                        <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">گیرنده</asp:TableHeaderCell>
                        <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">توضیحات</asp:TableHeaderCell>
                        <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">تعرفه حمل</asp:TableHeaderCell>
                        <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">تعداد باقیمانده</asp:TableHeaderCell>
                        <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">تعداد کل</asp:TableHeaderCell>
                        <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">تناژ</asp:TableHeaderCell>
                        <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">بارگیر</asp:TableHeaderCell>
                        <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">مقصد</asp:TableHeaderCell>
                        <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">شرح بار</asp:TableHeaderCell>
                        <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">زمان ثبت بار</asp:TableHeaderCell>
                        <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">کد مخزن</asp:TableHeaderCell>
                    </asp:TableHeaderRow>
                </asp:Table>
            </div>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="BtnRefresh" EventName="Click" />
        </Triggers>
    </asp:UpdatePanel>

</div>
