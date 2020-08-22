<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeBehind="LoadCapacitorLoadLoadAllocationLoadPermission.aspx.cs" Inherits="R2WebPrimaryTest.LoadCapacitorLoadLoadAllocationLoadPermission" %>

<%@ Register Src="~/UserControls/UCLoadCapacitorLoadLoadPermissionsIssued.ascx" TagName="UCLoadCapacitorLoadLoadPermissionsIssued" TagPrefix="TWebControl" %>
<%@ Register Src="~/UserControls/UCViewerLoadCapacitorLoads.ascx" TagName="UCViewerLoadCapacitorLoads" TagPrefix="TWebControl" %>
<%@ Register Src="~/UserControls/UCViewerNSSLoadCapacitorLoad.ascx" TagName="UCViewerNSSLoadCapacitorLoad" TagPrefix="TWebControl" %>
<%@ Register Src="~/UserControls/UCSmartCardsInquiry.ascx" TagName="UCSmartCardsInquiry" TagPrefix="TWebControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <meta http-equiv="Content-Type" content="text/html;charset=utf-8" />
    <link href="StyleSheets/StyleSheet1.css" rel="Stylesheet" type="text/css" />

    <asp:Panel ID="Panel8" runat="server">
        <h1 style="text-align: right; color: rebeccapurple">تخصیص بار و صدور مجوز بارگیری</h1>
        <asp:Label runat="server" ID="TransportCompanyTitle" CssClass="TransportCompanyTitle" ForeColor="Red" Text="شرکت حمل و نقل" Width="50%"></asp:Label>
        <hr style="width: 100%; color: gray; height: 1px;" />
    </asp:Panel>
    <asp:Panel ID="Panel4" runat="server" HorizontalAlign="Left" Width="100%">
        <asp:Button ID="BtnViewLoads" runat="server" Text="نمایش مجدد لیست بار" />&nbsp;&nbsp;
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel3" runat="server">
        <TWebControl:UCViewerLoadCapacitorLoads ID="UCViewerLoadCapacitorLoads" runat="server" ClientIDMode="Inherit" ValidateRequestMode="Inherit" ViewStateMode="Inherit" EnableTheming="True" EnableViewState="True"></TWebControl:UCViewerLoadCapacitorLoads>
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel1" runat="server" Width="100%" HorizontalAlign="Center">
        <TWebControl:UCViewerNSSLoadCapacitorLoad ID="UCViewerNSSLoadCapacitorLoad" runat="server" ClientIDMode="Inherit" ValidateRequestMode="Inherit" ViewStateMode="Inherit" EnableTheming="True" EnableViewState="True"></TWebControl:UCViewerNSSLoadCapacitorLoad>
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel2" runat="server" Width="100%" HorizontalAlign="Center">
        <TWebControl:UCSmartCardsInquiry ID="UCSmartCardsInquiry" runat="server" ClientIDMode="Inherit" ValidateRequestMode="Inherit" ViewStateMode="Inherit" EnableTheming="True" EnableViewState="True"></TWebControl:UCSmartCardsInquiry>
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel5" runat="server" Style="margin-right: auto; margin-left: auto; text-align: center" Width="70%" HorizontalAlign="Center">
        <asp:Button ID="BtnRepeatPrint" runat="server" Text="چاپ مجوز بارگیری" OnClick="BtnRepeatPrint_Click" OnClientClick="return PrintLoadPermission();" />&nbsp;&nbsp;
        <asp:Button ID="BtnLoadAllocationLoadPermission" runat="server" UseSubmitBehavior="False" Text="تخصیص بار و صدور مجوز بارگیری" />&nbsp;&nbsp;
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel15" runat="server" Style="margin-right: auto; margin-left: auto; text-align: center" Width="70%" Height="200px">
        <asp:Label ID="LblMessage" runat="server" Text="" Style="direction: rtl; vertical-align: central; font-family: Calibri; font-size: small; font-variant: normal; color: red;" Width="100%"></asp:Label>
    </asp:Panel>
    <br />
    <asp:Panel ID="PnlPrintLoadPermission" runat="server" Visible="True">
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
                    <span>شماره مجوز <%=PPDS.nEstelamId%></span><br />
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
    </asp:Panel>

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
</asp:Content>
