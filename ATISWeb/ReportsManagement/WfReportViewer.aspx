<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WfReportViewer.aspx.cs" Inherits="ATISWeb.ReportsManagement.WfReportViewer" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=15.0.0.0, Culture=neutral, PublicKeyToken=89845DCD8080CC91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="scriptManagerReport" runat="server"></asp:ScriptManager>
        <rsweb:reportviewer runat="server" visible="false" showprintbutton="true" width="99.9%" height="100%" asyncrendering="true" zoommode="Percent" keepsessionalive="true" id="rvSiteMapping" sizetoreportcontent="false"></rsweb:reportviewer>

        <div>
        </div>
    </form>
</body>
</html>
