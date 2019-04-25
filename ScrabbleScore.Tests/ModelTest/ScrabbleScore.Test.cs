using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ScrabbleScore;

namespace ScrabbleScore.Test
{
    [TestClass]
    public class ScoreTest
    {
        [TestMethod]
        public void CalculateScore_UserInputsHello_Return8()
        {
            Word newWord = new Word();
            newWord.SetWord("hello");
            Assert.AreEqual(8, newWord.CalculateScore());
        }
    }
}