<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master"  CodeBehind="StudentRegistered.aspx.cs" Inherits="eServeSU.StudentRegistered" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2>Opportunities Registered</h2>
    </div>
                <div ">
                <asp:DropDownList runat="server" ID="DropDownList1"  AutoPostBack="True" >
                    <asp:ListItem Text="Current" Value="Current" />
                    <asp:ListItem Text="All" Value="All" />                    
                </asp:DropDownList >
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
                <asp:TemplateField HeaderText="Academic Term" SortExpression="Name">
   <%--                 <EditItemTemplate>
                        <asp:TextBox ID="tbName" runat="server" Text='<%# Bind("Position") %>'></asp:TextBox>
                    </EditItemTemplate>--%>
                    <ItemTemplate>
                        <asp:Label ID="lblName" runat="server" Text='<%# Bind("Quarter") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Course" SortExpression="Supervisor">
                    <ItemTemplate>
                        <asp:Label ID="lblCourse" runat="server" Text='<%# Bind("Course") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Organization" SortExpression="Supervisor">
                    <ItemTemplate>
                        <asp:Label ID="lblOrganization" runat="server" Text='<%# Bind("Organization") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Opportunity" SortExpression="Supervisor">
                    <ItemTemplate>
                        <asp:Label ID="lblOpportunity" runat="server" Text='<%# Bind("Opportunity") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Email ID" SortExpression="Location">
                    <ItemTemplate>
                        <asp:Label ID="lblSlotsAvailable" runat="server" Text='<%# Bind("EmailId") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Status" SortExpression="Location">
                    <ItemTemplate>
                        <asp:Label ID="lblDistanceFromSU" runat="server" Text='<%# Bind("Status") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Hours: Completed/Approved" SortExpression="Location">
                    <ItemTemplate>
                        <asp:Label ID="lblHoursVolunteered" runat="server" Text='<%# Bind("HoursVolunteered") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkEditView" runat="server" CommandArgument='<%# Eval("StudentID")%>'
                            Text="View Details" OnClick="EditViewRegistered"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>

</asp:Content>