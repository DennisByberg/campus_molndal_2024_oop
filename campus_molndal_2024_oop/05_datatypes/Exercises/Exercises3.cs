﻿using System;
using System.Collections.Generic;

namespace campus_molndal_2024_oop._05_datatypes
{
    public static class Exercises3
    {
        // 1. Skapa en array med minst fem heltal.
        // 2. Implementera Bubble Sort för att sortera arrayen i stigande ordning.
        // 3. Skriv ut arrayen före och efter sortering.
        public static void PrintExercise1()
        {
            int[] numbers = new int[] { 32, 64, 33, 75, 21 };

            Console.WriteLine("Array before sorting:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            SortHelper.BubbleSort(numbers);

            Console.WriteLine("\nArray after sorting:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        }

        // 1. Skapa en lista med minst fem heltal.
        // 2. Skriv en metod som implementerar linjära sökning för att hitta ett specifikt tal i listan.
        // 3. Testa metoden med några olika tal.
        public static void PrintExercise2()
        {
            var numbers = new List<int> { 32, 64, 33, 75, 21 };

            int index = ListHelper.LinearSearch(numbers, 75);
            Console.WriteLine("Index of 75: " + index);
        }

        // 1. Skapa en lista med fem strängar.
        // 2. Modifiera det tredje elementet i listan till en ny sträng.
        // 3. Skriv ut listans innehåll före och efter modifieringen.
        public static void PrintExercise3()
        {
            var names = new List<string> { "Dennis", "Sune", "Polka", "Sofia", "Matteo" };

            Console.WriteLine("Before modification: " + string.Join(", ", names));

            names[2] = "Polkissen";

            Console.WriteLine("After modification: " + string.Join(", ", names));
        }
    }
}
