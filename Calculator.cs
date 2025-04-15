using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multus
{

    internal static class Calculator
    {
        internal static double Calculate(double d1, double d2, string ch)
        {
            return ch switch
            {
                "%" => d1 % d2,
                "/" => d1 / d2,
                "x" => d1 * d2,
                "-" => d1 - d2,
                "+" => d1 + d2,
                _ => 0
            };
        }

    }
}
