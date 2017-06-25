using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_n = args; //Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = tokens_n[2].Split(' '); //Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            int[] output = new int[n];
            Array.Copy(a, k, output, 0, n - k);

            int outputIndex = n - k;
            for (int i = 0; i < k; i++)
            {
                output[outputIndex++] = a[i];
            }

            Console.WriteLine(string.Join(" ", output));
            Console.ReadLine();
        }
    }
}
