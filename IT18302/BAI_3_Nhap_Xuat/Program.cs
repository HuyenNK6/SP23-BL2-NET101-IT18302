using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_Nhap_Xuat
{
    internal class Program
    {
        /*
         * BÀI 3 Nhập xuất dữ liệu từ bàn phím
         *  1. Xuất dữ liệu ra màn hình
         *      + Phím tắt : cw + tab
         *      + Console.WriteLine(); Ghi xong thì xuống dòng
         *      + Console.Write(); Ghi xong thì không xuống dòng
         *  2. Nhập dữ liệu từ bàn phím:
         *      + Console.Read(); Đọc 1 ký tự từ bàn phím nhưng là số ASII
         *      + Console.ReadLine();  Đọc nhiều ký tự từ bàn phím và kiểu dữ liệu là string - chuỗi
         */
        static void Main(string[] args)
        {
            //muốn gõ tiếng việt thì 2 dòng này
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            //Nhập & xuất thông tin sinh viên từ bàn phím

            //PHẦN 1: NHẬP
            //Console.ReadLine();
            //đọc 1 dòng dữ liệu từ bàn phím => string
            Console.WriteLine("Nhập thông tin SV");
            //msv: string
            Console.Write("Nhập mã sv: ");
            string msv = Console.ReadLine();
            //hoTen: string
            Console.Write("Nhập họ tên: ");
            string hoTen = Console.ReadLine();
            //namSinh: int
            Console.WriteLine("Nhập năm sinh: ");
            int namSinh = Convert.ToInt32(Console.ReadLine());
            //diem: double
            Console.WriteLine("Nhập điểm: ");
            double diem= Convert.ToDouble(Console.ReadLine());
            //isBoy: bool -> true: nam, false: nữ
            Console.WriteLine("Là nam- true hay nữ-false? ");
            bool isBoy = Convert.ToBoolean(Console.ReadLine());

            //PHẦN 2: XUẤT
            Console.WriteLine("Xuất thông tin SV");
            Console.WriteLine($"msv= {msv}");
            Console.WriteLine($"hoTen= {hoTen}");
            Console.WriteLine($"tuoi= {2023- namSinh}");
            Console.WriteLine($"diem= {diem}");
            Console.WriteLine($"isBoy= {isBoy}");

            /*
             * Bài tập: nhập và xuất thông tin 
             * món quà 8/3 tặng NY
             * - tenQua: string
             * - giaTien: double
             * - soLuong: int
             * - xuatXu: string
             * - isNew: bool //true- mới, false- cũ
             */

        }
    }
}
