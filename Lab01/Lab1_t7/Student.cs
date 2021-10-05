using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_t7
{
    class Student
    {
        private string studentID;
        private string fullName;
        private float averageScore;
        private string faculty;


        public Student()
        {

        }

        public Student(string studentID, string fullName, float averageScore, string faculty)
        {
            this.studentID = studentID;
            this.fullName = fullName;
            this.averageScore = averageScore;
            this.faculty = faculty;
        }

        public string StudentID { get => studentID; set => studentID = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public float AverageScore { get => averageScore; set => averageScore = value; }
        public string Faculty { get => faculty; set => faculty = value; }



        /// <summary>
        /// Hàm nhập sinh viên
        /// </summary>
        public  void Input()
        {
            Console.Write("Nhập Mssv:");
            StudentID = Console.ReadLine();
            Console.Write("Nhập tên Sinh vien:");
            FullName = Console.ReadLine();
            //AverageScore = float.Parse(Console.ReadLine());
            float kq;
            bool ketqua;
            do
            {
                Console.Write("Nhập DTB:");
                string textInput = Console.ReadLine();
                ketqua = float.TryParse(textInput, out kq);
            } while (!ketqua);

            AverageScore = kq;

            Console.Write("Nhập Khoa:");
            Faculty = Console.ReadLine();

            // xóa dữ liệu
            Console.Clear();
        }

        /// <summary>
        /// Hàm xuất sinh viên
        /// </summary>
        public  void Show()
        {
            Console.WriteLine($"Mã Số Người Dùng:{this.studentID} Họ Tên: {this.FullName} DTB: {this.AverageScore} Khoa: {this.Faculty}");
        }

    }
}
