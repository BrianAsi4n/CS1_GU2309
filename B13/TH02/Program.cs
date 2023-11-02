using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH02
{
    internal class Program
    {
        public static List<int> MinValue(List<int> array)
        {
            List<int> lst = new List<int>() {0};
            int min = array[0];
            int index = 0;
            int dem = 0;
            int dem2 = 0; 

            for (int i = 1; i < array.Count; i++)
            {
                dem++;
                if (array[i] < min)// tim gia tri min moi, phai resert list
                {
                    min = array[i];
                    index = i;
                    lst.Clear();
                    //lst.Add(i);
                    dem2 += 4;
                }
                //else if
                if (array[i] == min)// tim cac gis tri trung voi min
                {
                    
                    lst.Add(i);
                    dem2 += 2;
                }
            }
            Console.WriteLine(dem);
            Console.WriteLine(dem2);
            return lst;

        }
        static void Main(string[] args)
        {
           
            List<int> lst = new List<int>() { 1,4, 12, 7, 8, 1, 6, 9,1 }; 
            List<int> index = MinValue(lst);
            Console.WriteLine(String.Join(", ", index));
            Console.ReadLine();
        }
    }
}
