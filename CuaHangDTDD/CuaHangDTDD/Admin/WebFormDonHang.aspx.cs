using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CuaHangDTDD.ServiceReferenceDonHang;

namespace CuaHangDTDD.Admin
{
    public partial class WebFormDonHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ServiceDonHangClient sdhc = new ServiceDonHangClient();
                this.ListViewDonHang.DataSource = sdhc.findAll();
                this.ListViewDonHang.DataBind();
            }

        }
    }
}