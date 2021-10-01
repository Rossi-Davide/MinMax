using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vettore = new int[5] { 3,6,7,2,4};

            int min = vettore[0];

            for (int i = 0; i < vettore.Length; i++)
            {
                if (min>vettore[i])
                {
                    min = vettore[i];
                }
            }


            Console.WriteLine(min);

            Console.ReadKey();
            int max = vettore[0];
        }
    }
}
