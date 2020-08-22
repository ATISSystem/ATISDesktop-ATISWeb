<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WcSmartCardsInquiry.ascx.cs" Inherits="ATISWeb.TransportationAndLoadNotification.SmartCards.WcSmartCardsInquiry" %>

<div class="container-fluid p-1 border border-primary rounded">
    <div class="container-fluid text-right bg-primary" style="height: 40px">
        <asp:Label runat="server" ID="Label2" CssClass="R2FontBHomaLarge text-white">استعلام کارت هوشمند ناوگان و راننده باری</asp:Label>
    </div> 
    <div class="container-fluid p-1 border mb-1" style="border-color: gainsboro">
        <asp:UpdatePanel ID="UpdatePanelTruckSmartCard" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="True">
            <ContentTemplate>
                <div class="d-flex flex-row-reverse">
                    <div class="input-group col-lg-3 col-sm-3">
                        <asp:TextBox runat="server" ID="TxtTruckSmartCardNo" class="form-control R2FontBHomaSmall  text-center"></asp:TextBox>
                        <div class="input-group-append">
                            <span class="input-group-text R2FontBHomaSmall" style="background-color:greenyellow; color:black">هوشمند ناوگان</span>
                        </div>
                    </div>
                    <div class="col col-lg-5 col-sm-3">
                        <div class="d-flex flex-row mr-1 ml-1">
                            <asp:Button runat="server" ID="BtnTruckSmartCardInquiryfromRMTO" CssClass="btn border border-success mr-2 R2FontBYekanSmall" Text="استعلام ناوگان از سایت هوشمند" style="background-color: transparent;"/>
                            <asp:Button runat="server" ID="BtnTruckSmartCardInquiryfromLocal" CssClass="btn border border-success R2FontBYekanSmall" Text="استعلام ناوگان از سرور پایانه" style="background-color: transparent;"/>
                        </div>
                    </div>
                    <div class="col col-lg-2 col-sm-2 text-center">
                        <asp:Label runat="server" ID="LblTruck" CssClass="R2FontBHomaSmall text-primary" dir="rtl"></asp:Label>
                    </div>
                </div>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="BtnTruckSmartCardInquiryfromRMTO" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="BtnTruckSmartCardInquiryfromLocal" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
    </div>

    <div class="container-fluid p-1 border" style="border-color: gainsboro">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="True">
            <ContentTemplate>
                <div class="d-flex flex-row-reverse">
                    <div class="input-group col-lg-3 col-sm-3">
                        <asp:TextBox runat="server" ID="TxtTruckDriverSmartCardNo" class="form-control R2FontBHomaSmall  text-center"></asp:TextBox>
                        <div class="input-group-append">
                            <span class="input-group-text R2FontBHomaSmall" style="background-color: greenyellow; color: black">هوشمند راننده</span>
                        </div>
                    </div>
                    <div class="col col-lg-5 col-sm-3">
                        <div class="d-flex flex-row mr-1 ml-1">
                            <asp:Button runat="server" ID="BtnTruckDriverSmartCardInquiryfromRMTO" CssClass="btn border border-success mr-2 R2FontBYekanSmall" Text="استعلام راننده از سایت هوشمند" style="background-color: transparent; color: black"/>
                            <asp:Button runat="server" ID="BtnTruckDriverSmartCardInquiryfromLocal" CssClass="btn border border-success R2FontBYekanSmall" Text="استعلام راننده از سرور پایانه" style="background-color: transparent; color: black"/>
                        </div>
                    </div>
                    <div class="col col-lg-2 col-sm-2 text-center">
                        <asp:Label runat="server" ID="LblTruckDriver" CssClass="R2FontBHomaMedium text-primary" Style="direction: rtl"></asp:Label>
                    </div>
                </div>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="BtnTruckDriverSmartCardInquiryfromRMTO" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="BtnTruckDriverSmartCardInquiryfromLocal" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
    </div>



</div>
