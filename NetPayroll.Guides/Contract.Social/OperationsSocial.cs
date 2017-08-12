using System;
using System.Collections.Generic;
using System.Text;
using RadPayroll.Guides.Operations;

namespace NetPayroll.Guides.Contract.Social
{
    public static class OperationsSocial
    {
        public static decimal DecRoundUp(decimal valueDec)
        {
            return RoundingDec.RoundUp(valueDec);
        }

        public static Int32 IntRoundUp(decimal valueDec)
        {
            return RoundingInt.RoundUp(valueDec);
        }

        public static decimal DecRoundDown(decimal valueDec)
        {
            return RoundingDec.RoundDown(valueDec);
        }

        public static Int32 IntRoundDown(decimal valueDec)
        {
            return RoundingInt.RoundDown(valueDec);
        }

        public static decimal DecFactorResult(decimal valueDec, decimal factor)
        {
            return MathDec.MultiplyAndDivide(valueDec, factor, 100m);
        }

        public static decimal MinMaxValue(decimal valueToMinMax, decimal accumulValue, decimal maxLimitTo)
        {
            return MathDec.MinIncMaxDecValue(valueToMinMax, accumulValue, 0m, maxLimitTo);
        }

        public static decimal DecSuppressNegative(bool suppress, decimal valueDec)
        {
            if (suppress && valueDec < decimal.Zero)
            {
                return decimal.Zero;
            }
            return valueDec;
        }
    }
}
