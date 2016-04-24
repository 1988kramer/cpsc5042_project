<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="StudentDashboard.aspx.cs" Inherits="eServeSU.StudentDashboard" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2>Student Dashboard</h2>
        <h3>Welcome Mike!</h3>
    </div>

    <div class="glyphicon-sort-by-alphabet">
    </div>
    <table width="100%" align="center">
        <tr>
            <td>
                <asp:Button Text="Profile" BorderStyle="None" ID="Tab1" CssClass="Initial" runat="server"
                    OnClick="Tab1_Click" />
                <asp:Button Text="Current" BorderStyle="None" ID="Tab2" CssClass="Initial" runat="server"
                    OnClick="Tab2_Click" />
                <asp:Button Text="History" BorderStyle="None" ID="Tab3" CssClass="Initial" runat="server"
                    OnClick="Tab3_Click" />
                <asp:MultiView ID="MainView" runat="server">
                    <asp:View ID="View1" runat="server">
                        <table style="width: 100%; border-width: 1px; border-color: #666; border-style: solid">
                            <tr>
                                <td>
                                    <h3>
                                        <!--<span>View 1 </span>-->
                                    </h3>
                                    <iframe src="StudentProfile.aspx" width="1000" height="1000"></iframe>
                                </td>
                            </tr>
                        </table>
                    </asp:View>
                    <asp:View ID="View2" runat="server">
                        <table style="width: 100%; border-width: 1px; border-color: #666; border-style: solid">
                            <tr>
                                <td>
                                    <!--<h3>View 2</h3>-->
                                    <asp:Button ID="btnSignUp" runat="server" Text="Sign Up" />
                                    <br />
                                    <br />
                                    <iframe src="StudentRegistered.aspx" width="1500" height="500"></iframe>
                                </td>
                            </tr>
                        </table>
                    </asp:View>
                    <asp:View ID="View3" runat="server">
                        <table style="width: 100%; border-width: 1px; border-color: #666; border-style: solid">
                            <tr>
                                <td>
                                    <h3>History of opportunities registered</h3>
                                    <iframe src="StudentHistory.aspx" width="1500" height="500"></iframe>
                                </td>
                            </tr>
                        </table>
                    </asp:View>
                </asp:MultiView>
            </td>
        </tr>
    </table>
</asp:Content>
