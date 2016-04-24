<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FacultyCourseOpportunity.aspx.cs" Inherits="eServeSU.FacultyCourseOpportunity" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2>Student and Opportunities</h2>
    </div>
    <div class="glyphicon-sort-by-alphabet">
        <div> </div>
        <div>
            <asp:GridView ID="gvOpportunityFaculty" runat="server" AutoGenerateColumns="False"
                ShowFooter="True" ShowHeader="True" CssClass="Grid">
                <Columns>
                    <asp:TemplateField Visible="False">
                        <ItemTemplate>
                            <asp:Label ID="lblOppId" runat="server" Text='<%#Eval("OpportunityID")%>'></asp:Label>
                            <asp:Label ID="lblStudentId" runat="server" Text='<%#Eval("StudentID")%>'></asp:Label>
                            <asp:Label ID="lblOppStudentId" runat="server" Text='<%#Eval("OppID_StudentID")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="StudentName" SortExpression="StudentName">
                        <ItemTemplate>
                            <asp:Label ID="lblStudentName" runat="server" Text='<%# Bind("StudentName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Opportunity Name" SortExpression="OpportunityName">
                        <ItemTemplate>
                            <asp:Label ID="lblOpportunityName" runat="server" Text='<%# Bind("OpportunityName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Section Name" SortExpression="Section">
                        <ItemTemplate>
                            <asp:Label ID="lblSectionName" runat="server" Text='<%# Bind("SectionName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Hours Completed" SortExpression="HoursCompleted">
                        <ItemTemplate>
                            <asp:Label ID="lblHoursCompleted" runat="server" Text='<%# Bind("HoursCompleted") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Hours Approved" SortExpression="HoursApproved">
                        <ItemTemplate>
                            <asp:Label ID="lblHoursApproved" runat="server" Text='<%# Bind("HoursApproved") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkEvaluation" runat="server" CommandArgument='<%# Eval("OppID_StudentID")%>'
                                Text="Partner Evaluation" OnClick="ViewPartnerEvaluation"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                         <ItemTemplate>
                            <asp:LinkButton ID="lnkSEvaluation" runat="server" CommandArgument='<%# Eval("OppID_StudentID")%>'
                                Text="Student Evaluation" OnClick="ViewStudentEvaluation"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
