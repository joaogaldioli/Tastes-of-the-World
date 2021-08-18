﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Website.Master" AutoEventWireup="true" CodeBehind="usersignup.aspx.cs" Inherits="GameSite.usersignup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-8 mx-auto">
                <div class="card">
                    <div class="card">
                        <div class="card-body">
                            <div class="row">
                                <div class="col">
                                    <center>
                                        <img width="100px" src="images/user.png" />
                                    <center>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <center>
                                        <h4>
                                            User Sign Up
                                        </h4>
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
                                <div class="col-md-6">
                                   <label>Full Name</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Full Name"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="col-md-6">
                                   <label>Date of Birth</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Password" TextMode="Date"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-6">
                                   <label>Phone Number</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Phone Number" TextMode="Phone"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="col-md-6">
                                   <label>Email</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Email" TextMode="Email"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-4">
                                   <label>Province</label>
                                    <asp:DropDownList class="form-control" ID="DropDownList1" runat="server">
                                    <asp:ListItem Text="Province" Value="Province" />
                                    <asp:ListItem Text="Alberta" Value="Alberta" />
                                    <asp:ListItem Text="British Columbia" Value="British Columbia" />
                                    <asp:ListItem Text="Manitoba" Value="Manitoba" />
                                    <asp:ListItem Text="New Brunswick" Value="New Brunswick" />
                                    <asp:ListItem Text="Newfoundland and Labrador" Value="Newfoundland and Labrador" />
                                    <asp:ListItem Text="Northwest Territories" Value="Northwest Territories" />
                                    <asp:ListItem Text="Nova Scotia" Value="Nova Scotia" />
                                    <asp:ListItem Text="Nunavut" Value="Nunavut" />
                                    <asp:ListItem Text="Ontario" Value="Ontario" />
                                    <asp:ListItem Text="Prince Edward Island" Value="Prince Edward Island" />
                                    <asp:ListItem Text="Quebec" Value="Quebec" />
                                    <asp:ListItem Text="Saskatchewan" Value="Saskatchewan" />
                                    <asp:ListItem Text="Yukon" Value="Yukon" />
                           </asp:DropDownList>
                                </div>

                                <div class="col-md-4">
                                   <label>City</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" placeholder="City" TextMode="SingleLine"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="col-md-4">
                                   <label>Postal Code</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox7" runat="server" placeholder="Zip Code" TextMode="SingleLine"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                   <label>Address</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="Address" TextMode="SingleLine"></asp:TextBox>
                                    </div>
                                </div>
                            </div>

                            <div class="row" style="margin-top:30px;">
                                <div class="col-md-6">
                                   <label>User ID</label>
                                    <div class="form-group">
                                        <asp:TextBox class="form-control" ID="TextBox8" runat="server" placeholder="User ID"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="col-md-6">
                                   <label>Password</label>
                                    <div class="form-group">
                                        <asp:TextBox class="form-control" ID="TextBox9" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                                    </div>
                                </div>
                            </div>

                            <div class="row" style="margin-top: 10px;">
                                <div class="col">
                                    
                                </div>
                                
                                <div class="form-group">
                                    <asp:Button class="btn btn-success w-100 btn-lg" ID="Button1" runat="server" Text="Sign Up" OnClick="Button1_Click"/>
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
