using System;
using System.Collections.Generic;
using System.Text;

namespace RadPayroll.Guides.Operations
{
    public static class RoundingDec
    {
        public static decimal RoundUp(decimal valueDec)
        {
            decimal roundRet = decimal.Ceiling(Math.Abs(valueDec));

            return (valueDec < 0m ? decimal.Negate(roundRet) : roundRet);
        }

        public static decimal RoundDown(decimal valueDec)
        {
            decimal roundRet = decimal.Floor(Math.Abs(valueDec));

            return (valueDec < 0m ? decimal.Negate(roundRet) : roundRet);
        }

        public static decimal NearRoundUp(decimal valueDec, Int32 nearest = 100)
        {
            decimal dividRet = MathDec.Divide(valueDec, nearest);

            decimal multiRet = MathDec.Multiply(RoundUp(dividRet), nearest);

            return multiRet;
        }


        public static decimal NearRoundDown(decimal valueDec, Int32 nearest = 100)
        {
            decimal dividRet = MathDec.Divide(valueDec, nearest);

            decimal multiRet = MathDec.Multiply(RoundDown(dividRet), nearest);

            return multiRet;
        }
    }
}
