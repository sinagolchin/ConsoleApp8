using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    int[] a = new int[11];
        //    for (int k = 0; k <= 10; k++)
        //    {
        //        a[k] = k * 2;
        //    }
        //    for (int k = 0; k <= 10; k++)
        //    {
        //        Console.WriteLine(a[k]);
        //    }
        //    Console.ReadLine();
        //}

        //static void Main(string[] args)
        //{
        //    int[] a = new int[10];
        //    for (int k = 0; k < 10; k++)
        //    {
        //        a[k] = k * 2;
        //    }
        //    foreach (int k in a)
        //    {
        //        Console.WriteLine(k);
        //    }
        //    Console.ReadLine();
        //}

        static void Main(string[] args)
        {
            int[] arr = { 11, 35, 62, 555, 989 };
            int sum = 0;

            foreach (int x in arr)
            {
                sum += x;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
