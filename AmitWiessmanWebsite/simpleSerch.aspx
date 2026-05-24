<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="simpleSerch.aspx.cs" Inherits="simpleSerch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   
     <form name="formPage"
     method="post"
     runat="server"
   >

    שם השיר:
     <input type="text"
         name="songName"
         id="songName"
         placeholder="example"
         required />
            <input id="Submit1"
        type="submit"
        value="שלח" />

</form>
        <%= st %>

</asp:Content>

