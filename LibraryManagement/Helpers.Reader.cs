using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Helpers
{
    public static class Reader
    {
        public static string ReadNotEmptyString()
        {
            string? input;
            while (true)
            {
                input = ReadLine();
                if (input is not null && input != "")
                {
                    break;
                }
                WriteError("Input can not be null! try again:");

            }
            return input;
        }
        
        public static string ReadEmail()
        {
            string? input;
            while (true)
            {
                input = ReadLine();
                if (input is not null && IsEmail(input))
                {
                    break;
                }
                WriteError("this is not a valid email! your email should look like this:\n"
                    + "something@something.com");

            }
            return input;
        }
        public static bool IsEmail(string input)
        {
            Regex emailPattern = new(@".+@.+[.]com");
            return emailPattern.IsMatch(input);
        }
        public static Patron GetPatronInfoFromUser()
        {
            Patron patron = new();
            WriteLine();
            WriteInfo("Enter the Patrons's details:");
            Write("Name: ");
            patron.Name = ReadNotEmptyString();
            Write("Email: ");
            patron.Email = ReadNotEmptyString();
            Write("Phone: ");
            patron.Phone = ReadNotEmptyString();
            Write("Address: ");
            patron.Address = ReadNotEmptyString();
            return patron;
        }
        public static Book GetBookInfoFromUser()
        {
            Book book = new();
            WriteLine();
            WriteInfo("Enter the Book's details:");
            Write("Title: ");
            book.Title = ReadNotEmptyString();
            Write("Author: ");
            book.Author = ReadNotEmptyString();
            Write("Genre: ");
            book.Genre = ReadNotEmptyString();
            book.Availability = true;
            return book;
        }

        public static Patron FindPatronBasedOnUserInfo()
        {
            Patron? toBeFound = new();
            while (!UI.Program.Library.TryFindPatronByKey(ReadNotEmptyString(), out toBeFound))
            {
                WriteError("No patron with such specifications exists. Try again: ");
            }
            return toBeFound!;
        }
        public static Book FindBookBasedOnUserInfo()
        {
            Book? toBeFound = new();
            while (!UI.Program.Library.TryFindBookByKey(ReadNotEmptyString(), out toBeFound))
            {
                WriteError("No book with such specifications exists. Try again: ");
            }
            return toBeFound!;
        }
        public static Loan FindLoanBasedOnUserInfo(Patron patron)
        {
            Loan? toBeFound = new();
            while (!patron.TryFindLoan(ReadNotEmptyString(), out toBeFound))
            {
                WriteError("No Loan with such specifications exists. Try again: ");
            }
            return toBeFound!;
        }


    }

}
