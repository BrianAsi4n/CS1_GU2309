using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap kich thuoc ma tran vuong:");
                int n = int.Parse(Console.ReadLine());
            List<List<double>> matrix = new List<List<double>>();
            for(int i = 0; i<n; i++)
            {
                matrix.Add(new List<double>());
                for(int j = 0; j <n; j++)
                {
                    Console.Write($"nhap gia tri cho phan tu [{i},{j}]");
                    matrix[i].Add(double.Parse(Console.ReadLine()));
                }
            }
            double sum = 0;
            for (int i =0; i <n; i++)
            {
                sum += matrix[i][i] ;
            }
            Console.WriteLine($"tong cac phan tu o duong cheo chinh {sum}");
        }
    }
}
