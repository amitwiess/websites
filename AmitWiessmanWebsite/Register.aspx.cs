    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    public string st = "";
    public string name1;
    public string app1;
    public string music1;
    public string age1;
    public string email1;
    public string pass1;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            // שליפת נתונים
            string name = Request.Form["name"];
            string email = Request.Form["email"];
            string pass = Request.Form["pass"];
            string radio = Request.Form["radio"];
            string textarea = Request.Form["textarea1"];
            string ageStr = Request.Form["age"];

            // בדיקה אם המשתמש קיים - הוספתי N למניעת בעיות בעברית
            string sql = "SELECT * FROM tUsers WHERE [email] = N'" + email + "'";
            bool userExists = MyAdoHelper.IsExist(sql);

            if (userExists)
            {
                st = "המשתמש כבר קיים במערכת!";
                // כאן לא עושים Redirect כדי שהמשתמש יראה את הודעת השגיאה ב-st
            }
            else
            {
                // המרת גיל בטוחה - אם לא מספר, יקבל 0
                int ageNum;
                if (!int.TryParse(ageStr, out ageNum)) { ageNum = 0; }

                string sqlInsert = "INSERT INTO tUsers ([firstName], [email], [password], [favApp], [favStyle], [age]) VALUES (" +
                    "N'" + name + "', " +
                    "N'" + email + "', " +
                    "N'" + pass + "', " +
                    "N'" + radio + "', " +
                    "N'" + textarea + "', " +
                    ageNum + ")";

                MyAdoHelper.DoQuery("MyDB.mdf", sqlInsert);

                // במקום Redirect רגיל, נשתמש בטריק של JavaScript כדי להראות הודעה ואז לעבור דף
                string script = "alert('נרשמת בהצלחה! עובר לדף התחברות...'); location.href='sign in.aspx';";
                ClientScript.RegisterStartupScript(this.GetType(), "redirect", script, true);
            }
        }
    }
}