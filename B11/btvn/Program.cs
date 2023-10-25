using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btvn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 3, m = 3;
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[,] matrix = new int[n, m];

            int k = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = arr[k];
                    k++;
                }
            }

            Console.WriteLine("Ma tran vua nhap la:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
