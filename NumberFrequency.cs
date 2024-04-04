using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequecyOfNumber
{
    internal class NumberFrequency
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };

            Dictionary<int, int> numberWithFrequency = GetFrequencyOfNumber(numbers);

            foreach (var keyValuePair in numberWithFrequency)
            {
                Console.WriteLine($"Element: {keyValuePair.Key}, Frequency: {keyValuePair.Value}");
            }
            Console.ReadKey();
        }

        static Dictionary<int, int> GetFrequencyOfNumber(int[] inputArray)
        {
            Dictionary<int, int> numberWithFrequency = new Dictionary<int, int>();

            foreach (int num in inputArray)
            {
                if (numberWithFrequency.ContainsKey(num))
                {
                    numberWithFrequency[num]++;
                }
                else
                {
                    numberWithFrequency[num] = 1;
                }
            }

            return numberWithFrequency;
        }
    }
}
