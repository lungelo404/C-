using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int count = 0;

            for (int i = 0; count < 100; i++)
            {
                if (primeNumber(i))
                {
                    Console.WriteLine("{0}) {1}", ++count, i);
                }
            }
        }


        static bool primeNumber(int number)
        {
            bool result = true;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    break;
                }
            }

            if (number <= 1)
            {
                result = false;

            }
            return result;
        }
    }
}






