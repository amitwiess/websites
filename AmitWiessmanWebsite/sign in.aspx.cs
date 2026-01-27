using System;
using System.Collections.Generic;
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
            string sqlSelect =
                "SELECT * FROM tUsers " +
                "WHERE [email] = N'" + email + "' " +
                "AND [password] = N'" + pass + "'";
            bool userExists = MyAdoHelper.IsExist(sqlSelect);
            if (!userExists)
            
             stResult = "אימייל או סיסמא שגויים";

            else
            {
                stResult = "משתמש רשום";
            }


        }

    }
}