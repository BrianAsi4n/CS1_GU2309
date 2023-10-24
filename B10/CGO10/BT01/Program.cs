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


            Console.Write("Nhập số phần tử của mảng: ");
            int N = int.Parse(Console.ReadLine());

            int[] arr = new int[N];

            // Nhập giá trị cho mảng
            for (int i = 0; i < N; i++)
            {
                Console.Write("Nhập phần tử thứ " + i + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Nhập giá trị cần chèn: ");
            int giaTriChen = int.Parse(Console.ReadLine());

            Console.Write("Nhập vị trí cần chèn: ");
            int viTriChen = int.Parse(Console.ReadLine());

            if (viTriChen < 0 || viTriChen > N)
            {
                Console.WriteLine("Vị trí không hợp lệ. Vị trí chèn phải từ 0 đến " + N);
            }
            else
            {
                // Tạo mảng mới với kích thước tăng lên 1
                int[] newArr = new int[N + 1];

                // Sao chép các phần tử từ mảng cũ vào mảng mới
                for (int i = 0; i < viTriChen; i++)
                {
                    newArr[i] = arr[i];
                }

                newArr[viTriChen] = giaTriChen;

                for (int i = viTriChen; i < N; i++)
                {
                    newArr[i + 1] = arr[i];
                }

                Console.WriteLine("Mảng mới sau khi chèn:");
                for (int i = 0; i < N + 1; i++)
                {
                    Console.WriteLine(newArr[i]);
                }
            }
        }
    }
}
