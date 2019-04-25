using System;

namespace ScrabbleScore
{
    public class Program
    {
        static void Main()
        {   
            Console.WriteLine("Enter word to calculate Scrabble score");
            Word newWord = new Word (Console.ReadLine());
            Console.WriteLine(newWord.CalculateScore());
        }
    }
}