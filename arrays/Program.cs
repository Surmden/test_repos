using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace массивы_в_циклах
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 3, 7, 12 };
            int b = a.Length;
            for (int i = 0; i < b; i++)
            {
                Console.Write(a[i]);
                
                Console.Write("  ");
            }
            Console.ReadLine();
        }
    }
}
