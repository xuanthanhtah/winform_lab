
namespace lab04
{
    partial class frmTimKiem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbTKKhoa = new System.Windows.Forms.ComboBox();
            this.txtTKHoTen = new System.Windows.Forms.TextBox();
            this.txtTKMssv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.dgvTimkiem = new System.Windows.Forms.DataGridView();
            this.dgvtkmssv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtkhoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtkkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdiemtb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimkiem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbTKKhoa);
            this.groupBox1.Controls.Add(this.txtTKHoTen);
            this.groupBox1.Controls.Add(this.txtTKMssv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(193, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 183);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tìm Kiếm";
            // 
            // cbbTKKhoa
            // 
            this.cbbTKKhoa.FormattingEnabled = true;
            this.cbbTKKhoa.Location = new System.Drawing.Point(129, 134);
            this.cbbTKKhoa.Name = "cbbTKKhoa";
            this.cbbTKKhoa.Size = new System.Drawing.Size(172, 24);
            this.cbbTKKhoa.TabIndex = 11;
            // 
            // txtTKHoTen
            // 
            this.txtTKHoTen.Location = new System.Drawing.Point(129, 81);
            this.txtTKHoTen.Name = "txtTKHoTen";
            this.txtTKHoTen.Size = new System.Drawing.Size(173, 22);
            this.txtTKHoTen.TabIndex = 7;
            this.txtTKHoTen.TextChanged += new System.EventHandler(this.txtTKHoTen_TextChanged);
            this.txtTKHoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTKHoTen_KeyPress);
            // 
            // txtTKMssv
            // 
            this.txtTKMssv.Location = new System.Drawing.Point(129, 39);
            this.txtTKMssv.Name = "txtTKMssv";
            this.txtTKMssv.Size = new System.Drawing.Size(173, 22);
            this.txtTKMssv.TabIndex = 6;
            this.txtTKMssv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTKMssv_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Họ Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Số Sinh Viên";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(449, 264);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 37);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(322, 264);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(93, 37);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            this.btnTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnTimKiem_KeyDown);
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(763, 264);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(90, 37);
            this.btnTroVe.TabIndex = 11;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // dgvTimkiem
            // 
            this.dgvTimkiem.AllowUserToAddRows = false;
            this.dgvTimkiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimkiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtkmssv,
            this.dgvtkhoten,
            this.dgvtkkhoa,
            this.dgvdiemtb});
            this.dgvTimkiem.Location = new System.Drawing.Point(80, 325);
            this.dgvTimkiem.Name = "dgvTimkiem";
            this.dgvTimkiem.RowHeadersWidth = 51;
            this.dgvTimkiem.RowTemplate.Height = 24;
            this.dgvTimkiem.Size = new System.Drawing.Size(786, 242);
            this.dgvTimkiem.TabIndex = 12;
            // 
            // dgvtkmssv
            // 
            this.dgvtkmssv.HeaderText = "Mã Số Sinh Viên";
            this.dgvtkmssv.MinimumWidth = 6;
            this.dgvtkmssv.Name = "dgvtkmssv";
            // 
            // dgvtkhoten
            // 
            this.dgvtkhoten.HeaderText = "Họ Tên";
            this.dgvtkhoten.MinimumWidth = 6;
            this.dgvtkhoten.Name = "dgvtkhoten";
            // 
            // dgvtkkhoa
            // 
            this.dgvtkkhoa.HeaderText = "Khoa";
            this.dgvtkkhoa.MinimumWidth = 6;
            this.dgvtkkhoa.Name = "dgvtkkhoa";
            // 
            // dgvdiemtb
            // 
            this.dgvdiemtb.HeaderText = "Điểm TB";
            this.dgvdiemtb.MinimumWidth = 6;
            this.dgvdiemtb.Name = "dgvdiemtb";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(650, 585);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kết quả tìm kiếm";
            // 
            // txtKetqua
            // 
            this.txtKetqua.Location = new System.Drawing.Point(763, 580);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.ReadOnly = true;
            this.txtKetqua.Size = new System.Drawing.Size(103, 22);
            this.txtKetqua.TabIndex = 12;
            this.txtKetqua.TextChanged += new System.EventHandler(this.txtKetqua_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(337, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tìm Kiếm";
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 631);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKetqua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvTimkiem);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTimKiem);
            this.Name = "frmTimKiem";
            this.Text = "frmTimKiem";
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimkiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTKHoTen;
        private System.Windows.Forms.TextBox txtTKMssv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTKKhoa;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.DataGridView dgvTimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtkmssv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtkhoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtkkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdiemtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.Label label5;
    }
}