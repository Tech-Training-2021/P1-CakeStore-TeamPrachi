<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="CakeStoreWebApplication.homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #homeheading{
            font-family:Georgia, 'Times New Roman', Times, serif;
            margin-top: 20px;
            font-size:50px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <section>
        <div class="container">
            <div class="row">
                <div class="col-12">
                        <img src="Images/cakeshoplabel.jpg" width="300" align="left"/>
                        <h1 align="center" id="homeheading">Cake for you</h1>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-4">
                    <center>
                    <img src="Images/cake3.jpg" width="300" height="300"/>
                    <h4> Chocolate Cream Layer Cake </h4>
                    <p class="text-justify"> Save room for dessert—this is one you don’t want to miss. 
                         It certainly has its virtues: It’s made with whole-grain flour, 
                         gets topped with fresh fruit, and contains 6g of fiber per serving. 
                        But what makes this cake so spectacular, truly, is how good it tastes.</p>
                    </center>
                </div>
                <div class="col-md-4">
                    <center>
                        <img src="Images/cake2.jpg" width="320" height="300"/>
                        <h4>Pineapple Cake</h4>
                        <p class="text-justify">
                        It is a delicious, elegant and simple choice for any occasion. 
                            Now, you can have spotify songs code printed on the cake and 
                            dedicate song through our signature happy birthday Pineapple 
                            Cake.
                        </p>
                    </center>
                </div>
                <div class="col-md-4">
                    <center>
                        <img src="Images/cake4.jpg" width="300" height="300" />
                        <h4> Black Forest Cake</h4>
                        <p class="text-justify">
                            A classic all-time favourite. A delicious combination of 
                            chocolate cake, cherries and loads of fresh whipped cream 
                            makes up a classic Black forest cake. This is an evergreen 
                                cake that is suitable for all occasions.</p>
                    </center>
                </div>
            </div>
            
        </div>
    </section>
</asp:Content>
