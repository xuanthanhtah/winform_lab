using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab1_t7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode; 
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("------ Danh Sách Sinh Viên ------\n");
            List<Student> listStudents = nhapDSSV();
            xuatDSSV(listStudents);
            xuatDSCNTT(listStudents);
            XuatDSdiemhon5(listStudents);
            Sapxepdiem(listStudents);
            xuatDSCNTTVaDiemHon5(listStudents);
            xuatDSCNTTVaDiemcaonhat(listStudents);
            //do
            //{
            //    Console.WriteLine("1. Xuất danh sách sinh viên : ");
            //    Console.WriteLine("2. Xuất danh sách sinh viên công nghệ thông tin: ");
            //    Console.WriteLine("3. Xuất danh sách sinh viên điểm hơn 5 : ");
            //    Console.WriteLine("4. Sắp Xếp Điểm : ");
            //    Console.WriteLine("5. Xuất danh sách sinh viên công nghệ thông tin và điểm hơn 5: ");
            //    Console.WriteLine("6. Xuất danh sách sinh viên công nghệ thông tin và điểm cao nhất: ");
            //    int Temp = Convert.ToInt32(Console.ReadLine());
            //    Student student = new Student(); // tao 1 ps
            //    switch (Temp)
            //    {
            //        case 1:
            //            xuatDSSV(listStudents);
            //            break;
            //        case 2:
            //            xuatDSCNTT(listStudents);
            //            break;
            //        case 3:
            //            XuatDSdiemhon5(listStudents);
            //            break;
            //        case 4:
            //            Sapxepdiem(listStudents);
            //            break;
            //        case 5:
            //            xuatDSCNTTVaDiemHon5(listStudents);
            //            break;
            //        case 6:
            //            xuatDSCNTTVaDiemcaonhat(listStudents);
            //            break;

            //        default:
            //            return;
            //    }
            //} while (true);
        }
        private static List<Student> nhapDSSV()
        {
            Console.WriteLine("Nhập Số Lượng Danh Sách Sinh Viên: ");
            int N = Convert.ToInt32(Console.ReadLine());
            List<Student> listStudents = new List<Student>();
            Console.WriteLine("\n ------ Nhập Danh Sách Sinh Viên ------\n");

            // Nhập danh sách sv
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"\n ------Sinh viên thứ {i + 1} ------ \n");
                Student student = new Student();
                student.Input();
                listStudents.Add(student);
            }
            return listStudents;// ket qua tra ve
        }

        private static void xuatDSSV(List<Student> listStudents)
        {
            // Xuất danh sách sv
            Console.WriteLine("----- Danh Sách Sinh Viên là: ------");
            foreach (var i in listStudents)
            {
                i.Show();
            }
        }
        private static void xuatDSCNTTVaDiemcaonhat(List<Student> listStudents)
        {
            Console.WriteLine("------ Sinh Viên CNTT va diem cao nhất ------\n");
            List<Student> ListSVCNTTvadiemcaonhat = listStudents.Where(p =>  p.Faculty == "CNTT").ToList();
            var Diem = ListSVCNTTvadiemcaonhat.OrderByDescending(c => c.AverageScore).First();
            Diem.Show();
        }

        private static void xuatDSCNTTVaDiemHon5(List<Student> listStudents)
        {
            Console.WriteLine("------ Sinh Viên CNTT va diem hon 5 ------\n");
            List<Student> ListSVTren5 = (from s in listStudents where s.AverageScore >= 5 && s.Faculty == "CNTT" select s).ToList();
            if (listStudents.Count != 0)
            {
                xuatDSSV(ListSVTren5);
            }
            else
                Console.WriteLine("Không có sinh viên diem tren 5 va thuộc khoa CNTT");
        }

        private static void Sapxepdiem(List<Student> listStudents)
        {
            Console.WriteLine("------ Sắp Xếp điểm sinh viên ------\n");
            List<Student> SapXepDiem = listStudents.OrderBy(p => p.AverageScore).ToList();
            xuatDSSV(SapXepDiem);
        }

        private static void XuatDSdiemhon5(List<Student> listStudents)
        {
            Console.WriteLine("------ Sinh Viên diem tren 5 ------\n");
            List<Student> ListSVTren5 = (from s in listStudents where s.AverageScore >=5 select s).ToList();
            if (listStudents.Count != 0)
            {
                xuatDSSV(ListSVTren5);
            }
            else
                Console.WriteLine("Không có sinh viên diem tren 5");
        }

        private static void xuatDSCNTT(List<Student> listStudents)
        {
            Console.WriteLine("------ Sinh Viên CNTT ------\n");
            List<Student> ListSVCNTT = (from s in listStudents where s.Faculty == "CNTT" select s).ToList();
            if (listStudents.Count != 0)
            {
                xuatDSSV(ListSVCNTT);
            }
            else
                Console.WriteLine("Không có sinh viên CNTT");
        }

        

    }

}
