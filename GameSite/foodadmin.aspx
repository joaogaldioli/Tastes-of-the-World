<%@ Page Title="" Language="C#" MasterPageFile="~/Website.Master" AutoEventWireup="true" CodeBehind="foodadmin.aspx.cs" Inherits="GameSite.foodadmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
      $(document).ready(function () {
          $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
      });
   </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
      <div class="row">
         <div class="col-md-6">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Food Details</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <img width="100px" src="images/order.jpg" />
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <asp:FileUpload class="form-control" ID="FileUpload1" runat="server" />
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-5">
                        <label>Food ID</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Food ID"></asp:TextBox>
                              <asp:LinkButton class="btn btn-primary" ID="LinkButton4" runat="server" OnClick="Button4_Click"><i class="fas fa-check-circle"></i></asp:LinkButton>
                           </div>
                        </div>
                     </div>
                     <div class="col-md-7">
                        <label>Food Name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Food Name"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-8">
                        <label>Restaurant Name</label>
                        <div class="form-group">
                           <asp:DropDownList class="form-control" ID="DropDownList1" runat="server">
                              <asp:ListItem Text="Publisher 1" Value="Publisher 1" />
                              <asp:ListItem Text="Publisher 2" Value="Publisher 2" />
                           </asp:DropDownList>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>Food Cost</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox8" runat="server" placeholder="Food Cost" TextMode="Number"></asp:TextBox>
                        </div>
                        </div>
                  </div>
                  <div class="row">  
                      <div class="col-md-12">
                        <label>Date Added</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Date Added" TextMode="Date"></asp:TextBox>
                            </div>
                        </div>
                  </div>
                  <div class="row">
                     <div class="col-md-12">
                        <label>Cuisine</label>
                        <div class="form-group">
                           <asp:ListBox CssClass="form-control" ID="ListBox1" runat="server" SelectionMode="Multiple" Rows="6">
                              <asp:ListItem Text="Afghan" Value="Afghan" />
                              <asp:ListItem Text="Brazilian" Value="Brazilian" />
                              <asp:ListItem Text="Chinese" Value="Chinese" />
                              <asp:ListItem Text="Ethiopian" Value="Ethiopian" />
                              <asp:ListItem Text="French" Value="French" />
                              <asp:ListItem Text="German" Value="German" />
                              <asp:ListItem Text="Greek" Value="Greek" />
                              <asp:ListItem Text="Indian" Value="Indian" />
                              <asp:ListItem Text="Indonesian" Value="Indonesian" />
                              <asp:ListItem Text="Italian" Value="Italian" />
                              <asp:ListItem Text="Jamaican" Value="Jamaican" />
                              <asp:ListItem Text="Japanese" Value="Japanese" />
                              <asp:ListItem Text="Korean" Value="Korean" />
                              <asp:ListItem Text="Lebanese" Value="Lebanese" />
                              <asp:ListItem Text="Malaysian" Value="Malaysian" />
                              <asp:ListItem Text="Mexican" Value="Mexican" />
                              <asp:ListItem Text="Micronesian" Value="Micronesian" />
                              <asp:ListItem Text="Mongolian" Value="Mongolian" />
                              <asp:ListItem Text="Moroccan" Value="Moroccan" />
                              <asp:ListItem Text="Nigerian" Value="Nigerian" />
                              <asp:ListItem Text="Polish" Value="Polish" />
                              <asp:ListItem Text="Portuguese" Value="Portuguese" />
                              <asp:ListItem Text="Russian" Value="Russian" />
                              <asp:ListItem Text="Spanish" Value="Spanish" />
                              <asp:ListItem Text="Swedish" Value="Swedish" />
                              <asp:ListItem Text="Turkish" Value="Turkish" />
                              <asp:ListItem Text="Vietnamese" Value="Vietnamese" />
                           </asp:ListBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-12">
                        <label>Food Description</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" placeholder="Food Description" TextMode="MultiLine" Rows="3"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-4">
                        <asp:Button ID="Button1" class="btn btn-lg w-100 btn-success" runat="server" OnClick="Button1_Click" Text="Add" />
                     </div>
                     <div class="col-4">
                        <asp:Button ID="Button3" class="btn btn-lg w-100 btn-warning" runat="server" OnClick="Button3_Click" Text="Update" />
                     </div>
                     <div class="col-4">
                        <asp:Button ID="Button2" class="btn btn-lg w-100 btn-danger" runat="server" OnClick="Button2_Click" Text="Delete" />
                     </div>
                  </div>
               </div>
            </div>
            <a href="homepage.aspx"><< Back to Home</a><br>
            <br>
         </div>
         <div class="col-md-6">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Food Inventory List</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:tastesoftheworldDBConnectionString %>" SelectCommand="SELECT * FROM [food_admin_tbl]"></asp:SqlDataSource>
                     <div class="col">
                        <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="food_id" DataSourceID="SqlDataSource1">
                            <Columns>
                                <asp:BoundField DataField="food_id" HeaderText="Food ID" ReadOnly="True" SortExpression="food_id" />
                                <asp:BoundField DataField="food_name" HeaderText="Food Name" SortExpression="food_name" />
                                <asp:BoundField DataField="restaurant_name" HeaderText="Restaurant Name" SortExpression="restaurant_name" />
                                <asp:BoundField DataField="food_cost" HeaderText="Food Cost" SortExpression="food_cost" />
                            </Columns>
                         </asp:GridView>
                     </div>
                  </div>
               </div>
            </div>
         </div>
        </div>
</asp:Content>
