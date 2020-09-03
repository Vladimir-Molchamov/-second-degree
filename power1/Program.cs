using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace power1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите что нужно ввести во вторую степень");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n * n);
            Console.ReadKey();
        }
    }
}
