using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class addItem : System.Web.UI.Page
{
    // משתנה שיכיל הודעות עדכון או שגיאה עבור המשתמש בדף ה-aspx
    public string st = "";
    public string songName;
    public string songType;
    public string songLength;

    protected void Page_Load(object sender, EventArgs e)
    {
        // מריץ את הקוד רק לאחר לחיצה על כפתור השליחה של הטופס (PostBack)
        if (IsPostBack)
        {
            // שליפת הנתונים שהמשתמש הזין בטופס לגבי השיר
            string songName = Request.Form["songName"];
            string songType = Request.Form["songType"];
            string songLength = Request.Form["songLength"];
            string playName = Request.Form["playName"];

            // שאילתה לבדיקה האם קיים כבר שיר באותו השם בבסיס הנתונים
            string sql = "SELECT * FROM ttable WHERE songName = N'" + songName + "'";
            bool userExists = MyAdoHelper.IsExist(sql);

            // מניעת כפילויות: אם השיר קיים, המערכת לא תאפשר להוסיף אותו שוב
            if (userExists)
            {
                st = "השיר כבר קיים במערכת!";
            }
            else
            {
                // בניית שאילתת INSERT שמכניסה את נתוני השיר החדש לתוך הטבלה (ttable)
                string sqlInsert =
                  "INSERT INTO ttable (songName, songType, songLength, playName) VALUES (" +
                    "N'" + songName + "', " +
                    "N'" + songType + "', " +
                    "N'" + songLength + "', " +
                    "N'" + playName + "')";

                // הרצת שאילתת ההוספה מול קובץ בסיס הנתונים (MyDB.mdf) והצגת הודעת הצלחה
                MyAdoHelper.DoQuery("MyDB.mdf", sqlInsert);

                st = "השיר נוסף בהצלחה!";
            }
        }
    }
}