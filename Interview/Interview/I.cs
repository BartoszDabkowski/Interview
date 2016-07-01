using System.Collections.Generic;
using System.Text;

namespace Interview
{
    public class I
    {
        public static string ReverseWord(string word)
        {
            StringBuilder reversedWord = new StringBuilder(word);
            char temp;
            for (int i = 0; i < word.Length / 2; i++)
            {
                temp = reversedWord[i];
                reversedWord.Replace(word[i], word[word.Length - 1 - i]);
                reversedWord.Replace(word[word.Length - 1 - i], temp);
            }

            return word;
        }
        public static bool IsDuplicate(int[] array)
        {
            HashSet<int> hashSet = new HashSet<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (hashSet.Contains(array[i]))
                {
                    return true;
                }
                else
                {
                    hashSet.Add(array[i]);
                }
            }
            return false;
        }
        public static bool IsDuplicate2(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length - 1; j++)
                {
                    if (array[i] == array[j])
                        return true;
                }
            }
            return false;
        }
        public static bool IsPalindrome(string input)
        {
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
