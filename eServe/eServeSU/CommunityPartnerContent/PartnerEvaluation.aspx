<%@ Page Title="PartnerEvaluation" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PartnerEvaluation.aspx.cs" Inherits="eServeSU.PartnerEval" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        <asp:Label ID="Label1" runat="server" Text="PartnerEvaluation"></asp:Label>
    </h2>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Organization Name"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="tbOrgName" runat="server" Width="565px" Height="35px"></asp:TextBox>
    </p>
<p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Supervisor First  Name"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="tbSupervisorFirstName" runat="server" Height="50px" Width="262px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label runat="server" Text="Supervisor Last Name"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="tbSupervisorLastName" runat="server" Height="53px" Width="259px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Student First Name"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="tbStudentFirstName" runat="server" Height="48px" Width="257px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label18" runat="server" Text="Student Last Name"></asp:Label>
    </p>
<p>
        <asp:TextBox ID="tbStudentLastName" runat="server" Height="54px" Width="251px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
<p>
        &nbsp;</p>
    <p>
        <asp:Label ID="lblHours" runat="server" ForeColor="Red" Text="Please answer this question" Visible="False"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label5" runat="server" Text="Hours Completed"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="tbHours" runat="server" Height="33px" Width="115px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="lblCompletedHours" runat="server" ForeColor="Red" Text="Please answer this question" Visible="False"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label6" runat="server" Text="Did the completed hours fulfill the student's time commitment to your organization for this quarter?"></asp:Label>
    </p>
    <p>
        <asp:DropDownList ID="ddlHours" runat="server">
            <asp:ListItem>Yes</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        <asp:Label ID="lblRate" runat="server" ForeColor="Red" Text="Please answer this question" Visible="False"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label7" runat="server" Text="Please rate the student:"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label8" runat="server" Text="The overall quality of the student's service was high ?"></asp:Label>
    </p>
    <p>
        <asp:RadioButtonList ID="RblRate1" runat="server" RepeatDirection="Horizontal" Width="758px">
            <asp:ListItem>StronglyDisagree</asp:ListItem>
            <asp:ListItem>Disagree</asp:ListItem>
            <asp:ListItem>Neutral</asp:ListItem>
            <asp:ListItem>Agree</asp:ListItem>
            <asp:ListItem>StronglyAgree</asp:ListItem>
        </asp:RadioButtonList>
    </p>
    <p>
        <asp:Label ID="Label10" runat="server" Text="The student exhibited professionalism in regard to matters  of confidentiality and in respecting agency staff and policies ?"></asp:Label>
    </p>
    <p>
        <asp:RadioButtonList ID="RblRate2" runat="server" RepeatDirection="Horizontal" Width="770px">
            <asp:ListItem>StronglyDisagree</asp:ListItem>
            <asp:ListItem>Disagree</asp:ListItem>
            <asp:ListItem>Neutral</asp:ListItem>
            <asp:ListItem>Agree</asp:ListItem>
            <asp:ListItem>StronglyAgree</asp:ListItem>
        </asp:RadioButtonList>
    </p>
    <p>
        <asp:Label ID="Label11" runat="server" Text="The student demonstrated commitment for work with the organization?"></asp:Label>
    </p>
    <p>
        <asp:RadioButtonList ID="RblRate3" runat="server" RepeatDirection="Horizontal" Width="776px">
            <asp:ListItem>StronglyDisagree</asp:ListItem>
            <asp:ListItem>Disagree</asp:ListItem>
            <asp:ListItem>Neutral</asp:ListItem>
            <asp:ListItem>Agree</asp:ListItem>
            <asp:ListItem>StronglyAgree</asp:ListItem>
        </asp:RadioButtonList>
    </p>
    <p>
        <asp:Label ID="Label12" runat="server" Text="The student was conscientious to working with differences across cultures?"></asp:Label>
    </p>
    <p>
        <asp:RadioButtonList ID="RblRate4" runat="server" RepeatDirection="Horizontal" Width="789px">
            <asp:ListItem>StronglyDisAgree</asp:ListItem>
            <asp:ListItem>Disagree</asp:ListItem>
            <asp:ListItem>Neutral</asp:ListItem>
            <asp:ListItem>Agree</asp:ListItem>
            <asp:ListItem>StronglyAgree</asp:ListItem>
        </asp:RadioButtonList>
    </p>
    <p>
        <asp:Label ID="Label13" runat="server" Text="The student exhibited a sincere desire to learn ?"></asp:Label>
    </p>
    <p>
        <asp:RadioButtonList ID="RblRate5" runat="server" RepeatDirection="Horizontal" Width="799px">
            <asp:ListItem>StronglyDisagree</asp:ListItem>
            <asp:ListItem>Disagree</asp:ListItem>
            <asp:ListItem>Neutral</asp:ListItem>
            <asp:ListItem>Agree</asp:ListItem>
            <asp:ListItem>StronglyAgree</asp:ListItem>
        </asp:RadioButtonList>
    </p>
    <p>
        <asp:Label ID="Label14" runat="server" Text="Our agency would like to continue to work with this student in the future or recommend the student for work at another organization ?"></asp:Label>
    </p>
    <p>
        <asp:RadioButtonList ID="RblRate6" runat="server" RepeatDirection="Horizontal" Width="813px">
            <asp:ListItem>StronglyDisagree</asp:ListItem>
            <asp:ListItem>Disagree</asp:ListItem>
            <asp:ListItem>Neutral</asp:ListItem>
            <asp:ListItem>Agree</asp:ListItem>
            <asp:ListItem>StronglyAgree</asp:ListItem>
        </asp:RadioButtonList>
    </p>
    <p>
        <asp:Label ID="lblQuestion2" runat="server" ForeColor="Red" Text="Please answer this question" Visible="False"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label15" runat="server" Text="What do you see as student's strength?"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="tbQuestion2" runat="server" Height="44px" TextMode="MultiLine" Width="659px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="lblQuestion3" runat="server" ForeColor="Red" Text="Please answer this question ?" Visible="False"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label16" runat="server" Text="Do you have suggestions on how the student might  improve ?"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="tbQuestion3" runat="server" TextMode="MultiLine" Width="662px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="lblQuestion4" runat="server" ForeColor="Red" Text="Please answer this question" Visible="False"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label17" runat="server" Text="Please add any other comment about the student."></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="tbQuestion4" runat="server" TextMode="MultiLine" Width="652px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="lblEmpty" runat="server" Visible="False" ForeColor="Red"></asp:Label>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
</asp:Content>
