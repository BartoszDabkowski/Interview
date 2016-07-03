using Interview.DataStructures;
using System;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            var List = new MyList();

            List.InsertToEnd(4);
            List.InsertToEnd(1);
            List.InsertToEnd(5);
            List.InsertToEnd(2);
            List.InsertToEnd(1);
            List.InsertToEnd(2);
            List.InsertToEnd(6);

            List.Display();
            Console.WriteLine();

            List.RemoveKthFromLast(7);

            List.Display();

            Console.WriteLine("\nFinished.");
            Console.Read();
        }
    }
}
