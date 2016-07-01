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
        [TestCase(new int[] { 1, 3, 2, 4, 5, 5, 6, 1 }, true)]
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
    }
}
