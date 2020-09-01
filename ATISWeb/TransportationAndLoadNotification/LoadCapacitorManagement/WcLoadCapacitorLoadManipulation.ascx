<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WcLoadCapacitorLoadManipulation.ascx.cs" Inherits="ATISWeb.TransportationAndLoadNotification.LoadCapacitorManagement.WcLoadCapacitorLoadManipulation" %>
<%@ Register TagPrefix="TWebControl" TagName="WcAlertShower" Src="~/AlertManagement/WcAlertShower.ascx" %>
<%@ Register TagPrefix="TWebControl" TagName="WcLoadCapacitorLoadsCollectionSummaryIntelligently" Src="~/TransportationAndLoadNotification/LoadCapacitorManagement/WcLoadCapacitorLoadsCollectionSummaryIntelligently.ascx" %>

<TWebControl:WcAlertShower runat="server" ID="WcAlertShower" />

<div class="container-fluid p-1 border border-primary">
    <div class="container-fluid text-right bg-primary mb-1" style="height: 40px">
        <asp:Label runat="server" ID="Label2" CssClass="R2FontBHomaLarge text-white">ثبت و ویرایش بار</asp:Label>
    </div>
    <div class="container-fluid p-0 mb-2" style="">
        <TWebControl:WcLoadCapacitorLoadsCollectionSummaryIntelligently runat="server" ID="WcLoadCapacitorLoadsCollectionSummaryIntelligently"></TWebControl:WcLoadCapacitorLoadsCollectionSummaryIntelligently>
    </div>
    <div class="border border-primary rounded p-1" style="">
        <asp:UpdatePanel ID="UpdatePanelTxtnEstelamIdTxtDateTimeofLoadRegistering" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="False">
            <ContentTemplate>
                <div class="container-fluid p-1" style="background-color: gainsboro">
                    <div class="d-flex flex-row-reverse">
                        <div class="input-group col-lg-3">
                            <asp:TextBox runat="server" ID="TxtnEstelamId" class="form-control R2FontBHomaSmall  text-center" ReadOnly="True"></asp:TextBox>
                            <div class="input-group-append">
                                <span class="input-group-text R2FontBHomaSmall" style="background-color: yellow; color: blue">کد مخزن بار</span>
                            </div>
                        </div>
                        <div class="input-group col-lg-3">
                            <asp:TextBox runat="server" ID="TxtDateTimeofLoadRegistering" class="form-control R2FontBHomaSmall  text-center" ReadOnly="True"></asp:TextBox>
                            <div class="input-group-append">
                                <span class="input-group-text R2FontBHomaSmall" style="background-color: yellow; color: blue">زمان ثبت بار</span>
                            </div>
                        </div>
                    </div>
                </div>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="BtnNewLoad" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
        <div class="text-center">
            <asp:Label runat="server" CssClass="R2FontBYekanSmall">توجه:کنسلی بار بعد از اعلام بار و حذف بار قبل از اعلام بار امکان پذیر است</asp:Label>
        </div>
        <div class="container-fluid p-1">
            <div class="d-flex flex-row">
                <asp:Button runat="server" ID="BtnLoadRegistering" CssClass="btn btn-info mr-3 R2FontBYekanSmall bg-success" Text="ثبت بار" />
                <asp:Button runat="server" ID="BtnLoadDeleting" CssClass="btn btn-info mr-3 R2FontBYekanSmall bg-danger" Text="حذف بار" />
                <asp:Button runat="server" ID="BtnLoadCancelling" CssClass="btn btn-info mr-3 R2FontBYekanSmall bg-secondary" Text="کنسلی بار" />
                <asp:Button runat="server" ID="BtnNewLoad" CssClass="btn btn-info mr-2 R2FontBYekanSmall bg-warning" Text="بار جدید" />
            </div>
        </div>
        <div class="container-fluid p-1">
            <div class="form-row p-1">
                <div class="col">
                    <div class="form-group text-center border rounded p-1" style="border-color: gainsboro">
                        <span class="R2FontBYekanMedium" style="vertical-align: central; color: blue;">بارگیر</span>
                        <asp:UpdatePanel ID="UpdatePanel" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="True">
                            <ContentTemplate>
                                <div class="input-group mb-1">
                                    <asp:TextBox ID="TxtSearchLoaderType" runat="server" CssClass="form-control R2FontBHomaSmall text-center" placeholder="جستجو" Style="direction: rtl;"></asp:TextBox>
                                    <div class="input-group-append">
                                        <button runat="server" id="BtnSearchLoaderType" class="btn btn-group-sm" style="background-color: gray; color: white"><i class="fa fa-search" style=""></i></button>
                                    </div>
                                </div>
                                <asp:DropDownList ID="DropDownListLoaderType" runat="server" CssClass="form-control form-control-sm R2FontBHomaSmall" dir="rtl" AutoPostBack="True"></asp:DropDownList>
                            </ContentTemplate>
                            <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="BtnSearchLoaderType" EventName="ServerClick" />
                            </Triggers>
                        </asp:UpdatePanel>
                    </div>
                </div>
                <div class="col">
                    <div class="form-group text-center border rounded p-1" style="border-color: gainsboro">
                        <span class="R2FontBYekanMedium " style="vertical-align: central; color: blue;">مقصد</span>
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="True">
                            <ContentTemplate>
                                <div class="input-group mb-1">
                                    <asp:TextBox ID="TxtSearchTargetCity" runat="server" CssClass="form-control R2FontBHomaSmall text-center" placeholder="جستجو" Style="direction: rtl;"></asp:TextBox>
                                    <div class="input-group-append">
                                        <button runat="server" id="BtnSearchTargetCity" class="btn btn-group-sm" style="background-color: gray; color: white"><i class="fa fa-search" style=""></i></button>
                                    </div>
                                </div>
                                <asp:DropDownList ID="DropDownListTargetCity" runat="server" CssClass="form-control form-control-sm R2FontBHomaSmall" dir="rtl" AutoPostBack="True"></asp:DropDownList>
                            </ContentTemplate>
                            <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="BtnSearchTargetCity" EventName="ServerClick" />
                            </Triggers>
                        </asp:UpdatePanel>

                    </div>
                </div>
                <div class="col">
                    <div class="form-group text-center border rounded p-1" style="border-color: gainsboro">
                        <span class="R2FontBYekanMedium" style="vertical-align: central; color: blue;">بار</span>
                        <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="True">
                            <ContentTemplate>
                                <div class="input-group mb-1">
                                    <asp:TextBox ID="TxtSearchLoad" runat="server" CssClass="form-control R2FontBHomaSmall text-center" placeholder="جستجو" Style="direction: rtl;"></asp:TextBox>
                                    <div class="input-group-append">
                                        <button runat="server" id="BtnSearchLoad" class="btn btn-group-sm" style="background-color: gray; color: white"><i class="fa fa-search" style=""></i></button>
                                    </div>
                                </div>
                                <asp:DropDownList ID="DropDownListLoad" runat="server" CssClass="form-control form-control-sm R2FontBHomaSmall" dir="rtl" AutoPostBack="True"></asp:DropDownList>
                            </ContentTemplate>
                            <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="BtnSearchTargetCity" EventName="ServerClick" />
                            </Triggers>
                        </asp:UpdatePanel>
                    </div>
                </div>
            </div>
        </div>
        <asp:UpdatePanel ID="UpdatePanelDetails" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="False">
            <ContentTemplate>
                <div class="container-fluid p-1">
                    <div class="d-flex flex-row-reverse">
                        <div class="input-group col-sm-3 col-lg-3">
                            <asp:TextBox runat="server" ID="TxtTarrif" class="form-control R2FontBHomaSmall  text-center"></asp:TextBox>
                            <div class="input-group-append">
                                <span class="input-group-text R2FontBHomaSmall" style="background-color: yellow; color: blue">تعرفه حمل</span>
                            </div>
                        </div>
                        <div class="input-group col-sm-3 col-lg-3">
                            <asp:TextBox runat="server" ID="TxtnCarNumKol" class="form-control R2FontBHomaSmall  text-center"></asp:TextBox>
                            <div class="input-group-append">
                                <span class="input-group-text R2FontBHomaSmall" style="background-color: yellow; color: blue">تعداد</span>
                            </div>
                        </div>
                        <div class="input-group col-sm-6 col-lg-6">
                            <asp:TextBox runat="server" ID="TxtLoadReciever" class="form-control R2FontBHomaSmall  text-center"></asp:TextBox>
                            <div class="input-group-append">
                                <span class="input-group-text R2FontBHomaSmall" style="background-color: yellow; color: blue">گیرنده</span>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="container-fluid p-1">
                    <div class="d-flex flex-row-reverse">
                        <div class="input-group col-sm-6 col-lg-6">
                            <asp:TextBox runat="server" ID="TxtAddress" class="form-control R2FontBHomaSmall  text-center"></asp:TextBox>
                            <div class="input-group-append">
                                <span class="input-group-text R2FontBHomaSmall" style="background-color: yellow; color: blue">آدرس</span>
                            </div>
                        </div>
                        <div class="input-group col-sm-6 col-lg-6">
                            <asp:TextBox runat="server" ID="TxtDescription" class="form-control R2FontBHomaSmall  text-center"></asp:TextBox>
                            <div class="input-group-append">
                                <span class="input-group-text R2FontBHomaSmall" style="background-color: yellow; color: blue">توضیحات</span>
                            </div>
                        </div>
                    </div>
                </div>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="BtnNewLoad" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
    </div>
</div>

