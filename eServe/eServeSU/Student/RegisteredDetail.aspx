<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master"  CodeBehind="RegisteredDetail.aspx.cs" Inherits="eServeSU.RegisteredDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">        
        <asp:Label ID="lblOpportunityName" runat="server" Text="" Font-Bold="true"></asp:Label>
    </div>
    <!--<asp:Label ID="lblTimeSheetInstructions1" runat="server" Text="Timesheet instructions:" Font-Bold="true"></asp:Label>-->
    <br/>    
    <!--<br/>-->
    <asp:Label ID="lblTimeSheetInstructions3" runat="server" Text="Enter the number of hours you worked. " Font-Bold="true"></asp:Label>
    <!--<br/>--><br/>
    <asp:Label ID="lblTimeSheetInstructions4" runat="server" Text="Please round to the nearest quarter hours." Font-Bold="true"></asp:Label>
    <!--<br/>--><br/>
    <asp:Label ID="lblTimeSheetInstructions5" runat="server" Text="For example: If you worked an hour and twenty minutes, you would enter 1.25. " Font-Bold="true"></asp:Label>
    <!--<br/>--><br/>
    <asp:Label ID="lblTimeSheetInstructions6" runat="server" Text="Do not include your travel time." Font-Bold="true"></asp:Label>
    <!--<br/>--><br/>
    <asp:Label ID="lblTimeSheetInstructions7" runat="server" Text="If you make a mistake, you may re-enter hours for any particular date. " Font-Bold="true"></asp:Label>
    <br/>
   <div class="glyphicon-sort-by-alphabet">
        <br /><br />            
            <asp:Label ID="lblDateVolunteeredInput" runat="server" Text="Date:" Font-Bold="true"></asp:Label>
            <asp:TextBox ID="tboxDateVolunteered" runat="server" AutoPostBack="false" ></asp:TextBox>       
            <asp:Label ID="lblTimeSheetInstructions2" runat="server" Text="Enter the date in mm/dd/yyyy format." Font-Bold="true"></asp:Label>   
            <br/><br/>      
            <asp:Label ID="lblHour" runat="server" Text="Hour(s) volunteered:" Font-Bold="true"></asp:Label>
            <asp:TextBox ID="tboxHoursVolunteered" runat="server" AutoPostBack="false" ></asp:TextBox>                
            <br/><br/>
            <asp:Button ID="btnSubmitHours" runat="server" Text="Submit" Enabled="true" Font-Bold="true" OnClick="btnSubmitHours_Click" AutoPostBack="true"/>
            <asp:Label ID="lblTimeEntryWarning" runat="server" Font-Bold="true" ForeColor ="Red" Text=""></asp:Label>
        <br/><br/>      
       <asp:Label ID="lblTimeSheetInstructions8" runat="server" Text="Site Supervisors will compare this timesheet to their on-site records before approving your hours. It is your responsibility to record your hours accurately. " Font-Bold="true"></asp:Label> 
        <asp:GridView ID="gvTimeEntry" runat="server" AutoGenerateColumns="False"
            ShowFooter="True" CssClass="Grid"
            OnRowUpdating="gvTimeEntry_RowUpdating"
            OnRowEditing="gvTimeEntry_RowEditing"
            OnRowCancelingEdit="gvTimeEntry_RowCancelingEdit">
            <Columns>
                <asp:TemplateField HeaderText="Date Volunteered" SortExpression="Name">
                    <ItemTemplate>
                        <asp:Label ID="lblDateVolunteered" runat="server" Text='<%# Bind("WorkDate") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Hour(s)" SortExpression="Supervisor">
                    <ItemTemplate>
                        <asp:Label ID="lblHoursSubmitted" runat="server" Text='<%# Bind("HoursVolunteered") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>           
    </div>
        <br/><br/>      
            <asp:Label ID="lblEvaluationInstruction" runat="server" Text="At the end of the quarter, please complete the Evaluation.  This is an opportunity for you to provide useful, constructive feedback for your Site Supervisor. Note that evaluations are not anonymous." Font-Bold="true"></asp:Label>
            <br/>  
            <!--<asp:Label ID="lblStudentEvaluation" runat="server" Text="Evaluation:" Font-Bold="true"></asp:Label>            -->
            <asp:Button ID="btnSubmitEvaluation" runat="server" Text="Evaluate Opportunity" Enabled="true" Font-Bold="true" OnClick="btnSubmitEvaluation_Click" />          
        <br/><br/>            
            <asp:Label ID="lblReflectionInstruction" runat="server" Text="Community Partners are also interested in your reflections! Please feel free to submit a reflection on your experience here. Reflections are not anonymous but will be treated as confidential. " Font-Bold="true"></asp:Label>
            <br/>  
            <!--<asp:Label ID="lblStudentReflection" runat="server" Text="Reflection:" Font-Bold="true"></asp:Label>            -->
            <asp:Button ID="btnSubmitReflection" runat="server" Text="Write Reflection" Enabled="true" Font-Bold="true" OnClick="btnSubmitReflection_Click" />          
        <br/><br/>
</asp:Content>