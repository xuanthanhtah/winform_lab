
namespace lab04
{
    partial class frmFalculty
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemSua = new System.Windows.Forms.Button();
            this.txtTongGiaoSu = new System.Windows.Forms.TextBox();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvFalculty = new System.Windows.Forms.DataGridView();
            this.dgvmakhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtenkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTongGS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDong = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFalculty)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThemSua);
            this.groupBox1.Controls.Add(this.txtTongGiaoSu);
            this.groupBox1.Controls.Add(this.txtTenKhoa);
            this.groupBox1.Controls.Add(this.txtMaKhoa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(40, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khoa";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(165, 231);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 37);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemSua
            // 
            this.btnThemSua.Location = new System.Drawing.Point(50, 231);
            this.btnThemSua.Name = "btnThemSua";
            this.btnThemSua.Size = new System.Drawing.Size(93, 37);
            this.btnThemSua.TabIndex = 9;
            this.btnThemSua.Text = "Thêm / Sửa";
            this.btnThemSua.UseVisualStyleBackColor = true;
            this.btnThemSua.Click += new System.EventHandler(this.btnThemSua_Click);
            // 
            // txtTongGiaoSu
            // 
            this.txtTongGiaoSu.Location = new System.Drawing.Point(129, 130);
            this.txtTongGiaoSu.Name = "txtTongGiaoSu";
            this.txtTongGiaoSu.Size = new System.Drawing.Size(126, 22);
            this.txtTongGiaoSu.TabIndex = 8;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(82, 81);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(173, 22);
            this.txtTenKhoa.TabIndex = 7;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(82, 39);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(173, 22);
            this.txtMaKhoa.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng Số Giáo Sư";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Khoa";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(618, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(8, 8);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dgvFalculty
            // 
            this.dgvFalculty.AllowUserToAddRows = false;
            this.dgvFalculty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFalculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFalculty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvmakhoa,
            this.dgvtenkhoa,
            this.dgvTongGS});
            this.dgvFalculty.Location = new System.Drawing.Point(332, 88);
            this.dgvFalculty.Name = "dgvFalculty";
            this.dgvFalculty.RowHeadersWidth = 51;
            this.dgvFalculty.RowTemplate.Height = 24;
            this.dgvFalculty.Size = new System.Drawing.Size(424, 282);
            this.dgvFalculty.TabIndex = 2;
            this.dgvFalculty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFalculty_CellClick);
            // 
            // dgvmakhoa
            // 
            this.dgvmakhoa.HeaderText = "Mã Khoa";
            this.dgvmakhoa.MinimumWidth = 6;
            this.dgvmakhoa.Name = "dgvmakhoa";
            // 
            // dgvtenkhoa
            // 
            this.dgvtenkhoa.HeaderText = "Tên Khoa";
            this.dgvtenkhoa.MinimumWidth = 6;
            this.dgvtenkhoa.Name = "dgvtenkhoa";
            // 
            // dgvTongGS
            // 
            this.dgvTongGS.HeaderText = "Tổng số Giáo Sư";
            this.dgvTongGS.MinimumWidth = 6;
            this.dgvTongGS.Name = "dgvTongGS";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(666, 392);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(90, 37);
            this.btnDong.TabIndex = 11;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(199, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quản Lý Thông Tin Khoa";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // frmFalculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvFalculty);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmFalculty";
            this.Text = "frmFalculty";
            this.Load += new System.EventHandler(this.frmFalculty_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFalculty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvFalculty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTongGiaoSu;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemSua;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvmakhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtenkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTongGS;
        private System.Windows.Forms.Label label4;
    }
}