using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform.GUI
{
    public partial class FormNhanVien : Form
    {
        ServiceNhanVien.ServiceNhanVienClient obj = new ServiceNhanVien.ServiceNhanVienClient();
        public FormNhanVien()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            showdata();
        }

        public void showdata()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = obj.findAll();
            //dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            //ServiceNhanVien.NhanVien objnv = new ServiceNhanVien.NhanVien();
            //cbxQuyen.DataSource = objnv.QuyenNV;
            
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            
            ServiceNhanVien.NhanVien objnv = new ServiceNhanVien.NhanVien();
            objnv.ten = txtTen.Text;
            objnv.pass = txtPass.Text;
            objnv.quyen = int.Parse(txtQuyen.Text);
            obj.insert(objnv.ten, objnv.pass, Convert.ToInt32(objnv.quyen));
            showdata();

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            ServiceNhanVien.NhanVien objnv = new ServiceNhanVien.NhanVien();
            objnv.id = (int)dataGridView1.SelectedRows[0].Cells["id"].Value;
            obj.delete(objnv.id);
            showdata();

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            ServiceNhanVien.NhanVien objnv = new ServiceNhanVien.NhanVien();
            objnv.id = (int)dataGridView1.SelectedRows[0].Cells["id"].Value;
            objnv.ten = txtTen.Text;
            objnv.pass = txtPass.Text;

            objnv.quyen = int.Parse(txtQuyen.Text);
            obj.update(objnv.id, objnv.ten, objnv.pass, Convert.ToInt32(objnv.quyen));
            showdata();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txtId.Text = row.Cells["id"].Value.ToString();
                txtPass.Text = row.Cells["pass"].Value.ToString();
                txtTen.Text = row.Cells["ten"].Value.ToString();
                txtQuyen.Text = row.Cells["quyen"].Value.ToString();
                
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtId.Text = null;
            txtPass.Text = null;
            txtTen.Text = null;
            txtQuyen.Text = null;
        }

        
    }
}
