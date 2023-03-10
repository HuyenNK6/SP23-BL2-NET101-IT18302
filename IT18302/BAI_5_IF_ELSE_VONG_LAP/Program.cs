using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_5_IF_ELSE_VONG_LAP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Vòng For
            //for tab
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Nhap so luong n= ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"So chan tu 0-{n}");
            for (int i = 0; i < n; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            //2. Vòng WHILE
            //whi tab
            int a = 0;
            while (a < 15)
            {
                if(a == 10)
                {
                    Console.WriteLine("Co Huyen xinh gai " + a);
                    //break;
                    a++;
                    continue;
                }
                Console.WriteLine("Co Huyen hien nhat BM "+ a);
                a++;
            }
            //3. Vòng Do-While
            int k = 50;
            //do tab
            do
            {
                Console.WriteLine(k + " co Huyen de thuong");
                k++;
            } while (k < 20);



            //////////////
            int x = 2;
            int y = 5;
            int z = y - (++x);//5-2
            Console.WriteLine(z); //3 x++ 2 ++x
            Console.WriteLine(x); //3
        }
    }/*
      * Bài 1: Nhập và xuất thông tin Xe Máy
      * - id: int
      * - hang: string
      * - gia: double
      * - phanKhoi: int
      * - isVietNam: bool 
      * => yêu cầu in ra true là Xe Máy Việt Nam/ false là Xe Máy Nước Ngoài
      * 
      * Bài 2: Nhập min- max (int) từ bàn phím
      * - Nếu người dùng nhập min/max <0 yêu cầu nhập lại
      * - In ra tất cả các số lẻ trong khoảng min-max
      * - và đếm xem có bao nhiêu số lẻ đó
      */
}
