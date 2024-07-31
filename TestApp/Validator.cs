using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public static class Validator
    {
        public static bool IsWithinRange(int value, int min, int max)
        {
            return value >= min && value <= max;
        }
    }
}
