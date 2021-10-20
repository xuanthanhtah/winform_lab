using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab04.models;

namespace lab04
{
    public partial class frmFalculty : Form

    {
        dbcontext context = new dbcontext();
        public frmFalculty()
        {
            InitializeComponent();
        }

        private void frmFalculty_Load(object sender, EventArgs e)
        {
            List<Faculty> listFalcultys = context.Faculties.ToList();
            FillFalculty(listFalcultys);
        }

        private void FillFalculty(List<Faculty> listFalcultys)
        {
            dgvFalculty.Rows.Clear();
            foreach (var item in listFalcultys)
            {
                int index = dgvFalculty.Rows.Add();
                dgvFalculty.Rows[index].Cells[0].Value = item.FacultyID;
                dgvFalculty.Rows[index].Cells[1].Value = item.FacultyName;
                dgvFalculty.Rows[index].Cells[2].Value = item.TotalProfessor;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            if (checkdatainput())
            {
                if (checkidKhoa(txtMaKhoa.Text) == -1)
                {
                    Faculty faculty = new Faculty();
                    faculty.FacultyID = Convert.ToInt32( txtMaKhoa.Text);
                    faculty.FacultyName = txtTenKhoa.Text;
                    faculty.TotalProfessor = Convert.ToInt32(txtTongGiaoSu.Text);

                    context.Faculties.AddOrUpdate(faculty);
                    context.SaveChanges();

                    loadDGV();

                    loadform();
                    MessageBox.Show($"thêm sinh viên {faculty.FacultyName} thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Faculty faculty = new Faculty();
                    faculty.FacultyID = Convert.ToInt32(txtMaKhoa.Text);
                    faculty.FacultyName = txtTenKhoa.Text;
                    faculty.TotalProfessor = Convert.ToInt32(txtTongGiaoSu.Text);

                    context.Faculties.AddOrUpdate(faculty);
                    context.SaveChanges();

                    loadDGV();
                    loadform();
                    MessageBox.Show($"chỉnh sữa dữ liệu Khoa{faculty.FacultyName} thành công", "Thông Báo", MessageBoxButtons.OK);

                }
            }

        }

        private void loadform()
        {
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
            txtTongGiaoSu.Clear();

        }

        private void loadDGV()
        {
            List<Faculty> newListFaculty = context.Faculties.ToList();
            FillFalculty(newListFaculty);
        }

        private int checkidKhoa(string idnewfalculty)
        {
            int length = dgvFalculty.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if (dgvFalculty.Rows[i].Cells[0].Value != null)
                    if (dgvFalculty.Rows[i].Cells[0].Value.ToString() == idnewfalculty)
                        return i;
            }
            return -1;
        }

        private bool checkdatainput()
        {
            if (txtMaKhoa.Text == "" || txtTenKhoa.Text == "" || txtTongGiaoSu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khoa");
                return false;
            }
            else
            {
                float kq = 0;
                bool ketqua = float.TryParse(txtTongGiaoSu.Text, out kq);
                if (!ketqua)
                {
                    MessageBox.Show("tổng số giáo sư chưa đúng!", "Thông Báo", MessageBoxButtons.OK);
                    return false;
                }
            }
            return true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int idKhoa = int.Parse(txtMaKhoa.Text);
            Faculty deleteFaculty = context.Faculties.FirstOrDefault(p => p.FacultyID == idKhoa);
            if (deleteFaculty != null)
            {
                DialogResult result = MessageBox.Show($"Bạn có đồng ý xóa Khoa {deleteFaculty.FacultyName} không ?", "Thông báo cho bạn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    context.Faculties.Remove(deleteFaculty);
                    context.SaveChanges();

                    loadform();
                    loadDGV();

                    MessageBox.Show($"Xóa Khoa {deleteFaculty.FacultyName} thành công", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void dgvFalculty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvFalculty.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvFalculty.CurrentRow.Selected = true;
                    txtMaKhoa.Text = dgvFalculty.Rows[e.RowIndex].Cells["dgvmakhoa"].FormattedValue.ToString();
                    txtTenKhoa.Text = dgvFalculty.Rows[e.RowIndex].Cells["dgvtenkhoa"].FormattedValue.ToString();
                    txtTongGiaoSu.Text = dgvFalculty.Rows[e.RowIndex].Cells["dgvTongGS"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
