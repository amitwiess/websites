using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default4 : System.Web.UI.Page
{
    public string stResult = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            string email = Request.Form["email"];
            string pass = Request.Form["pass"];

            if (email=="manager" && pass=="123")
            {
                //מנהל
                Session["username"] = "manager";
                Session["nihul"] = "ok";
                Response.Redirect("Manager.aspx");

            }
            else
            {
                string sqlSelect =
                    "SELECT * FROM tUsers " +
                    "WHERE [email] = N'" + email + "' " +
                    "AND [password] = N'" + pass + "'";

                DataTable dt = MyAdoHelper.ExecuteDataTable(sqlSelect);

                if (dt.Rows.Count==0)
                {
                    //אורח
                    Session["username"] = "guest";
                    stResult = "אימייל או סיסמא שגויים";
                }
                else
                {
                    //משתמש רגיל
                    Session["username"] = dt.Rows[0]["firstName"];
                    Session["user"] = "ok";
                    Response.Redirect("HomePage.aspx");
                }


            }

        }
    }
}