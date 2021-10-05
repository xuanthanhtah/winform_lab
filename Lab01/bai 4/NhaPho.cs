using System;
using System.Collections.Generic;
using System.Text;

namespace bai_4
{
    class NhaPho : khudat
    {
        private int NamXaydung;
        private int Sotang;

        public NhaPho()
        {

        }
        public NhaPho(string diadiem, double giaBan, int dienTich, int namXaydung, int sotang) : base(diadiem,giaBan,dienTich)
        {
            NamXaydung = namXaydung;
            Sotang = sotang;
        }

        public int NamXaydung1 { get => NamXaydung; set => NamXaydung = value; }
        public int Sotang1 { get => Sotang; set => Sotang = value; }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhập năm xây dựng: ");
            NamXaydung = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số tầng: ");
            Sotang = int.Parse(Console.ReadLine());
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Nam xay dung {this.NamXaydung} So tang {this.Sotang}");
        }
    }
}
