using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    partial class Program
    {
        static void AddBook()
        {
            Book book = new();
            WriteLine();
            DisplayInfo("Enter the Book's details:");
            Write("Title: ");
            book.Title = ReadNotEmptyString();
            Write("Id: ");
            book.BookId = ReadNotEmptyInt();
            Write("Author: ");
            book.Author = ReadNotEmptyString();
            Write("ISBN: ");
            book.ISBN = ReadNotEmptyInt();
            Write("Genre: ");
            book.Genre = ReadNotEmptyString();
            book.Availability = true;
            DisplaySuccess("Book Created Sucsessfully");
        }
        static void AddPatron()
        {
            Patron patron = new();
            WriteLine();
            DisplayInfo("Enter the Patrons's details:");
            Write("Name: ");
            patron.Name = ReadNotEmptyString();
            Write("Id: ");
            patron.PatronId = ReadNotEmptyInt();
            Write("Email: ");
            patron.Email = ReadNotEmptyString();
            Write("Phone: ");
            patron.Phone = ReadNotEmptyInt();
            Write("Address: ");
            patron.Address = ReadNotEmptyString();
            DisplaySuccess("Book Created Sucsessfully");
        }
    }
}
