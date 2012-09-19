using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Liskov
    {
        static void PrintSequence<T>(IEnumerable<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }

        public void ArraysBreakLiskov()
        {
            IList<string> strings = new string[5];
            strings.Add("Hello");
        }

    }
}
