using System;

namespace Ubs
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = WordCounter.CountWordOccurrences("This is a statement, and so is this.");

            foreach (var item in result)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
            Console.ReadLine();
        }
    }
}
