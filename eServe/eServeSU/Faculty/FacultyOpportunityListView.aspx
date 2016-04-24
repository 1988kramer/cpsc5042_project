<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FacultyOpportunityListView.aspx.cs" Inherits="eServeSU.FacultyOpportunityListView" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2>Community Partners and Opportunities</h2>
    </div>
    <div class="glyphicon-sort-by-alphabet">
        <div> </div>
        <div>
            <asp:GridView ID="gvOpportunityFaculty" runat="server" AutoGenerateColumns="False"
                ShowFooter="True" CssClass="Grid">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkDetail" runat="server" CommandArgument='<%# Eval("OpportunityId")%>'
                                Text="Detail" OnClick="ViewOpportunityDetail"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField Visible="False">
                        <ItemTemplate>
                            <asp:Label ID="lblOppId" runat="server" Text='<%#Eval("OpportunityID")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Status" SortExpression="Status">
                        <ItemTemplate>
                            <asp:Label ID="lblStatus" runat="server" Text='<%# Bind("Status") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Community Partner" SortExpression="CommunityPartner">
                        <ItemTemplate>
                            <asp:Label ID="lblCommnunityPartner" runat="server" Text='<%# Bind("OrganizationName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Position" SortExpression="Position">
                        <ItemTemplate>
                            <asp:Label ID="lblPosition" runat="server" Text='<%# Bind("Name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Opportunity Type" SortExpression="oppType">
                        <ItemTemplate>
                            <asp:Label ID="lblOppType" runat="server" Text='<%# Bind("OpportunityTypeName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Date Approved" SortExpression="dateApproved">
                        <ItemTemplate>
                            <asp:Label ID="lblDataApproved" runat="server" Text='<%# Bind("DateApprovedForDisplay") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Supervisor" SortExpression="Supervisor">
                        <ItemTemplate>
                            <asp:HyperLink ID="lblSupervisor" runat="server" NavigateUrl = '<%# Bind("SupervisorEmail") %>' Text = '<%# Bind("SupervisorName") %>'></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Slots" SortExpression="Slots">
                        <ItemTemplate>
                            <asp:Label ID="lblSlots" runat="server" Text='<%# Bind("TotalNumberSlots") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
