<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Opportunities.aspx.cs" Inherits="eServeSU.CommunityPartnerContent.Opportunities" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        <asp:Label ID="Label3" runat="server" Text="Opportunities"></asp:Label>
    </h2>
    <p>
        &nbsp;
        <asp:HyperLink ID="hlinkAddOpp" runat="server" NavigateUrl="~/Opportunity/Opportunity.aspx">AddOpportunity</asp:HyperLink>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="hlinkEditViewDelete" runat="server" NavigateUrl="~/Opportunity/OpportunityList.aspx">Edit/View/Delete Opportunity</asp:HyperLink>
    </p>
</asp:Content>
