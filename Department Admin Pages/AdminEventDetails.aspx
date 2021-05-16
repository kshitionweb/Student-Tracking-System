<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master Pages/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="AdminEventDetails.aspx.cs" Inherits="Student_Tracking_System.Pages.Admin_Pages.AdminAnnouncementDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container student-announcements-details">
        <div class="announcements-detail-home">
            <div class="row">
                <div class="col-sm-6">
                    <asp:Image ID="imgEventDetailImage" runat="server" class="img" />
                </div>
                <div class="col-sm-6">
                    <div class="announcements-detail-content">
                        <h2><asp:Label ID="lblEventDetailHeading" runat="server"></asp:Label></h2>
                        <h4>Date : <asp:Label ID="lblEventDate" runat="server"></asp:Label></h4>
                        <h4>Venue : <asp:Label ID="lblEventVenue" runat="server"></asp:Label></h4>
                        <p>Details : <asp:Label ID="lblEventDetails" runat="server"></asp:Label></p>
                        <div class="announcement-details-btn">
                            <asp:Button ID="btnEventDelete" runat="server" Text="Delete" class="btn" OnClick="btnEventDelete_Click" />
                            <asp:Button ID="btnEventUpdate" runat="server" Text="Update" class="btn" OnClick="btnEventUpdate_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
