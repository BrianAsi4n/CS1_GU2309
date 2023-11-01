using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] students = { "Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily" };
            Console.WriteLine("nhap ten can tim vao:");
            string input = Console.ReadLine();
            bool isExist = false;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Equals(input))
                {
                    Console.WriteLine("Position of the students in the list " + input + " is: " + (i + 1));
                    isExist = true;
                    break;
                }
            }
            if (!isExist)
            {
                Console.WriteLine("Not found" + input + " in the list.");
            }*/

           
            List<string> sinhVien = new List<string>() { "Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily" };
            Console.WriteLine("nhap ten vao ");
            string tenSinhVien = Console.ReadLine();
            int viTri = sinhVien.IndexOf(tenSinhVien);
            if (viTri == -1)
            {
                Console.WriteLine("Không tìm thấy sinh viên có tên {0} trong danh sách.", tenSinhVien);
            }
            else
            {
                Console.WriteLine("Vị trí của sinh viên {0} trong danh sách là {1}.", tenSinhVien, viTri);
            }
        }
    }
}
