<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WcProcess.ascx.cs" Inherits="ATISWeb.MenuManagement.WcProcess" %>

<div class="container">
    <div class="card" style="width: 280px;">
        <img src="/Images/Header2.jpg" class="card-img-top" alt="...">
        <div class="card-body text-right">
            <div class="col">
                <asp:Label ID="LblProcessTitle" runat="server" Text="" CssClass="card-title text-right R2FontBYekanLarge" Font-Size="Larger" Style=""></asp:Label>
            </div>
            <div class="col" style="height: 150px;">
                <asp:Label ID="LblDescription" runat="server" Text="" CssClass="card-text text-right R2FontBYekanSmall"></asp:Label>
            </div>
            <div class="col">
                <a id="TargetURL" runat="server" class="btn btn-primary R2FontBYekanLarge border border-danger" href="#" style="font-size: medium; color: white; width: 200px;"></a>
            </div>
        </div>

    </div>
</div>


