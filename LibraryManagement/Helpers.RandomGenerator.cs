using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public static class RandomGenerator
    {
        public static string GenerateRandomISBN()
        {
            Random r = new();
            return r.Next(10001, 1000000).ToString();
        }
        public static string GenerateRandomId()
        {
            Random r = new();
            return r.Next(1, 10000).ToString();
        }
    }
}
