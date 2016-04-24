<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master"  CodeBehind="StudentOpportunityEvaluation.aspx.cs" Inherits="eServeSU.StudentOpportunityEvaluation" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <asp:Label ID="lblPageTitle" runat="server" Text="Service-Learning Evaluation" Font-Bold="true"></asp:Label>
        <br />
        <asp:Label ID="lblOpportunityAndCPName" runat="server" Text="" Font-Bold="true"></asp:Label>
    </div>    
    <asp:Label ID="lblQuestion" runat="server" Text="Community organization where you completed your service-learning"></asp:Label>
    <br/>
    <asp:Label ID="lblOrganizationName" runat="server" Text=""></asp:Label>    
    <br/><br/>
    <asp:Label ID="lblQuestion01" runat="server" Text="What did you like most about the service-learning placement? Why?"></asp:Label>
    <br/>
    <asp:TextBox ID="tboxQuestion01" runat="server"></asp:TextBox>
    <br/><br/>
    <asp:Label ID="lblQuestion02" runat="server" Text="What did you like least about the service-learning placement? Why?"></asp:Label>
    <br/>
    <asp:TextBox ID="tboxQuestion02" runat="server"></asp:TextBox>
    <br/><br/>
    <asp:Label ID="lblQuestion03" runat="server" Text="Would you recommend this site to another student? Why or why not?"></asp:Label>
    <br/>
    <asp:TextBox ID="tboxQuestion03" runat="server"></asp:TextBox>
    <br/><br/>
    <asp:Label ID="lblQuestion04" runat="server" Text="Do you plan to continue serving at this organization beyond this quarter?"></asp:Label>
    <br/>
    <!--<asp:TextBox ID="tboxQuestion05" runat="server"></asp:TextBox>-->
    <asp:RadioButtonList ID="RadioButtonList7" runat="server"
        RepeatDirection="Horizontal" RepeatLayout="Table">
        <asp:ListItem>Yes</asp:ListItem>
        <asp:ListItem>No</asp:ListItem>
    </asp:RadioButtonList>
    <br/>
    <asp:Label ID="lblRating01" runat="server" Text="(1) The overall quality of my experience was high."></asp:Label>
    <asp:RadioButtonList ID="RadioButtonList1" runat="server"
        RepeatDirection="Horizontal" RepeatLayout="Table">
        <asp:ListItem>Strongly Disagree (1)</asp:ListItem>
        <asp:ListItem>Disagree (2)</asp:ListItem>
        <asp:ListItem>Neutral (3)</asp:ListItem>
        <asp:ListItem>Agree (4)</asp:ListItem>
        <asp:ListItem>Strongly Agree (5)</asp:ListItem>
    </asp:RadioButtonList>
        <br/>
    <asp:Label ID="lblRating02" runat="server" Text="(2) My experience was applicable to my classwork."></asp:Label>
    <asp:RadioButtonList ID="RadioButtonList2" runat="server"
        RepeatDirection="Horizontal" RepeatLayout="Table">
        <asp:ListItem>Strongly Disagree (1)</asp:ListItem>
        <asp:ListItem>Disagree (2)</asp:ListItem>
        <asp:ListItem>Neutral (3)</asp:ListItem>
        <asp:ListItem>Agree (4)</asp:ListItem>
        <asp:ListItem>Strongly Agree (5)</asp:ListItem>
    </asp:RadioButtonList>
        <br/>
    <asp:Label ID="lblRating03" runat="server" Text="(3) I learned a great deal from my experience."></asp:Label>
    <asp:RadioButtonList ID="RadioButtonList3" runat="server"
        RepeatDirection="Horizontal" RepeatLayout="Table">
        <asp:ListItem>Strongly Disagree (1)</asp:ListItem>
        <asp:ListItem>Disagree (2)</asp:ListItem>
        <asp:ListItem>Neutral (3)</asp:ListItem>
        <asp:ListItem>Agree (4)</asp:ListItem>
        <asp:ListItem>Strongly Agree (5)</asp:ListItem>
    </asp:RadioButtonList>
        <br/>
    <asp:Label ID="lblRating04" runat="server" Text="(4) I learned about my community."></asp:Label>
    <asp:RadioButtonList ID="RadioButtonList4" runat="server"
        RepeatDirection="Horizontal" RepeatLayout="Table">
        <asp:ListItem>Strongly Disagree (1)</asp:ListItem>
        <asp:ListItem>Disagree (2)</asp:ListItem>
        <asp:ListItem>Neutral (3)</asp:ListItem>
        <asp:ListItem>Agree (4)</asp:ListItem>
        <asp:ListItem>Strongly Agree (5)</asp:ListItem>
    </asp:RadioButtonList>
        <br/>
    <asp:Label ID="lblRating05" runat="server" Text="(5) I was able to make a positive impact at my service site."></asp:Label>
    <asp:RadioButtonList ID="RadioButtonList5" runat="server"
        RepeatDirection="Horizontal" RepeatLayout="Table">
        <asp:ListItem>Strongly Disagree (1)</asp:ListItem>
        <asp:ListItem>Disagree (2)</asp:ListItem>
        <asp:ListItem>Neutral (3)</asp:ListItem>
        <asp:ListItem>Agree (4)</asp:ListItem>
        <asp:ListItem>Strongly Agree (5)</asp:ListItem>
    </asp:RadioButtonList>
          <br/>
    <asp:Label ID="lblRating06" runat="server" Text="(6) I plan to keep in contact with my service site for potential future volunteering, internships, and/or employment."></asp:Label>
    <asp:RadioButtonList ID="RadioButtonList6" runat="server"
        RepeatDirection="Horizontal" RepeatLayout="Table">
        <asp:ListItem>Strongly Disagree (1)</asp:ListItem>
        <asp:ListItem>Disagree (2)</asp:ListItem>
        <asp:ListItem>Neutral (3)</asp:ListItem>
        <asp:ListItem>Agree (4)</asp:ListItem>
        <asp:ListItem>Strongly Agree (5)</asp:ListItem>
    </asp:RadioButtonList>
    <br/>
    <asp:Label ID="lblShareComment" runat="server" Text="Please share any other comments about your service site."></asp:Label>
    <br/>
    <asp:TextBox ID="tboxShareComment" runat="server"></asp:TextBox>
    <br /><br />
    <asp:Button ID="btnSubmitEvaluation" runat="server" Text="Submit" Enabled="true" Font-Bold="true" OnClick="btnSubmitEvaluation_Click" /> 
    <br/><br/>
    <asp:Label ID="lblReflectionMessage" runat="server" Text="Community partners are often interested in hearing students' thoughts about their experience. If you have a written reflection that you would like to share with the community organization, please copy and paste a reflection into the box."></asp:Label>

</asp:Content>


