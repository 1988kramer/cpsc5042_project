<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master"  CodeBehind="StudentProfile.aspx.cs" Inherits="eServeSU.StudentProfile" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2>Student Profile</h2>
    </div>
   
   <%-- <div class="glyphicon-sort-by-alphabet"><br />--%>
    <%--    <asp:Button ID="btnSaveChanges" runat="server" Text="Save Changes" OnClick="btnSaveChanges_Click" />        
        <br /><br />--%>

        <div>
        <asp:Label ID="lblLegalName" runat="server" Text="Legal Name: "></asp:Label>
        <asp:Label ID="lblStudentLegalName" runat="server" Font-Bold="true" Text=""></asp:Label>
        <%--<asp:TextBox ID="txtLegalName" runat="server"></asp:TextBox>--%>
        <br /><br />

        <asp:Label ID="PreferredName" runat="server" Text="Preferred Name: "></asp:Label>        
        <asp:TextBox ID="txtPreferName" runat="server"></asp:TextBox>
        <br /><br />

        <asp:Label ID="lblDateOfBirth" runat="server" Text="Date of Birth: "></asp:Label>
        <asp:Label ID="lblStudentDOB" runat="server" Font-Bold="true" Text=""></asp:Label>
        <%--<asp:TextBox ID="txtDateOfBirth" runat="server"></asp:TextBox>--%>
        <br /><br />

        <asp:Label ID="lblGender" runat="server" Text="Gender (optional): "></asp:Label>
        <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
        <br /><br />

<%--        <asp:Label ID="lblEthinicity" runat="server" Text="Ethinicity: "></asp:Label>
        <asp:CheckBoxList ID="cbxEthinicity" runat="server">
            <asp:ListItem>Hispanic or Latino</asp:ListItem>
            <asp:ListItem>American Indian or Alaska Native</asp:ListItem>
            <asp:ListItem>Asian</asp:ListItem>
            <asp:ListItem>Black or African American</asp:ListItem>
            <asp:ListItem>Native Hawaiian or Pacific Islander</asp:ListItem>
            <asp:ListItem>White</asp:ListItem>
        </asp:CheckBoxList>
        <br /><br />--%>

        <asp:Label ID="lblFocusAreas" runat="server" Text="I’m interested in opportunities related to: "></asp:Label>        
        <asp:CheckBoxList ID="cbxFocusAreas" runat="server">
            <asp:ListItem>Children and Youth</asp:ListItem>
            <asp:ListItem>Intercultural Connections</asp:ListItem>
            <asp:ListItem>Working with Families</asp:ListItem>
            <asp:ListItem>Hunger and Homelessness</asp:ListItem>
            <asp:ListItem>Sustainability</asp:ListItem>
            <asp:ListItem>Aging and Disabilities</asp:ListItem>         
            <asp:ListItem>Seattle University Youth Initiative</asp:ListItem>                     
        </asp:CheckBoxList>
        <br />

        <asp:Label ID="LabelInternationalStudent" runat="server" Text="International student? (optional) "></asp:Label>
        <asp:RadioButtonList ID="rbtnInternationalStudent" runat="server">
            <asp:ListItem Text="Yes" Value="Yes"></asp:ListItem>
            <asp:ListItem Text="No" Value="No"></asp:ListItem>
        </asp:RadioButtonList>
        <br /><br />

        <asp:Label ID="lblLastBackgroundCheck" runat="server" Text="Last background check: "></asp:Label>
        <asp:Label ID="lblStudentLastBackgroundCheck" runat="server" Font-Bold="true" Text=""></asp:Label>        
        <br /><br />
        <asp:Button ID="btnUpdate" runat="server" Text="Update" Enabled="true" Font-Bold="true" OnClick="UpdateStudentProfile"/>
    </div>
</asp:Content>
