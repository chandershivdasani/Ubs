using System.Collections.Generic;
using System.Linq;

namespace Ubs
{
    /// <summary>
    ///  Count the occurrences of unique words in a sentence. 
    /// </summary>
    class WordCounter
    {
        public static Dictionary<string, int> CountWordOccurrences(string sentence)
        {
            var result = new Dictionary<string, int>();

            if (string.IsNullOrEmpty(sentence))
                return result;

            var words = SplitSentenceIntoWords(sentence);

            foreach (var word in words)
            {
                if(string.IsNullOrEmpty(word))
                    continue;
               
                if (result.ContainsKey(word))
                {
                    var count = result[word];
                    result[word] = count + 1;
                }
                else
                {
                    result[word] = 1;
                }
            }

            return result;
        }

        /// <summary>
        /// Split the given sentence into words, ignoring all the punctuations.
        /// </summary>
        /// 
        /// <remarks>
        /// The split words are converted to lowercase before returning.
        /// </remarks>
        /// <param name="str"></param>
        /// <returns></returns>
        private static IEnumerable<string> SplitSentenceIntoWords(string str)
        {
         
            var specialChars = str.Where(char.IsPunctuation).Distinct().ToArray();
            var words = str.Split().Select(x => x.Trim(specialChars)).Select(x => x.ToLower());
           
            return words;
        }
      
    }
}
