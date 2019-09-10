using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using EntityLayer;
using BussinessLogicLayer;

public partial class OgrenciSilme : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt32(Request.QueryString["OGRID"]);
        Response.Write(x);
        EntityOgrenci ent = new EntityOgrenci();
        ent.OgrId = x;
        BLLOgrenci.OgrenciSilBLL(ent.OgrId);
        Response.Redirect("OgrenciListesi.aspx");
    }
}