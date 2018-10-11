using System;
using System.Linq;

namespace _04.Palindromes
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(new char[] {' ', ',', '.', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in input)
            {
                string reverse = new string(word.Reverse().ToArray());
                if (reverse == word)
                {
                    Console.Write($"{word}, ");
                }
            }

            Console.WriteLine();
        }
    }
}
