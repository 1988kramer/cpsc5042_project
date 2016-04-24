<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="OpportunityList.aspx.cs" Inherits="eServeSU.Opportunity_OpportunityList" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2>Opportunity List</h2>
    </div>
    <div class="glyphicon-sort-by-alphabet">
        <asp:GridView ID="gvOpportunity" runat="server" AutoGenerateColumns="False"
            ShowFooter="True" CssClass="Grid"
            OnRowUpdating="gvOpportunity_RowUpdating"
            OnRowEditing="gvOpportunity_RowEditing"
            OnRowCancelingEdit="gvOpportunity_RowCancelingEdit"
            OnRowDataBound="gvOpportunity_OnRowDataBound">
            <Columns>
                <asp:TemplateField Visible="False">
                    <ItemTemplate>
                        <asp:Label ID="lblOppId" runat="server" Text='<%# Eval("OpportunityID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkEditView" runat="server" CommandArgument='<%# Eval("OpportunityId") %>'
                            Text="Edit/View" OnClick="EditViewOpportunity"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkRemove" runat="server" CommandArgument='<%# Eval("OpportunityId") %>'
                            OnClientClick="return confirm('Do you want to delete?')" Text="Delete" OnClick="DeleteOpportunity"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkClone" runat="server" CommandArgument='<%# Eval("OpportunityId")%>'
                            Text="Clone" OnClick="CloneOpportunity"></asp:LinkButton>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="AddNewOpportunity" />
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Name" SortExpression="Name">
                    <EditItemTemplate>
                        <asp:TextBox ID="tbName" runat="server" Text='<%# Bind("Name") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblName" runat="server" Text='<%# Bind("Name") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Location" SortExpression="Location">
                    <EditItemTemplate>
                        <asp:TextBox ID="tbLocation" runat="server" Text='<%# Bind("Location") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblLocation" runat="server" Text='<%# Bind("Location") %>'></asp:Label>
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
                <asp:TemplateField HeaderText="Status" SortExpression="Status">
                    <ItemTemplate>
                        <asp:Label ID="lblStatus" runat="server" Text='<%# Bind("Status") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Supervisor" SortExpression="Supervisor">
                    <ItemTemplate>
                        <asp:Label ID="lblSupervisor" runat="server" Text='<%# Bind("SupervisorName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>

</asp:Content>
