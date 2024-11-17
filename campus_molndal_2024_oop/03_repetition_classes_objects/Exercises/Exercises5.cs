﻿using System;

namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    public static class Exercises5
    {
        // Skapa en klass Library som har fält för Name och Location.
        // Skapa en klass Book med fält för Title, Author, och Year.
        // Lägg till en metod i Library som skriver ut bibliotekets namn och plats.
        // Skapa objekt av både Library och Book, och anropa metoderna för att visa information om biblioteket och en bok.
        public static void PrintExercise1()
        {
            var library = new Library("Kållered Bibliotek", "Kållered");
            var book = new Book("book1", "author1", 1994);
            var book2 = new Book("book2", "author2", 1993);

            library.AddBook(book);
            library.AddBook(book2);

            library.PrintNameAndLocation();
            library.PrintAllBooks();
        }
    }
}
