<%@ Page Title="ReadEvaluation" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReadEvaluation.aspx.cs" Inherits="eServeSU.ReadEvaluation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        <asp:Label ID="Label1" runat="server" Text="ReadEvaluations"></asp:Label>
    </h2>
                <asp:GridView runat="server" AutoGenerateColumns="False" CellPadding="3" BackColor="White" BorderColor="#CCCCCC" BorderWidth="1px" BorderStyle="None" Height="16px" Width="586px" ID="gvEvaluations" OnSelectedIndexChanged="gvEvaluations_SelectedIndexChanged"><Columns>
                    <asp:TemplateField Visible="False">
                        <ItemTemplate>
                            <asp:Label ID="lblOpportunityID" runat="server" Text='<%# Eval("OpportunityID") %>' Visible="False"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField Visible="False">
                        <ItemTemplate>
                            <asp:Label ID="lblStudentID" runat="server" Text='<%# Eval("StudentID") %>' Visible="False"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Opportunity" SortExpression="Opportunity">
                        <ItemTemplate>
                            <asp:Label ID="lblOpportunity" runat="server" Text='<%# Bind("Name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Student" SortExpression="Student">
                        <ItemTemplate>
                            <asp:Label ID="lblStudent" runat="server" Text='<%# Bind("Student") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="SectionName" SortExpression="SectionName">
                        <ItemTemplate>
                            <asp:Label ID="lblSectionName" runat="server" Text='<%# Bind("SectionName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="CourseEvaluation">
                        <ItemTemplate>
                            <asp:HyperLink ID="hlnkEval" runat="server" NavigateUrl="~/CommunityPartnerContent/StudentEvaluation.aspx">ViewEvaluation</asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
</Columns>

<FooterStyle BackColor="White" ForeColor="#000066"></FooterStyle>

<HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White"></HeaderStyle>

<PagerStyle HorizontalAlign="Left" BackColor="White" ForeColor="#000066"></PagerStyle>

<RowStyle ForeColor="#000066"></RowStyle>

<SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White"></SelectedRowStyle>

<SortedAscendingCellStyle BackColor="#F1F1F1"></SortedAscendingCellStyle>

<SortedAscendingHeaderStyle BackColor="#007DBB"></SortedAscendingHeaderStyle>

<SortedDescendingCellStyle BackColor="#CAC9C9"></SortedDescendingCellStyle>

<SortedDescendingHeaderStyle BackColor="#00547E"></SortedDescendingHeaderStyle>
</asp:GridView>

                </asp:Content>
