using System;
using System.Text;

namespace Kata_DuplicateEncoder
{
    public class Kata
    {
        public static string DuplicateEncode(string word)
        {
            var sb = new StringBuilder(word);
            var count = 0;
            foreach (var c in word)
            {
                sb[count] = IsMultiple(c, word) && (c != '(' || c != ')') ? ')' : '(';
                count++;
            }

            return sb.ToString();
        }

        public static bool IsMultiple(char c, string word)
        {
            var last = word.LastIndexOf(c.ToString(), StringComparison.CurrentCultureIgnoreCase);
            var first = word.IndexOf(c.ToString(),StringComparison.CurrentCultureIgnoreCase);
            return (last != first);
        }
    }
}