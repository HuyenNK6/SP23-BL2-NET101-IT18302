using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_7_MANG
{
    internal class Program
    {
        /*
        * Mảng 1 chiều
        *
        *  1. Định nghĩa: Mảng dùng để lưu trữ nhiều phần tử có cùng kiểu dữ liệu (Biến dùng để lưu trữ 1 giá trị có cùng kiểu dữ liệu).
        *          - Để truy xuất (để lấy giá trị) các phần tử thì cần phải biết chỉ số(index). Index là số nguyên và bắt đầu từ 0 1 2 3....
        *
        *  2. Khai báo 1 mảng trong Csharp:
        *          - Cách 1:
        *              <Kiểu dữ liệu>[] arr<Tên Mảng>;
        *              arr<Tên Mảng> = new <Kiểu dữ liệu>[length];//Khởi tạo mảng có kích thước.
        *          - Cách 2: 
        *              <Kiểu dữ liệu>[] arr<Tên Mảng> = new <Kiểu dữ liệu>[length];
        *
        *          - Cách 3:
        *     <Kiểu dữ liệu>[] arr<Tên Mảng> = new <Kiểu dữ liệu>[] {value1,value2..,valuen};//Khởi tạo mảng kiểu tường minh.
        *
        *     <Kiểu dữ liệu>[] arr<Tên Mảng> = new [] {value1,value2..,valuen};//Khởi tạo kiểu ngầm đinhj
        *
        *  3. Truy xuất các phần tử trong mảng
        *      - Gán giá trị cho mảng:
        *           <tên mảng>[index] = Giá trị cần gán.
        *   
        *     - Lấy giá trị trong mảng:
        *          <tên mảng>[index] = Giá trị của mảng tại vị trí.
        *      Lưu ý: Để lấy nhiều giá trị trong mảng xuất ra cần sử dụng vòng lòng.
        *
        *  4. Kích thước hoặc độ dài của mảng sử dụng thuộc tính length.
        *      <tên mảng>.length = kích thước mảng có kiểu số nguyên
        */
        /*
       * Thao tác với mảng
       *  ***Phương thức của Array
       *      + SetValue(<giá trị>,<index>): Gán giá trị cho phần tử ở vị trí.
       *      + GetValue(index): lấy giá trị ở vị trí
       *      + IndexOf(<Array>,<value>): Tìm kiếm vị trí của phần tử
       *      + GetLength(0): Trả ra số lượng phần tử trong mảng
       *      + Reverse(<mảng>): Đảo ngược mảng
       *      + Sort(Array): Sắp xếp mảng tăng dần

       */
        static void Main(string[] args)
        {
            //1. khai báo mảng
            //int arrSo[50];
            int[] arrSo;

            //2. Khởi tạo mảng
            //arrSo = { 1, 2, 3, 4, 5 };
            arrSo = new int[] { 1, 2, 3, 4, 5 };

            int[] arrNum1 = new int[] { 2, 4, 6, 8 };
            int[] arrNum2 = { 6, 7, 8, 9 };
            //khai bảo 1 mảng có sẵn kích thước gồm 5 phần tử
            //có 1 phần tử là số 5
            int[] arrNum3 = new int[] { 5 };
            //kích thước gồm 5 phần tử
            int[] arrTuoi = new int[5];

            //3. gán giá trị
            //vị trí chạy từ  0- (n-1)
            arrTuoi[0] = 15;
            arrTuoi[1] = 27;
            arrTuoi[2] = 8;
            arrTuoi[3] = 32;
            arrTuoi[4] = 21;
            //arrTuoi[5] = 15;

            //4. truy xuất phần tử
            Console.WriteLine($"arrTuoi[3]= {arrTuoi[3]}");

            //5. duyệt mảng
            Console.WriteLine("Cach 1: for i");
            Console.WriteLine($"length = {arrTuoi.Length}");
            //for tab
            for (int i = 0; i < arrTuoi.Length; i++)
            {
                Console.WriteLine($"arrTuoi[{i}]= {arrTuoi[i]}");
            }
            Console.WriteLine("Cach 2: for each");
            //fore tab
            foreach (var item in arrTuoi)
            {
                Console.WriteLine(item);
            }
            /////////////////////
            
            string[] arrMonHoc = { "java", "c#", "mkt", "english" };
            double[] arrDiemTB = { 9.2, 7.5, 8.4, 6.5 };

            Console.WriteLine("Mang mon hoc");
            Array.Sort(arrMonHoc);
            Array.Reverse(arrMonHoc);
            for (int i = 0; i < arrMonHoc.Length; i++)
            {
                Console.WriteLine(arrMonHoc[i]);
            }

            Console.WriteLine("Mang diem TB");
            Array.Sort(arrDiemTB);
            Array.Reverse(arrDiemTB);
            foreach (var item in arrDiemTB)
            {
                Console.WriteLine(item);
            }

        }
    }
}
