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

    }

}
