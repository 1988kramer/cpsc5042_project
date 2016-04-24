<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FacultyOppDetail.aspx.cs" Inherits="eServeSU.FacultyOppDetail" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2>Opportunity Detail</h2>
    </div>
    <div class="glyphicon-sort-by-alphabet">
        <div>
            <div class="col-xs-3">
                <asp:Label ID="lblName" runat="server" Text="Opportunity Name: "></asp:Label></div>
            <div class="col-xs-9">
                <asp:TextBox ID="tbName" runat="server" Text="" MaxLength="50" Width="500"></asp:TextBox></div>
        </div>
        <br />
        <div>
            <div class="col-xs-3">
                <asp:Label ID="lblLocation" runat="server" Text="Location: "></asp:Label></div>
            <div class="col-xs-9">
                <asp:TextBox ID="tbThisLocation" runat="server" Text="" MaxLength="50" Width="700" CssClass=""></asp:TextBox></div>
        </div>
        <br />
        <div>
            <div class="col-xs-3">
                <asp:Label ID="lblType" runat="server" Text="Opportunity Type: "></asp:Label></div>
            <div class="col-xs-9">
                <asp:DropDownList ID="ddlType" runat="server"></asp:DropDownList></div>
        </div>
        <br />
        <div>
            <div class="col-xs-3">
                <asp:Label ID="lblTime" runat="server" Text="Time Commitment: "></asp:Label></div>
            <div class="col-xs-9">
                <asp:DropDownList runat="server" ID="ddlTimeCommitment">
                    <asp:ListItem Text="1 quarter" Value="1 quarter" />
                    <asp:ListItem Text="2 quarters" Value="2 quarters" />
                    <asp:ListItem Text="3 quarters" Value="3 quarters" />
                </asp:DropDownList>
            </div>
        </div>
        <br />
        <div>
            <div class="col-xs-3">
                <asp:Label ID="lblJobHours" runat="server" Text="Hours required per quarter: "></asp:Label></div>
            <div class="col-xs-9">
                <asp:TextBox ID="tbJobHours" runat="server" Text=""></asp:TextBox></div>
        </div>
        <br />
        <div>
            <div class="col-xs-3">
                <asp:Label ID="lblSlot" runat="server" Text="No. of Slots: "></asp:Label></div>
            <div class="col-xs-9">
                <asp:TextBox ID="tbSlot" runat="server" Text=""></asp:TextBox></div>
        </div>
        <br />
        <div>
            <div class="col-xs-3">
                <asp:Label ID="lblSupervisor" runat="server" Text="Site supervisor: "></asp:Label></div>
            <div class="col-xs-9">
                <asp:DropDownList ID="ddlSupervisor" runat="server"></asp:DropDownList></div>
        </div>
        <br />
        <div>
            <div class="col-xs-3">
                <asp:Label ID="lblOriDate" runat="server" Text="Orientation Date Time: "></asp:Label></div>
            <div class="col-xs-9">
                <asp:TextBox ID="tbDate" runat="server" Text=""></asp:TextBox>
                <img src="../Img/calender.png" />
            </div>
        </div>
        <br />
        <div>
            <div class="col-xs-3">
                <asp:Label ID="lblFoucusArea" runat="server" Text="Focus Area"></asp:Label></div>
            <div class="col-xs-9">
                <asp:DropDownList ID="ddlFocusArea" runat="server"></asp:DropDownList></div>
        </div>
        <br />
        <div>
            <div class="col-xs-3">
                <asp:Label ID="lblQuarter" runat="server" Text="Quarter: "></asp:Label></div>
            <div class="col-xs-9">
                <asp:DropDownList ID="ddlQuarter" runat="server"></asp:DropDownList></div>
        </div>
        <br />
        <div>
            <div class="col-xs-3">
                <asp:Label ID="lblDistance" runat="server" Text="Distance From SU: "></asp:Label></div>
            <div class="col-xs-9">
                <asp:TextBox ID="tbDistance" runat="server" Text=""></asp:TextBox>miles</div>
        </div>
        <br />
        <div>
            <div class="col-xs-3">
                <asp:Label ID="lblLink" runat="server" Text="Link to Online App: "></asp:Label></div>
            <div class="col-xs-9">
                <asp:TextBox ID="tbLink" runat="server" Text=""></asp:TextBox></div>
        </div>
        <br />
        <div>
            <div class="col-xs-3">
                <asp:Label ID="lblRequirementAge" runat="server" Text="Minimul Age: " ></asp:Label></div>
            <div class="col-xs-9">
                <asp:TextBox ID="tbRequirementAge" runat="server" Text=""></asp:TextBox></div>
            </div>
        <br>
        <div>
            <div class="col-xs-3">
                <asp:Label ID="lblRequirementCRC" runat="server" Text="Criminal record check required? "></asp:Label></div>
            <div class="col-xs-9">
                <asp:RadioButtonList runat="server" ID="rblCRC" RepeatDirection="Horizontal">
                    <asp:ListItem Selected="true">Yes</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                </asp:RadioButtonList>
            </div>
        </div>
        <br />
        <div>
            <div class="col-xs-3">
                <asp:Label ID="lblRequirementResume" runat="server" Text="Resume required? " ></asp:Label></div>
            <div class="col-xs-9">
                <asp:RadioButtonList runat="server" ID="rblResume" RepeatDirection="Horizontal">
                    <asp:ListItem Selected="true">Yes</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                </asp:RadioButtonList>
            </div>
        </div>
        <br />
        <div>
            <div class="col-xs-3">
                <asp:Label ID="lblRequirementOther" runat="server" Text="Other Requirements: " TextMode="MultiLine" Height="100"></asp:Label></div>
            <div class="col-xs-9M">
                <asp:TextBox ID="tbRequirement" runat="server" Text="" TextMode="MultiLine" Width="1000" Height="100"></asp:TextBox>
            </div>
        </div>
        <br />
        <div>
            <div class="col-xs-3">
                <asp:Label ID="lblJobDescription" runat="server" Text="Opportunity Description: " TextMode="MultiLine" Height="100"></asp:Label></div>
            <div class="col-xs-9M">
                <asp:TextBox ID="tbJobDescription" runat="server" Text="" TextMode="MultiLine" Width="2000" Height="100"></asp:TextBox></div>
        </div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </div>
    <br>
    <br>
    <br>
    <br>
</asp:Content>
