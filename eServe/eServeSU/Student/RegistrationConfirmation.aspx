<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="RegistrationDocuments.aspx.cs" Inherits="eServeSU.RegistrationConfirmation" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2>Service-Learning Registration</h2>
    </div>
        <br />
    <div>
        <asp:Label ID="Label1" runat="server" Text="Registration is pending until your site supervisor approves your placement." Font-Bold="true"></asp:Label>
    </div>
    <br />
    <div>
        <asp:Label ID="Label3" runat="server" Text="Your next steps:" Font-Bold="true"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Text="1.	Get in touch with site supervisor immediately" Font-Bold="true"></asp:Label>
        <br />
        <asp:Label ID="Label5" runat="server" Text="2.	Attend orientation at your site" Font-Bold="true"></asp:Label>
        <br />
        <asp:Label ID="Label6" runat="server" Text="3.	Commit to a regular schedule of service for the full quarter" Font-Bold="true"></asp:Label>
        <br />
        <asp:Label ID="Label7" runat="server" Text="4.	Complete evaluation at the end of the quarter" Font-Bold="true"></asp:Label>
    </div>
    <br />
    <div>
        <asp:Label ID="Label8" runat="server" Text="Your selected position:" Font-Bold="true"></asp:Label>
         <br />
        <asp:Label ID="lblPositionAtOrganization" runat="server" Text="" Font-Bold="true"></asp:Label>
        <br />
        <asp:Label ID="lblOpportunityDesc" runat="server" Text="" Font-Bold="false"></asp:Label>        
    </div>
    <br />
    <div>
        <br />
        <asp:Label ID="lblSiteSuperVisotrNameandAddress" runat="server" Text="Site supervisor name and email:" Font-Bold="true"></asp:Label>
        <asp:Label ID="lblSiteSuperVisotrNameandAddressValue" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="lblLocation" runat="server" Text="Location:" Font-Bold="true"></asp:Label>
        <asp:Label ID="lblLocationValue" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="lblTimeCommitment" runat="server" Text="Time Commitment:" Font-Bold="true"></asp:Label>
        <asp:Label ID="lblTimeCommitmentValue" runat="server" Text=""></asp:Label>
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
    <br />
    <div>
        <asp:Button ID="btnClose" runat="server" Text="Close" Font-Bold="true" OnClick="ClosePage" />            
    </div>
</asp:Content>