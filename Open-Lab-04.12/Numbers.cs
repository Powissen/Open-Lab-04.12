using System;
using System.Linq;

namespace Open_Lab_04._12
{
    public class Numbers
    {
        int output;
        public int MissingNum(int[] nums)
        {
            for (int num = 0; num < 11; num++)
            {
            if (!nums.Contains(num))
                {
                    output = num;
                }

            }
            return output;
        }
    }
}
