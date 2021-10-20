using lab04.models;
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

namespace lab04
{
    public partial class QLThongTinSV : Form
    {
        dbcontext context = new dbcontext();
        public QLThongTinSV()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CBBKhoa.SelectedItem = "Công Nghệ Thông Tin";
            try
            {
                List<Faculty> listFalcultys = context.Faculties.ToList(); 
                List<Student> listStudent = context.Students.ToList();
                FillFalcultyCombobox(listFalcultys);
                BindGrid(listStudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
        private void BindGrid(List<Student> listStudent) 
        {
            DTGbangthongtin.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = DTGbangthongtin.Rows.Add();
                DTGbangthongtin.Rows[index].Cells[0].Value = item.StudentID;
                DTGbangthongtin.Rows[index].Cells[1].Value = item.Fullname;
                DTGbangthongtin.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                DTGbangthongtin.Rows[index].Cells[3].Value = item.AverageScore;
            }
        }

        private void FillFalcultyCombobox(List<Faculty> listFalcultys)
        {
            this.CBBKhoa.DataSource = listFalcultys;
            this.CBBKhoa.DisplayMember = "FacultyName";
            this.CBBKhoa.ValueMember = "FacultyID";
        }
    


        private void btnThem_Click(object sender, EventArgs e)
        {   
            if(checkdatainput())
            {
                if (checkidSinhVien(txtMSSV.Text) == -1)
                {
                    Student newstudent = new Student();
                    newstudent.StudentID = txtMSSV.Text;
                    newstudent.Fullname = txtHoTen.Text;
                    newstudent.AverageScore = Convert.ToDouble(txtDiemTB.Text);
                    newstudent.FacultyID = Convert.ToInt32( CBBKhoa.SelectedValue.ToString());

                    context.Students.AddOrUpdate(newstudent);
                    context.SaveChanges();

                    loadDGV();

                    loadform();
                    MessageBox.Show($"thêm sinh viên {newstudent.Fullname} thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Sinh viên có mã số {txtMSSV.Text} đã tồn tại!", "Thông Báo", MessageBoxButtons.OK);

                }
            }    
        }

        private void loadform()
        {
            txtMSSV.Clear();
            txtHoTen.Clear();
            txtDiemTB.Clear();

        }

        private void loadDGV()
        {
            List<Student> newListStudent = context.Students.ToList();
            BindGrid(newListStudent);
        }



        private int checkidSinhVien(string idnewStudent)
        {
            int length = DTGbangthongtin.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if(DTGbangthongtin.Rows[i].Cells[0].Value != null)
                    if (DTGbangthongtin.Rows[i].Cells[0].Value.ToString() == idnewStudent)
                        return i;
            }
            return -1;
        }

        private bool checkdatainput()
        {
            if (txtMSSV.Text == "" || txtHoTen.Text == "" || txtDiemTB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên");
                return false;
            }
            else
            {
                float kq = 0;
                bool ketqua = float.TryParse(txtDiemTB.Text, out kq);
                if (!ketqua)
                {
                    MessageBox.Show("điểm sinh viên chưa đúng!", "Thông Báo", MessageBoxButtons.OK);
                    return false;
                }
            }
            return true;
            int mssvLength = txtMSSV.TextLength;
            if (mssvLength < 10 || mssvLength > 10)
            {
                MessageBox.Show("Mã số sinh viên phải 10 ký tự", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (checkdatainput())
            {
                //lấy ra phần tử đầu tiên để thỏa mãn dk
                Student updateStudent = context.Students.FirstOrDefault(p => p.StudentID == txtMSSV.Text);
                if(updateStudent !=null)
                {
                    
                    updateStudent.Fullname = txtHoTen.Text;
                    updateStudent.AverageScore = Convert.ToInt32( txtDiemTB.Text);
                    updateStudent.FacultyID = Convert.ToInt32(CBBKhoa.SelectedValue.ToString());
                    
                    context.Students.AddOrUpdate(updateStudent);
                    context.SaveChanges();

                    reloadDGV();
                    reloadform();
                    MessageBox.Show($"chỉnh sữa dữ liệu sinh viên{updateStudent.Fullname} thành công", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên cần sửa", "Thông Báo", MessageBoxButtons.OK);
                }
            }
        }

        private void reloadform()
        {
            txtMSSV.Clear();
            txtHoTen.Clear();
            txtDiemTB.Clear();

        }

        private void reloadDGV()
        {
            List<Student> Liststudents = context.Students.ToList();
            BindGrid(Liststudents);
        }

        private void DTGbangthongtin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DTGbangthongtin.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DTGbangthongtin.CurrentRow.Selected = true;
                    txtMSSV.Text = DTGbangthongtin.Rows[e.RowIndex].Cells["dgvmssv"].FormattedValue.ToString();
                    txtHoTen.Text = DTGbangthongtin.Rows[e.RowIndex].Cells["dgvHoTen"].FormattedValue.ToString();
                    CBBKhoa.Text = DTGbangthongtin.Rows[e.RowIndex].Cells["dgvKhoa"].FormattedValue.ToString();
                    txtDiemTB.Text = DTGbangthongtin.Rows[e.RowIndex].Cells["dgvDTB"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Student deleteStudent = context.Students.FirstOrDefault(p => p.StudentID == txtMSSV.Text);
                if (deleteStudent != null)
                {
                    DialogResult result = MessageBox.Show($"Bạn có đồng ý xóa sinh viên {deleteStudent.Fullname} không ?", "Thông báo cho bạn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                        if (result == DialogResult.Yes)
                        {
                            context.Students.Remove(deleteStudent);
                            context.SaveChanges();

                            reloadform();
                            reloadDGV();

                             MessageBox.Show($"Xóa sinh viên {deleteStudent.Fullname} thành công", "Thông báo", MessageBoxButtons.OK);
                        }
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
            frmFalculty frmFalculty = new frmFalculty();
            frmFalculty.Show();
        }

        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFalculty frmFalculty = new frmFalculty();
            frmFalculty.Show();
        }

        private void TSTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiem frmTimKiem = new frmTimKiem();
            frmTimKiem.Show();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiem frmTimKiem = new frmTimKiem();
            frmTimKiem.Show();
        }

        private void CBBKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
