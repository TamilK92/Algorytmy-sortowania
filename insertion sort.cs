using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    class Program
    {
        public static int[] InsertionSort(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                while ((i > 0) && (tab[i] < tab[i - 1]))
                {
                    int temp = tab[i];
                    tab[i] = tab[i - 1];
                    tab[i-- - 1] = temp;
                    
                }
            } return tab;
        }
        static void Main(string[] args)
        {
            int[]tab = new int [25];
            Random r = new Random();
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = r.Next(100);
            }
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            }
            Console.WriteLine("\nposortowana:\n");
            InsertionSort(tab);
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
