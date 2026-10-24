using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap4_03_
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap ho ten khong theo chuan. Chinh lai theo chuan va xuat ra");
            Console.WriteLine();

            Console.Write("Nhap ho ten (khong can theo chuan)");
            string fullname = Console.ReadLine();

            string SEPERATOR = " ";

            // Tach tu dua vao khoang trang, khong lay cac gia tri rong
            string[] parts = fullname.Split(new string[] { SEPERATOR }, StringSplitOptions.RemoveEmptyEntries);

            string ho = parts[0].Substring(0, 1).ToUpper() + // Chu dau tien viet hoa
                parts[0].Substring(1, parts[0].Length - 1).ToLower(); // Phan con lai viet thuong
            
            string tenlot = parts[1].Substring(0, 1).ToUpper() + //Chu dau tien viet hoa
                parts[1].Substring(1, parts[1].Length - 1).ToLower(); // Phan con lai viet thuong

            string ten = parts[2].Substring(0, 1).ToUpper() + //Chu dau tien viet hoa
                parts[2].Substring(1, parts[2].Length - 1).ToLower(); // Phan con lai viet thuong

            Console.WriteLine("Ten theo dung chuan la: {0} {1} {2}", ho, tenlot, ten);

            Console.ReadKey(true);
        }
    }
}
