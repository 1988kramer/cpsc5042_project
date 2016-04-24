<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AdminProfile.aspx.cs" Inherits="eServeSU.AdminProfile" %>

<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<%@ Register TagPrefix="aspdd" Namespace="Saplin.Controls" Assembly="DropDownCheckBoxes" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2>Admin - Opportunity</h2>
    </div>
    <div class="glyphicon-sort-by-alphabet">
        <div>Community Partners and Opportunities : </div>
        <div>
            <asp:GridView ID="gvOpportunityAdmin" runat="server" AutoGenerateColumns="False"
                ShowFooter="True" ShowHeader="True" CssClass="Grid"
                OnRowDataBound="gvOpportunityAdmin_OnRowDataBound">
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
                            <asp:Label ID="lblSupervisor" runat="server" Text='<%# Bind("SupervisorName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Slots" SortExpression="Slots">
                        <ItemTemplate>
                            <asp:Label ID="lblSlots" runat="server" Text='<%# Bind("TotalNumberSlots") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Add Section Courses">
                        <ItemTemplate>
                            <aspdd:DropDownCheckBoxes ID="ddckAddCourseSections" runat="server" UseButtons="True" UseSelectAllNode="True"
                                 AddJQueryReference="True" OnSelectedIndexChanged="checkBoxesAdd_SelcetedIndexChanged" 
                                meta:resourcekey="checkBoxes3Resource1">
                                <Style SelectBoxWidth="" DropDownBoxBoxWidth="" DropDownBoxBoxHeight=""></Style>
                                <Texts OkButton="Add" CancelButton="Cancel" SelectAllNode="ALL" SelectBoxCaption="Add Courses" />
                            </aspdd:DropDownCheckBoxes>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Remove Section Courses">
                        <ItemTemplate>
                            <aspdd:DropDownCheckBoxes ID="ddckRemoveCourseSections" runat="server" UseButtons="True" UseSelectAllNode="True"
                                AddJQueryReference="True" AutoPostBack="False" OnSelectedIndexChanged="checkBoxesRemove_SelcetedIndexChanged"
                                meta:resourcekey="checkBoxes3Resource1">
                                <Style SelectBoxWidth="" DropDownBoxBoxWidth="" DropDownBoxBoxHeight=""></Style>
                                <Texts OkButton="Remove" CancelButton="Cancel" SelectAllNode="ALL" SelectBoxCaption="Remove Courses" />
                            </aspdd:DropDownCheckBoxes>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
        
        <div>Assign opportunity to student : </div>
        
        <asp:DropDownList ID="ddlOtherOpportunity" runat="server"></asp:DropDownList>
        
        Student SU Email:<asp:TextBox ID="tbStudentEmail" runat="server"></asp:TextBox>
        
        <asp:Button ID="btnSign" runat="server" Text=" Sign " OnClick="tbnClick_Assign" />
        
        <asp:Label ID="tbLabel" runat="server" Text=""></asp:Label>

    </div>
</asp:Content>
