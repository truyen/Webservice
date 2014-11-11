using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CuaHangDTDD.ServiceReferenceNhanVien;

namespace CuaHangDTDD.Admin
{
    public partial class WebFormNhanViens : System.Web.UI.Page
    {
        private ServiceNhanVienClient snvc = new ServiceNhanVienClient();
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
            this.ListViewNhanVien.DataSource = snvc.findAll();
            this.ListViewNhanVien.DataBind();
        }
        protected void lbtBack_Click(object sender, EventArgs e)
        {
            ListViewNhanVien.Visible = true;
            pnUpdate.Visible = false;
        }

        protected void LinkButtonXoa_Click(object sender, EventArgs e)
        {
            LinkButton lb = (LinkButton)sender;
            HiddenField hd = (HiddenField)lb.FindControl("HiddenFieldid");
            if (snvc.delete(Convert.ToInt32(hd.Value)))
            {
                FillData();
                LabelThongBao.Text = " Xóa Thành Công";
            }
            else
                LabelThongBao.Text = "Xóa thất bại";

        }
        protected void btnThem_Click(object sender, EventArgs e)
        {
            ListViewNhanVien.Visible = false;
            pnUpdate.Visible = true;

        }
        protected void LinkButtonSua_Click(object sender, EventArgs e)
        {
            Edit = true;
            ListViewNhanVien.Visible = false;
            pnUpdate.Visible = true;
            LinkButton lb = (LinkButton)sender;
            HiddenField hd = (HiddenField)lb.FindControl("HiddenFieldid");
            NhanVien hang = snvc.find(Convert.ToInt32(hd.Value));
            txtId.Text = hang.id.ToString();
            txtName.Text = hang.ten.ToString();
            txtStatus.Text = hang.quyen.ToString();

        }
        protected void lbtUpdate_Click(object sender, EventArgs e)
        {
            if (Edit)
            {
                var obj = new NhanVien();
                obj.id = int.Parse(txtId.Text);
                obj.ten = txtName.Text;
                obj.pass = txtPass.Text;
                obj.quyen = int.Parse(txtStatus.Text);
                snvc.update(obj.id, obj.ten, obj.pass, Convert.ToInt32(obj.quyen));
            }
            else
            {
                snvc.insert(this.txtName.Text, this.txtPass.Text, Convert.ToInt32(this.txtStatus.Text));
            }
            Response.Redirect("~/Admin/WebFormNhanViens.aspx");
        }
    }
}