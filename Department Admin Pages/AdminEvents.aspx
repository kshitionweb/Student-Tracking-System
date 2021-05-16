<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master Pages/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="AdminEvents.aspx.cs" Inherits="Student_Tracking_System.Pages.Admin_Pages.AdminAnnouncements" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="student-list">
        <div class="student-search">
            <asp:DropDownList ID="ddlEventSearch" runat="server" class="form-control">
                <asp:ListItem Selected="True" Value="event_name">Event Name</asp:ListItem>
                <asp:ListItem Value="date_of_event">Event Date</asp:ListItem>
                <asp:ListItem Value="event_venue">Event Venue</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="txtSearch" runat="server" class="form-control light-table-filter" placeholder="Enter Event Name, Date or Venue" />
            <asp:Button ID="btnSearchEvent" runat="server" Text="Search" class="form-control btnStudentSearch" OnClick="btnSearchEvent_Click" data-toggle="modal" data-target="#myModal" />
        </div>
        <div class="student-search-content">
            <asp:GridView ID="gridEventList" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" OnPageIndexChanging="OnPaging" OnSelectedIndexChanged="girdEventList_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:ImageField DataImageUrlField="event_image_name" ControlStyle-Height="200" ControlStyle-Width="150">
                    </asp:ImageField>
                    <asp:BoundField DataField="event_name" HeaderText="Event Name" SortExpression="event_name" />
                    <asp:BoundField DataField="date_of_event" HeaderText="Date of Event" SortExpression="date_of_event" />
                    <asp:BoundField DataField="event_venue" HeaderText="Event Venue" SortExpression="event_venue" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
    <div class="modal front-modal" id="myModal">
        <div class="modal-dialog modal-dialog-centered">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                </div>
                <div class="modal-body">
                    <asp:RequiredFieldValidator ID="rvSearchEvent" runat="server" ErrorMessage="Please enter Event Name, Date or Venue" ControlToValidate="txtSearch"></asp:RequiredFieldValidator><br />
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn-danger" data-dismiss="modal">OK</button>
                </div>
            </div>
        </div>
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [event_name], [date_of_event], [event_venue], [event_image_name] FROM [Event_Table]"></asp:SqlDataSource>
</asp:Content>
