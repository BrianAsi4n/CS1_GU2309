using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CGO_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //B1:lap duong dan
            string exepath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            Console.WriteLine("Duong dan thuc thi chuong trinh:"+ exepath);
            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine("Duong dan cua file exe la: "+ exeDirectory);
            string directoryName = new DirectoryInfo(exeDirectory).Name;
            Console.WriteLine("ten cua thu muc chua ten tip exe la:"+ directoryName);
            Console.ReadKey();
        }
        
    }
}
