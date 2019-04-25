using System;
using System.Collections.Generic;

namespace ScrabbleScore
{
    public class Word
    {
        private Dictionary<char, int> _letterScores = new Dictionary<char, int>()
        {
            {'a', 1}, {'b', 3}, {'c', 3}, {'d', 2}, {'e', 1}, {'f', 4}, {'g', 2}, {'h', 4}, {'i', 1}, {'j', 8}, {'k', 5}, {'l', 1}, {'m', 3}, {'n', 1}, {'o', 1}, {'p', 3}, {'q', 10}, {'r', 1}, {'s', 1}, {'t', 1}, {'u', 1}, {'v', 4}, {'w', 4}, {'x', 8}, {'y', 4}, {'z', 10}
        };

        private string _word;

        public void SetWord(string word)
        {
            _word = word;
        }
        public Word(string word)
        {
            _word = word.ToLower();
        }

        public int CalculateScore()
        {
            char[] wordArray = _word.ToCharArray();
            int score = 0;
            foreach (char letter in wordArray)
            {
                score += _letterScores[letter];
            }
            return score;
        }
    }
}