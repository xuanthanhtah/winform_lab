using System;
using System.Collections.Generic;
using System.Text;

namespace bai_4
{
    class chungcu : khudat
    {
        private int Sotang;

        public chungcu()
        {

        }

        public chungcu(int sotang, string diadiem, double giaBan, int dienTich) : base( diadiem, giaBan, dienTich)
        {
            Sotang = sotang;
        }

        public int Sotang1 { get => Sotang; set => Sotang = value; }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhập số tầng: ");
            Sotang = int.Parse(Console.ReadLine());
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Số Tầng: {this.Sotang}");
        }
    }
}
