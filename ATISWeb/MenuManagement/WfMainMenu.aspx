<%@ Page Title="آتیس وب | منوی اصلی" Language="C#" MasterPageFile="~/DomainSite.Master" AutoEventWireup="true" CodeBehind="WfMainMenu.aspx.cs" Inherits="ATISWeb.MenuManagement.WfMainMenu" %>

<%@ Register TagPrefix="TWebControl" TagName="WcAlertShower" Src="~/AlertManagement/WcAlertShower.ascx" %>
<%@ Register TagPrefix="TWebC" TagName="WcLogin" Src="~/MenuManagement/WcProcess.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid p-0">
        <div class="table table-responsive-lg border" >
            <asp:Table ID="TblProcesses" runat="server"  CellSpacing="0" CellPadding="0" BorderStyle="None" CssClass="table border-white text-center table-borderless bg-white" HorizontalAlign="Center" style="">
                <asp:TableHeaderRow runat="server" CssClass="bg-primary border border-danger" ForeColor="White">
                </asp:TableHeaderRow>
            </asp:Table>
        </div>
    </div>

    <div class="container">
        <div class="modal fade" id="Alerter" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered modal-xl" id="PnlDialog" role="document">
                <div class="modal-content" id="PnlContent">
                    <div class="modal-header text-center" id="PnlHeader">
                        <span class="R2FontBYekanMedium text-white">پیام سیستم</span>
                        <button type="button" class="close text-white" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body text-center R2FontBHomaSmall" style="word-wrap: break-word;">
                        <div class="d-flex flex-column">
                            <span class="R2FontBHomaXLarge" style="color: crimson" id="SpanFixMessage1"></span>
                            <span class="R2FontBHomaXLarge" id="SpanDailyMessage"></span>
                            <hr id="hr1" />
                            <span class="R2FontBHomaLarge" id="SpanFixMessage2"></span>
                            <span class="R2FontBHomaLarge" id="SpanFixMessage3"></span>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <a class="btn R2FontBYekanMedium mx-auto rounded" data-dismiss="modal" href="#" role="button">تایید</a>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script type="text/javascript">
        function WcViewAlert(YourColor, YourDailyMessage, YourFixMessage1, YourFixMessage2, YourFixMessage3) {
            $(".modal-header").css("background-color", YourColor);
            $(".modal-content").css("border", '2px !important');
            $(".modal-content").css("border-color", YourColor);
            $("span").filter("#SpanFixMessage1").css("color", YourColor);
            $("span").filter("#SpanFixMessage1").html(YourFixMessage1);
            $("span").filter("#SpanDailyMessage").html(YourDailyMessage);
            $("span").filter("#SpanFixMessage2").html(YourFixMessage2);
            $("span").filter("#SpanFixMessage3").html(YourFixMessage3);

            //$("Span.SpanDailyMessage").html(YourDailyMessage);
            //$("Span.SpanFixMessage2").html(YourFixMessage2);
            //$("Span.SpanFixMessage3").html(YourFixMessage3);
            $(".btn").css("border", '2px !important');
            $(".btn").css("border-color", YourColor);
            $("#Alerter").modal('show');
        }
    </script>

</asp:Content>
