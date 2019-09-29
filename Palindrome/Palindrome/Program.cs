using System;
using System.Text;

namespace Palindrome
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var chars = input?.ToCharArray();

            var isValid = chars != null;
            var isProper = false;
            if (isValid)
            {
                isProper = IsPalindrome(chars);
            }
            var candidate = string.Empty;
            if (isValid && isProper)
            {
                candidate = input;
            }
            if (isValid && !isProper)
            {
                for (int amount = 0; amount < chars.Length; amount++)
                {
                    var part = input.Substring(0,amount);
                    Array.Reverse(part.ToCharArray());
                    var reversed = new StringBuilder().Append(part);
                    
                    candidate = input + reversed;
                    isProper = IsPalindrome(candidate.ToCharArray());
                    if (isProper)
                    {
                        break;
                    }
                }
            }

            if (isValid && isProper)
            {
                Console.WriteLine($@"{input}=> {candidate}");
            }
            if (!isValid)
            {
                Console.WriteLine($@"Fail to compose palindrome for string `{input}`");
            }
        }

        private static bool IsPalindrome(char[] chars)
        {
            var isEqual = true;
            var reversed = (char[])chars?.Clone();
            Array.Reverse(reversed);

            for (var index = 0; index < chars?.Length; index++)
            {
                if (chars[index] != reversed[index])
                {
                    isEqual = false;
                    break;
                }
            }

            return isEqual;
        }
    }
}
