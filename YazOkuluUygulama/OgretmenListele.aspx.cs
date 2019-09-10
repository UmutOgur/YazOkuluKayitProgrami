using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BussinessLogicLayer;

public partial class OgretmenListele : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        List<EntityOgretmen> OgrList = BLLOgretmen.BllOgretmen();
        Repeater1.DataSource = OgrList;
        Repeater1.DataBind();
    }
}