using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Activities.Statements;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class simpleSerch : System.Web.UI.Page
{
    // משתנה שיכיל את קוד ה-HTML של הטבלה ויוצג בדף ה-aspx
    public string st = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        // מבצע את החיפוש רק אם הייתה לחיצה על כפתור (PostBack) ולא בטעינה הראשונה של הדף
        if (Page.IsPostBack)
        {
            // שליפת הערך שכתב המשתמש בתיבת הטקסט
            string songName = Request.Form["songName"];

            // שאילתה שמחפשת בבסיס הנתונים שירים המכילים את המילה שהוקלדה
            String sql = "SELECT * FROM ttable WHERE songName LIKE N'%" + songName + "%'";

            // הפעלת השאילתה וקבלת התוצאות לטבלה בזיכרון (DataTable)
            DataTable dt = MyAdoHelper.ExecuteDataTable(sql);

            if (dt.Rows.Count == 0)
            {
                st = "אין נתונים";
            }
            else
            {
                // בניית כותרת הטבלה
                st += "<table border='1'>";
                st += "<tr>";
                st += "<td>שם השיר</td>";
                st += "<td>סוג השיר</td>";
                st += "<td>אורך השיר בשניות</td>";
                st += "</tr>";

                // לולאה כפולה: הלולאה החיצונית עוברת על השורות, והפנימית מדפיסה את התאים (העמודות) של כל שיר
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