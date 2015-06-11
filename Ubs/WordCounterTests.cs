
using System.Collections.Generic;
using NUnit.Framework;

namespace Ubs
{
    [TestFixture]
    class WordCounterTests
    {

        [Test]
        public void SentenceWithSpecialCharacters()
        {
            var sentence = "This is a sentence, and so is this.";
            var expected = new Dictionary<string, int>()
            {
                {"this", 2},
                {"is", 2},
                {"a", 1},
                {"sentence", 1},
                {"and", 1},
                {"so", 1},
            };

            var actual = WordCounter.CountWordOccurrences(sentence);
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void SentenceWithApostrophe()
        {
            var sentence = "Thi's is a sentence, and so is thi's.";
            var expected = new Dictionary<string, int>()
            {
                {"thi's", 2},
                {"is", 2},
                {"a", 1},
                {"sentence", 1},
                {"and", 1},
                {"so", 1},
            };

            var actual = WordCounter.CountWordOccurrences(sentence);
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void SentenceWithNumbers()
        {
            var sentence = "Sentence with 2 2 2 2 sentence";
            var expected = new Dictionary<string, int>()
            {
                {"sentence", 2},
                {"with", 1}, 
                {"2", 4}
            };
            
            var actual = WordCounter.CountWordOccurrences(sentence);
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void EmptySentence()
        {
            var sentence = "";
            var expected = new Dictionary<string, int>();

            var actual = WordCounter.CountWordOccurrences(sentence);
            Assert.AreEqual(actual, expected);
        }
          
        [Test]
        public void NullSentence()
        {
            string sentence = null;
            var expected = new Dictionary<string, int>();
         

            var actual = WordCounter.CountWordOccurrences(sentence);
            Assert.AreEqual(actual, expected);
        }
        
        [Test]
        public void SentenceWithOnlyOneWord()
        {
            var sentence = "This this this This";
            var expected = new Dictionary<string, int>()
            {
                {"this", 4},
            };

            var actual = WordCounter.CountWordOccurrences(sentence);
            Assert.AreEqual(actual, expected);
        }

    }
}
