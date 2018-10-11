using System;

namespace _01.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringToReverse = Console.ReadLine();

            char[] charArray = stringToReverse.ToCharArray();

            Array.Reverse(charArray);

            Console.WriteLine(new string(charArray));
        }
    }
}
