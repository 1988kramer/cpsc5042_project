<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FacultyOppPartnerEvaluation.aspx.cs" Inherits="eServeSU.FacultyOppPartnerEvaluation" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2>Evaluation of Opportunity</h2>
    </div>
    <div class="glyphicon-sort-by-alphabet">
        <div>
            <div class="col-xs-3">
                <b><asp:Label ID="lblName" runat="server" Text="Organization Name: "></asp:Label></b></div>
            <div class="col-xs-9">
                <asp:Label ID="lblNameValue" runat="server" Text="" MaxLength="500" Width="500"></asp:Label></div>
        </div>
        <br />
        <div>
            <div class="col-xs-3">
                <b><asp:Label ID="lblQuestion1" runat="server" Text="Question 1: "></asp:Label></b></div>
            <div class="col-xs-9">
                <asp:Label ID="lblQuestionV1" runat="server" Text="What did you like most about the service-learning placement? Why?"></asp:Label></div>
        </div>
        <div>
            <div class="col-xs-3">
                <b><asp:Label ID="lblQ1" runat="server" Text="Answer: "></asp:Label></b></div>
            <div class="col-xs-9">
                <asp:Label ID="lblQuestionValue1" runat="server" Text="" MaxLength="500" Width="500"></asp:Label></div>
        </div>
        <div>
            <div class="col-xs-3">
                <b><asp:Label ID="lblQuestion2" runat="server" Text="Question 2: "></asp:Label></b></div>
            <div class="col-xs-9">
                <asp:Label ID="lblQuestionV2" runat="server" Text="What did you like least about the service-learning placement? Why?"></asp:Label></div>
        </div>
        <div>
            <div class="col-xs-3">
                <b><asp:Label ID="lblQ2" runat="server" Text="Answer: "></asp:Label></b></div>
            <div class="col-xs-9">
                <asp:Label ID="lblQuestionValue2" runat="server" Text="" MaxLength="500" Width="500"></asp:Label></div>
        </div>
        <div>
            <div class="col-xs-3">
                <b><asp:Label ID="lblQuestion3" runat="server" Text="Question 3: "></asp:Label></b></div>
            <div class="col-xs-9">
                <asp:Label ID="lblQuestionV3" runat="server" Text="Would you recommend this site to another student? Why or why not?"></asp:Label></div>
        </div>
         <div>
            <div class="col-xs-3">
                <b><asp:Label ID="lblQ3" runat="server" Text="Answer: "></asp:Label></b></div>
            <div class="col-xs-9">
                <asp:Label ID="lblQuestionValue3" runat="server" Text="" MaxLength="500" Width="500"></asp:Label></div>
        </div>
        <div>
            <div class="col-xs-3">
                <b><asp:Label ID="lblQuestion4" runat="server" Text="Question 4: "></asp:Label></b></div>
            <div class="col-xs-9">
                <asp:Label ID="lblQuestionV4" runat="server" Text="Do you plan to continue serving at this organization beyond this quarter?"></asp:Label></div>
        </div>
        <div>
            <div class="col-xs-3">
                <b><asp:Label ID="lblQ4" runat="server" Text="Answer: "></asp:Label></b></div>
            <div class="col-xs-9">
                <asp:Label ID="lblQuestionValue4" runat="server" Text="" MaxLength="500" Width="500"></asp:Label></div>
        </div>
        <div>
            <div class="col-xs-3">
                <b><asp:Label ID="lblRate1" runat="server" Text="Rate 1: "></asp:Label></b></div>
            <div class="col-xs-9">
                <asp:Label ID="lblRateV1" runat="server" Text="The overall quality of my experience was high."></asp:Label></div>
        </div>    
        <div>
            <div class="col-xs-3">
                <b><asp:Label ID="lblR1" runat="server" Text="Answer: "></asp:Label></b></div>
            <div class="col-xs-9">
                <asp:Label ID="lblRateValue1" runat="server" Text="" MaxLength="50" Width="500"></asp:Label></div>
        </div>    
        <div>
            <div class="col-xs-3">
                <b><asp:Label ID="lblRate2" runat="server" Text="Rate 2: "></asp:Label></b></div>
            <div class="col-xs-9">
                <asp:Label ID="lblRateV2" runat="server" Text="My experience was applicable to my classwork."></asp:Label></div>
        </div>
        <div>
            <div class="col-xs-3">
                <b><asp:Label ID="lblR2" runat="server" Text="Answer: "></asp:Label></b></div>
            <div class="col-xs-9">
                <asp:Label ID="lblRateValue2" runat="server" Text="" MaxLength="50" Width="500"></asp:Label></div>
        </div>  
         <div>
            <div class="col-xs-3">
                <b><asp:Label ID="lblRate3" runat="server" Text="Rate 3: "></asp:Label></b></div>
            <div class="col-xs-9">
                <asp:Label ID="lblRateV3" runat="server" Text="I learned a great deal from my experience."></asp:Label></div>
        </div>
        <div>
            <div class="col-xs-3">
                <b><asp:Label ID="lblR3" runat="server" Text="Answer: "></asp:Label></b></div>
            <div class="col-xs-9">
                <asp:Label ID="lblRateValue3" runat="server" Text="" MaxLength="50" Width="500"></asp:Label></div>
        </div>  
        <div>
            <div class="col-xs-3">
                <b><asp:Label ID="lblRate4" runat="server" Text="Rate 4: "></asp:Label></b></div>
            <div class="col-xs-9">
                <asp:Label ID="lblRateV4" runat="server" Text="I learned about my community."></asp:Label></div>
        </div>
        <div>
            <div class="col-xs-3">
                <b><asp:Label ID="lblR4" runat="server" Text="Answer: "></asp:Label></b></div>
            <div class="col-xs-9">
                <asp:Label ID="lblRateValue4" runat="server" Text="" MaxLength="50" Width="500"></asp:Label></div>
        </div> 
        <div>
            <div class="col-xs-3">
                <b><asp:Label ID="lblRate5" runat="server" Text="Rate 5: "></asp:Label></b></div>
            <div class="col-xs-9">
                <asp:Label ID="lblRateV5" runat="server" Text="I was able to make a positive impact at my service site."></asp:Label></div>
        </div>
        <div>
            <div class="col-xs-3">
                <b><asp:Label ID="lblR5" runat="server" Text="Answer: "></asp:Label></b></div>
            <div class="col-xs-9">
                <asp:Label ID="lblRateValue5" runat="server" Text="" MaxLength="50" Width="500"></asp:Label></div>
        </div> 
        <div>
            <div class="col-xs-3">
                <b><asp:Label ID="lblRate6" runat="server" Text="Rate 6: "></asp:Label></b></div>
            <div class="col-xs-9">
                <asp:Label ID="lblRateV6" runat="server" Text="I plan to keep in contact with my service site for potential future volunteering, internships, and/or employment."></asp:Label>
                </div>
        </div>
        <div>
            <div class="col-xs-3">
                <b><asp:Label ID="lblR6" runat="server" Text="Answer: "></asp:Label></b></div>
            <div class="col-xs-9">
                <asp:Label ID="lblRateValue6" runat="server" Text="" MaxLength="50" Width="500"></asp:Label></div>
        </div> 
        <div>
            <div class="col-xs-3">
                <b><asp:Label ID="lblComments" runat="server" Text="Comments: "></asp:Label></b></div>
            <div class="col-xs-9">
                <asp:Label ID="lblCommentsValue" runat="server" Text="" MaxLength="50" Width="500"></asp:Label></div>
        </div>
        <div>
            <div class="col-xs-3">
                </div>
            <div class="col-xs-9">
                </div>
        </div>
    </div>
    
</asp:Content>
