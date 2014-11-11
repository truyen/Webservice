using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CuaHangDTDD.ServiceReferenceHangSX;

namespace CuaHangDTDD.Admin
{
    public partial class WebFormHangSX : System.Web.UI.Page
    {
        private ServiceHangSXClient shc = new ServiceHangSXClient();
        public static bool Edit;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FillData();
                pnUpdate.Visible = false;
            }
        }
        private void FillData()
        {
            this.ListViewHangSX.DataSource = shc.findAll();
            this.ListViewHangSX.DataBind();
        }
        protected void lbtBack_Click(object sender, EventArgs e)
        {
            ListViewHangSX.Visible = true;
            pnUpdate.Visible = false;
        }
        
        protected void LinkButtonXoa_Click(object sender, EventArgs e)
        {
            LinkButton lb = (LinkButton)sender;
            HiddenField hd = (HiddenField)lb.FindControl("HiddenFieldid");
            if (shc.delete(Convert.ToInt32(hd.Value)))
            {
                FillData();
                LabelThongBao.Text = " Xóa Thành Công";
            }
            else
                LabelThongBao.Text = "Xóa thất bại";
       
        }
        protected void btnThem_Click(object sender, EventArgs e)
        {
            ListViewHangSX.Visible = false;
            pnUpdate.Visible = true;
         
        }
        protected void LinkButtonSua_Click(object sender, EventArgs e)
        {
            Edit = true;
            ListViewHangSX.Visible = false;
            pnUpdate.Visible = true;
            LinkButton lb = (LinkButton)sender;
            HiddenField hd = (HiddenField)lb.FindControl("HiddenFieldid");
            HangSX hang = shc.find(Convert.ToInt32(hd.Value));
            txtId.Text = hang.id.ToString();
            txtName.Text = hang.ten.ToString();
            txtStatus.Text = hang.active.ToString();
            
        }
        protected void lbtUpdate_Click(object sender, EventArgs e)
        {
            if (Edit)
            {
                var obj = new HangSX();
                obj.id = int.Parse(txtId.Text);
                obj.ten = txtName.Text;
                obj.active = true;
                shc.update(obj.id, obj.ten, true);
            }
            else
            {
                shc.insert(this.txtName.Text, true);
            }
            Response.Redirect("~/Admin/WebFormHangSX.aspx");
        }
        
    }
}