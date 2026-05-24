using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class simpleSerch : System.Web.UI.Page
{
    public string st = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            string songName = Request.Form["songName"];

            //String sql = "SELECT * FROM tUsers WHERE firstName = N'" + name1 + "'";
            String sql = "SELECT * FROM ttable WHERE songName LIKE N'%" + songName + "%'";

            DataTable dt = MyAdoHelper.ExecuteDataTable(sql);
            if (dt.Rows.Count == 0)
            {
                st = "אין נתונים";
            }
            else
            {
                st += "<table boarder='1'>'";
                st += "<tr>";
                st += "<td>שם השיר</td>";
                st += "<td>סוג השיר</td>";
                st += "<td>אורך השיר בשניות</td>";
              

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




