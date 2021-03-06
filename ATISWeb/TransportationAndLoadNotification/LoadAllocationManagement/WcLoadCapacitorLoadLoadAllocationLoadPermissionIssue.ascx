<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WcLoadCapacitorLoadLoadAllocationLoadPermissionIssue.ascx.cs" Inherits="ATISWeb.TransportationAndLoadNotification.LoadAllocationManagement.WcLoadCapacitorLoadLoadAllocationLoadPermissionIssue" %>
<%@ Register TagPrefix="TWebControl" TagName="WcViewerNSSLoadCapacitorLoad" Src="~/TransportationAndLoadNotification/LoadCapacitorManagement/WcViewerNSSLoadCapacitorLoad.ascx" %>
<%@ Register TagPrefix="TWebControl" TagName="WcSmartCardsInquiry" Src="~/TransportationAndLoadNotification/SmartCards/WcSmartCardsInquiry.ascx" %>
<%@ Register TagPrefix="TWebControl" TagName="WcLoadCapacitorLoadsCollectionSummaryIntelligently" Src="~/TransportationAndLoadNotification/LoadCapacitorManagement/WcLoadCapacitorLoadsCollectionSummaryIntelligently.ascx" %>


<div class="container-fluid p-1 border border-primary">
    <asp:UpdatePanel ID="UpdatePanelWcViewerNSSLoadCapacitorLoad" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="True">
        <ContentTemplate>
            <div class="container-fluid mb-1 p-0">
                <TWebControl:WcLoadCapacitorLoadsCollectionSummaryIntelligently runat="server" ID="WcLoadCapacitorLoadsCollectionSummaryIntelligently" />
            </div>
            <div class="container-fluid mb-1 p-0">
                <TWebControl:WcViewerNSSLoadCapacitorLoad runat="server" ID="WcViewerNSSLoadCapacitorLoad" />
            </div>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="BtnPrint" EventName="Click" />
            <asp:AsyncPostBackTrigger ControlID="WcLoadCapacitorLoadsCollectionSummaryIntelligently" EventName="WcLoadCapacitorLoadSelectedEvent" />
        </Triggers>
    </asp:UpdatePanel>

    <TWebControl:WcSmartCardsInquiry runat="server" ID="WcSmartCardsInquiry" />

    <asp:UpdatePanel ID="UpdatePanelWcLoadCapacitorLoadLoadAllocationLoadPermissionIssue" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="False">
        <ContentTemplate>
            <div class="container-fluid p-1">
                <div class="d-flex flex-row">
                    <asp:Button runat="server" ID="BtnPrint" CssClass="btn btn-info mr-3 R2FontBYekanSmall bg-success" Text="چاپ مجوز" OnClientClick="return PrintLoadPermission();" />
                    <asp:Button runat="server" ID="BtnLoadAllocationLoadPermissionIssue" CssClass="btn btn-info mr-3 R2FontBYekanSmall bg-danger" Text="تخصیص بار و صدور مجوز" />
                </div>
            </div>
            <asp:Panel ID="PnlPrintLoadPermission" runat="server" Style="margin-left: auto; margin-right: auto;" Visible="True" Width="70%">
                <div runat="server" style="border: solid;">
                    <div style="text-align: center; width: 100%; font-family: 'B Homa'; font-size: xx-large;">
                        <span>پایانه امیرکبیر اصفهان</span>
                    </div>
                    <div style="width: 100%;">
                        <div style="display: inline-block; float: left; font-family: 'B Homa'; font-size: medium; margin-left: 20px; text-align: right">
                            <span>تاریخ صدور <%=PPDS.StrExitDate%></span><br />
                            <span>ساعت صدور <%=PPDS.StrExitTime%></span>
                        </div>
                        <div style="display: inline-block; float: right; font-family: 'B Homa'; font-size: medium; margin-right: 20px; text-align: right">
                            <span>شماره تخصیص <%=PPDS.LAId%></span><br />
                            <span>کدمخزن بار <%=PPDS.nEstelamId%></span><br />
                            <span>شماره نوبت <%=PPDS.TurnId%></span>
                        </div>
                    </div>
                    <br />
                    <div style="width: 100%; text-align: center; font-family: Titr; font-size: larger;">
                        <span>سیستم هوشمند صدور مجوز بارگیری</span><br />
                        <span>((مجوز بارگیری))</span>
                    </div>
                    <div style="width: 100%; text-align: right; font-family: Titr; font-size: larger;"><span>شرکت/موسسه محترم <%=PPDS.CompanyName%>&nbsp;&nbsp;&nbsp;</span></div>
                    <br />
                    <div style="width: 100%; text-align: right;">
                        <div style="display: inline-block; float: right; font-family: 'B Homa'; font-size: medium;"><span>بدین وسیله یک دستگاه <%=PPDS.CarTruckLoaderTypeName%></span>&nbsp;&nbsp;</div>
                        <div style="display: inline-block; float: right; font-family: B Homa; font-size: medium;"><span>به شماره پلاک <%=PPDS.pelak%> - <%=PPDS.Serial%></span></div>
                    </div>
                    <br />
                    <br />

                    <div style="width: 100%; text-align: center; font-family: 'B Homa'; font-size: larger;">
                        <div><span>به رانندگی آقای <%=PPDS.DriverTruckFullNameFamily%> دارای گواهینامه به شماره <%=PPDS.DriverTruckDrivingLicenseNo%></span>&nbsp;&nbsp;</div>
                    </div>

                    <div style="width: 100%; text-align: right;">
                        <div style="display: inline-block; float: right; font-family: 'B Homa'; font-size: larger;"><span>جهت حمل <%=PPDS.ProductName%></span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</div>
                        <div style="display: inline-block; float: right; font-family: 'B Homa'; font-size: larger;"><span>از اصفهان به مقصد <%=PPDS.TargetCityName%></span>&nbsp;&nbsp;&nbsp;</div>
                    </div>
                    <br />
                    <br />
                    <div style="width: 100%; text-align: center; font-family: 'B Homa'; font-size: larger;">
                        <div style="display: inline-block; float: right">&nbsp;<span>با نرخ <%=PPDS.StrPriceSug%></span>&nbsp;&nbsp;&nbsp;</div>
                        <div style="display: inline-block; float: right"><span>ریال با مسئولیت آن شرکت/موسسه معرفی می گردد</span></div>
                    </div>
                    <br />
                    <br />
                    <div style="text-align: center; font-family: 'B Homa'; font-size: medium;">
                        <div style="display: inline-block; float: right; direction: rtl">&nbsp;&nbsp;&nbsp;<span>توجه : </span></div>
                        <div style="display: inline-block; float: right"><span><%=PPDS.StrDescription%></span></div>
                    </div>
                    <br />
                    <br />
                    <div style="text-align: center; font-family: 'B Homa'; font-size: medium;">
                        <span>مجوز فوق پس از صدور تعویض نخواهد شد - دریافت نوبت بعدی از پایانه به شرط انجام سفر امکان پذیر است</span>
                    </div>
                    <div>
                        <span style="font-family: 'B Homa'; font-size: 10;">&nbsp;&nbsp;&nbsp; نام کاربر : <%=PPDS.PermissionUserName%></span>
                    </div>
                </div>
                <br />
                <br />
                <br />
                <br />
                <br />
            </asp:Panel>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="BtnPrint" EventName="Click" />
            <asp:AsyncPostBackTrigger ControlID="BtnLoadAllocationLoadPermissionIssue" EventName="Click" />
        </Triggers>
    </asp:UpdatePanel>

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
