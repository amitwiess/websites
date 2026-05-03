<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <script language="javascript">
         function checkAll() {
             let f = true;

             nameError.innerHTML = "";
             passError.innerHTML = "";
             emailError.innerHTML = "";
             if (checkFirstName() == false)
                 f = false;
             if (checkPassword() == false)
                 f = false;
             if (checkEmail() == false)
                 f = false;

             return f;
         }

         function checkFirstName() {
             let name = document.getElementById("firstname").value;

             if (name.length < 2 || name.length > 30) {
                 nameError.innerHTML = "אורך השם לא תקין";
                 return false;
             }

             return true;
         }

         function checkPassword() {
             let pass = document.getElementById("pass").value;

             if (pass.length < 6 || pass.length > 20) {
                 passError.innerHTML = "אורך הסיסמה לא תקין";
                 return false;
             }

             return true;
         }
         function checkEmail() {
             let email = document.getElementById("email").value;

             if (email.length < 6 || email.length > 20) {
                 emailError.innerHTML = "אורך המייל לא תקין";
                 return false;
             }

             return true;
         }
     </script>  

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <h1 style="text-align:center;">דף הרשמה</h1>

       <form name="formPage" method="post" runat="server"  onsubmit="return checkAll();">
        שם פרטי: <input type="text" name="name" id="firstname" placeholder="example">
           <span class="error" id="nameError"></span>
        <br />
           מייל: <input type="text" name="email" id="email" placeholder="example">
           <span class="error" id="emailError"></span>
<br />
           סיסמה: <input type="text" name="pass" id="pass" placeholder="example">
                      <span class="error" id="passError"></span>

<br />
        אפליקציית האזנה מעודפת: 
        <br />
        spotify<input type="radio" name="radio" checked value="spotify" id="check_1"><br />
                             <span class="error" id="check_1Error"></span>

        Apple music <input type="radio" name="radio" value="Apple music" id="check_2"><br />
                             <span class="error" id="check_2Error"></span>

        Sound cloud<input type="radio" name="radio" value="Sound cloud" checked id="check_3"><br />
                  <span class="error" id="check_3Error"></span>

         <br />
        סגנון מוזיקה אהוב: 
        <br />
       
        <textarea rows="5" cols="20" name="textarea1" id="textarea1" placeholder="הכנס מלל חופשי"></textarea>
                      <span class="error" id="textarea1Error"></span>

        <br />
        <select name="age" id="age">
            <option value="0">בחר גיל</option>
            <option value="15">15</option>
            <option value="16">16</option>
            <option value="17">17</option>
            <option value="אחר">אחר</option>
               <option value="18+">18+</option>

        </select>
                                  <span class="error" id="ageError"></span>

        <br />
        <input id="Submit1" type="submit" value="שלח" />
                      <span class="error" id="Submit1Error"></span>

    </form>
    <br />
   <%=st %>
   
</asp:Content>

