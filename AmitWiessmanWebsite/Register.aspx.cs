using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    public string st="";    
    public string name1;
    public string app1;
    public string music1;
    public string age1;
    public string email1;    
    public string pass1;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack)
        {
             name1 = "name:" + Request.Form["name"];
             app1 ="app:" +  Request.Form["radio"];
             music1 = "music:" + Request.Form["textarea1"];
             age1 = "age:" + Request.Form["age"];
            email1 = "email:" + Request.Form["email"];
            pass1= "pass:"+ Request.Form["pass"];

            string name= Request.Form["name"];
            string email = Request.Form["email"];
            string pass = Request.Form["pass"];
            string radio = Request.Form["radio"];
            string textarea = Request.Form["textarea1"];
            string age= Request.Form["age"];
            int ageNum = int.Parse(Request.Form["age"]);
            string sql=
                "SELECT * FROM tUsers " +
                "WHERE [email] = '" + email + "'";
            bool userExists = MyAdoHelper.IsExist(sql);
            string sqlInsert =
            "INSERT INTO tUsers ([firstName], [email], [password], [favApp], [favStyle], [age]) VALUES (" +
            "N'" + name + "', " +
            "N'" + email + "', " +
            "N'" + pass + "', " +
            "N'" + radio + "', " +
            "N'" + textarea + "', " +
            ageNum + ")";




            MyAdoHelper.DoQuery("MyDB.mdf", sqlInsert);
            st = "נרשמת בהצלחה!";

            // Here you can add code to process the form data, such as sending an email or saving to a database.
        }
    }
}