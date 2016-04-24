<%@ Page Title="CommunityPartnerStudentView.aspx" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CommunityPartnerStudentView.aspx.cs" Inherits="eServeSU.CommunityPartnerStudentView" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2>Student List</h2>
    </div>
    <div class="glyphicon-sort-by-alphabet">
        <asp:GridView runat="server" AutoGenerateColumns="False" CellPadding="3" Height="114px" Width="739px" ID="gvCommunityPartnerStudentView" CssClass="Grid" 
                OnRowUpdating ="gvCommunityPartnerStudentView_RowUpdating"
                OnRowEditing="gvCommunityPartnerStudentView_RowEditing"
                OnRowCancelingEdit="gvCommunityPartnerStudentView_RowCancelingEdit"
                OnRowDataBound="gvCommunityPartnerStudentView_OnRowDataBound" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" OnSelectedIndexChanged="gvCommunityPartnerStudentView_SelectedIndexChanged">
                        <Columns>
                        <asp:TemplateField HeaderText="OpportunityID" SortExpression="OpportunityID" Visible="False">
                            <ItemTemplate>
                                <asp:Label ID="lblOpportunityID" runat="server" Text='<%# Eval("OpportunityID") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                            <asp:TemplateField HeaderText="CPID" Visible="False">
                                <ItemTemplate>
                                    <asp:Label ID="lblCPID" runat="server" Text='<%# Bind("CPID") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="CPPID" Visible="False">
                                <ItemTemplate>
                                    <asp:Label ID="lblCPPID" runat="server" Text='<%# Bind("CPPID") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        <asp:TemplateField HeaderText="ProfessorID" SortExpression="ProfessorID" Visible="False">
                            <ItemTemplate>
                                <asp:Label ID="lblProfessorID" runat="server" Text='<%# Eval("ProfessorID") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="StudentID" SortExpression="StudentID" Visible="False">
                            <ItemTemplate>
                                <asp:Label ID="lblStudentID" runat="server" Text='<%# Eval("StudentID") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="SectionID" SortExpression="SectionID" Visible="False">
                            <ItemTemplate>
                                <asp:Label ID="lblSectionID" runat="server" Text='<%# Eval("SectionID") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Opportunity" SortExpression="Opportunity">
                            <HeaderStyle Width="1000px" />
                            <ItemTemplate>
                                <asp:Label ID="lblOpportuniity" runat="server" Text='<%# Bind("Name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="SectionName" SortExpression="SectionName">
                            <HeaderStyle Width="800px" />
                            <ItemTemplate>
                                <asp:Label ID="lblSectionName" runat="server" Text='<%# Bind("SectionName") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Professor" SortExpression="Professor">
                                <ItemTemplate>
                                    <asp:HyperLink ID="hlnkProfessor" runat="server" NavigateUrl='<%# Eval("ProfessorEmail","mailto:{0}") %>' Text='<%# Eval("Professor","{0}") %>'></asp:HyperLink>
                                </ItemTemplate>
                                <HeaderStyle Width="800px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Student" SortExpression="Student">
                            <ItemTemplate>
                                <asp:HyperLink ID="hlnkStudent" runat="server" NavigateUrl="~/Student/StudentProfile.aspx?StudentID=106288" Text='<%# Bind("Student") %>'></asp:HyperLink>
                            </ItemTemplate>
                            <HeaderStyle Width="800px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="TotalHoursVolunteered">
                       
                            <HeaderTemplate>
                                TotalHours<br /> Volunteered
                            </HeaderTemplate>
                            <HeaderStyle Width="50px" />
                            <ItemTemplate>
                                <asp:Label ID="lblTotalVolunteeredHours" runat="server" Text='<%# Bind("TotalHoursVolunteered") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="PartnerApprovedHours" SortExpression="PartnerApprovedHours">
                            <HeaderTemplate>
                                Partner<br /> Approved<br /> Hours
                            </HeaderTemplate>
                                <HeaderStyle Width="50px" />
                            <ItemTemplate>
                                <asp:Label ID="lblPartnerApprovedHours" runat="server" Text='<%# Bind("PartnerApprovedHours") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                Time Sheet
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:HyperLink ID="hlnkTimeSheet" runat="server" NavigateUrl="~/CommunityPartnerContent/TimeSheet.aspx?StudentID=101945 &amp;OpportunityID =5">ViewTimeSheet</asp:HyperLink>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="SignUpStatus" SortExpression="SignUpStatus">
                            <ItemTemplate>
                                <asp:button ID="lblSignUpStatus" runat="server" Text='<%# Bind("SignUpStatus") %>' OnClick="EditSignUpStatus"></asp:button>
                            </ItemTemplate>
                            <HeaderStyle Width="100px" />
                            <HeaderTemplate>
                                SignUp Status
                            </HeaderTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="PartnerEvaluation">
                            <HeaderTemplate>
                                Partner Evaluation
                            </HeaderTemplate>
                            <HeaderStyle Width="200px" />
                            <ItemTemplate>
                                <asp:LinkButton ID="lbtnPartnerEval" runat="server" OnClick="SubmitPartnerEvaluation">SubmitEval</asp:LinkButton>
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
    </div>

 </asp:Content>
