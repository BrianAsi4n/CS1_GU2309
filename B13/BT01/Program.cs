using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT01
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<int> lst = new List<int>() { 1, 2,4,12, 7, 8, 1, 6, 9, 1 };
            int value = 2;

           lst.Remove(value);
            Console.WriteLine(String.Join(", ", lst));
        }
    }
}
