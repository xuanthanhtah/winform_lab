using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab04.models;
using System.Configuration;

namespace lab04
{
    public partial class frmTimKiem : Form
    {
        dbcontext context = new dbcontext();
        public frmTimKiem()
        {

            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtTKMssv.Clear();
            txtTKHoTen.Clear();
            txtTKMssv.Focus();
        }


        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            List<Faculty> listFalcultys = context.Faculties.ToList();
            List<Student> listStudent = context.Students.ToList();
            FillFalcultyCombobox(listFalcultys);
            //BindGrid(listStudent);
            txtKetqua.Text = "0";
            
        }
        private void BindGrid(List<Student> listStudent)
        {
            dgvTimkiem.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvTimkiem.Rows.Add();
                dgvTimkiem.Rows[index].Cells[0].Value = item.StudentID;
                dgvTimkiem.Rows[index].Cells[1].Value = item.Fullname;
                dgvTimkiem.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dgvTimkiem.Rows[index].Cells[3].Value = item.AverageScore;
            }
        }


        private void FillFalcultyCombobox(List<Faculty> listFalcultys)
        {
            this.cbbTKKhoa.DataSource = listFalcultys;
            this.cbbTKKhoa.DisplayMember = "FacultyName";
            this.cbbTKKhoa.ValueMember = "FacultyID";
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTKMssv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnTimKiem.PerformClick();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<Student> listStudent = context.Students.ToList();
            if(txtTKMssv.Text == "" || txtTKHoTen.Text == "")
            {
                List<Student> listFindStudent = (from s in listStudent
                                                 where
                            s.StudentID == txtTKMssv.Text ||
                            s.Fullname == txtTKHoTen.Text ||
                            s.Faculty.FacultyID == Convert.ToInt32(cbbTKKhoa.SelectedValue)
                                                 select s).ToList();
                txtKetqua.Text = (listFindStudent.Count).ToString();
                BindGrid(listFindStudent);
            }
            if (txtTKMssv.Text != "" || txtTKHoTen.Text != "") {
                List<Student> listFindStudent2 = (from s in listStudent
                                                  where
                            s.StudentID == txtTKMssv.Text ||
                            s.Fullname == txtTKHoTen.Text
                                                  select s).ToList();
                txtKetqua.Text = (listFindStudent2.Count).ToString();
                BindGrid(listFindStudent2);
            }
            
            if (false)
            {
                List<Student> listFindStudent3 = (from s in listStudent
                                                 where
                            s.StudentID == txtTKMssv.Text ||
                            s.Fullname == txtTKHoTen.Text ||
                            s.Faculty.FacultyID == Convert.ToInt32(cbbTKKhoa.SelectedValue)
                                                 select s).ToList();
                txtKetqua.Text = (listFindStudent3.Count).ToString();
                BindGrid(listFindStudent3);
            }

        }

        private void txtTKHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTKHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnTimKiem.PerformClick();
        }

        private void btnTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtKetqua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
