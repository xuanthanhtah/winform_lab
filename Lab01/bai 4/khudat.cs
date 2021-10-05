using System;
using System.Collections.Generic;
using System.Text;

namespace bai_4
{
    class khudat
    {
            private string Diadiem;
            private double GiaBan;
            private int DienTich;


            public khudat()
            {

            }
            public khudat(string diadiem, double giaBan, int dienTich)
            {
                Diadiem = diadiem;
                GiaBan = giaBan;
                DienTich = dienTich;
            }

            public string Diadiem1 { get => Diadiem; set => Diadiem = value; }
            public double GiaBan1 { get => GiaBan; set => GiaBan = value; }
            public int DienTich1 { get => DienTich; set => DienTich = value; }

            public virtual void Input()
            {
                Console.WriteLine("Nhập tên địa điểm: ");
                Diadiem = Console.ReadLine();
                Console.WriteLine("Nhập tên giá bán: ");
                GiaBan = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhập tên diện tích: ");
                DienTich = int.Parse(Console.ReadLine());

            }

            public virtual void Show()
            {
                Console.WriteLine($"Địa điểm {this.Diadiem} Giá bán {this.GiaBan} Diện tích {this.DienTich}");
            }
        }
    
}
