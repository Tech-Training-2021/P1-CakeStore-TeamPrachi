<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="signupPage.aspx.cs" Inherits="CakeStoreWebApplication.signupPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-8 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img src="Images/signup.png" width="200" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4> Sign Up </h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <hr />
                                </center>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-6">
                                <label> Full Name </label>
                                <div class="form-group">
                                    <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" placeholder="full name"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label> Date of Birth </label>
                                <div class="form-group">
                                    <asp:TextBox ID="TextBox2" TextMode="Date" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-6">
                                <label> Contact Number </label>
                                <div class="form-group">
                                    <asp:TextBox ID="TextBox3" TextMode="Number" CssClass="form-control" runat="server" placeholder="contact no"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label> Email ID </label>
                                <div class="form-group">
                                    <asp:TextBox ID="TextBox4" TextMode="Email" CssClass="form-control" runat="server" placeholder="Email ID"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-4">
                                <label> State </label>
                                <div class="form-group">
                                    <asp:DropDownList ID="DropDownList1" class="form-control" runat="server">
                                        <asp:ListItem Text="Select" Value="select"></asp:ListItem>
                                        <asp:ListItem Text="Mahrashtra" Value="Mahrashtra"></asp:ListItem>
                                    </asp:DropDownList>      
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label> City </label>
                                <div class="form-group">
                                    <asp:TextBox ID="TextBox6" class="form-control" runat="server" placeholder="city"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label> Pincode </label>
                                <div class="form-group">
                                    <asp:TextBox ID="TextBox7" TextMode="Number" class="form-control" runat="server" placeholder="pincode"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <label> Full Address </label>
                                <div class="form-group">
                                    <asp:TextBox ID="TextBox5" TextMode="MultiLine" Rows="2" CssClass="form-control" runat="server" placeholder="full address"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <center>
                                    <span class="badge rounded-pill bg-info text-dark">Login Credentials</span>
                                </center>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-6">
                                <label> User Name </label>
                                <div class="form-group">
                                    <asp:TextBox ID="TextBox8" CssClass="form-control" runat="server" placeholder="UserName"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label> Password </label>
                                <div class="form-group">
                                    <asp:TextBox ID="TextBox9" TextMode="Password" CssClass="form-control" runat="server" placeholder="Password"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <asp:Button ID="Button1" class="btn btn-info btn-block" runat="server" Text="Sign Up" OnClick="Button1_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <a href="homepage.aspx"> << Back to Home </a><br /><br />

            </div>
        </div>
    </div>

</asp:Content>
