<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WcViewerNSSLoadCapacitorLoad.ascx.cs" Inherits="ATISWeb.TransportationAndLoadNotification.LoadCapacitorManagement.WcViewerNSSLoadCapacitorLoad" %>

<div class="container-fluid p-1 border border-primary d-flex flex-column">
    <div class="container-fluid text-right bg-primary mb-1" style="height: 40px">
        <asp:Label runat="server" ID="Label2" CssClass="R2FontBHomaLarge text-white">مشخصات بار</asp:Label>
    </div>
    <div class="container-fluid p-1 mb-2" style="background-color:gainsboro">
        <div class="d-flex flex-row-reverse">
            <div class="input-group col-lg-3">
                <asp:TextBox runat="server" ID="TxtnEstelamId" class="form-control R2FontBHomaSmall  text-center" ReadOnly="True"></asp:TextBox>
                <div class="input-group-append">
                    <span class="input-group-text R2FontBHomaSmall" style="background-color: crimson; color: white">کد مخزن بار</span>
                </div>
            </div>
        </div>
    </div>
    <div class="d-flex flex-column">
        <div class="row">
            <div class="col-1 col-lg-1 R2FontBYekanSmall text-center" style="color: #CCCCCC"><span>تعرفه حمل</span></div>
            <div class="col-2 col-lg-1 R2FontBYekanSmall text-center" style="color: #CCCCCC"><span>تعداد باقیمانده</span></div>
            <div class="col-2 col-lg-1 R2FontBYekanSmall text-center" style="color: #CCCCCC"><span>تعداد کل</span></div>
            <div class="col-2 col-lg-1 R2FontBYekanSmall text-center" style="color: #CCCCCC"><span>بارگیر</span></div>
            <div class="col-3 col-lg-3 R2FontBYekanSmall text-center" style="color: #CCCCCC"><span>مقصد</span></div>
            <div class="col-1 col-lg-3 R2FontBYekanSmall text-center" style="color: #CCCCCC"><span>شرح بار</span></div>
            <div class="col-1 col-lg-2 R2FontBYekanSmall text-center" style="color: #CCCCCC"><span>زمان ثبت بار</span></div>
        </div>
        <div class="row">
            <div class="col-1 col-lg-1 text-center">
                <asp:Label runat="server" ID="LblTarrif" CssClass="R2FontBHomaSmall"></asp:Label>
            </div>
            <div class="col-2 col-lg-1 text-center">
                <asp:Label runat="server" ID="LblnCarNum" CssClass="R2FontBHomaSmall"></asp:Label>
            </div>
            <div class="col-2 col-lg-1 text-center">
                <asp:Label runat="server" ID="LblnCarNumKol" CssClass="R2FontBHomaSmall"></asp:Label>
            </div>
            <div class="col-2 col-lg-1 text-center">
                <asp:Label runat="server" ID="LblLoaderType" CssClass="R2FontBYekanSmall"></asp:Label>
            </div>
            <div class="col-3 col-lg-3 text-center">
                <asp:Label runat="server" ID="LblTargetCity" CssClass="R2FontBHomaSmall"></asp:Label>
            </div>
            <div class="col-1 col-lg-3 text-center">
                <asp:Label runat="server" ID="LblLoadTitle" CssClass="R2FontBHomaSmall"></asp:Label>
            </div>
            <div class="col-1 col-lg-2 text-center">
                <asp:Label runat="server" ID="LblDateTimeofLoadRegistering" CssClass="R2FontBHomaSmall"></asp:Label>
            </div>
        </div>
    </div>
    <div class="d-flex flex-column">
        <div class="row">
            <div class="col-4 col-lg-4 R2FontBYekanSmall text-center" style="color: #CCCCCC"><span>آدرس</span></div>
            <div class="col-4 col-lg-4 R2FontBYekanSmall text-center" style="color: #CCCCCC"><span>گیرنده</span></div>
            <div class="col-4 col-lg-4 R2FontBYekanSmall text-center" style="color: #CCCCCC"><span>توضیحات</span></div>
        </div>
        <div class="row">
            <div class="col-4 col-lg-4 text-center">
                <asp:Label runat="server" ID="LblAddress" CssClass="R2FontBHomaSmall"></asp:Label>
            </div>
            <div class="col-4 col-lg-4 text-center">
                <asp:Label runat="server" ID="LblLoadReceiver" CssClass="R2FontBHomaSmall"></asp:Label>
            </div>
            <div class="col-4 col-lg-4 text-center">
                <asp:Label runat="server" ID="LblDescription" CssClass="R2FontBHomaSmall"></asp:Label>
            </div>
        </div>
    </div>
</div>



