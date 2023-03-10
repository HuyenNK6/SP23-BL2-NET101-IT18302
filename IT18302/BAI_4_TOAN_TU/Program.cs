using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_4_TOAN_TU
{
    internal class Program
    {
        /*
         * 4 Loại toán tử trong lập trình
         *  1. Toán tử số học:
         *  (+ - * / % ++ --)
         *      +: Tính tổng của 2 số hoặc dùng để cộng chuỗi
         *      -: Phép trừ của 2 số
         *      *: Phép nhân của 2 số
         *      %: Phép chia lấy dư của 2 số
         *      ++: Tăng lên 1 đơn vị
         *      --: Giảm 1 đơn vị
         *  2. Toán tử so sánh:
         *  (> < >= <= == !=)
         *      >: Lớn hơn
         *      <: nhỏ hơn
         *      >=: lớn hơn hoặc bằng
         *      <=: nhỏ hơn hoặc bằng
         *      ==: so sánh bằng
         *      !=: so sánh khác
         *  3. Toán tử Logic:
         * (&& || !)
         *      &&: Yêu cầu các mệnh đề phải luôn đúng
         *      ||: Yêu cầu 1 trong các mệnh đề dúng là được
         *      !: Lấy giá trị phủ định của mệnh đề.
         *  4. Toán tử gán:
         * (= += -= *= /= %=)
         *      +=: Cộng tiếp với vế bên phải các phép còn lại tương tự
         */

        /*
         * Toán tử ba ngôi
         *  <biểu thức> ? <kết quả đúng> : <kết quả sai>
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            //Nhập và xuất thông tin của máy điều hòa 
            //ma: string
            //hang: string
            //gia: double
            //namSX: int
            //isNew: bool => true/false

            //cw    tab tab
            Console.WriteLine("---------NHẬP---------");
            //ma: string
            Console.Write("Nhập mã: ");
            string ma = Console.ReadLine();
            //hang: string
            Console.Write("Nhập hãng: ");
            string hang= Console.ReadLine();
            //gia: double
            Console.Write("Nhập giá: ");
            double gia = Convert.ToDouble(Console.ReadLine());
            //namSX: int
            Console.Write("Nhập năm sản xuất: ");
            int namSX = Convert.ToInt32(Console.ReadLine());
            //isNew: bool
            Console.Write("Còn mới hay cũ (true/false)? ");
            bool isNew = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("---------XUẤT---------");
            Console.WriteLine($"ma= {ma}");
            Console.WriteLine($"hang= {hang}");
            Console.WriteLine($"gia= {gia}");
            Console.WriteLine($"namSX= {namSX}");
            Console.WriteLine($"isNew= {isNew}");
            Console.WriteLine($"isNew= {( isNew == true ? "Máy Mới" : "Máy Cũ" )}");

            //(isNew) => (isNew == true)
            //(!isNew) => (isNew == false)
            if (!isNew)
            {
                Console.WriteLine("Máy Cũ");
            }
            else
            {
                Console.WriteLine("Máy Mới");
            }
            //////////////////////
            //Console.Read(); Đọc 1 ký tự từ bàn phím nhưng là số ASCII
            Console.WriteLine("Nhập màu sắc: ");
            int mauSac = Console.Read();
            Console.WriteLine(mauSac);
            ////////
            /////var: nhận tất cả kiểu dữ liệu
            int a;
            var v1 = 10;
            var v2 = true;
            var v3 = "HuyenNK6";
            //var v4; => phải khởi tạo luôn giá trị

        }
    }
}
