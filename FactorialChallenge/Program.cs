using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial.reverseFactorial(120));
            Console.WriteLine(Factorial.reverseFactorial(150));
            Console.ReadLine();
        }
    }

    static class Factorial
    {
        public static String reverseFactorial(int n)
        {
            int number = n;

            int divisor = 2;
            while (number % divisor == 0)
            {
                number /= divisor;
                divisor++;

            }
            return String.Format("{0} = ", n) + ((divisor % number == 0) ? String.Format("{0}", divisor - 1) : "NONE");

        }

    }
}
