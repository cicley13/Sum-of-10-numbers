using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Write 10 numbers between 0 to 100");
            double a = Numbers(1);
            a += Numbers(2);
            a += Numbers(3);
            a += Numbers(4);
            a += Numbers(5);
            a += Numbers(6);
            a += Numbers(7);
            a += Numbers(8);
            a += Numbers(9);
            a += Numbers(10);
            Console.WriteLine(a);
            Console.ReadLine();
        }
        static double Numbers(int k)
        {
            Console.WriteLine($"Entry # {k} ");
            double a = double.Parse(Console.ReadLine());
            if (a < 0 || a > 100)
            {
                Console.WriteLine("Invalid number. Choose a number between 0 to 100");
                a = double.Parse(Console.ReadLine());
            }
            return a;
        }
    }
}
