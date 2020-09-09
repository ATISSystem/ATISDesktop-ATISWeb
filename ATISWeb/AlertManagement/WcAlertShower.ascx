<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WcAlertShower.ascx.cs" Inherits="ATISWeb.AlertManagement.WcAlertShower" %>

<div class="container">
    <div class="modal fade" id="AlertShower" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog modal-dialog-centered" id="PnlDialog" role="document">
            <div class="modal-content" id="PnlContent">
                <div class="modal-header text-center" id="PnlHeader">
                    <span class="R2FontBYekanMedium text-white">پیام سیستم</span>
                    <button type="button" class="close text-white" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body text-center R2FontBHomaMedium" style="word-wrap: break-word;">
                    <asp:Label runat="server" ID="LblMessage" CssClass="R2FontBHomaMedium text-center" Text="123"></asp:Label>
                </div>
                <div class="modal-footer">
                    <a class="btn R2FontBYekanMedium mx-auto rounded" data-dismiss="modal" href="#" role="button">تایید</a>
                </div>
            </div>
        </div>
    </div>
</div>

<%--WcViewAlert.AlertType None = 0 ErrorType = 1 ErrorInDataEntry = 2 Warning = 3 SuccessProccess = 4 Information = 5--%>
<script type="text/javascript">
    function WcViewAlert(AlertType, message) {
        var colorx;
        switch (AlertType) {
            case '1':
                colorx = 'red';
                break;
            case '2':
                colorx = 'green';
                break;
            default:
                colorx = 'yellow';
                break;
        }
        $(".modal-header").css("background-color", colorx);
        $(".modal-content").css("border", '2px !important');
        $(".modal-content").css("border-color", colorx);
        $(".modal-body").text(message);
        $(".btn").css("border", '2px !important');
        $(".btn").css("border-color", colorx);
        $("#AlertShower").modal('show');
    }
</script>



