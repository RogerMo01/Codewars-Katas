using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_Katas
{
    class Kata2
    {
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            int minor = numbers.Min();
            numbers[Array.IndexOf(numbers, minor)] = numbers.Max();

            return minor + numbers.Min();
        }
    }
}
