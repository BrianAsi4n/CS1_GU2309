using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> matrix = new List<double>();
            Console.WriteLine("nhap vao cac phan tu:");
            while (true)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }
                double number = double.Parse(input);
                matrix.Add(number);
            }

            double max = matrix.Max();
            int index = matrix.IndexOf(max);

            Console.WriteLine($"gia tri lon nhat {max} tai vi tri {index}");

        }
    }
    
}
