<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="manager.aspx.cs" Inherits="Default9" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <h1  style="text-align:center;"> דף מנהל</h1>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    
    <form method="post" runat="Server">

       
        <label for="fname">:שם פרטי</label><br>
        <input type="text" id="fname" name="fname"><br>

       

        <input type="submit" value="Submit">

        <br /><br />

       

    </form>
    <%= st %>
</asp:Content>