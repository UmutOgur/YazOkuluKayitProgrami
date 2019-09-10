using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BussinessLogicLayer;

public partial class TalepFormuListele : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        IList<EntityBasvuruForm> List = BLLBasvuru.BllBasvuru();
        Reapeter2.DataSource = List;
        Reapeter2.DataBind();


    }
}