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
    public partial class FormDonHang : Form
    {
        ServiceDonHang.ServiceDonHangClient obj = new ServiceDonHang.ServiceDonHangClient();
        public FormDonHang()
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
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            ServiceDonHang.DonHang objdh = new ServiceDonHang.DonHang();
            objdh.id = (int)dataGridView1.SelectedRows[0].Cells["id"].Value;
            obj.delete(objdh.id);
            showdata();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
