using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    public string st="";    
    public string name;
    public string app;
    public string music;
    public string age;
    public string email;    
    public string pass;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack)
        {
             name = "name:" + Request.Form["name"];
             app ="app:" +  Request.Form["radio"];
             music = "music:" + Request.Form["textarea0"];
             age = "age:" + Request.Form["age"];
            email = "email:" + Request.Form["email"];
            pass= "pass"+ Request.Form["pass"];

            string name1= Request.Form["name"];
            string email1 = Request.Form["email"];
            string pass1 = Request.Form["pass"];
            string app1 = Request.Form["radio"];
            string music1= Request.Form["textarea0"];
            string age1= Request.Form["age"];
           
            string sqlInsert=
"INSERT INTO tUsers VALUES (" +
"N'" + name1 + "', " +
"N'" + email1 + "', " +
"N'" + pass1 + "', " +
"N'" + app1 + "', " +
"N'" + music1 + "', " +
"N'" + age1 + "')";


            MyAdoHelper.DoQuery("MyDB.mdf", sqlInsert);
            st = "נרשמת בהצלחה!";

            // Here you can add code to process the form data, such as sending an email or saving to a database.
        }
    }
}