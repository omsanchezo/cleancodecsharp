using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeaningfulNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 30, 20, 50, 40, 10 };
            int i, j;
            int N = a.Length;

            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (a[i] > a[i + 1])
                        exchange(a, i, i + 1);
                }
            }

            Console.WriteLine("Sorted array:");
            foreach (var n in a)
                Console.Write($"{n} ");

            Console.WriteLine();
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }

        public static void exchange(int[] data, int m, int n)
        {
            int temporary;
            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }
    }
}
