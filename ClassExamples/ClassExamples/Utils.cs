using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamples
{
    static class Utils
    {
        public static string ToUpperCase(string randomWord)
        {
            if (string.IsNullOrEmpty(randomWord))
            {
                return string.Empty;
            }
            char[] a = randomWord.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }

        public static string ToLowerCase(string randomWord)
        {
            if (string.IsNullOrEmpty(randomWord))
            {
                return string.Empty;
            }
            char[] a = randomWord.ToCharArray();
            a[0] = char.ToLower(a[0]);
            return new string(a);
        }
    }
}
