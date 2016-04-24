<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Opportunity.aspx.cs" Inherits="eServeSU.Opportunity_Opportunity" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script src="../Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
    <script src="../Scripts/jquery.dynDateTime.min.js" type="text/javascript"></script>
    <script src="../Scripts/calendar-en.min.js" type="text/javascript"></script>
    <link href="../Content/calendar-blue.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        $(document).ready(function () {
            $("#<%=tbDate.ClientID %>").dynDateTime({
                showsTime: true,
                ifFormat: "%m/%d/%Y %H:%M",
                daFormat: "%l;%M %p, %e %m,  %Y",
                align: "BR",
                electric: false,
                singleClick: false,
                displayArea: ".siblings('.dtcDisplayArea')",
                button: ".next()"
            });
        });
    </script>

    <div class="jumbotron">
        <h2><asp:Label ID="lblTitle" runat="server" Text="Add Opportunity"></asp:Label></h2>
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
        <div>
            <div class="col-xs-3">
                <asp:Button ID="tbAdd" runat="server" Text="Add Opportunity" OnClick="btnAdd_Click"></asp:Button>
                <asp:Label ID="lblEmpty" runat="server" Text="" Width="2000" TextMode="MultiLine" Height="100"></asp:Label>
            </div>
            <div class="col-xs-9">
            </div>
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
