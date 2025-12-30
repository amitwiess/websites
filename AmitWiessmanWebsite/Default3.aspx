<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <h1 style="text-align:center;">דף הרשמה</h1>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
        <form runat="server" method="post" >
  <label for="שם פרטי">שם פרטי:</label><br>
  <input type="text" id="שם פרטי" name="שם פרטי"><br>
  <label for="שם משפחה">Last name:</label><br>
  <input type="text" id="lname" name="שם משפחה">
</form>
   
</asp:Content>

