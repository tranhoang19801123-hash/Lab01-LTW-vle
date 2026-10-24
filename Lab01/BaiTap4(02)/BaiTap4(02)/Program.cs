using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap4_02_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap ho ten day du. Xuat ra tung phan");
            Console.WriteLine();

            Console.Write("Nhap ho ten:");
            string fullname = Console.ReadLine();

            string SPACE = " ";
            string[] parts = fullname.Split(new string[] { SPACE }, StringSplitOptions.None);

            Console.WriteLine("Ho: {0}, ten lot: {1}, ten: {2}", parts[0], parts[1], parts[2]);

            Console.ReadKey(true);
        }
    }
}
