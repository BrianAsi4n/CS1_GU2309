using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1D = { 2, 3, 4, 5, 6, 7, 8};
            int[,] arr2D = new int[3, 3];

            for (int i = 0; i < arr1D.Length; i++)
            {
                arr2D[i / 3, i % 3] = arr1D[i];
            }

            Console.WriteLine("Ma tran vua chuyen doi la:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr2D[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
