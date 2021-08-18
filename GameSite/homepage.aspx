<%@ Page Title="" Language="C#" MasterPageFile="~/Website.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="GameSite.homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <img src="images/website-banner-bg.jpg" class="img-fluid" width="1920" height="1200"/>
    </section>

    <section>
        <div class="container">
            <div class="row">
                <div class="col-12">
                    <center>
                        <h2>
                            Our Services
                        </h2>
                        <p>
                            <b>
                                Our 3 Features
                            </b>
                        </p>
                    <center>
                </div>
            </div>
            <div class="row">
                <div class="col-md-4">
                    <center>
                        <img width="150px" src="images/delivery.jpg" />
                        <h4>Delivery</h4>
                        <p class="text-justify">
                            We deliver everywhere.
                        </p>
                    <center>
                </div>
                <div class="col-md-4">
                    <center>
                        <img width="150px" src="images/order.jpg" />
                        <h4>Order From Your Table</h4>
                        <p class="text-justify">
                            Order from your table.
                        </p>
                    <center>
                </div>
                <div class="col-md-4">
                    <center>
                        <img width="150px" src="images/member.jpg" />
                        <h4>Become a Member for Discounts</h4>
                        <p class="text-justify">
                            Become a member for great discounts.
                        </p>
                    <center>
                </div>
            </div>
        </div>
    </section>
    <section>
        <img src="images/website-bg-bottom.jpg" class="img-fluid" />
   </section>
</asp:Content>
