using System;
using System.Collections.Generic;
using System.Text;

namespace Interview
{
    public class I
    {
        public static string ReverseWord(string word)
        {
            var revWord = new StringBuilder(word);
            var last = word.Length - 1;

            for (var i = 0; i < word.Length / 2; i++)
            {
                var temp = revWord[i];
                revWord[i] = word[last - i];
                revWord[last - i] = temp;
            }
            return revWord.ToString();
        }

        public static bool IsDuplicate(int[] array)
        {
            var hashSet = new HashSet<int>();

            foreach(var character in array)
            {
                if (hashSet.Contains(character))
                    return true;
                hashSet.Add(character);
            }
            return false;
        }
        public static bool IsDuplicate2(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                        return true;
                }
            }
            return false;
        }

        public static bool IsPalindrome(string word)
        {
            for (var i = 0; i < word.Length / 2; i++)
            {
                var last = word.Length - 1 - i;
                if (word[i] != word[last])
                    return false;
            }
            return true;
        }

        public static bool IsPermutation(string word1, string word2)
        {
            if (word1.Length != word2.Length)
                return false;

            return SortWord(word1).Equals(SortWord(word2));
        }
        public static bool IsPermutation2(string word1, string word2)
        {
            if (word1.Length != word2.Length)
                return false;
            var characters = new int[128];

            foreach(var character in word1)
            {
                characters[character]++;
            }

            for (var i = 0; i < word1.Length; i++)
            {
                var ch = word2[i];
                if (--characters[ch] < 0)
                    return false;
            }
            return true;
        }
        private static string SortWord(string word)
        {
            var sortedWord = word.ToCharArray();
            Array.Sort(sortedWord);
            return sortedWord.ToString();
        }

        public static string RepalceSpaceWith20(string word, int size)
        {
            var newWord = new StringBuilder(word);
            var last = word.Length;
            for (var i = size - 1; i >= 0; i--)
            {
                if (newWord[i] == ' ')
                {
                    newWord[last - 1] = '0';
                    newWord[last - 2] = '2';
                    newWord[last - 3] = '%';
                    last -= 3;
                }
                else
                {
                    newWord[last - 1] = word[i];
                    last--;
                }
            }
            return newWord.ToString();
        }

        public static string ReducedRepeatedLetters(string word)
        {
            var nWord = new StringBuilder("");

            var count = 1;
            var letter = word[0];
            for (var i = 1; i < word.Length; i++)
            {
                if (word[i] == letter)
                {
                    count++;
                }
                else
                {
                    nWord.Append(letter);
                    nWord.Append(count);
                    letter = word[i];
                    count = 1;
                }
            }
            nWord.Append(letter);
            nWord.Append(count);

            return (nWord.Length > word.Length) ? word : nWord.ToString();
        }

        public static int[,] RotateNxNBy90(int[,] n1)
        {
            for (var i = 0; i < n1.GetLength(0) / 2; i++)
            {
                var first = i;
                var last = n1.GetLength(0) - 1 - i;

                for (var j = first; j < last; j++)
                {
                    var temp = n1[first, first + j];
                    n1[first, first + j] = n1[last - j, first];
                    n1[last - j, first] = n1[last, last - j];
                    n1[last, last - j] = n1[first + j, last];
                    n1[first + j, last] = temp;

                    //Debug
                    //Console.WriteLine("(" + first + "," + (first + j) + ") =" + "(" + (last - j) + "," + first + ")");
                    //Console.WriteLine("(" + (last - j) + "," + first + ") =" + "(" + last + "," + (last - j) + ")");
                    //Console.WriteLine("(" + last + "," + (last - j) + ") =" + "(" + (first + j) + "," + last + ")");
                    //Console.WriteLine("(" + (first + j) + "," + last + ") =" + "(" + first + "," + (first + j) + ")");
                    //Console.WriteLine();
                }
                //Console.WriteLine("--------------------------");
            }
            return n1;
        }

        public static int[,] DeleteRowAndColWith0(int[,] n1)
        {
            var rowsWith0 = new bool[n1.GetLength(0)];
            var colsWith0 = new bool[n1.GetLength(1)];

            for (var i = 0; i < n1.GetLength(0); i++)
            {
                for (var j = 0; j < n1.GetLength(1); j++)
                {
                    if (n1[i, j] == 0)
                    {
                        rowsWith0[i] = true;
                        colsWith0[j] = true;
                    }
                }
            }

            for (var row = 0; row < rowsWith0.Length; row++)
            {
                if (rowsWith0[row])
                    n1 = NullifyRows(n1, row);
            }

            for (var col = 0; col <colsWith0.Length; col++)
            {
                if (colsWith0[col])
                    n1 = NullifyCols(n1, col);
            }
            return n1;
        }
        private static int[,] NullifyRows(int[,] n1, int row)
        {
            for (var i = 0; i < n1.GetLength(1); i++)
            {
                n1[row, i] = 0;
            }
            return n1;
        }
        private static int[,] NullifyCols(int[,] n1, int col)
        {
            for (var i = 0; i < n1.GetLength(0); i++)
            {
                n1[i, col] = 0;
            }
            return n1;
        }
    }
}
