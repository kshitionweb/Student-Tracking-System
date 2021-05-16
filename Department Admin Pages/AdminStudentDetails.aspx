<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master Pages/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="AdminStudentDetails.aspx.cs" Inherits="Student_Tracking_System.Pages.Department_Admin_Pages.AdminStudentDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container student-details">
        <div class="profile-details">
            <div class="section">
                <div class="row">
                    <div class="col-md-4">
                        <asp:Image ID="Image1" runat="server" src="https://library.kissclipart.com/20191007/cfw/kissclipart-kids-avatars-icon-girl-icon-75f146e762baddc8.png" />
                    </div>
                    <div class="col-md-8">
                        <table class="table profile-table">
                            <tbody>
                                <tr>
                                    <th>Student Number</th>
                                    <td><asp:Label ID="lblStudent_id" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <th>First Name</th>
                                    <td><asp:Label ID="lblStudent_first_name" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <th>Last Name</th>
                                    <td><asp:Label ID="lblStudent_last_name" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <th>Email</th>
                                    <td><asp:Label ID="lblStudent_email" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <th>Contact Number</th>
                                    <td><asp:Label ID="lblStudent_contact" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <th>Date of Birth</th>
                                    <td>18/06/1996</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            <div class="section">
                <table class="table profile-table">
                    <tbody>
                        <tr>
                            <th>Course Studied :</th>
                            <td>Master of Applied Science in Computer Science</td>
                        </tr>
                        <tr>
                            <th>Study Period :</th>
                            <td>From 2019 to 2020</td>
                        </tr>
                        <tr>
                            <th>Further Education :</th>
                            <td>No</td>
                        </tr>
                        <tr>
                            <th>Nationality :</th>
                            <td>Indian</td>
                        </tr>
                        <tr>
                            <th>Staying in (State) :</th>
                            <td>Nova Scotia</td>
                        </tr>
                        <tr>
                            <th>Staying in (City) :</th>
                            <td>Antigonish</td>
                        </tr>
                        <tr>
                            <th>Working At :</th>
                            <td>Walmart</td>
                        </tr>
                        <tr>
                            <th>Job Type :</th>
                            <td>Cashier</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
