<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WcLoadCapacitorLoadLoadPermissionsIssued.ascx.cs" Inherits="ATISWeb.TransportationAndLoadNotification.LoadAllocationManagement.WcLoadCapacitorLoadLoadPermissionsIssued" %>
<%@ Register TagPrefix="TWebControl" TagName="WcLoadCapacitorLoadsCollectionSummaryIntelligently" Src="~/TransportationAndLoadNotification/LoadCapacitorManagement/WcLoadCapacitorLoadsCollectionSummaryIntelligently.ascx" %>

<div class="container-fluid p-1 border border-primary rounded">
    <div class="container-fluid bg-primary mb-2" style="height: 50px">
        <div class="d-flex flex-row-reverse  text-right">
            <asp:Label runat="server" ID="LblCaption" CssClass="R2FontBHomaLarge text-white">تخصیص های صادر شده</asp:Label>
        </div>
    </div>
    <asp:UpdatePanel ID="UpdatePanelWcLoadCapacitorLoadLoadPermissionsIssued" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="True">
        <ContentTemplate>
            <div class="container-fluid p-0 mb-2" style="">
                <TWebControl:WcLoadCapacitorLoadsCollectionSummaryIntelligently runat="server" ID="WcLoadCapacitorLoadsCollectionSummaryIntelligently"></TWebControl:WcLoadCapacitorLoadsCollectionSummaryIntelligently>
            </div>
            <div class="container-fluid text-center p-0">
                <asp:GridView ID="GridViewLoadCapacitorLoadLoadPermissionsIssued" runat="server" dir="rtl" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" ShowFooter="True" ShowHeaderWhenEmpty="True" Width="100%" HorizontalAlign="Center" HeaderStyle-CssClass="R2FontBYekanSmall">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <Columns>
                        <asp:BoundField ItemStyle-CssClass="R2FontBHomaSmall" HeaderText="ناوگان" DataField="Truck">
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField ItemStyle-CssClass="R2FontBHomaSmall" HeaderText="راننده" DataField="TruckDriver">
                            <HeaderStyle CssClass="ATISFontBYekanMedium" HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField ItemStyle-CssClass="R2FontBHomaSmall" HeaderText="گواهینامه" DataField="StrDrivingLicenceNo">
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField ItemStyle-CssClass="R2FontBHomaSmall" HeaderText="کدملی" DataField="StrNationalCode">
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField ItemStyle-CssClass="R2FontBHomaSmall" HeaderText="هوشمند راننده" DataField="StrSmartcardNo">
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField ItemStyle-CssClass="R2FontBHomaSmall" HeaderText="زمان صدور مجوز" DataField="StrExitDateTime">
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField ItemStyle-CssClass="R2FontBHomaSmall" HeaderText="موبایل" DataField="Mobile">
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField ItemStyle-CssClass="R2FontBHomaSmall" HeaderText="آدرس" DataField="strAddress">
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField ItemStyle-CssClass="R2FontBHomaSmall" HeaderText="محل صدور مجوز" DataField="IssuedLocation">
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField ItemStyle-CssClass="R2FontBHomaSmall" HeaderText="توضیحات" DataField="StrDescription">
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#000099" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="Gray" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>
            </div>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="WcLoadCapacitorLoadsCollectionSummaryIntelligently" EventName="WcLoadCapacitorLoadSelectedEvent" />
        </Triggers>
    </asp:UpdatePanel>
</div>

