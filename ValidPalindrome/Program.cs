using System;
using System.Collections.Generic;

namespace ValidPalindrome
{
    class Program
    {
        static public bool IsPalindrome(string s) {
            var sList = new List<char>();
            foreach (var st in s.ToLower()) {
                if (((int)st > 96 && (int)st < 123) || ((int)st > 47 && (int)st < 58))
                    sList.Add(st);
            }
            var length = sList.Count - 1;
            for (var i = 0; i < sList.Count; i++) {
                if (sList[i] != sList[length])
                    return false;
                length--;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama")); //true
            Console.WriteLine(IsPalindrome("race a car")); //false
            Console.WriteLine(IsPalindrome("0P")); //false
            Console.WriteLine(IsPalindrome("")); //true
            Console.WriteLine(IsPalindrome("a")); //true
            Console.WriteLine(IsPalindrome("a.")); //true
        }
    }
}
