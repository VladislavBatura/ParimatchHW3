#pragma warning disable IDE0160
using System.Text.RegularExpressions;

namespace Hw3.Exercise4;
#pragma warning restore IDE0160

public static class WordsFinder
{
    public static List<string>? FindWords(string word, List<string> listOfWords)
    {
        if (string.IsNullOrEmpty(word))
        {
            throw new ArgumentNullException(word);
        }
        else if (listOfWords == null || listOfWords.Count == 0)
        {
            listOfWords = new List<string>();
            throw new ArgumentNullException(listOfWords.ToString());
        }

        var countFirstChar = word.Count(f => f == word[0]);
        var countSecondChar = 0;
        if (word.Length > 1 && word[0] != word[1])
        {
            countSecondChar = word.Count(f => f == word[1]);
        }
        if (word.Length > 1 && word[0] == word[1])
        {
            var secondChar = word.FirstOrDefault(f => f != word[0] || f != word[1]);
            countSecondChar = word.Count(f => f == secondChar);
        }

        //\b(?:([" + word + @"])(?!\w*?\1)){" + word.Length + @"}\b
        //([" + word + "])+
        var secondRegex = new Regex(@"\b([" + word + @"]){" + word.Length + @"}\b");

        var result = listOfWords.Where(x => secondRegex.IsMatch(x))
            .Where(x =>
            {
                var v = x.Count(f => f == word[0]);
                return countSecondChar == 0 ? v == countFirstChar
                    : v == countFirstChar || v == countSecondChar;
            })
            .ToList();

        return result;
    }
}
