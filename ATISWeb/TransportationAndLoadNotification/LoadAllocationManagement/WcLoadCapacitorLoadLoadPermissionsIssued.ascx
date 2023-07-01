<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WcLoadCapacitorLoadLoadPermissionsIssued.ascx.cs" Inherits="ATISWeb.TransportationAndLoadNotification.LoadAllocationManagement.WcLoadCapacitorLoadLoadPermissionsIssued" %>

<%@ Register TagPrefix="TWebControl" TagName="WcLoadCapacitorLoadsCollectionSummaryIntelligently" Src="~/TransportationAndLoadNotification/LoadCapacitorManagement/WcLoadCapacitorLoadsCollectionSummaryIntelligently.ascx" %>
<%@ Register TagPrefix="TWebControl" TagName="WCDriverSelfDeclarationViewer" Src="~/TransportationAndLoadNotification/DriverSelfDeclaration/WCDriverSelfDeclarationViewer.ascx" %>

<div class="container-fluid p-1 border border-primary rounded">
    <div class="container-fluid bg-primary mb-2" style="height: 50px">
        <div class="d-flex flex-row-reverse  text-right">
            <asp:Label runat="server" ID="LblCaption" CssClass="R2FontBHomaLarge text-white">مجوزهای صادر شده</asp:Label>
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
                        <asp:BoundField ItemStyle-CssClass="R2FontBHomaSmall" HeaderText="تخصیص" DataField="LoadAllocationId">
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField ItemStyle-CssClass="R2FontBHomaSmall" HeaderText="ناوگان" DataField="Truck">
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField ItemStyle-CssClass="R2FontBHomaSmall" HeaderText="هوشمند ناوگان" DataField="TruckSmartCardNo">
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
                        <asp:CommandField ButtonType="Image" HeaderText="مشاهده" SelectImageUrl="~/Images/Monitor.ico" ShowSelectButton="true" Visible="true" />
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
            <br />
            <div class="container-fluid p-1">
                <asp:Button runat="server" ID="BtnPrint" Visible="true" CssClass="btn btn-info mr-3 R2FontBYekanSmall bg-success" Text="چاپ مجوز" OnClientClick="return PrintLoadPermission();" />
            </div>
            <asp:Panel ID="PnlPrintLoadPermission" runat="server" Style="margin-left: auto; margin-right: auto;" Visible="true" Width="70%">
                <div runat="server" style="border: solid;">
                    <div style="text-align: center; width: 100%; font-family: 'B Homa'; font-size: x-large;">
                        <span>پایانه امیرکبیر اصفهان</span>
                    </div>
                    <div style="width: 100%;">
                        <div style="display: inline-block; float: left; font-family: 'B Homa'; font-size: smaller; margin-left: 20px; text-align: right">
                            <span>تاریخ صدور <%=PPDS.LoadPermissionDate%></span><br />
                            <span>ساعت صدور <%=PPDS.LoadPermissionTime%></span>
                        </div>
                        <div style="display: inline-block; float: right; font-family: 'B Homa'; font-size: smaller; margin-right: 20px; text-align: right">
                            <span>شماره تخصیص <%=PPDS.LoadAllocationId%></span><br />
                            <span>کد مخزن بار <%=PPDS.nEstelamId%></span><br />
                            <span>شماره نوبت <%=PPDS.TurnId%></span>
                        </div>
                    </div>
                    <br />
                    <div style="width: 100%; text-align: center; font-family: Titr; font-size: smaller;">
                        <span>سیستم هوشمند صدور مجوز بارگیری</span><br />
                        <span>((مجوز بارگیری))</span>
                    </div>
                    <div style="width: 100%; text-align: right; font-family: Titr; font-size: small;"><span>شرکت/موسسه محترم <%=PPDS.TransportCompany%>&nbsp;&nbsp;&nbsp;</span></div>
                    <br />
                    <div style="width: 100%; text-align: right;">
                        <div style="display: inline-block; float: right; font-family: 'B Homa'; font-size: smaller;"><span>بدین وسیله یک دستگاه <%=PPDS.CarType%></span>&nbsp;&nbsp;</div>
                        <div style="display: inline-block; float: right; font-family: B Homa; font-size: smaller;"><span>به شماره پلاک <%=PPDS.TruckLP%> - <%=PPDS.TruckLPSerial%></span></div>
                    </div>
                    <br />
                    <br />
                    <div style="width: 100%; text-align: center; font-family: 'B Homa'; font-size: smaller;">
                        <div><span>به رانندگی آقای <%=PPDS.TruckDriver%> دارای گواهینامه به شماره <%=PPDS.TruckDriverDrivingLicenseNo%></span>&nbsp;&nbsp;</div>
                    </div>

                    <div style="width: 100%; text-align: right;">
                        <div style="display: inline-block; float: right; font-family: 'B Homa'; font-size: x-small;"><span>جهت حمل <%=PPDS.GoodName%>   با تناژ:<%=PPDS.Tonaj%></span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</div>
                        <div style="display: inline-block; float: right; font-family: 'B Homa'; font-size: x-small;"><span>از اصفهان به مقصد <%=PPDS.TargetCity%></span>&nbsp;&nbsp;&nbsp;</div>
                    </div>
                    <br />
                    <div style="width: 100%; text-align: right;">
                        <div style="display: inline-block; float: right; font-family: 'B Homa'; font-size: smaller;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span>با نرخ <%=PPDS.TransportPrice%> ریال با مسئولیت آن شرکت/موسسه معرفی می گردد</span></div>
                        <div style="display: inline-block; float: right; font-family: 'B Homa'; font-size: smaller;"><span></span>&nbsp;&nbsp;&nbsp;</div>
                    </div>
                    <br />
                    <div style="width: 100%; text-align: center;">
                        <div style="display: inline-block; float: right; font-family: 'B Homa'; font-size: smaller;"><span><%=PPDS.LoadCapacitorLoadDescription%></span></div>
                    </div>
                    <br />
                    <div style="width: 100%; text-align: center;">
                        <div style="display: inline-block; float: right; font-family: 'B Homa'; font-size: x-small;"><span>توجه : مجوز فوق پس از صدور تعویض نخواهد شد - دریافت نوبت بعدی از پایانه به شرط انجام سفر امکان پذیر است</span></div>
                    </div>
                    <br />
                    <div style="width: 100%; text-align: center;">
                        <div style="display: inline-block; float: left; font-family: 'B Homa'; font-size: x-small;"><span style="font-family: 'B Homa'; font-size: 10;">&nbsp;&nbsp;&nbsp; نام کاربر : <%=PPDS.UserName%></span></div>
                    </div>
                    <br />
                    <br />
                </div>
                <br />
                <br />
                <div runat="server" style="border: solid;">
                    <div style="text-align: center; width: 100%; font-family: 'B Homa'; font-size: x-large;">
                        <span>پایانه امیرکبیر اصفهان</span>
                    </div>
                    <div style="width: 100%;">
                        <div style="display: inline-block; float: left; font-family: 'B Homa'; font-size: smaller; margin-left: 20px; text-align: right">
                            <span>تاریخ صدور <%=PPDS.LoadPermissionDate%></span><br />
                            <span>ساعت صدور <%=PPDS.LoadPermissionTime%></span>
                        </div>
                        <div style="display: inline-block; float: right; font-family: 'B Homa'; font-size: smaller; margin-right: 20px; text-align: right">
                            <span>شماره تخصیص <%=PPDS.LoadAllocationId%></span><br />
                            <span>کد مخزن بار <%=PPDS.nEstelamId%></span><br />
                            <span>شماره نوبت <%=PPDS.TurnId%></span>
                        </div>
                    </div>
                    <br />
                    <div style="width: 100%; text-align: center; font-family: Titr; font-size: smaller;">
                        <span>سیستم هوشمند صدور مجوز بارگیری</span><br />
                        <span>((مجوز بارگیری))</span>
                    </div>
                    <div style="width: 100%; text-align: right; font-family: Titr; font-size: small;"><span>شرکت/موسسه محترم <%=PPDS.TransportCompany%>&nbsp;&nbsp;&nbsp;</span></div>
                    <br />
                    <div style="width: 100%; text-align: right;">
                        <div style="display: inline-block; float: right; font-family: 'B Homa'; font-size: smaller;"><span>بدین وسیله یک دستگاه <%=PPDS.CarType%></span>&nbsp;&nbsp;</div>
                        <div style="display: inline-block; float: right; font-family: B Homa; font-size: smaller;"><span>به شماره پلاک <%=PPDS.TruckLP%> - <%=PPDS.TruckLPSerial%></span></div>
                    </div>
                    <br />
                    <br />
                    <div style="width: 100%; text-align: center; font-family: 'B Homa'; font-size: smaller;">
                        <div><span>به رانندگی آقای <%=PPDS.TruckDriver%> دارای گواهینامه به شماره <%=PPDS.TruckDriverDrivingLicenseNo%></span>&nbsp;&nbsp;</div>
                    </div>

                    <div style="width: 100%; text-align: right;">
                        <div style="display: inline-block; float: right; font-family: 'B Homa'; font-size: x-small;"><span>جهت حمل <%=PPDS.GoodName%>   با تناژ:<%=PPDS.Tonaj%></span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</div>
                        <div style="display: inline-block; float: right; font-family: 'B Homa'; font-size: x-small;"><span>از اصفهان به مقصد <%=PPDS.TargetCity%></span>&nbsp;&nbsp;&nbsp;</div>
                    </div>
                    <br />
                    <div style="width: 100%; text-align: right;">
                        <div style="display: inline-block; float: right; font-family: 'B Homa'; font-size: smaller;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span>با نرخ <%=PPDS.TransportPrice%> ریال با مسئولیت آن شرکت/موسسه معرفی می گردد</span></div>
                        <div style="display: inline-block; float: right; font-family: 'B Homa'; font-size: smaller;"><span></span>&nbsp;&nbsp;&nbsp;</div>
                    </div>
                    <br />
                    <div style="width: 100%; text-align: center;">
                        <div style="display: inline-block; float: right; font-family: 'B Homa'; font-size: smaller;"><span><%=PPDS.LoadCapacitorLoadDescription%></span></div>
                    </div>
                    <br />
                    <div style="width: 100%; text-align: center;">
                        <div style="display: inline-block; float: right; font-family: 'B Homa'; font-size: x-small;"><span>توجه : مجوز فوق پس از صدور تعویض نخواهد شد - دریافت نوبت بعدی از پایانه به شرط انجام سفر امکان پذیر است</span></div>
                    </div>
                    <br />
                    <div style="width: 100%; text-align: center;">
                        <div style="display: inline-block; float: left; font-family: 'B Homa'; font-size: x-small;"><span style="font-family: 'B Homa'; font-size: 10;">&nbsp;&nbsp;&nbsp; نام کاربر : <%=PPDS.UserName%></span></div>
                    </div>
                    <br />
                    <br />
                </div>
            </asp:Panel>
            <br />
            <div class="container-fluid p-0 mb-2" style="">
                <TWebControl:WCDriverSelfDeclarationViewer runat="server" ID="WCDriverSelfDeclarationViewer"></TWebControl:WCDriverSelfDeclarationViewer>
            </div>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="WcLoadCapacitorLoadsCollectionSummaryIntelligently" EventName="WcLoadCapacitorLoadSelectedEvent" />
            <asp:AsyncPostBackTrigger ControlID="GridViewLoadCapacitorLoadLoadPermissionsIssued" EventName="SelectedIndexChanged" />
        </Triggers>
    </asp:UpdatePanel>


    <br />
    <br />
    <br />

</div>

<script type="text/javascript">
    function PrintLoadPermission() {
        var panel = document.getElementById("<%=PnlPrintLoadPermission.ClientID %>");
        var printWindow = window.open('', '', 'height=400,width=800');
        printWindow.document.write('<html><head><title></title>');
        printWindow.document.write('</head><body>');
        printWindow.document.write(panel.innerHTML);
        printWindow.document.write('</body></html>');
        printWindow.document.close();
        setTimeout(function () {
            printWindow.print();
        }, 500);
        return false;
    }
</script>


