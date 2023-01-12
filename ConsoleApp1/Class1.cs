using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        internal int[] EnterArray()
        {
            Console.Write("Massivin uzunlugu:");
            int n = int.Parse(Console.ReadLine());
            int m=int.Parse(Console.ReadLine());
            int[,] arr = new int[n, m];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    Console.Write($"arr[{i},{j}]=");
                  arr[i,j] = int.Parse(Console.ReadLine());
                }
               Console.WriteLine();
            }
         }
        
    }
}
