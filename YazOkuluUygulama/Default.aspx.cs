using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BussinessLogicLayer;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityOgrenci ent = new EntityOgrenci();
        ent.OrgAd = TxtAd.Text;
        ent.OgrSoyad = TxtSoyad.Text;
        ent.OgrNumara = TxtNumara.Text;
        ent.OgrFotograf = TxtFotograf.Text;
        ent.OgrSifre = TxtSifre.Text;
        BLLOgrenci.OgrenciEkleBLL(ent);
        TxtAd.Text = "";
        TxtSoyad.Text = "";
        TxtNumara.Text = "";
        TxtFotograf.Text = "";
        TxtSifre.Text = "";

    }
}