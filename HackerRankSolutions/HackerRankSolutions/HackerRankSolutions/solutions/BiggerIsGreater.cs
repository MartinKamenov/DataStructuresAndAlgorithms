using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.solutions
{
    public class BiggerIsGreater
    {
        public static string FindBiggestString(string w)
        {
            string smallestBiggerWord = w;

            StringBuilder str = new StringBuilder();
            for (int i = 0; i < w.Length; i++)
            {
                str.Append('a');
            }

            smallestBiggerWord = str.ToString();

            bool foundSmallerWord = true;
            bool smallestBiggestWordHasChanged = false;
            while (foundSmallerWord)
            {
                foundSmallerWord = false;
                for (int i = smallestBiggerWord.Length - 1; i >= 0; i--)
                {
                    for (int j = smallestBiggerWord.Length - 2; j >= 0; j--)
                    {
                        string word = "";
                        if (smallestBiggestWordHasChanged)
                        {
                            word = SwitchCharPlaces(smallestBiggerWord, i, j);
                        }
                        else
                        {
                            word = SwitchCharPlaces(w, i, j);
                        }
                        if (isBetweenLexicographicaly(word, smallestBiggerWord, w))
                        {
                            smallestBiggerWord = word;
                            foundSmallerWord = true;
                            smallestBiggestWordHasChanged = true;
                            break;
                        }
                    }

                    if (foundSmallerWord)
                    {
                        break;
                    }
                }
            }
            
            return smallestBiggerWord;
        }

        //public static void rearangeWord(string word)
        //{
        //    char[] charWord = word.ToCharArray();
        //    Array.Sort(charWord);
        //    Array.Reverse(charWord);
        //}

        //public List<char> FindSmallestBiggerThan(string word, int index, char[] wordLetters)
        //{
        //    if (index == word.Length - 1)
        //    {

        //    }
        //}

        public static bool isBetweenLexicographicaly(string word, string before, string after)
        {
            if (string.Compare(word, before) > 0 && string.Compare(word, after) < 0)
            {
                return true;
            }

            return false;
        }

        public static string SwitchCharPlaces(string word, int firstIndex, int lastIndex)
        {
            StringBuilder newWord = new StringBuilder();
            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];

                if (i == firstIndex)
                {
                    c = word[lastIndex];
                }
                else if (i == lastIndex)
                {
                    c = word[firstIndex];
                }

                newWord.Append(c);
            }

            return newWord.ToString();
        }

        public static void Execute()
        {
            string str = Console.ReadLine();

            string result = FindBiggestString(str);

            Console.WriteLine(result);
        }
    }
}
