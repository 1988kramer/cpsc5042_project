<%@ Page Title="CommunityPartnerView" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CommunityPartnerView.aspx.cs" Inherits="eServeSU.CommunityPartnerView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2 title="CommunityPartnerProfile">
        <asp:Label ID="lblCommunityPartnerView" runat="server" Text="Profile"></asp:Label>
    </h2>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="CPhyperlink" runat="server" NavigateUrl="CommunityPartnerProfile.aspx">Edit CommunityPartner profile</asp:HyperLink>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="hlnkSupervisor" runat="server" NavigateUrl="SupervisorList.aspx">Edit Supervisor </asp:HyperLink>
    </asp:Content>
