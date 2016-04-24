<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="OpportunitySignUp.aspx.cs" Inherits="eServeSU.Opportunity_OpportunitySignUp" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2>Opportunity SignUp</h2>
    </div>

    <div class="glyphicon-sort-by-alphabet">
        <div>
            <div class="col-xs-2">
                <asp:Label ID="lblName" runat="server" Text=" Opportunity Name: "></asp:Label></div>
            <div class="col-xs-10">
                <asp:Label ID="lblNameValue" runat="server" Text=""></asp:Label></div>
        </div>
        <br />
        <div>
            <div class="col-xs-2">
                <asp:Label ID="lblLocation" runat="server" Text="Opportunity Location: "></asp:Label></div>
            <div class="col-xs-10">
                <asp:Label ID="lblLocationValue" runat="server" Text=""></asp:Label></div>
        </div>
        <br />
        <div>
            <div class="col-xs-2">
                <asp:Label ID="lblJobHours" runat="server" Text="Opportunity Hours: "></asp:Label></div>
            <div class="col-xs-10">
                <asp:Label ID="lblJobHoursValue" runat="server" Text=""></asp:Label></div>
        </div>
        <br />
        <div>
            <div class="col-xs-2">
                <asp:Label ID="lblType" runat="server" Text="Opportunity Type: "></asp:Label></div>
            <div class="col-xs-10">
                <asp:Label ID="lblTypeValue" runat="server" Text=""></asp:Label></div>
        </div>
        <br />
        <div>
            <div class="col-xs-2">
                <asp:Label ID="lblFocusArea" runat="server" Text="Focus Area: "></asp:Label></div>
            <div class="col-xs-10">
                <asp:Label ID="lblFocusAreaValue" runat="server" Text=""></asp:Label></div>
        </div>
        <br />
        <div>
            <div class="col-xs-2">
                <asp:Label ID="lblDistanceFromSU" runat="server" Text="Distance From SU: "></asp:Label></div>
            <div class="col-xs-10">
                <asp:Label ID="lblDistanceFromSUValue" runat="server" Text=""></asp:Label></div>
        </div>
        <br />
        <div>
            <div class="col-xs-2">
                <asp:Label ID="lblSupervisor" runat="server" Text="Opportunity Supervisor: " Height="30"></asp:Label></div>
            <div class="col-xs-10">
                <asp:Label ID="lblSupervisorValue" runat="server" Text=""></asp:Label></div>
        </div>
        <br />
        <div>
            <div class="col-xs-2">
                <asp:Button ID="tbSignUp" runat="server" Text="Sign Up for this Opportunity"></asp:Button></div>
            <div class="col-xs-10">
                <asp:Label ID="lblEmpty" runat="server" Text="" Width="2000"></asp:Label></div>
        </div>
    </div>
    <br>
    <br>
    <br>
    <br>
</asp:Content>

