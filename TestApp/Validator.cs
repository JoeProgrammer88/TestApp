using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public static class Validator
    {
        /// <summary>
        /// This checks that a integer is within an inclusive range
        /// </summary>
        /// <param name="value">The number to check</param>
        /// <param name="min">The inclusive lower</param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static bool IsWithinRange(int value, int min, int max)
        {
            // Ensure number is within range
            return value >= min && value < max;
        }
    }
}
