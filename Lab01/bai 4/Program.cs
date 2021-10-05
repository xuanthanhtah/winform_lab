using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace bai_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("------ Danh Sách Nhà ------");
            //List<khudat> ListHouse = NhapDSHouse();
            //XuatDSHouse(ListHouse);
            List<khudat> ListHouse = NhapNha();
            XuatNha(ListHouse);
            TongGiaBan(ListHouse);
            Xuatdskhudat(ListHouse);
            TimkiemNha(ListHouse);
        }

        private static bool KiemTra(khudat i, String diaChicantim, double giaBancantim, int dienTichcantim)
        {
            if (i.Diadiem1.ToLower().StartsWith(diaChicantim.ToLower()) && i.GiaBan1 <= giaBancantim && i.DienTich1 >= dienTichcantim)
                return true;
            return false;
        }
        private static void TimkiemNha(List<khudat> listHouse)
        {
            String diadiem;
            double GiaBan; 
            int DienTich;
            Console.WriteLine("Nhập địa điểm cần tìm : ");
            diadiem = Console.ReadLine();
            Console.WriteLine("Nhập giá cần tìm : ");
            GiaBan = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập diện tích cần tìm : ");
            DienTich = int.Parse(Console.ReadLine());

            foreach (khudat i in listHouse)
            {
                if (KiemTra(i, diadiem, GiaBan, DienTich)) 
                    i.Show();
            }
        }

        

        private static void Xuatdskhudat(List<khudat> listHouse)
        {
            Console.WriteLine("Danh sách các khu đất là: ");
            List<khudat> danhsachcackhudat = listHouse.Where(a => a.DienTich1 > 100).ToList();
            var listhousee = listHouse.OfType<NhaPho>();
            List<khudat> danhsachcacnhapho = listhousee.Where(a => a.DienTich1 > 60 && a.NamXaydung1 >= 2020).Cast<khudat>().ToList();
            foreach (khudat item in danhsachcackhudat)
            {
                item.Show();
            }
            foreach (khudat item in danhsachcacnhapho)
            {
                item.Show();
            }
        }

        private static void TongGiaBan(List<khudat> listHouse)
        {
            
            float sum = 0;
            foreach (var i in listHouse)
            {
                sum = (float)(sum + i.GiaBan1);
            }
            Console.WriteLine("Tổng giá bán các khu nhà là:{0}", sum);
        }

        private static void XuatNha(List<khudat> ListHouse)
        {
            Console.WriteLine("----- Danh Sách Nhà: ------");
            foreach (var i in ListHouse)
            {
                i.Show();
            }
        }

        private static List<khudat> NhapNha()
        {
            Console.WriteLine("----- Chọn Khu nhà bạn cần------");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("\nNhập Số Lượng Nhà:");
            int N = Convert.ToInt32(Console.ReadLine());
            List<khudat> ListHouse = new List<khudat>();
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Bạn Muốn nhà nào: ");
                Console.WriteLine("1. Khu Đất: ");
                Console.WriteLine("2. Nhà Phố: ");
                Console.WriteLine("3. Chung cư: ");
                int Temp = Convert.ToInt32(Console.ReadLine());
                khudat khunha = new khudat(); // tao 1 ps
                switch (Temp)
                {
                    case 1:
                        khunha = new khudat();
                        break;
                    case 2:
                        khunha = new NhaPho();
                        break;
                    case 3:
                        khunha = new chungcu();
                        break;
                    default:
                        Console.WriteLine("Nhập Lại");
                        break;
                }
                khunha.Input();
                ListHouse.Add(khunha);
            }


            return ListHouse;// ket qua tra ve
        }

        private static void XuatDSHouse(List<khudat> listHouse)
        {
            Console.WriteLine("----- Danh Sách Sinh Viên là: ------");
            foreach (var i in listHouse)
            {
                i.Show();
            }
        }

        private static List<khudat> NhapDSHouse()
        {
            Console.WriteLine("Nhập Số Lượng Nhà: ");
            int N = Convert.ToInt32(Console.ReadLine());
            List<khudat> ListHouse = new List<khudat>();
            Console.WriteLine(" ------ Nhập Danh Sách Nhà ------");

            // Nhập danh sách sv
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($" ------Nhà thứ {i + 1} ------");
                khudat house = new khudat();
                house.Input();
                ListHouse.Add(house);
            }
            return ListHouse;
        }
    }
}

