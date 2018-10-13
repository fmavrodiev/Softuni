using System;

namespace _03.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] patternToReplace = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string inputToRead = Console.ReadLine();

            foreach (var banword in patternToReplace)
            {
                if (inputToRead.Contains(banword))
                {
                    inputToRead = inputToRead.Replace(banword, new string('*', banword.Length));
                }
            }

            Console.WriteLine(inputToRead);
        }
    }
}