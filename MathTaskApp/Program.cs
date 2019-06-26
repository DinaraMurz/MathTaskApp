using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 300;  // количество циклов в факториале 
            int factorial = 1;   // значение факториала 

            for(int i = 0;i < 9999999; i++)
            {
                FindFactorial(n, factorial);
            }

            Console.WriteLine(factorial);
        }

        static public void FindFactorial(int n, int fact)
        {
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
        }

    }
}
