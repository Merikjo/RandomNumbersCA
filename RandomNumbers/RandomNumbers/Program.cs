using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            InitArray();
        }

        private static void InitArray()
        {
            int[] arr = new int[10];

            Random rnd = new Random();
            int tmp;

            for (int i = 0; i < arr.Length; i++)
            {
                tmp = rnd.Next(11);
                while (IsDup(tmp, arr))
                {
                    tmp = rnd.Next(11);
                }
                arr[i] = tmp;
            }
            PrintTheArray(arr);
        }


        private static void PrintTheArray(int[] arr)
        {
           foreach (var item in arr)
            {
                Console.WriteLine(item);
                Console.ReadLine();
            }
        }

        private static bool IsDup(int tmp, int[] arr)
        {
            foreach (var item in arr)
            {
                if (item == tmp)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
