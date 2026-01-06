using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    public string name;
    public string app;
    public string music;
    public string age;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack)
        {
             name = "name:" + Request.Form["name"];
             app ="app:" +  Request.Form["radio"];
             music = "music:" + Request.Form["textarea0"];
             age = "age:" + Request.Form["age"];   
            // Here you can add code to process the form data, such as sending an email or saving to a database.
        }
    }
}