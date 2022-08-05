<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CustomControl.ascx.cs" Inherits="CustomControl" %>
<asp:FileUpload ID="FilUpl" runat="server" />
<br />
<asp:CustomValidator ID="ErrorMsg" runat="server" ErrorMessage="CustomValidator" OnServerValidate="ErrorMsg_ServerValidate"></asp:CustomValidator><br />
