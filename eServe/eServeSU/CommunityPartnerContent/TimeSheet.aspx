<%@ Page Title="TimeSheet" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TimeSheet.aspx.cs" Inherits="eServeSU.TimeSheet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        <asp:Label ID="Label1" runat="server" Text="TimeSheet"></asp:Label>
    </h2>
    <h2>
        <asp:GridView ID="gvTimeSheet" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
            OnRowUpdating ="gvTimeSheet_RowUpdating"
            OnRowEditing="gvTimeSheet_RowEditing"
            OnRowCancelingEdit="gvTimeSheet_RowCancelingEdit"
            OnRowDataBound="gvTimeSheet_OnRowDataBound">
            <Columns>
                <asp:TemplateField HeaderText="WorkDate" SortExpression="workDate">
                    <ItemTemplate>
                        <asp:Label ID="lblWorkDate" runat="server" Text='<%# Bind("WorkDate") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="HoursVolunteered">
                    <ItemTemplate>
                        <asp:Label ID="lblHours" runat="server" Text='<%# Bind("HoursVolunteered") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="PartnerApprovedHours">
                    <EditItemTemplate>
                        <asp:TextBox ID="tbPartnerHours" runat="server"></asp:TextBox>
                    
</EditItemTemplate>
<HeaderTemplate>
                        PartnerApproved<br /> Hours
                    
</HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblPartnerHours" runat="server" Text='<%# Bind("PartnerApprovedHours") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="OpportunityID" Visible="False">
                    <ItemTemplate>
                        <asp:Label ID="lblOpportunityID" runat="server" Text='<%# Bind("OpportunityID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="StudentID" Visible="False">
                    <ItemTemplate>
                        <asp:Label ID="lblStudent" runat="server" Text='<%# Bind("StudentID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowEditButton="True" />
            </Columns>
            <EmptyDataTemplate>
                <asp:Label ID="lbtnEdit" runat="server"></asp:Label>
            </EmptyDataTemplate>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
    </h2>
    </asp:Content>
