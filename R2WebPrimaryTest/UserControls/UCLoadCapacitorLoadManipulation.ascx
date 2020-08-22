<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCLoadCapacitorLoadManipulation.ascx.cs" Inherits="R2WebPrimaryTest.UCLoadCapacitorLoadManipulation" %>


<asp:Panel ID="Panel1" runat="server" Width="100%">
    <asp:Panel ID="Panel2" runat="server" HorizontalAlign="Center">
        <asp:Label ID="LblnEstelamId" runat="server" Font-Names="B Homa" ForeColor="Red" Text="" Width="100px"></asp:Label>
        <asp:Label ID="Label1" runat="server" Font-Names="B Homa" Text="کد مخزن بار : "></asp:Label>
        <br />
        <asp:Label ID="LblDateElam" runat="server" Font-Names="B Homa" ForeColor="Red" Text="" Width="100px"></asp:Label>
        <asp:Label ID="Label3" runat="server" Font-Names="B Homa" Text="زمان ثبت بار : "></asp:Label>
    </asp:Panel>
    <asp:Panel ID="Panel3" runat="server" HorizontalAlign="Right" Width="100%">
        <asp:Button ID="BtnEmpty" runat="server" Text="" />&nbsp;&nbsp;
        <asp:Button ID="BtnCancelling" runat="server" Text="کنسلی بار" UseSubmitBehavior="false" OnClick="BtnCancelling_Click" />&nbsp;&nbsp;
        <asp:Button ID="BtDeleting" runat="server" Text="حذف بار" UseSubmitBehavior="false" OnClick="BtnDeleting_Click" />&nbsp;&nbsp;
        <asp:Button ID="BtnRegistering" runat="server" Text="ثبت بار" UseSubmitBehavior="false" OnClick="BtnRegistering_Click" />&nbsp;&nbsp;
        <asp:Button ID="BtnNewLoad" runat="server" Text="بار جدید" UseSubmitBehavior="false" OnClick="BtnNewLoad_Click" />&nbsp;&nbsp;
        <br />
        <asp:Label runat="server" Text="توجه : کنسلی بار بعد از اعلام بار و حذف بار قبل از اعلام بار امکان پذیر است " Font-Names="Calibri" Font-Size="Large" ForeColor="#FF3300"></asp:Label>
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel11" runat="server" Style="display: inline-block; float: left;" HorizontalAlign="Center" Width="33%">
        <span style="vertical-align: central; font-family: Calibri; font-size: large; font-weight: bold; font-variant: normal; color: #008000;">بارگیر</span>
        <br />
        <asp:TextBox ID="TxtSearchLoaderType" runat="server" Width="80%" OnTextChanged="TxtSearchLoaderType_TextChanged" BorderStyle="Groove" BorderWidth="3px" Style="text-align: center"></asp:TextBox>
        <asp:DropDownList ID="DropDownListLoaderType" runat="server" dir="rtl" Width="80%" Font-Names="Calibri" Font-Bold="True"></asp:DropDownList>

    </asp:Panel>
    <asp:Panel ID="Panel12" runat="server" Style="display: inline-block; float: left; margin-left: 5px; margin-right: 5px;" HorizontalAlign="Center" Width="33%">
        <span style="vertical-align: central; font-family: Calibri; font-size: large; font-weight: bold; color: #FF0000;">مقصد</span>
        <br />
        <asp:TextBox ID="TxtSearchTarget" runat="server" Width="80%" OnTextChanged="TxtSearchTarget_TextChanged" BorderStyle="Groove" BorderWidth="3px" Style="text-align: center"></asp:TextBox>
        <asp:DropDownList ID="DropDownListTargets" runat="server" dir="rtl" Width="80%" Font-Names="Calibri" Font-Bold="True"></asp:DropDownList>
    </asp:Panel>
    <asp:Panel ID="Panel13" runat="server" Style="display: inline-block; float: right;" HorizontalAlign="Center" Width="33%">
        <span style="vertical-align: central; font-family: Calibri; font-size: large; font-weight: bold; color: #0066FF;">بار</span>
        <br />
        <asp:TextBox ID="TxtSearchGood" runat="server" Width="80%" OnTextChanged="TxtSearchGood_TextChanged" BorderStyle="Groove" BorderWidth="3px" Style="text-align: center"></asp:TextBox>
        <asp:DropDownList ID="DropDownListGoods" runat="server" dir="rtl" Width="80%" Font-Names="Calibri" Font-Bold="True"></asp:DropDownList>
    </asp:Panel>

    <asp:Panel ID="Panel4" runat="server" HorizontalAlign="Right">
        <asp:Panel runat="server" ID="Panel5">
            <asp:TextBox ID="TxtStrBarName" runat="server"></asp:TextBox>
            <asp:Label ID="Label7" runat="server" Font-Names="B Homa" Text="گیرنده"></asp:Label>
        </asp:Panel>
        <asp:Panel runat="server" ID="Panel6">
            <asp:TextBox ID="TxtTarrif" runat="server"></asp:TextBox>
            <asp:Label ID="Label6" runat="server" Font-Names="B Homa" Text="تعرفه حمل"></asp:Label>
        </asp:Panel>
        <asp:Panel runat="server" ID="Panel7">
            <asp:TextBox ID="TxtnCarNumKol" runat="server"></asp:TextBox>
            <asp:Label ID="Label5" runat="server" Font-Names="B Homa" Text="تعداد"></asp:Label>
        </asp:Panel>
        <br />
        <asp:Panel runat="server" ID="Panel8">
            <asp:TextBox ID="TxtDescription" runat="server" Width="50%"></asp:TextBox>
            <asp:Label ID="Label9" runat="server" Font-Names="B Homa" Text="توضیحات"></asp:Label>
        </asp:Panel>
        <br />
        <asp:Panel runat="server" ID="Panel9">
            <asp:TextBox ID="TxtAddress" runat="server" Width="50%"></asp:TextBox>
            <asp:Label ID="Label8" runat="server" Font-Names="B Homa" Text="آدرس"></asp:Label>
        </asp:Panel>
        <br />
        <asp:Panel runat="server" ID="Panel10">
        </asp:Panel>
    </asp:Panel>
</asp:Panel>

