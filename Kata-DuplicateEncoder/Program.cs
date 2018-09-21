using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//    The goal of this exercise is to convert a string to a new string where each character in the new string is '(' if that character appears only once in the original string, or ')' if that character appears more than once in the original string. Ignore capitalization when determining if a character is a duplicate.

//Examples:

//"din" => "((("

//"recede" => "()()()"

//"Success" => ")())())"

//"(( @" => "))(("

namespace Kata_DuplicateEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            var newStr = Kata.DuplicateEncode("Success");
            Console.WriteLine(newStr);
            Console.WriteLine(Kata.IsMultiple('s',"Sus"));

        }
    }
}
