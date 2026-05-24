using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class addItem : System.Web.UI.Page
{
    public string st = "";
    public string songName;
    public string songType;
    public string songLength;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            string songName = Request.Form["songName"];
            string songType = Request.Form["songType"];
            string songLength = Request.Form["songLength"];

            string sql = "SELECT * FROM ttable WHERE songName = N'" + songName + "'";
            bool userExists = MyAdoHelper.IsExist(sql);

            if (userExists)
            {
                st = "השיר כבר קיים במערכת!";
            }
            else
            {
                string sqlInsert =
                    "INSERT INTO ttable (songName, songType, songLength) VALUES (" +
                    "N'" + songName + "', " +
                    "N'" + songType + "', " +
                    "N'" + songLength + "')";

                MyAdoHelper.DoQuery("MyDB.mdf", sqlInsert);

                st = "השיר נוסף בהצלחה!";
            }
        }
    }
}