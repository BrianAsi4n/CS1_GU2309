using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO13
{
    internal class Program
    {
        public static void Swap(int n1, int n2)
        {
            Console.WriteLine("\t Inside the swap method");
            Console.WriteLine("\t\t before swapping, n1 is" + n1 + "and n2 is" + n2);

            int temp = n1;
            n1 = n2;
            n2 = temp;

            Console.WriteLine("\t\t After swapping, nq is " + n1 + "and n2 is" + n2);

        }

        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 2;
            Console.WriteLine("Before invoking the swap method, num1 is" + num1 + "and num2 is " + num2);
            Swap(num1, num2);
            Console.WriteLine("after invoking the swap method, num1 is " + num1 + " and num2 is" + num2);
        }
    }
    } 

