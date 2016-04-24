<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master"  CodeBehind="StudentReflection.aspx.cs" Inherits="eServeSU.StudentReflection" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2>Student Reflection</h2>
        <asp:Label ID="lblOpportunityAndCPName" runat="server" Text="" Font-Bold="true"></asp:Label>                
    </div>    
    <asp:Button ID="btnSubmitReflection" runat="server" Text="Submit" Enabled="true" Font-Bold="true" OnClick="btnSubmitReflection_Click" />     
    <br /><br />
    <asp:TextBox ID="tboxStudentReflection" runat="server"></asp:TextBox>
    
</asp:Content>




