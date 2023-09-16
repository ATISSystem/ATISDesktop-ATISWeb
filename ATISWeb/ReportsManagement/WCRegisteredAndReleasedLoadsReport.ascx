<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WCRegisteredAndReleasedLoadsReport.ascx.cs" Inherits="ATISWeb.ReportsManagement.WCRegisteredAndReleasedLoadsReport" %>
<%@ Register TagPrefix="TWebControl" TagName="WcAlertShower" Src="~/AlertManagement/WcAlertShower.ascx" %>

<TWebControl:WcAlertShower runat="server" ID="WcAlertShower" />

<div class="container-fluid p-1 border border-primary">
    <div class="container-fluid text-right bg-primary mb-1" style="height: 40px">
        <asp:Label runat="server" ID="Label2" CssClass="R2FontBHomaLarge text-white">گزارش بار ثبت شده و ترخیص شده</asp:Label>
    </div>
    <div class="border border-primary rounded p-1" style="">
        <div class="container-fluid p-1" style="background-color:white ">
            <div class="d-flex flex-row-reverse">
                <div class="input-group col-lg-3">
                    <asp:TextBox runat="server" ID="TxtDateShamsi1" class="form-control R2FontBHomaSmall  text-center" ReadOnly="false"></asp:TextBox>
                    <div class="input-group-append">
                        <span class="input-group-text R2FontBHomaSmall" style="background-color: yellow; color: blue">ازتاریخ</span>
                    </div>
                </div>
                <div class="input-group col-lg-3">
                    <asp:TextBox runat="server" ID="TxtDateShamsi2" class="form-control R2FontBHomaSmall  text-center" ReadOnly="false"></asp:TextBox>
                    <div class="input-group-append">
                        <span class="input-group-text R2FontBHomaSmall" style="background-color: yellow; color: blue">تاتاریخ</span>
                    </div>
                </div>
                <div class="col-lg-6">
                    <asp:Button runat="server" ID="BtnViewReport" CssClass="btn btn-info mr-3 R2FontBYekanSmall bg-success" Text="مشاهده گزارش" />
                </div>
            </div>
        </div>
        <div class="container-fluid p-1">
            <div class="d-flex flex-row">
            </div>
        </div>
        <asp:UpdatePanel ID="UpdatePanelViewReport" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="False">
            <ContentTemplate>
                <div class="table table-responsive-lg border">
                    <asp:Table ID="TblViewReport" runat="server" CssClass="table table-striped table-hover table-borderless text-center border-white" HorizontalAlign="Center" CellSpacing="0">
                        <asp:TableHeaderRow runat="server" CssClass="bg-primary" ForeColor="White">
                            <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">وضعیت مجوز</asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">زمان آزادسازی بار</asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">لیست رانندگان</asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">محل تخلیه</asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">محل بارگیری</asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">پارامترهای موثر</asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">آدرس</asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">گیرنده</asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">توضیحات</asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">وضعیت نهایی بار</asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">اعلام بار</asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">تعرفه حمل</asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">مقصد</asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">تعداد</asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">تناژبار</asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">شرح بار</asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">تاریخ اعلام</asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">کدبار</asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="R2FontBYekanSmall" HorizontalAlign="Center">شرکت حمل و نقل</asp:TableHeaderCell>
                        </asp:TableHeaderRow>
                    </asp:Table>
                </div>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="BtnViewReport" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>

    </div>
</div>
