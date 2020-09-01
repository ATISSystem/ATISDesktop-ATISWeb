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
                            <span class="input-group-text R2FontBHomaSmall" style="background-color: greenyellow; color: black">هوشمند ناوگان</span>
                        </div>
                    </div>
                    <div class="">
                        <asp:Button runat="server" ID="BtnTruckSmartCardInquiry" CssClass="btn border border-success mr-2 R2FontBYekanSmall" Text="استعلام ناوگان" Style="background-color: transparent;" />
                    </div>
                    <div class="text-center mr-3">
                        <asp:Label runat="server" ID="LblTruck" CssClass="R2FontBHomaSmall text-primary" dir="rtl"></asp:Label>
                    </div>
                </div>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="BtnTruckSmartCardInquiry" EventName="Click" />
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
                    <div class="">
                        <asp:Button runat="server" ID="BtnTruckDriverSmartCardInquiry" CssClass="btn border border-success mr-2 R2FontBYekanSmall" Text="استعلام راننده" Style="background-color: transparent; color: black" />
                    </div>
                    <div class="text-center mr-3">
                        <asp:Label runat="server" ID="LblTruckDriver" CssClass="R2FontBHomaMedium text-primary" Style="direction: rtl"></asp:Label>
                    </div>
                </div>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="BtnTruckDriverSmartCardInquiry" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
    </div>



</div>
