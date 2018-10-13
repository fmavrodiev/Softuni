using System;

namespace _02.CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringToRead = Console.ReadLine().ToLower();
            string occurenceToLookFor = Console.ReadLine().ToLower();
            int counter = 0;
            int index = stringToRead.IndexOf(occurenceToLookFor);

            while (index != -1)
            {
                counter++;
                index = stringToRead.IndexOf(occurenceToLookFor, index + 1);
            }
            Console.WriteLine(counter);
        }
    }
}
