

/*
* Sortowanie Bąbelkowe
* www.algorytm.org
* Opracował: Patryk Pasek
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        //Sortowanie babelkowe
        static void sort(int[] tablica)
        {
            int n = tablica.Length;
            do
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (tablica[i] > tablica[i + 1])
                    {
                        int tmp = tablica[i];
                        tablica[i] = tablica[i + 1];
                        tablica[i + 1] = tmp;
                    }
                }
                n--;
            }
            while (n > 1);
        }

        static void Main(string[] args)
        {
            //tablica do posortowania
            int[] arr = { 1000, 33, 123, 10, 1, 12442, 99, 111 };

            //wypisz zawartosc przed sortowaniem
            Console.WriteLine("\n Przed sortowaniem : \n");
            for (int z = 0; z < arr.Length; z++)
            {
                Console.Write(arr[z] + ", ");
            }

            //sortuj babelkowo
            sort(arr);

            //wypisz zawartosc po sortowaniu
            Console.WriteLine("\n\n\n Po sortowaniu : \n");
            for (int z = 0; z < arr.Length; z++)
            {
                Console.Write(arr[z] + ", ");
            }

            Console.ReadKey();
        }
    }
}