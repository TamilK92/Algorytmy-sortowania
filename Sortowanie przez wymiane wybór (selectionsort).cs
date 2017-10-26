// Sortowanie przez wymiane/wybor (selectionsort)
// www.algorytm.org

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SelectionSort
{
    class Program
    {
        static int sprawdzenie(string liczba)
        {
            int ilosc_liczb;

            while (!Int32.TryParse(liczba, out ilosc_liczb) || liczba.ElementAt(0) == '-')  // Sprawdz czy wpisany znak jest liczbą oraz czy jest to liczba dodatnia
            {
                Console.Write("Podaj ilość liczb do posortowania: ");
                liczba = Console.ReadLine();
            }

            return ilosc_liczb;
        }

        static void algorytm(int[] do_posortowania)         // Algorytm sortowania
        {
            int bufor;

            for (int i = 0; i < do_posortowania.Length; i++)
            {
                for (int j = i + 1; j < do_posortowania.Length; j++)
                {

                    if (do_posortowania[i] >= do_posortowania[j])    // Sprawdz czy dany element tablicy nieposortowanej jest mniejszy 
                    {                           // od elementów tablicy posortowanej. Jeśli tak to zamień elementy miejscami
                        bufor = do_posortowania[i];         
                        do_posortowania[i] = do_posortowania[j];
                        do_posortowania[j] = bufor;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int ilosc_liczb, element;
            string liczba = "nic";

            Random randomizer = new Random();

            ilosc_liczb = sprawdzenie(liczba);

            int[] do_posortowania = new int[ilosc_liczb];   // Deklaracja dwóch tablic zawierające elementy do posortowania

            Console.WriteLine("");

            for (int i = 0; i < ilosc_liczb; i++)        // Wypełnienie tablicy do posortowania liczbami losowymi
            {
                element = randomizer.Next(101);         // za zakresu 0 - 100
                do_posortowania[i] = element;
                Console.Write(do_posortowania[i] + " ");    // oraz wyświetlenie wyniku na ekranie
            }

            Console.WriteLine("");

            algorytm(do_posortowania);

            Console.WriteLine("Posortowane liczby:");
            for (int i = 0; i < ilosc_liczb; i++)        // Wyświetlenie tablicy posortwanej.
            {
                Console.Write(do_posortowania[i] + " ");
            }
            Console.Read();
        }
    }
}