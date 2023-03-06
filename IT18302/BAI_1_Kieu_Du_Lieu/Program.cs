using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_Kieu_Du_Lieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            int namSinh = 2004;
            double canNang = 40.5;
            float chieuCao = 152;
            char c = 'H';
            string hoTen = "HuyenNK6";
            bool gioiTinh = true; //true- nam- false- nữ

            Console.WriteLine(hoTen);
            Console.WriteLine("Tên tôi là: "+ hoTen);
            Console.WriteLine($"Tên tôi là: {hoTen}");
            Console.WriteLine($"Năm sinh: {namSinh}| tuoi: {2023- namSinh}");
            Console.WriteLine($"Chiều cao: {chieuCao}| cân nặng: {canNang}");
        }
    }
}
