<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="StudentRegistration.aspx.cs" Inherits="eServeSU.StudentRegistration" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2>Opportunity List</h2>
    </div>
    <div class="glyphicon-sort-by-alphabet">
        <asp:GridView ID="gvOpportunity" runat="server" AutoGenerateColumns="False"
            ShowFooter="True" ShowHeader="True" CssClass="Grid"
            OnRowUpdating="gvOpportunity_RowUpdating"
            OnRowEditing="gvOpportunity_RowEditing"
            OnRowCancelingEdit="gvOpportunity_RowCancelingEdit">
            <Columns>
                <asp:TemplateField Visible="False">
                    <ItemTemplate>
                        <asp:Label ID="lblOppId" runat="server" Text='<%#Eval("OpportunityID")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Position" SortExpression="Name">
   <%--                 <EditItemTemplate>
                        <asp:TextBox ID="tbName" runat="server" Text='<%# Bind("Position") %>'></asp:TextBox>
                    </EditItemTemplate>--%>
                    <ItemTemplate>
                        <asp:Label ID="lblName" runat="server" Text='<%# Bind("Position") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Organization" SortExpression="Supervisor">
                    <ItemTemplate>
                        <asp:Label ID="lblOrganization" runat="server" Text='<%# Bind("Organization") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Slots Available" SortExpression="Location">
                    <ItemTemplate>
                        <asp:Label ID="lblSlotsAvailable" runat="server" Text='<%# Bind("SlotsAvailable") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Distance From SU" SortExpression="Location">
                    <ItemTemplate>
                        <asp:Label ID="lblDistanceFromSU" runat="server" Text='<%# Bind("DistanceFromSU") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Location" SortExpression="Location">
                    <ItemTemplate>
                        <asp:Label ID="lblLocation" runat="server" Text='<%# Bind("Location") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Time Commitment" SortExpression="Supervisor">
                    <ItemTemplate>
                        <asp:Label ID="lblTimeCommitment" runat="server" Text='<%# Bind("TimeCommittment") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Minimum Age" SortExpression="oppType">
                    <ItemTemplate>
                        <asp:Label ID="lblOppType" runat="server" Text='<%# Bind("MinimumAge") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="CRC Required" SortExpression="oppType">
                    <ItemTemplate>
                        <asp:Label ID="lblCRCRequired" runat="server" Text='<%# Bind("CRCRequiredByPartner") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <%--<asp:TemplateField HeaderText="JobDescription" SortExpression="oppType">
                    <ItemTemplate>
                        <asp:Label ID="lblJobDescription" runat="server" Text='<%# Bind("JobDescription") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>--%>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkViewOpportunityDetails" runat="server" CommandArgument='<%# Eval("OpportunityId")%>'
                            Text="View Details" OnClick="ViewOpportunityDetails"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>

</asp:Content>
