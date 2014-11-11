using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CuaHangDTDD.ServiceReferenceTonKho;

namespace CuaHangDTDD.Admin
{
    public partial class WebFormTonKho : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ServiceTonKhoClient stkc = new ServiceTonKhoClient();
                this.ListViewTonKho.DataSource = stkc.findAll();
                this.ListViewTonKho.DataBind();
            }

        }
    }
}