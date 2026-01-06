<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <h1 style="text-align:center;">דף הרשמה</h1>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
       <form name="formPage" method="post" runat="server">
        שם פרטי: <input type="text" name="name" id="firstname" placeholder="example">
        <br />
        אפליקציית האזנה מעודפת: 
        <br />
        spotify<input type="radio" name="radio" checked value="spotify" id="check_1"><br />
        Apple music <input type="radio" name="radio" value="Apple music" id="check_2"><br />
        Sound cloud<input type="radio" name="radio" value="Sound cloud" checked id="check_3"><br />
       
         <br />
        סגנון מוזיקה אהוב: 
        <br />
       
        <textarea rows="5" cols="20" name="textarea1" id="textarea1" placeholder="הכנס מלל חופשי"></textarea>
        <br />
        <select name="age" id="age">
            <option value="0">בחר גיל</option>
            <option value="15">15</option>
            <option value="16">16</option>
            <option value="17">17</option>
        </select>
        <br />
        <input id="Submit1" type="submit" value="שלח" />
    </form>
    <br />
   <%=name %>
    <%=age %>
    <%=music %>
    <%=app %>
</asp:Content>

