using System;
using System.Collections.Generic;
using System.Text;

namespace bai_2
{
    class Teacher : Person
    {
        private string Diachi;

        public Teacher()
        {

        }
        public Teacher(string diachi, string studentID, string fullName) : base(studentID, fullName)
        {
            Diachi = diachi;
        }

        public string Diachi1 { get => Diachi; set => Diachi = value; }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhập dia chi:");
            Diachi = Console.ReadLine();

            // xóa dữ liệu
            Console.Clear();
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Dia chi: {this.Diachi1}");
        }
    }
}
