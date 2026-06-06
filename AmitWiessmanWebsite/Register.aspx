<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true"
    CodeFile="Register.aspx.cs"
    Inherits="Default3" %>

<asp:Content ID="Content1"
    ContentPlaceHolderID="head"
    Runat="Server">
        <h1 style="text-align:center;">דף הרשמה</h1>

    <script language="javascript">

        function checkAll() {

            let f = true;

            document.getElementById("nameError").innerHTML = "";
            document.getElementById("passError").innerHTML = "";
            document.getElementById("emailError").innerHTML = "";
            document.getElementById("textarea1Error").innerHTML = "";

            if (checkFirstName() == false)
                f = false;

            if (checkPassword() == false)
                f = false;

            if (checkEmail() == false)
                f = false;

            if (checkTextArea() == false)
                f = false;

            return f;
        }

        function checkFirstName() {

            let name = document.getElementById("firstname").value;

            if (name.length < 2 || name.length > 30) {

                document.getElementById("nameError").innerHTML =
                    "אורך השם חייב להיות בין 2 ל-30 תווים";

                return false;
            }

            return true;
        }

        function checkPassword() {

            let pass = document.getElementById("pass").value;

            if (pass.length < 6 || pass.length > 20) {

                document.getElementById("passError").innerHTML =
                    "אורך הסיסמה חייב להיות בין 6 ל-20 תווים";

                return false;
            }

            return true;
        }
     
        function checkEmail() {

            let email = document.getElementById("email").value;

            let msg = "";

            if (email.length < 3 || email.length > 30) {

                msg += "אורך המייל לא תקין<br />";
            }

            if (email.indexOf("@") == -1) {

                msg += "המייל חייב להכיל @<br />";
            }



            if (msg != "") {

                document.getElementById("emailError").innerHTML = msg;

                return false;
            }

            return true;
        }

        function checkTextArea() {

            let text = document.getElementById("textarea1").value;

            if (text.length < 3 || text.length > 100) {

                document.getElementById("textarea1Error").innerHTML =
                    "יש להכניס בין 3 ל-100 תווים";

                return false;
            }

            return true;
        }

    </script>

</asp:Content>

<asp:Content ID="Content2"
    ContentPlaceHolderID="ContentPlaceHolder1"
    Runat="Server">


    <form name="formPage"
        method="post"
        runat="server"
        onsubmit="return checkAll();">

        שם פרטי:
        <input type="text"
            name="name"
            id="firstname"
            placeholder="example"
            required />

        <span class="error" id="nameError"></span>

        <br /><br />

        מייל:
        <input type="text"
            name="email"
            id="email"
            placeholder="example@gmail.com"
            required />

        <span class="error" id="emailError"></span>

        <br /><br />

        סיסמה:
        <input type="password"
            name="pass"
            id="pass"
            placeholder="example"
            required />

        <span class="error" id="passError"></span>

        <br /><br />

        אפליקציית האזנה מועדפת:

        <br />

        spotify
        <input type="radio"
            name="radio"
            checked
            value="spotify"
            id="check_1" />

        <br />

        Apple music
        <input type="radio"
            name="radio"
            value="Apple music"
            id="check_2" />

        <br />

        Sound cloud
        <input type="radio"
            name="radio"
            value="Sound cloud"
            id="check_3" />

        <br /><br />

        סגנון מוזיקה אהוב:

        <br />

        <textarea rows="5"
            cols="20"
            name="textarea1"
            id="textarea1"
            placeholder="הכנס מלל חופשי"></textarea>

        <span class="error" id="textarea1Error"></span>

        <br /><br />

        גיל:

        <br />

        <select name="age" id="age">

            <option value="0">בחר גיל</option>
            <option value="15">15</option>
            <option value="16">16</option>
            <option value="17">17</option>
            <option value="18+">18+</option>
            <option value="אחר">אחר</option>

        </select>

        <br /><br />

        <input id="Submit1"
            type="submit"
            value="שלח" />

    </form>

    <br />

    <%=st %>

</asp:Content>