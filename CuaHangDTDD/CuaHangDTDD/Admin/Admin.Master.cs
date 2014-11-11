using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CuaHangDTDD.Admin
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbthoten.Text = "Xin chào : " + Session["UserName"] + " - Employees";       
        }
        protected void lbtthoat_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~");
        }

        protected void Linkbutton_Click(object sender, EventArgs e)
        {
            LinkButton lbt = (LinkButton)sender;
            Response.Redirect("~/Admin/" + lbt.ID.Trim() + ".aspx");
        }
    }
}