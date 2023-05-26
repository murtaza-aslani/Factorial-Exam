using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter a number : ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"factorial = {fact(a)}");
            Console.ReadLine();
        }
        static int fact(int a)
        {
            int sum = 1;
            for (int i = 1; i <= a; i++)
            {
                sum *= i;
            }
            return sum;
        }
    }
}
