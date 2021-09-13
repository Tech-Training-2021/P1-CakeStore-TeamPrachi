<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="loginpage.aspx.cs" Inherits="CakeStoreWebApplication.loginpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img src="Images/login.jpg" width="300"/>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3> Login </h3>
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
                            <div class="col">
                                <label> Enter User Name </label>
                                <div class="form-group">
                                    <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" placeholder="UserName"></asp:TextBox>
                                </div>
                                <label> Enter Password </label>
                                <div class="form-group">
                                    <asp:TextBox ID="TextBox2" TextMode="Password" CssClass="form-control" runat="server" placeholder="Password"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:Button class="btn btn-primary btn-block" ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
                                </div>
                                <div class="form-group">
                                    <a href="signupPage.aspx"><input class="btn btn-info btn-block" id="Button2" type="button" value="Sign Up" /></a>
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
