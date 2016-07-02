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

            return sortWord(word1).Equals(sortWord(word2));
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
        public static string sortWord(string word)
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

        //public static StringBuilder ShiftChars(StringBuilder word, int start, int last)
        //{
        //    word[last] = word[start - 2];
        //    word[last + 1] = word[start - 1];
        //    word[last + 2] = word[start];

        //    word[start] = '0';
        //    word[start - 1] = '2';
        //    word[start - 2] = '%';

        //    return word;
        //}
    }
}
