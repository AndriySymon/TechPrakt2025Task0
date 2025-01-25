using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть перше число: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введiть друге число: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double sum = number1 + number2;

            Console.WriteLine($"Сума чисел {number1} i {number2} дорiвнює {sum}");
        }
    }
}
