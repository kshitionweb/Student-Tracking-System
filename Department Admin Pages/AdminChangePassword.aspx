<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master Pages/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="AdminChangePassword.aspx.cs" Inherits="Student_Tracking_System.Pages.Admin_Pages.AdminChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="change-password">
        <div class="card-header">
            <h2>Change Your Password</h2>
        </div>
        <div class="card-body">
            <div class="form-group">
                <label for="inputPasswordOld">Current Password</label>
                <asp:TextBox ID="txtAdminPwd" runat="server" TextMode="Password" class="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="inputPasswordNew">New Password</label>
                <asp:TextBox ID="txtAdminNewPwd" runat="server" TextMode="Password" class="form-control"></asp:TextBox>
                <span class="form-text small text-muted">The password must be 8-20 characters, and must <em>NOT</em> contain spaces.
                </span>
            </div>
            <div class="form-group">
                <label for="inputPasswordNewVerify">Verify</label>
                <asp:TextBox ID="txtAdminConPwd" runat="server" TextMode="Password" class="form-control"></asp:TextBox>
                <span class="form-text small text-muted">To confirm, type the new password again.
                </span>
            </div>
            <div class="form-group">
                <button type="button" class="btn" data-toggle="modal" data-target="#myModal">Save</button>
            </div>
        </div>
    </div>
   <div class="modal" id="myModal">
  <div class="modal-dialog modal-dialog-centered">
    <div class="modal-content">
      <div class="modal-header">
        <h3 class="modal-title">Please enter the following information.</h3>
        <button type="button" class="close" data-dismiss="modal">&times;</button>
      </div>
      <div class="modal-body">
          <asp:Label ID="Label1" runat="server">Enter your mother's maiden name</asp:Label>
          <asp:TextBox ID="txtAdminSecAns" runat="server"></asp:TextBox>
      </div>
      <div class="modal-footer">
          <asp:Button ID="btnAdminChangePwd" runat="server" Text="Submit" class="btn-primary" OnClick="btnAdminChangePwd_Click"/>
        <button type="button" class="btn-danger" data-dismiss="modal">Close</button>
      </div>
    </div>
  </div>
</div>
</asp:Content>
