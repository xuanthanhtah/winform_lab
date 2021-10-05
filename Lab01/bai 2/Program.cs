using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace bai_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("------ Danh Sách Giảng Viên và Sinh Viên ------");
            List<Person> ListPerson = NhapPerson();
            //XuatPerson(ListPerson);
            //xuatDSCNTT(ListPerson);
            //XuatDSCNTTDiemnho5(ListPerson);
            //XuatDSGVQ9(ListPerson);
            //TimGVtheoMa(ListPerson);
            //DSSVDTBCaoNhat(ListPerson);
            do
            {
                Console.WriteLine("1. Sinh Viên Công Nghệ Thông Tin : ");
                Console.WriteLine("2. Sinh Viên Công Nghệ Thông Tin và điểm nhỏ hơn 5: ");
                Console.WriteLine("3. Giảng Viên ở Quận 9 : ");
                Console.WriteLine("4.  Giảng Viên có mã = CHN060286 : ");
                Console.WriteLine("5. Sinh Viên Công Nghệ Thông Tin và điểm cao nhất: ");
                int Temp = Convert.ToInt32(Console.ReadLine());
                Person person = new Person(); // tao 1 ps
                switch (Temp)
                {
                    case 1:
                        xuatDSCNTT(ListPerson);
                        break;
                    case 2:
                        XuatDSCNTTDiemnho5(ListPerson);
                        break;
                    case 3:
                       
                        XuatDSGVQ9(ListPerson);
                        break;
                    case 4:
                        TimGVtheoMa(ListPerson);
                        break;
                    case 5:
                        DSSVDTBCaoNhat(ListPerson);
                        break;

                    default:
                        Console.WriteLine("Nhập Lại đi");
                        return;
                }
            } while (true);
            
        }

        static List<Person> ListPerson = new List<Person>();
        private static void DSSVDTBCaoNhat(List<Person> listPerson)
        {
            Console.WriteLine("------ Sinh Viên CNTT và điểm trung bình cao nhất ------");
            var ListCntt = ListPerson.OfType<Student>();
            float diemcaonhat = ListCntt.Max(a => a.AverageScore);
            List<Student> ListSVCNTT = (from s in ListCntt where s.Faculty == "CNTT" && s.AverageScore == diemcaonhat select s).ToList();
            if (ListSVCNTT.Count == 0)
            {
                Console.WriteLine("Không có Sinh Viên CNTT và điểm trung bình cao nhất ");
            }
            else
                foreach (var item in ListSVCNTT)
            {
                item.Show();
            }
        }

        
        private static void TimGVtheoMa(List<Person> listPerson)
        {
            Console.WriteLine("------ Giảng Viên có mã là CHN060286 :------");
            var ListCntt = ListPerson.OfType<Teacher>();
            List<Student> ListSVCNTT = (from s in ListCntt where s.StudentID == "CHN060286" select s).Cast<Student>().ToList();
            if (ListSVCNTT.Count == 0)
            {
                Console.WriteLine("Không có Giảng Viên có mã là CHN060286");
            }
            else
                foreach (var item in ListSVCNTT)
            {
                item.Show();
            }
        }

        
        private static void XuatDSGVQ9(List<Person> listPerson)
        {
            Console.WriteLine("------ Giảng Viên ở Quận 9 ------");
            var ListCntt = ListPerson.OfType<Teacher>();
            List<Person> ListSVCNTT = (from s in ListCntt where s.Diachi1 == "Quận 9" select s).Cast<Person>().ToList();
            if(ListSVCNTT.Count == 0)
            {
                Console.WriteLine("Không có GV ở  Quận 9");
            }
            else

            foreach (var item in ListSVCNTT)
            {
                item.Show();
            }
        }

        
        private static void XuatDSCNTTDiemnho5(List<Person> listPerson)
        {
            Console.WriteLine("------ Sinh Viên CNTT và điểm nhỏ hơn 5 ------\n");
            var ListCntt = ListPerson.OfType<Student>();
            List<Student> ListSVCNTT = (from s in ListCntt where s.Faculty == "CNTT" && s.AverageScore < 5 select s).ToList();
            if (ListSVCNTT.Count == 0)
            {
                Console.WriteLine("Không có Sinh Viên CNTT và điểm nhỏ hơn 5");
            }
            else
                foreach (var item in ListSVCNTT)
            {
                item.Show();
            }
        }

        

        private static void xuatDSCNTT(List<Person> listPerson)
        {
            Console.WriteLine("------ Sinh Viên CNTT ------\n");
            var ListCntt = ListPerson.OfType<Student>();
            List<Student> ListSVCNTT = (from s in ListCntt where s.Faculty == "CNTT" select s).ToList();
            if (ListSVCNTT.Count == 0)
            {
                Console.WriteLine("Không có Sinh Viên CNTT");
            }
            else
                foreach (var item in ListSVCNTT)
            {
                item.Show();
            }
        }

        private static void XuatPerson(List<Person> listPerson)
        {
            Console.WriteLine("----- Danh Sách Người cần nhập là: ------");
            foreach (var i in listPerson)
            {
                i.Show();
            }
        }

        private static List<Person> NhapPerson()
        {
            Console.WriteLine("----- Chọn Chức Năng Bạn Cần------");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("\nNhập Số Lượng Danh Sách Người Dùng:");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Bạn Muốn Nhập GV hay SV: ");
                Console.WriteLine("1. Giảng Viên: ");
                Console.WriteLine("2. Sinh Viên: ");
                
                int Temp = Convert.ToInt32(Console.ReadLine());
                Person person = new Person(); // tao 1 ps
                switch (Temp)
                {
                    case 1:
                        person = new Teacher();
                        break;
                    case 2:
                        person = new Student();
                        break;
                    default:
                        break;
                }
                person.Input();
                ListPerson.Add(person);
            }


            return ListPerson;// ket qua tra ve
        }

    }
}
