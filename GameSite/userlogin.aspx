<%@ Page Title="" Language="C#" MasterPageFile="~/Website.Master" AutoEventWireup="true" CodeBehind="userlogin.aspx.cs" Inherits="GameSite.userlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="card">
                        <div class="card-body">
                            <div class="row">
                                <div class="col">
                                    <center>
                                        <img width="150px" src="images/user.png" />
                                    <center>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <center>
                                        <h3>
                                            User Login
                                        </h3>
                                    <center>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <center>
                                        <hr>
                                    <center>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <label>User ID</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="User ID"></asp:TextBox>
                                    </div>
                                </div>
                                <label>Password</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                                    </div>
                                <div class="form-group">
                                    <asp:Button class="btn btn-success w-100 btn-lg" ID="Button1" runat="server" Text="Login" OnClick="LoginButton_Click"/>
                                </div>
                                <div class="form-group" style="margin-top:10px;">
                                    <a href="usersignup.aspx">
                                        <input class="btn btn-info w-100 btn-lg" ID ="Button2" type="button" value="Sign Up" />
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                    
                </div>
                <a href="homepage.aspx">Back to Home</a> <br><br>
            </div>
        </div>
    </div>

</asp:Content>
