using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_Katas
{
    public static class Kata1
    {
        public static int DescendingOrder(int num)
        {
            char[] strNumber = num.ToString().ToCharArray();
            Array.Sort(strNumber);
            Array.Reverse(strNumber);
            return int.Parse(new string(strNumber));
        }
    }
}
