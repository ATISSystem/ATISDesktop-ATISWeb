<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCViewerNSSLoadCapacitorLoad.ascx.cs" Inherits="R2WebPrimaryTest.UserControls.UCViewerNSSLoadCapacitorLoad" %>
<asp:Panel ID="Panel14" runat="server" Width="100%">
    <asp:Panel ID="Panel1" runat="server" BorderStyle="Solid" BorderWidth="2" Width="70%" Style="margin-right: auto; margin-left: auto">
        <asp:Panel ID="Panel2" runat="server" Style="text-align: center;" HorizontalAlign="Center">
            <asp:Panel ID="Panel5" runat="server" Style=" display:inline-block;" HorizontalAlign="Center" Width="10%">
                <asp:Label runat="server" Text="نرخ حمل" Style="vertical-align: central; font-family: Calibri; font-size: small; font-variant: normal; color: navajowhite;" Width="100%"></asp:Label>
                <asp:Label ID="LblTarrifPrice" runat="server" Text="آدرس" Style="vertical-align: central; font-family: Calibri; font-size: small; font-variant: normal; color: black;" Width="100%"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="Panel4" runat="server" Style="display:inline-block;" HorizontalAlign="Center" Width="13%">
                <asp:Label runat="server" Text="نوع بارگیر" Style="vertical-align: central; font-family: Calibri; font-size: small; font-variant: normal; color: navajowhite;" Width="100%"></asp:Label>
                <br />
                <asp:Label ID="LblLoaderTypeTitle" runat="server" Text="آدرس" Style="vertical-align: central; font-family: Calibri; font-size: small; font-variant: normal; color: black;" Width="100%"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="Panel6" runat="server" Style="display:inline-block;" HorizontalAlign="Center" Width="20%">
                <asp:Label runat="server" Text="مقصد" Style="vertical-align: central; font-family: Calibri; font-size: small; font-variant: normal; color: navajowhite;" Width="100%"></asp:Label>
                <br />
                <asp:Label ID="LblLoadTargetTitle" runat="server" Text="آدرس" Style="vertical-align: central; font-family: Calibri; font-size: small; font-variant: normal; color: black;" Width="100%"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="Panel7" runat="server" Style="display: inline-block;" HorizontalAlign="Center" Width="18%">
                <asp:Label runat="server" Text="بار" Style="vertical-align: central; font-family: Calibri; font-size: small; font-variant: normal; color: navajowhite;" Width="100%"></asp:Label>
                <br />
                <asp:Label ID="LblGoodTitle" runat="server" Text="آدرس" Style="vertical-align: central; font-family: Calibri; font-size: small; font-variant: normal; color: black;" Width="100%"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="Panel9" runat="server" Style="display: inline-block; " HorizontalAlign="Center" Width="12%">
                <asp:Label runat="server" Text="تعداد" Style="vertical-align: central; font-family: Calibri; font-size: small; font-variant: normal; color: navajowhite;" Width="100%"></asp:Label>
                <br />
                <asp:Label ID="LblnCarNumKol" runat="server" Text="آدرس" Style="vertical-align: central; font-family: Calibri; font-size: small; font-variant: normal; color: black;" Width="100%"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="Panel10" runat="server" Style="display: inline-block;" HorizontalAlign="Center" Width="14%">
                <asp:Label runat="server" Text="زمان ثبت بار" Style="vertical-align: central; font-family: Calibri; font-size: small; font-variant: normal; color: navajowhite;" Width="100%"></asp:Label>
                <br />
                <asp:Label ID="LbldDateTimeElam" runat="server" Text="1399/05/01 - 88:88:88" Style="vertical-align: central; font-family: Calibri; font-size:x-small; font-variant: normal; color: black;" Width="100%"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="Panel8" runat="server" Style="display: inline-block; " HorizontalAlign="Center" Width="10%" Wrap="False">
                <asp:Label runat="server" Text="کدمخزن بار" Style="vertical-align: central; font-family: Calibri; font-size: small; font-variant: normal; color: navajowhite;" Width="100%"></asp:Label>
                <br />
                <asp:Label ID="LblnEstelamId" runat="server" Text="آدرس" Style="vertical-align: central; font-family: Calibri; font-size: small; font-variant: normal; color: black;" Width="100%"></asp:Label>
            </asp:Panel>
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server" Style="text-align: center;" HorizontalAlign="Center">
            <asp:Panel ID="Panel11" runat="server" Style="display: inline-block; " HorizontalAlign="Center" Width="33%">
                <asp:Label runat="server" Text="گیرنده" Style="vertical-align: central; font-family: Calibri; font-size: small; font-variant: normal; color: navajowhite;" Width="100%"></asp:Label>
                <br />
                <asp:Label ID="LblStrBarName" runat="server" Text="آدرس" Style="vertical-align: central; font-family: Calibri; font-size: small; font-variant: normal; color: black;" Width="100%"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="Panel12" runat="server" Style="display: inline-block;" HorizontalAlign="Center" Width="33%">
                <asp:Label runat="server" Text="توضیحات" Style="vertical-align: central; font-family: Calibri; font-size: small; font-variant: normal; color: navajowhite;" Width="100%"></asp:Label>
                <br />
                <asp:Label ID="LblStrDescription" runat="server" Text="آدرس" Style="vertical-align: central; font-family: Calibri; font-size: small; font-variant: normal; color: black;" Width="100%"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="Panel13" runat="server" Style="display: inline-block; " HorizontalAlign="Center" Width="32%">
                <asp:Label runat="server" Text="آدرس" Style="vertical-align: central; font-family: Calibri; font-size: small; font-variant: normal; color: navajowhite;" Width="100%"></asp:Label>
                <br />
                <asp:Label ID="LblStrAddress" runat="server" Text="آدرس" Style="vertical-align: central; font-family: Calibri; font-size: small; font-variant: normal; color: black;" Width="100%"></asp:Label>
            </asp:Panel>
        </asp:Panel>
    </asp:Panel>
</asp:Panel>



