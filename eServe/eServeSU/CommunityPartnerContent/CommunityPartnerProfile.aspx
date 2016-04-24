<%@ Page Title="CommunityPartnerProfile" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CommunityPartnerProfile.aspx.cs" Inherits="eServeSU.CommunityPartnerProfile_CommunityPartnerProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2 title="CommunityPartnerProfile">
        <asp:Label ID="lblCommunityPartnerProfile" runat="server" Text="CommunityPartnerProfile"></asp:Label>
    </h2>
    <table class="nav-justified">
        <tr>
            <td style="width: 229px">
                <asp:Label ID="Label1" runat="server" Text="OrganizationName:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tbOrganizationName" runat="server" Height="43px" Width="648px"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 229px">
                <asp:Label ID="Label2" runat="server" Text="Address:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tbAddress" runat="server" Height="81px" Width="645px"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 229px">
                <asp:Label ID="Label3" runat="server" Text="Website:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tbWebsite" runat="server" Height="42px" Width="641px"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 229px">
                <asp:Label ID="Label4" runat="server" Text="MainPhone:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tbMainPhone" runat="server" Height="32px" Width="376px"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 229px">
                <asp:Label ID="Label5" runat="server" Text="MissionStatement:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tbMissionStatement" runat="server" Height="64px" Width="639px"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 229px">
                <asp:Label ID="Label6" runat="server" Text="Description:"></asp:Label>
            </td>
            <td id="tableCommunityPartnerProfile">
                <asp:TextBox ID="tbDescription" runat="server" TextMode="MultiLine" Width="641px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
        </tr>
    </table>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Button ID="btUpdate" runat="server" Text="Update" OnClick="btUpdate_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="OutputLabel" runat="server" Visible="False" ForeColor="Red">Your Profile is successfuly updated.</asp:Label>
            &nbsp;&nbsp;&nbsp;
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="btUpdate" EventName="Click" />
        </Triggers>
    </asp:UpdatePanel>
    <p>
    </p>
</asp:Content>
