using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contest
{
    internal class _298
    {
        public static void Run()
        {
            Console.WriteLine(GreatestLetter("arRAzFif"));
            Console.WriteLine(MinimumNumbers(58, 9));
        }
        public static string GreatestLetter(string s)
        {
            string gl = "";
            for (char a = 'A';  a <= 'z'; a++)
            {
                if (s.Contains(a) && s.Contains( (char) (a + 32)))
                {
                    gl = a.ToString();
                }
            }
            return gl;
        }
        public static int MinimumNumbers(int num, int k)
        {
            if (num == 0) return 0;
            for (int i = 1; i <= 10; i++)
            {
                if ((num >= k * i) && (num - k * i) % 10 == 0) return i;
            }
            return -1;
        }
    }
}
