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
            Console.Write("Nhập số hàng của ma trận: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Nhập số cột của ma trận: ");
            int cols = int.Parse(Console.ReadLine());

            double[,] matrix = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Nhập giá trị cho phần tử [{i}, {j}]: ");
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }
            }

            double max = matrix[0, 0];
            int row = 0;
            int col = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        row = i;
                        col = j;
                    }
                }
            }

            Console.WriteLine($"Giá trị lớn nhất trong ma trận là {max} tại tọa độ [{row}, {col}].");
        }
    }
    
}
