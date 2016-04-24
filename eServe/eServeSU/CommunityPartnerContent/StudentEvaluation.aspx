<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StudentEvaluation.aspx.cs" Inherits="eServeSU.StudentEvaluation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
    <asp:Label ID="Label1" runat="server" Text="Student Evaluation"></asp:Label>
</h2>
<p>
    <asp:Label ID="Label2" runat="server" Text="Organization name where you completed your service learning " Height="30px"></asp:Label>
</p>
<p>
    <asp:TextBox ID="tbOrgName" runat="server" Height="32px" ReadOnly="True" Width="395px"></asp:TextBox>
</p>
    <p>
        &nbsp;</p>
<p>
    <asp:Label ID="Label3" runat="server" Text="What did you like most about this service learning placement? Why?"></asp:Label>
</p>
<p>
    <asp:TextBox ID="tblike" runat="server" Height="30px" ReadOnly="True" Width="147px"></asp:TextBox>
</p>
    <p>
        &nbsp;</p>
<p>
    <asp:Label ID="Label4" runat="server" Text="What did you like least about this placement? Why?" Height="30px"></asp:Label>
</p>
<p>
    <asp:TextBox ID="tbleast" runat="server" Height="37px" ReadOnly="True" Width="146px"></asp:TextBox>
</p>
    <p>
        &nbsp;</p>
<p>
    <asp:Label ID="Label5" runat="server" Text="Would you recommend this site to another student? Why or Why not?" Height="30px"></asp:Label>
</p>
<p>
    <asp:TextBox ID="tbRecommend" runat="server" Height="36px" ReadOnly="True" Width="169px"></asp:TextBox>
</p>
    <p>
        &nbsp;</p>
<p>
    <asp:Label ID="Label6" runat="server" Text="Do you plan to continue serving at this organization beyond this quarter?" Height="30px"></asp:Label>
</p>
<p>
    <asp:TextBox ID="tbContinue" runat="server" Height="32px" ReadOnly="True" Width="201px"></asp:TextBox>
</p>
    <p>
        &nbsp;</p>
<p>
    <asp:Label ID="Label7" runat="server" Text="(1) The overall quality of my experience was high." Height="30px"></asp:Label>
</p>
<p>
    <asp:TextBox ID="tbRate1" runat="server" Height="37px" ReadOnly="True" Width="200px"></asp:TextBox>
</p>
    <p>
        &nbsp;</p>
<p>
    <asp:Label ID="Label8" runat="server" Text="(2) My experience was applicable to my classwork." Height="30px"></asp:Label>
</p>
<p>
    <asp:TextBox ID="tbRate2" runat="server" Height="34px" ReadOnly="True" Width="199px"></asp:TextBox>
</p>
    <p>
        &nbsp;</p>
<p>
    <asp:Label ID="Label9" runat="server" Text="(3) I learned a great deal from my experience." Height="30px" Width="300px"></asp:Label>
</p>
<p>
    <asp:TextBox ID="tbRate3" runat="server" Height="39px" ReadOnly="True" Width="198px"></asp:TextBox>
</p>
    <p>
        &nbsp;</p>
<p>
    <asp:Label ID="Label10" runat="server" Text="(4) I learned about my community." Height="30px"></asp:Label>
</p>
<p>
    <asp:TextBox ID="tbRate4" runat="server" Height="38px" ReadOnly="True" Width="196px"></asp:TextBox>
</p>
    <p>
        &nbsp;</p>
<p>
    <asp:Label ID="Label11" runat="server" Text="(5) I was able to make a positive impact at my service site." Height="30px"></asp:Label>
</p>
<p>
    <asp:TextBox ID="tbRate5" runat="server" Height="42px" ReadOnly="True" Width="194px"></asp:TextBox>
</p>
    <p>
        &nbsp;</p>
<p>
    <asp:Label ID="Label12" runat="server" Text="(6) I plan to keep in contact with my service site for potential future volunteering, internships, and/or employment." Height="30px"></asp:Label>
</p>
<p>
    <asp:TextBox ID="tbRate6" runat="server" Height="43px" ReadOnly="True" Width="198px"></asp:TextBox>
</p>
    <p>
        &nbsp;</p>
<p>
    <asp:Label ID="Label13" runat="server" Text="Please share any other comments about this site."></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="tbComments" runat="server" Height="61px" ReadOnly="True" TextMode="MultiLine" Width="702px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
