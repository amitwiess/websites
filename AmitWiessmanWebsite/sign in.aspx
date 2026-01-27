<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="sign in.aspx.cs" Inherits="Default4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 <h1  style="text-align:center;"> דף כניסה</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
           <form name="formPage" method="post" runat="server">
       
        <br />
           מייל: <input type="text" name="email" id="email" placeholder="example">
<br />
           סיסמה: <input type="text" name="pass" id="pass" placeholder="example">
<br />
        

        <br />
        <input id="Submit1" type="submit" value="שלח" />
    </form>
    <br />
 
</asp:Content>
