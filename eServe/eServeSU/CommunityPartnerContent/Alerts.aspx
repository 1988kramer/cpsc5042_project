<%@ Page Title="Alerts" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Alerts.aspx.cs" Inherits="eServeSU.Alerts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        <asp:Label ID="Label1" runat="server" Text="Alerts"></asp:Label>
    </h2>
    <asp:GridView runat="server" AllowSorting="True" AutoGenerateColumns="False" CellPadding="3" BackColor="White" BorderColor="#CCCCCC" BorderWidth="1px" BorderStyle="None" Height="77px" Width="175px" ID="gvAlerts">
        <Columns>
            <asp:TemplateField HeaderText="AlertID" SortExpression="AlertId">
                <ItemTemplate>
                    <asp:Label ID="lblAlertID" runat="server" Text='<%# Bind("AlertID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Message" SortExpression="Message">
                <ItemTemplate>
                    <asp:Label ID="lblMessage" runat="server" Text='<%# Bind("Message") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Date" SortExpression="date">
                <ItemTemplate>
                    <asp:Label ID="lblDate" runat="server" Text='<%# Bind("Date") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ButtonType="Button" ShowDeleteButton="True" ShowHeader="True" />
            <asp:TemplateField HeaderText="CPID" SortExpression="CPID" Visible="False">
                <ItemTemplate>
                    <asp:Label ID="lblCPID" runat="server"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#000066"></FooterStyle>
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White"></HeaderStyle>
        <PagerStyle HorizontalAlign="Left" BackColor="White" ForeColor="#000066"></PagerStyle>
        <RowStyle ForeColor="#000066"></RowStyle>
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White"></SelectedRowStyle>
        <SortedAscendingCellStyle BackColor="#F1F1F1">
        </SortedAscendingCellStyle>
        <SortedAscendingHeaderStyle BackColor="#007DBB">
        </SortedAscendingHeaderStyle>
        <SortedDescendingCellStyle BackColor="#CAC9C9">
        </SortedDescendingCellStyle>
        <SortedDescendingHeaderStyle BackColor="#00547E">
        </SortedDescendingHeaderStyle>
    </asp:GridView>
</asp:Content>
