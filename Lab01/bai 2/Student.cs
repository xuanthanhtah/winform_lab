using System;
using System.Collections.Generic;
using System.Text;

namespace bai_2
{
    class Student : Person
    {

        private float averageScore;
        private string faculty;


        public Student()
        {

        }
        public Student(string studentID, string fullName, float averageScore, string faculty) : base(studentID, fullName)
        {

            this.AverageScore = averageScore;
            this.Faculty = faculty;
        }

        public float AverageScore { get => averageScore; set => averageScore = value; }
        public string Faculty { get => faculty; set => faculty = value; }

        /// <summary>
        /// Hàm nhập sinh viên
        /// </summary>
        public override void Input()
        {
            base.Input();
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
        public override void Show()
        {
            base.Show();
            Console.WriteLine($" DTB: {this.AverageScore} Khoa: {this.faculty}");
        }

    }
}
