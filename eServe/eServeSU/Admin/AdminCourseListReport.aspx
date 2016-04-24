<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminCourseListReport.aspx.cs" Inherits="eServeSU.AdminCourseList" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2>Admin - Opportunities - Section Courses - Student reports</h2>
    </div>
    <div class="glyphicon-sort-by-alphabet">
        <div>Opportunities - Section Courses - Student reports : </div>
        <div><br></div>
        <div>
            <asp:DropDownList ID="ddlQuarters" runat="server"></asp:DropDownList>
            <asp:Button ID="btnReport" runat="server" Text=" Get Report " OnClick="btnReport_Click" />
            <asp:Button ID="btnExport" runat="server" Text=" Export Report to Excel" OnClick="btnExport_Click" />            
            <br>
        </div>
        <div>
            <asp:GridView ID="gvOppSecAdmin" runat="server" AutoGenerateColumns="False"
                ShowFooter="True" ShowHeader="True" CssClass="Grid">
                <Columns>
                    <asp:TemplateField Visible="False">
                        <ItemTemplate>
                            <asp:Label ID="lblOppId" runat="server" Text='<%#Eval("OpportunityID")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Community Partner" SortExpression="CommunityPartner">
                        <ItemTemplate>
                            <asp:Label ID="lblCommnunityPartner" runat="server" Text='<%# Bind("OrganizationName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Position" SortExpression="Position">
                        <ItemTemplate>
                            <asp:Label ID="lblPosition" runat="server" Text='<%# Bind("OpportunityName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Opportunity Type" SortExpression="oppType">
                        <ItemTemplate>
                            <asp:Label ID="lblOppType" runat="server" Text='<%# Bind("OpportunityTypeName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Section Name">
                       <ItemTemplate>
                            <asp:Label ID="lblSection" runat="server" Text='<%# Bind("SectionName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Course Name">
                       <ItemTemplate>
                            <asp:Label ID="lblSection" runat="server" Text='<%# Bind("CourseShortName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Quarter Name">
                       <ItemTemplate>
                            <asp:Label ID="lblSection" runat="server" Text='<%# Bind("QuarterShortName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Professor Name">
                       <ItemTemplate>
                            <asp:Label ID="lblSection" runat="server" Text='<%# Bind("ProfessorName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Approved Hours">
                       <ItemTemplate>
                            <asp:Label ID="lblSection" runat="server" Text='<%# Bind("PartnerApprovedHours") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Student Name">
                       <ItemTemplate>
                            <asp:Label ID="lblSection" runat="server" Text='<%# Bind("StudentName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Student Email">
                       <ItemTemplate>
                            <asp:Label ID="lblSection" runat="server" Text='<%# Bind("StudentEmail") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
