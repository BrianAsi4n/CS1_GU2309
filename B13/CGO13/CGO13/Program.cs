using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO13
{
    internal class Program
    {
        static int UCLN(int a,int b)
        {
            while (a*b!= 0)
            {
                if (a > b) a %= b;
                else b %= a;
            }
            return a + b;
        }
        static int gcd(int a,int b)
        {
            if (b == 0) return a;
            return gcd(b, a % b);
        }
        static int Fibonacci(int n)
        {
            if (n <= 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
            
        }
        static int dayso(int n)
        {
            if (n == 1) return -2;
            return 3 * dayso(n - 1) - 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(6));
        }
    } 
}
