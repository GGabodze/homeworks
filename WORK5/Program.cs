using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WORK5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region work1

            Console.WriteLine("shemoiyvane cifri");
            var num = Convert.ToInt32(Console.ReadLine());
            if (num % 5 == 0)
            {
                Console.WriteLine("yes");
            }
            else
            {
               Console.WriteLine("No");
            }

            #endregion


            Console.WriteLine("shemoiyvane cifri");
            var numb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("shemoiyvane meore cifri");

            var numb2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("shemoiyvane moqmedebis operatori");
            var numb3 = Convert.ToChar(Console.ReadLine());

            if (numb3 == '+')
            {
                Console.WriteLine(numb + numb2);
            }

            else if (numb3 == '*')
            {
                Console.WriteLine(numb * numb2);
            }

            else if (numb3 == '/')
            {
                Console.WriteLine(numb / numb2);

            }

            else if (numb3 == '%')
            {
               Console.WriteLine(numb % numb2);
                    }

            #region work3

            var a = 5;
            var b = 10;
            a = b;
            b = a;
            Console.WriteLine(a);
            Console.WriteLine(b);
            #endregion


            var n = 5;
            for (int c = 1; c < 10; c++)
            {
                Console.WriteLine($"{n} * {c}={n * c}");
            }


            var z = 10;
            int d;
            for (d = 2; d < z; d = d + 2)
            {
                if (d % 2 == 0)
                {
                    var f = d * d;
                    Console.WriteLine(f);
                }

            }

        }
    }
}
