﻿using System;

namespace campus_molndal_2024_oop._02_basiccsharp
{
    public static class OperatorsAndExpressions
    {
        // Beräknar och skriver ut
        public static void PrintExercise1()
        {
            // Summan av 10 och 20.
            Console.WriteLine(10 + 20);

            // Skillnaden mellan 100 och 30.
            Console.WriteLine(100 - 30);

            // Produkten av 5 och 7.
            Console.WriteLine(5 * 7);

            // Kvoten när 20 delas med 4.
            Console.WriteLine(20 / 4);

            // Resten när 10 delas med 3.
            Console.WriteLine(10 % 3);
        }

        // Jämför två tal och skriver ut resultatet av jämförelser
        public static void PrintExercise2()
        {
            const int a = 15;
            const int b = 20;

            // Är a lika med b?
            Console.WriteLine(a == b);
            // Är a större än b?
            Console.WriteLine(a > b);
            // Är a mindre än eller lika med b?
            Console.WriteLine(a <= b);
        }

        // Använder logiska operatorer för att utvärdera uttryck
        public static void PrintExercise3()
        {
            const int x = 10;
            const int y = 5;
            const int z = 20;

            // Är x större än y OCH z större än y?
            Console.WriteLine(x > y && z > y);

            // Är x större än y ELLER z mindre än y?
            Console.WriteLine(x > y || z < y);

            // Negera resultatet av x > y.
            Console.WriteLine(!(x > y));
        }

        // Beräknar och skriver ut resultatet av ett uttryck som använder både aritmetiska och jämförelseoperatorer
        public static void PrintExercise4()
        {
            Console.WriteLine((10 + 5) * 2 > 20);
        }

    }
}
