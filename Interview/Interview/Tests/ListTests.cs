using Interview.DataStructures;
using NUnit.Framework;

namespace Interview.Tests
{
    public class ListTests : AssertionHelper
    {
        [Test]
        [TestCase(new int[] { 4, 1, 5, 2, 1, 2, 6 },"4 1 5 2 1 2 6 ")]
        public void InsertToEnd(int[] numbers, string result)
        {
            var List = new MyList();

            foreach (var number in numbers)
            {
                List.InsertToEnd(number);
            }

            Expect(List.ToString(), Is.EqualTo(result));
        }

        [Test]
        [TestCase(new int[] { 4, 1, 5, 2, 1, 2, 6 }, "4 1 5 2 6 ")]
        public void RemoveDuplicates(int[] numbers, string result)
        {
            var List = new MyList();

            foreach (var number in numbers)
            {
                List.InsertToEnd(number);
            }

            List.RemoveDuplicates();

            Expect(List.ToString(), Is.EqualTo(result));
        }

        [Test]
        [TestCase(new int[] { 4, 1, 5, 2, 1, 2, 6 }, "4 1 5 2 6 ")]
        public void RemoveDuplicates2(int[] numbers, string result)
        {
            var List = new MyList();

            foreach (var number in numbers)
            {
                List.InsertToEnd(number);
            }

            List.RemoveDuplicates2();

            Expect(List.ToString(), Is.EqualTo(result));
        }

        [Test]
        [TestCase(new int[] { 4, 1, 5, 2, 1, 2, 6 }, 2, "4 1 5 2 1 6 ")] //Middle
        [TestCase(new int[] { 4, 1, 5, 2, 1, 2, 6 }, 1, "4 1 5 2 1 2 ")] //Last
        [TestCase(new int[] { 4, 1, 5, 2, 1, 2, 6 }, 7, "1 5 2 1 2 6 ")] //First
        public void RemoveKthFromLast(int[] numbers, int k, string result)
        {
            var List = new MyList();

            foreach (var number in numbers)
            {
                List.InsertToEnd(number);
            }

            List.RemoveKthFromLast(k);

            Expect(List.ToString(), Is.EqualTo(result));
        }
    }
}
