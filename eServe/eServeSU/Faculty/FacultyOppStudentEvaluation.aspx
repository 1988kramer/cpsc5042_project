<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FacultyOppStudentEvaluation.aspx.cs" Inherits="eServeSU.FacultyOppStudentEvaluation" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2>Evaluation of Student</h2>
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
                <b><asp:Label ID="lblStudentName" runat="server" Text="Student Name: "></asp:Label></b></div>
            <div class="col-xs-9">
                <asp:Label ID="lblStudentNameValue" runat="server" Text="" MaxLength="500" Width="500"></asp:Label></div>
        </div>
        
        <div>
            <div class="col-xs-3">
                <b><asp:Label ID="lblSupervisorName" runat="server" Text="Supervisor Name: "></asp:Label></b></div>
            <div class="col-xs-9">
                <asp:Label ID="lblSupervisorNameValue" runat="server" Text="" MaxLength="500" Width="500"></asp:Label></div>
        </div>
        <div>
            <div class="col-xs-3">
                <b><asp:Label ID="lblQuestion1" runat="server" Text="Question 1: "></asp:Label></b></div>
            <div class="col-xs-9">
                <asp:Label ID="lblQuestionV1" runat="server" Text="Did the completed hours fulfill the student's time commitment to your organization for this quarter?"></asp:Label></div>
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
                <asp:Label ID="lblQuestionV2" runat="server" Text="What do you see as student's strength?"></asp:Label></div>
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
                <asp:Label ID="lblQuestionV3" runat="server" Text="Do you have suggestions on how the student might improve ?"></asp:Label></div>
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
                <asp:Label ID="lblQuestionV4" runat="server" Text="Please add any other comment about the student."></asp:Label></div>
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
                <asp:Label ID="lblRateV1" runat="server" Text="The overall quality of the student's service was high?"></asp:Label></div>
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
                <asp:Label ID="lblRateV2" runat="server" Text="The student exhibited professionalism in regard to matters  of confidentiality and in respecting agency staff and policies ?"></asp:Label></div>
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
                <asp:Label ID="lblRateV3" runat="server" Text="The student demonstrated commitment for work with the organization?"></asp:Label></div>
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
                <asp:Label ID="lblRateV4" runat="server" Text="The student was conscientious to working with differences across cultures?"></asp:Label></div>
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
                <asp:Label ID="lblRateV5" runat="server" Text="The student exhibited a sincere desire to learn ?"></asp:Label></div>
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
                <asp:Label ID="lblRateV6" runat="server" Text="Our agency would like to continue to work with this student in the future or recommend the student for work at another organization ?"></asp:Label>
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
                </div>
            <div class="col-xs-9">
                </div>
        </div>
    </div>
    
</asp:Content>
