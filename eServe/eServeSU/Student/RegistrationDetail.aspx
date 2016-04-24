<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="RegistrationDetail.aspx.cs" Inherits="eServeSU.RegistrationDetail" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <%--<h2>Registration Detail</h2>--%>
    <div>        
        <asp:Label ID="lblPageTitle" runat="server" Text="Organization: Opportunity" Font-Bold="true"></asp:Label>        
    </div>
    </div>
    <br />
    <br />
    <div>
        <asp:Label ID="lblOrganization" runat="server" Text="Organization" Font-Bold="true"></asp:Label>
        <asp:Label ID="lblOrganizationDesc" runat="server" Text="Organization Description"></asp:Label>
    </div>
       <br />
    <div>
        <asp:Label ID="lblOpportunity" runat="server" Text="Opportunity" Font-Bold="true"></asp:Label>
        <asp:Label ID="lblOpportunityDesc" runat="server" Text="Opportunity Description"></asp:Label>
    </div>
       <br />
    <div>
        <br />
        <asp:Label ID="lblLocation" runat="server" Text="Location:" Font-Bold="true"></asp:Label>
        <asp:Label ID="lblLocationValue" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="lblTimeCommitment" runat="server" Text="Time Commitment:" Font-Bold="true"></asp:Label>
        <asp:Label ID="lblTimeCommitmentValue" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="lblSiteSuperVisotrNameandAddress" runat="server" Text="Site supervisor name and email:" Font-Bold="true"></asp:Label>
        <asp:Label ID="lblSiteSuperVisotrNameandAddressValue" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="lblBackgroundCheckRequired" runat="server" Text="Background check required?:" Font-Bold="true"></asp:Label>
        <asp:Label ID="lblBackgroundCheckRequiredValue" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="lblMinimumAge" runat="server" Text="Minimum age:" Font-Bold="true"></asp:Label>
        <asp:Label ID="lblMinimumAgeValue" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="lblLink" runat="server" Text="Link to online application:" Font-Bold="true"></asp:Label>
        <asp:Label ID="lblLinkValue" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="lblOtherRequirements" runat="server" Text="Other requirements:" Font-Bold="true"></asp:Label>
        <asp:Label ID="lblOtherRequirementsValue" runat="server" Text=""></asp:Label>
    </div>
    <br />
    <div>
        <asp:Button ID="btnClose" runat="server" Text="Close" Font-Bold="true" OnClick="ClosePage"/>    
        <asp:Button ID="btnSignup" runat="server" Text="SIGN UP" Font-Bold="true" OnClick="SignUpOpportunity"/>
        <asp:Label ID="lblMinimumAgeWarning" runat="server" Font-Bold="true" ForeColor ="Red" Text=""></asp:Label>
    </div>
</asp:Content>
