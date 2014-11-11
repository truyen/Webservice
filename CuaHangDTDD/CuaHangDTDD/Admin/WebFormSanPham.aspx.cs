using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CuaHangDTDD.ServiceReferenceSanPham;

namespace CuaHangDTDD.Admin
{
    public partial class WebFormSanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ServiceSanPhamClient sspc = new ServiceSanPhamClient();
                this.ListViewSanPham.DataSource = sspc.findAll();
                this.ListViewSanPham.DataBind();
            }

        }
    }
}