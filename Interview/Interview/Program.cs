using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
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

            I.DeleteRowAndColWith0(n1);
            Console.ReadKey();
        }
    }
}
