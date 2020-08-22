<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCViewerLoadCapacitorLoads.ascx.cs" Inherits="R2WebPrimaryTest.UserControls.UCViewerLoadCapacitorLoads" %>
<asp:Panel ID="Panel3" runat="server">
    <asp:Table ID="TblLoadCapacitorLoads" runat="server" HorizontalAlign="Center" Width="100%" CellPadding="3" CellSpacing="0" GridLines="Vertical" Font-Names="B Homa">
        <asp:TableHeaderRow ID="Table1HeaderRow" BackColor="LightBlue" runat="server">
            <asp:TableHeaderCell HorizontalAlign="Center">آدرس</asp:TableHeaderCell>
            <asp:TableHeaderCell HorizontalAlign="Center">توضیحات</asp:TableHeaderCell>
            <asp:TableHeaderCell HorizontalAlign="Center">گیرنده</asp:TableHeaderCell>
            <asp:TableHeaderCell HorizontalAlign="Center">تعرفه حمل</asp:TableHeaderCell>
            <asp:TableHeaderCell HorizontalAlign="Center">تعداد</asp:TableHeaderCell>
            <asp:TableHeaderCell HorizontalAlign="Center">بارگیر</asp:TableHeaderCell>
            <asp:TableHeaderCell HorizontalAlign="Center">مقصد</asp:TableHeaderCell>
            <asp:TableHeaderCell HorizontalAlign="Center">عنوان بار</asp:TableHeaderCell>
            <asp:TableHeaderCell HorizontalAlign="Center">زمان ثبت بار</asp:TableHeaderCell>
            <asp:TableHeaderCell HorizontalAlign="Center">کدمخزن</asp:TableHeaderCell>
        </asp:TableHeaderRow>
    </asp:Table>
</asp:Panel>
