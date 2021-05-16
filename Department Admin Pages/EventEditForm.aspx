<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master Pages/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="EventEditForm.aspx.cs" Inherits="Student_Tracking_System.Pages.Department_Admin_Pages.EventEditForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container student-details">
        <div class="profile-details">
            <div class="section">
                <table class="table profile-table">
                    <tbody>
                        <tr>
                            <th>
                                <asp:Image ID="imgEditImage" runat="server" class="updateEventImg" />
                            </th>
                            <td>
                                <asp:FileUpload ID="fuUpdateEventImg" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <th>Event Name :</th>
                            <td>
                                <asp:TextBox ID="txtUploadEventName" runat="server" class="form-control"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <th>Event Date :</th>
                            <td>
                                <asp:TextBox ID="txtUploadEventDate" runat="server" class="form-control" TextMode="Date"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <th>Event Venue :</th>
                            <td>
                                <asp:TextBox ID="txtUploadEventVenue" runat="server" class="form-control"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <th>Event Details :</th>
                            <td>
                                <asp:TextBox ID="txtUploadEventDetails" runat="server" class="form-control" TextMode="MultiLine" Rows="10"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td><asp:Button ID="btnUpdateEventDetails" runat="server" Text="Submit" class="btn" OnClick="btnUpdateEventDetails_Click" /></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
