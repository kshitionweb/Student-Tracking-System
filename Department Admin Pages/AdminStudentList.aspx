<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master Pages/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="AdminStudentList.aspx.cs" Inherits="Student_Tracking_System.Pages.Admin_Pages.AdminStudentList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="student-list">
   <div class="student-search">
            <asp:DropDownList ID="ddlStudentSearch" runat="server" class="form-control">
                <asp:ListItem Selected="True" Value="student_id">Stduent ID</asp:ListItem>
                <asp:ListItem Value="student_first_name">First Name</asp:ListItem>
                <asp:ListItem Value="student_last_name">Last Name</asp:ListItem>
                <asp:ListItem Value="student_email">Email</asp:ListItem>
                <asp:ListItem Value="student_passout_year">Passout Year</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="txtSearch" runat="server" class="form-control light-table-filter" placeholder="Enter Student Name, Student Number or Passout Year" />
            <asp:Button ID="btnSearchStudent" runat="server" Text="Search" class="form-control btnStudentSearch" OnClick="btnSearchStudent_Click" />
        </div>
        <div class="student-search-content">
            <asp:GridView ID="gvStudentSearch" runat="server" AutoGenerateColumns="False" DataKeyNames="student_id" AllowPaging="True" OnPageIndexChanging="OnPaging" OnSelectedIndexChanged="gvStudentSearch_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" SelectText="Show Details" />
                    <asp:BoundField DataField="student_id" HeaderText="Student ID" ReadOnly="True" SortExpression="student_id" />
                    <asp:BoundField DataField="student_first_name" HeaderText="First Name" SortExpression="student_first_name" />
                    <asp:BoundField DataField="student_last_name" HeaderText="Last Name" SortExpression="student_last_name" />
                    <asp:BoundField DataField="student_email" HeaderText="Email" SortExpression="student_email" />
                    <asp:BoundField DataField="student_passout_year" HeaderText="Passout Year" SortExpression="student_passout_year" />
                </Columns>
            </asp:GridView>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [student_id], [student_first_name], [student_email], [student_passout_year], [student_last_name] FROM [Student_Table]"></asp:SqlDataSource>
    </div>
</asp:Content>
