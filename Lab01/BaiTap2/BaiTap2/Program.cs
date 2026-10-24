using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Nhap tham so a: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Nhap tham so b: ");
                double b = double.Parse(Console.ReadLine());
                if (a == 0)
                {
                    if (b == 0)
                        Console.Write("Phuong trinh co vo so nghiem");
                    else
                        Console.Write("Phuong trinh vo nghiem");
                }
                else
                {
                    double x = -b / a;
                    Console.Write("Phuong trinh co nghiem x= " + x.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Co loi xay ra: " + ex.Message);
            }
        }
    }
}
