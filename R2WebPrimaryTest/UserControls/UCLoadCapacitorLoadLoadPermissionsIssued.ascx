<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCLoadCapacitorLoadLoadPermissionsIssued.ascx.cs" Inherits="R2WebPrimaryTest.UserControls.UCLoadCapacitorLoadLoadPermissionsIssued" %>
<div>
    <asp:GridView ID="GridViewLoadCapacitorLoadLoadPermissionsIssued" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" Font-Names="B Homa" ForeColor="#FF3300" GridLines="Vertical" ShowFooter="True" ShowHeaderWhenEmpty="True" Width="100%" Caption="لیست مجوزهای صادر شده" CaptionAlign="Top" HorizontalAlign="Center">
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <Columns>
            <asp:BoundField HeaderText="توضیحات" DataField="StrDescription" ><HeaderStyle HorizontalAlign="Center" /><ItemStyle HorizontalAlign="Center" /></asp:BoundField>
            <asp:BoundField  HeaderText="محل صدور مجوز" DataField="IssuedLocation"><HeaderStyle HorizontalAlign="Center" /><ItemStyle HorizontalAlign="Center" /></asp:BoundField>
            <asp:BoundField HeaderText="آدرس" DataField="strAddress"><HeaderStyle HorizontalAlign="Center" /><ItemStyle HorizontalAlign="Center" /></asp:BoundField>
            <asp:BoundField HeaderText="موبایل" DataField="Mobile"><HeaderStyle HorizontalAlign="Center" /><ItemStyle HorizontalAlign="Center" /></asp:BoundField>
            <asp:BoundField  HeaderText="زمان صدور مجوز" DataField="StrExitDateTime"><HeaderStyle HorizontalAlign="Center" /><ItemStyle HorizontalAlign="Center" /></asp:BoundField>
            <asp:BoundField HeaderText="هوشمند راننده" DataField="StrSmartcardNo"><HeaderStyle HorizontalAlign="Center" /><ItemStyle HorizontalAlign="Center" /></asp:BoundField>
            <asp:BoundField HeaderText="کدملی" DataField="StrNationalCode"><HeaderStyle HorizontalAlign="Center" /><ItemStyle HorizontalAlign="Center" /></asp:BoundField>
            <asp:BoundField  HeaderText="گواهینامه" DataField="StrDrivingLicenceNo"><HeaderStyle HorizontalAlign="Center" /><ItemStyle HorizontalAlign="Center" /></asp:BoundField>
            <asp:BoundField HeaderText="راننده" DataField="TruckDriver"><HeaderStyle HorizontalAlign="Center" /><ItemStyle HorizontalAlign="Center" /></asp:BoundField>
            <asp:BoundField HeaderText="ناوگان" DataField="Truck"><HeaderStyle HorizontalAlign="Center" /><ItemStyle HorizontalAlign="Center" /></asp:BoundField>
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="Gray" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
</div>

