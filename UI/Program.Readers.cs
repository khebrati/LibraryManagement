using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UI
{
    partial class Program
    {
        static string ReadNotEmptyString()
        {
            string? input;
            while (true)
            {
                input = ReadLine();
                if (input is not null && input != "")
                {
                    break;
                }
                DisplayError("Input can not be null! try again:");

            }
            return input;
        }
        static int ReadNotEmptyInt()
        {
            int input;
            while (true)
            {
                try
                {
                    input = ToInt32(ReadLine());
                    break;
                }
                catch
                {
                    DisplayError("your input must be an integer, try again: ");
                }
            }
            return input;
        }
        static string ReadEmail()
        {
            string? input;
            while (true)
            {
                input = ReadLine();
                if (input is not null && IsEmail(input))
                {
                    break;
                }
                DisplayError("this is not a valid email! your email should look like this:\n"
                    + "something@something.com");

            }
            return input;
        }
        static bool IsEmail(string input)
        {
            Regex emailPattern = new(@".+@.+[.]com");
            return emailPattern.IsMatch(input);
        }
    }
}
