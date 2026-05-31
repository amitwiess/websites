using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default4 : System.Web.UI.Page
{
    // משתנה שיכיל הודעת שגיאה אם הפרטים לא נכונים
    public string stResult = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        // בדיקה שהדף נטען בעקבות לחיצה על כפתור התחברות (שליחת הטופס)
        if (Page.IsPostBack)
        {
            // שליפת האימייל והסיסמה שהמשתמש הקליד בטופס ה-HTML
            string email = Request.Form["email"];
            string pass = Request.Form["pass"];

            // בדיקה ידנית האם מדובר במנהל המערכת (לפי נתונים קבועים מראש)
            if (email == "manager" && pass == "123")
            {
                // שמירת נתוני המנהל ב-Session והעברתו לדף הניהול
                Session["username"] = "manager";
                Session["nihul"] = "ok";
                Response.Redirect("Manager.aspx");
            }
            else
            {
                // שאילתה לבדיקה האם קיימת התאמה בין האימייל והסיסמה בבסיס הנתונים
                string sqlSelect =
                    "SELECT * FROM tUsers " +
                    "WHERE [email] = N'" + email + "' " +
                    "AND [password] = N'" + pass + "'";

                // הרצת השאילתה וקבלת התוצאה לטבלה בזיכרון
                DataTable dt = MyAdoHelper.ExecuteDataTable(sqlSelect);

                // אם לא חזרה אף שורה, סימן שהאימייל או הסיסמה לא קיימים/שגויים
                if (dt.Rows.Count == 0)
                {
                    Session["username"] = "guest";
                    stResult = "אימייל או סיסמא שגויים";
                }
                else
                {
                    // אם נמצא משתמש, שומרים את שמו הפרטי ואת הסטטוס שלו ב-Session ומעבירים אותו לדף הבית
                    Session["username"] = dt.Rows[0]["firstName"];
                    Session["user"] = "ok";
                    Response.Redirect("HomePage.aspx");
                }
            }
        }
    }
}