using NUnit.Framework;

namespace Interview
{
    public class CodeTests : AssertionHelper
    {
        [Test]
        [TestCase("HannaH", true)]
        [TestCase("TrainniarT", true)]
        [TestCase("Hellej", false)]
        public void Palindrome(string input, bool result)
        {
            Expect(I.IsPalindrome(input), Is.EqualTo(result));
        }

        [Test]
        [TestCase(new int[] { 1, 3, 2, 4, 5, 9, 6, 1 }, true)]
        [TestCase(new int[] { 1, 3, 2, 4, 5, 8, 6, 9 }, false)]
        public void Duplicate(int[] input, bool result)
        {
            Expect(I.IsDuplicate(input), Is.EqualTo(result));
            Expect(I.IsDuplicate2(input), Is.EqualTo(result));
        }

        [Test]
        [TestCase("hello", "olleh")]
        [TestCase("HowAreYou", "uoYerAwoH")]
        public void Reverse(string word, string result)
        {
            Expect(I.ReverseWord(word), Is.EqualTo(result));
        }

        [Test]
        [TestCase("dog", "god", true)]
        [TestCase("fire", "ifre", true)]
        [TestCase("abcdefg", "gacbdef", true)]
        [TestCase("abcdefg", "abcdet", false)]
        [TestCase("abcdefg", "111111111", false)]
        public void IsPermutation(string word1, string word2, bool result)
        {
            Expect(I.IsPermutation(word1, word2), Is.EqualTo(result));
            Expect(I.IsPermutation2(word1, word2), Is.EqualTo(result));
        }

        [Test]
        [TestCase("str ing  ", 7, "str%20ing")]
        [TestCase(" s tr in g        ", 10, "%20s%20tr%20in%20g")]
        public void ReplaceSpaceWith20(string word, int size, string result)
        {
            Expect(I.RepalceSpaceWith20(word, size), Is.EqualTo(result));
        }

        [Test]
        [TestCase("aaabbbcccccaad","a3b3c5a2d1")]
        [TestCase("abcde","abcde")]
        public void ReplaceSpaceWith20(string word, string result)
        {
            Expect(I.ReducedRepeatedLetters(word), Is.EqualTo(result));
        }

        [Test]
        public void RotateNxNBy90()
        {
            var n1 = new int[4, 4]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12},
                {13, 14, 15, 16}
            };

            var n2 = new int[4, 4]
            {
                {13, 9, 5, 1},
                {14, 10, 6, 2},
                {15, 11, 7, 3},
                {16, 12, 8, 4}
            };

            Expect(I.RotateNxNBy90(n1), Is.EqualTo(n2));
        }

        [Test]
        public void DeleteRowAndColWith0()
        {
            var n1 = new int[3, 4]
            {
                {1, 2, 3, 4},
                {5, 0, 7, 0},
                {9, 10, 11, 12}
            };

            var n2 = new int[3, 4]
            {
                {1, 0, 3, 0},
                {0, 0, 0, 0},
                {9, 0, 11, 0}
            };

            Expect(I.DeleteRowAndColWith0(n1), Is.EqualTo(n2));
        }
    }
}
