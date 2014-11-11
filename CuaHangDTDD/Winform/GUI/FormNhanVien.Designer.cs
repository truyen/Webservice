namespace Winform.GUI
{
    partial class FormNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelMa = new System.Windows.Forms.Label();
            this.labelTen = new System.Windows.Forms.Label();
            this.labelMatKhau = new System.Windows.Forms.Label();
            this.labelQuyen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtQuyen = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMa
            // 
            this.labelMa.AutoSize = true;
            this.labelMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMa.Location = new System.Drawing.Point(26, 17);
            this.labelMa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMa.Name = "labelMa";
            this.labelMa.Size = new System.Drawing.Size(92, 16);
            this.labelMa.TabIndex = 0;
            this.labelMa.Text = "Mã Nhân Viên";
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTen.Location = new System.Drawing.Point(20, 51);
            this.labelTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(97, 16);
            this.labelTen.TabIndex = 1;
            this.labelTen.Text = "Tên Nhân Viên";
            // 
            // labelMatKhau
            // 
            this.labelMatKhau.AutoSize = true;
            this.labelMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatKhau.Location = new System.Drawing.Point(275, 15);
            this.labelMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMatKhau.Name = "labelMatKhau";
            this.labelMatKhau.Size = new System.Drawing.Size(63, 16);
            this.labelMatKhau.TabIndex = 2;
            this.labelMatKhau.Text = "Mật Khẩu";
            // 
            // labelQuyen
            // 
            this.labelQuyen.AutoSize = true;
            this.labelQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuyen.Location = new System.Drawing.Point(291, 51);
            this.labelQuyen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuyen.Name = "labelQuyen";
            this.labelQuyen.Size = new System.Drawing.Size(47, 16);
            this.labelQuyen.TabIndex = 3;
            this.labelQuyen.Text = "Quyền";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(126, 45);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(118, 22);
            this.txtTen.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(354, 15);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(118, 22);
            this.txtPass.TabIndex = 4;
            // 
            // txtQuyen
            // 
            this.txtQuyen.Location = new System.Drawing.Point(354, 45);
            this.txtQuyen.Name = "txtQuyen";
            this.txtQuyen.Size = new System.Drawing.Size(118, 22);
            this.txtQuyen.TabIndex = 4;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(23, 303);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 5;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(172, 303);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 6;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(338, 303);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 6;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(493, 303);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 6;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataSource = typeof(Winform.ServiceNhanVien.NhanVien);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ten,
            this.pass,
            this.quyen});
            this.dataGridView1.Location = new System.Drawing.Point(42, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(495, 190);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Location = new System.Drawing.Point(126, 17);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(0, 16);
            this.txtId.TabIndex = 8;
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(493, 32);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 9;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Tên Nhân Viên";
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            this.ten.Width = 150;
            // 
            // pass
            // 
            this.pass.DataPropertyName = "pass";
            this.pass.HeaderText = "Mật Khẩu";
            this.pass.Name = "pass";
            this.pass.ReadOnly = true;
            this.pass.Width = 150;
            // 
            // quyen
            // 
            this.quyen.DataPropertyName = "quyen";
            this.quyen.HeaderText = "Quyền";
            this.quyen.Name = "quyen";
            this.quyen.ReadOnly = true;
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 338);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.txtQuyen);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.labelQuyen);
            this.Controls.Add(this.labelMatKhau);
            this.Controls.Add(this.labelTen);
            this.Controls.Add(this.labelMa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMa;
        private System.Windows.Forms.Label labelTen;
        private System.Windows.Forms.Label labelMatKhau;
        private System.Windows.Forms.Label labelQuyen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtQuyen;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn quyen;
    }
}