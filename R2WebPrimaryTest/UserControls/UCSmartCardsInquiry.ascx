<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCSmartCardsInquiry.ascx.cs" Inherits="R2WebPrimaryTest.UserControls.UCSmartCardsInquiry" %>

<asp:Panel ID="Panel14" runat="server" Width="100%">
    <asp:Panel ID="Panel1" runat="server" BorderStyle="Solid" BorderWidth="1" BorderColor="gray" Width="70%" Style="margin-right: auto; margin-left: auto">
        <asp:Panel ID="Panel2" runat="server" Style="text-align: center;" HorizontalAlign="Center" Width="100%">
            <asp:Panel ID="Panel5" runat="server" Style="display: inline-block; margin-left: 2px; margin-right: 2px" HorizontalAlign="Center" Width="20%">
                <asp:Button ID="BtnGetTruckSmartCardInfoFromRMTO" runat="server" Text="استعلام ناوگان از سایت سازمان" Width="100%" />
            </asp:Panel>
            <asp:Panel ID="Panel4" runat="server" Style="display: inline-block; margin-left: 5px; margin-right: 5px" HorizontalAlign="Center" Width="20%">
                <asp:Button ID="BtnGetTruckSmartCardInfoFromPayaneh" runat="server" Text="استعلام ناوگان از بانک اطلاعات پایانه" Width="100%" />
            </asp:Panel>
            <asp:Panel ID="Panel6" runat="server" Style="display: inline-block; margin-left: 2px; margin-right: 2px" HorizontalAlign="Center" Width="20%" Height="100%">
                <asp:Label runat="server" ID="LblTruck" Text="" Style="vertical-align: central; font-family: Calibri; font-size: medium; font-variant: normal; color: black;" Width="82%" Height="100%"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="Panel7" runat="server" Style="display: inline-block; margin-left: 2px; margin-right: 2px" HorizontalAlign="Center" Width="18%">
                <asp:TextBox ID="TxtTruckSmartCardNo" runat="server"  AutoPostBack="false" Style="text-align: center" Width="100%"></asp:TextBox>
            </asp:Panel>
            <asp:Panel ID="Panel9" runat="server" Style="display: inline-block; margin-left: 2px; margin-right: 2px" HorizontalAlign="Center" Width="12%">
                <asp:Label runat="server" Text="هوشمند ناوگان:" Style="direction: rtl; vertical-align: central; font-family: Calibri; font-size: medium; font-variant: normal; color: black;" Width="100%"></asp:Label>
            </asp:Panel>
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server" Style="text-align: center;" HorizontalAlign="Center" Width="100%">
            <asp:Panel ID="Panel8" runat="server" Style="display: inline-block; margin-left: 2px; margin-right: 2px" HorizontalAlign="Center" Width="20%">
                <asp:Button ID="BtnGetTruckDriverSmartCardInfoFromRMTO" runat="server" Text="استعلام راننده از سایت سازمان" Width="100%" />
            </asp:Panel>
            <asp:Panel ID="Panel10" runat="server" Style="display: inline-block; margin-left: 5px; margin-right: 5px" HorizontalAlign="Center" Width="20%">
                <asp:Button ID="BtnGetTruckDriverSmartCardInfoFromPayaneh" runat="server" Text="استعلام راننده از بانک اطلاعات پایانه" Width="100%" />
            </asp:Panel>
            <asp:Panel ID="Panel11" runat="server" Style="display: inline-block; margin-left: 2px; margin-right: 2px" HorizontalAlign="Center" Width="20%" Height="100%">
                <asp:Label runat="server" ID="LblTruckDriver" Text="" Style="vertical-align: central; font-family: Calibri; font-size: medium; font-variant: normal; color: black;" Width="82%" Height="100%"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="Panel12" runat="server" Style="display: inline-block; margin-left: 2px; margin-right: 2px" HorizontalAlign="Center" Width="18%">
                <asp:TextBox ID="TxtTruckDriverSmartCardNo" runat="server"  AutoPostBack="false" Style="text-align: center" Width="100%"></asp:TextBox>
            </asp:Panel>
            <asp:Panel ID="Panel13" runat="server" Style="display: inline-block; margin-left: 2px; margin-right: 2px" HorizontalAlign="Center" Width="12%">
                <asp:Label runat="server" Text="هوشمند راننده:" Style="direction: rtl; vertical-align: central; font-family: Calibri; font-size: medium; font-variant: normal; color: black;" Width="100%"></asp:Label>
            </asp:Panel>
        </asp:Panel>
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel15" runat="server" Style="margin-right: auto; margin-left: auto;text-align: center" Width="70%">
        <asp:Label ID="LblMessage" runat="server" Text="" Style="direction: rtl; vertical-align: central; font-family: Calibri; font-size: small; font-variant: normal; color: red;" Width="100%" Height="100px"></asp:Label>
    </asp:Panel>
</asp:Panel>
