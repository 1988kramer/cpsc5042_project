<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="RegistrationDocuments.aspx.cs" Inherits="eServeSU.RegistrationDocuments" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2>Required Documents</h2>
    </div>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Are you over 18?" Font-Bold="true"></asp:Label>
        <br />
           <asp:RadioButtonList runat="server" ID="rblMinimumAge" RepeatDirection="Horizontal">
                    <asp:ListItem>Yes</asp:ListItem>
                    <asp:ListItem Selected="true">No</asp:ListItem>
           </asp:RadioButtonList>
    </div>
    <br />
    <div>
        <asp:Label ID="Label2" runat="server" Text="This opportunity requires a background check" Font-Bold="true"></asp:Label>
    </div>
    <br />
    <br />
    <div>
        <asp:Button ID="Button1" runat="server" Text="Back" Font-Bold="true" />    
        <asp:Button ID="Button2" runat="server" Text="Register" Enabled="false" Font-Bold="true"/>
    </div>
</asp:Content>
