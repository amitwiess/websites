<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="manager.aspx.cs" Inherits="Default9" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    
    <form method="post" runat="Server">

        <h1>מנהל</h1>
       
        <label for="fname">:שם פרטי</label><br>
        <input type="text" id="fname" name="fname"><br>

       

        <input type="submit" value="Submit">

        <br /><br />

       

    </form>
    <%= st %>
</asp:Content>