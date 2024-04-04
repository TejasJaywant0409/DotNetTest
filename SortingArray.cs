using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SortedArray
{
    class SortingArray
    {
        static void Main()
        {
            int[] input = { 10, 8, 15, 12, 6, 20, 1 };
            
            int[] sortedArray = input.OrderBy(x => x).ToArray();
            int[] ranks = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                int index = Array.IndexOf(sortedArray, input[i]) + 1;
                ranks[i] = index;
            }
;
            Console.WriteLine("{ "+string.Join(", ", input)+" }");
            Console.WriteLine("{ " + string.Join(", ", ranks) + " }");
            Console.ReadLine();
        }
    }
}
