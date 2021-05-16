<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master Pages/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="AdminAddEvent.aspx.cs" Inherits="Student_Tracking_System.Pages.Department_Admin_Pages.AdminAddEvent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container admin-add-event">
        <div class="section">
            <table class="table profile-table">
                <tbody>
                    <tr>
                        <td>
                            <asp:Image ID="imgUploadEvent" runat="server" class="imgUploadEvent" />
                        </td>
                        <td>
                            <asp:FileUpload ID="fuEventImgUpload" runat="server" />
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
                            <asp:TextBox ID="txtUploadEventDetails" runat="server" TextMode="MultiLine" Rows="10" class="form-control"></asp:TextBox>
                        </td>
                    </tr>
                </tbody>
            </table>
            <asp:Button ID="btnSubmitEventDetails" runat="server" Text="Submit" class="" OnClick="btnSubmitEventDetails_Click" data-toggle="modal" data-target="#myModal" />
        </div>
    </div>
    <div class="modal front-modal" id="myModal">
        <div class="modal-dialog modal-dialog-centered">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                </div>
                <div class="modal-body">
                    <%--<asp:RequiredFieldValidator ID="rvSearchEvent" runat="server" ErrorMessage="Please enter Event Name, Date or Venue" ControlToValidate="txtSearch"></asp:RequiredFieldValidator><br />--%>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn-danger" data-dismiss="modal">OK</button>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
