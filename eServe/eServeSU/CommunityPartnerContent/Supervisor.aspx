<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Supervisor.aspx.cs" Inherits="eServeSU.CommunityPartnerContent.Supervisor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        <asp:Label ID="Label1" runat="server" Text="Supervisor"></asp:Label>
    </h2>
    <p>
        First Name</p>
    <p>
        <asp:TextBox ID="tbFirstName" runat="server" Height="22px" Width="499px"></asp:TextBox>
    </p>
    <p>
        Last Name</p>
    <asp:TextBox ID="tbLastName" runat="server" Height="22px" Width="499px"></asp:TextBox>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Title"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="tbTitle" runat="server" Width="495px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label5" runat="server" Text="EmailID"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="tbEmailID" runat="server" Height="20px" Width="491px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label6" runat="server" Text="Phone"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="tbPhone" runat="server" Width="273px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblOutput" runat="server" Text="&quot;You have successfully updated the supervisor&quot;" Visible="False" ForeColor="Red"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
    </p>
</asp:Content>
