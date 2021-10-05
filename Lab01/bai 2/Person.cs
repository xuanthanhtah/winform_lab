using System;
using System.Collections.Generic;
using System.Text;

namespace bai_2
{
    class Person
    {
        private string studentID;
        private string fullName;

        public Person()
        {

        }
        public Person(string studentID, string fullName)
        {
            this.studentID = studentID;
            this.fullName = fullName;
        }

        public string StudentID { get => studentID; set => studentID = value; }
        public string FullName { get => fullName; set => fullName = value; }

        public virtual void Input()
        {
            Console.Write("Nhập Số Người Dùng:");
            StudentID = Console.ReadLine();
            Console.Write("Nhập tên Người Dùng:");
            FullName = Console.ReadLine();
        }

        public virtual void Show()
        {
            Console.WriteLine($"Mã Số Người Dùng:{this.studentID} Họ Tên: {this.FullName} ");
        }
    }
}

