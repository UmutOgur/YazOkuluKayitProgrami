using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using BussinessLogicLayer;
using EntityLayer;

public partial class OgrenciGüncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt32(Request.QueryString["OGRID"].ToString());
        TxtId.Text = x.ToString();
        TxtId.Enabled = false;
        if (Page.IsPostBack == false)
        {
            List<EntityOgrenci> OgrList = BLLOgrenci.BllDetay(x);
            TxtAd.Text = OgrList[0].OrgAd.ToString();
            TxtSoyad.Text = OgrList[0].OgrSoyad.ToString();
            TxtNumara.Text = OgrList[0].OgrNumara.ToString();
            TxtFotograf.Text = OgrList[0].OgrFotograf.ToString();
            TxtSifre.Text = OgrList[0].OgrSifre.ToString();
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityOgrenci ent = new EntityOgrenci();
        ent.OgrId = Convert.ToInt32(TxtId.Text);
        ent.OrgAd = TxtAd.Text;
        ent.OgrSoyad = TxtSoyad.Text;
        ent.OgrNumara = TxtNumara.Text;
        ent.OgrFotograf = TxtFotograf.Text;
        ent.OgrSifre = TxtSifre.Text;
        BLLOgrenci.OgrenciGuncelleBLL(ent);
        Response.Redirect("OgrenciListesi.aspx");

    }
}