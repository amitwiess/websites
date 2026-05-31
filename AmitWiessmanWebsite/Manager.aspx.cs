using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Activities.Statements;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default9 : System.Web.UI.Page
{
    // משתנה שיכיל את קוד ה-HTML של טבלת המשתמשים ויוצג בדף ה-aspx
    public string st = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        // מבצע את החיפוש רק בעקבות לחיצה על כפתור (PostBack) ולא בטעינה הראשונית של הדף
        if (Page.IsPostBack)
        {
            // שליפת השם הפרטי שהמשתמש הקליד בתיבת הטקסט בטופס
            string name1 = Request.Form["fname"];

            // שאילתה שמחפשת בטבלת המשתמשים (tUsers) את כל מי ששמו מכיל את הטקסט שהוקלד
            String sql = "SELECT * FROM tUsers WHERE firstName LIKE N'%" + name1 + "%'";

            // הפעלת השאילתה מול בסיס הנתונים וקבלת התוצאות לטבלה בזיכרון (DataTable)
            DataTable dt = MyAdoHelper.ExecuteDataTable(sql);

            // בדיקה האם לא נמצאו משתמשים שעונים על תנאי החיפוש
            if (dt.Rows.Count == 0)
            {
                st = "אין נתונים";
            }
            else
            {
                // בניית כותרת הטבלה להצגת המשתמשים
                st += "<table border='1'>"; // שים לב: תוקנה שגיאת הכתיב מ-boarder ל-border ונמחק הגרש המיותר
                st += "<tr>";
                st += "<td>שם פרטי</td>";
                st += "<td>מייל</td>";
                st += "<td>סיסמא</td>";
                st += "<td>111</td>";
                st += "<td>222</td>";
                st += "<td>גיל</td>";
                st += "</tr>"; // שים לב: נוספה תגית סגירת שורת הכותרת שהייתה חסרה

                // לולאה כפולה: החיצונית עוברת על כל המשתמשים (שורות), והפנימית מדפיסה את כל הנתונים שלהם (עמודות)
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    st += "<tr>";
                    for (int k = 0; k < dt.Columns.Count; k++)
                    {
                        st += "<td>" + dt.Rows[i][k] + "</td>";
                    }
                    st += "</tr>";
                }
                st += "</table>";
            }
        }
    }
}