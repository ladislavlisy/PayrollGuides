using System;
using System.Text;

namespace NetPayroll.Guides.Common
{
    public class PeriodSpan
    {
        public PeriodSpan(uint year)
        {
			ValidFrom = new Period(year, 1);
			ValidUpto = new Period(year, 12);
		}

		public Period ValidFrom { get; private set; }

		public Period ValidUpto { get; private set; }

		public bool IsPeriodValid(Period period)
		{
			return (period >= ValidFrom && period <= ValidUpto);
		}
		public bool IsPeriodBetween(Period period, byte monthFrom, byte monthUpto)
		{
			Period periodFrom = new Period(ValidFrom.YearUInt(), monthFrom);
			Period periodUpto = new Period(ValidFrom.YearUInt(), monthUpto);

			return (period >= periodFrom && period <= periodUpto);
		}
		public static bool operator <(PeriodSpan x, PeriodSpan y)
		{
			return (x.ValidFrom < y.ValidFrom) || (x.ValidFrom == y.ValidFrom && (x.ValidUpto < y.ValidUpto));
		}

		public static bool operator >(PeriodSpan x, PeriodSpan y)
		{
			return (x.ValidFrom > y.ValidFrom) || (x.ValidFrom == y.ValidFrom && (x.ValidUpto > y.ValidUpto));
		}

		public static bool operator <=(PeriodSpan x, PeriodSpan y)
		{
			return (x.ValidFrom <= y.ValidFrom) || (x.ValidFrom == y.ValidFrom && (x.ValidUpto <= y.ValidUpto));
		}

		public static bool operator >=(PeriodSpan x, PeriodSpan y)
		{
			return (x.ValidFrom >= y.ValidFrom) || (x.ValidFrom == y.ValidFrom && (x.ValidUpto >= y.ValidUpto));
		}

		public int CompareTo(object obj)
		{
			PeriodSpan other = obj as PeriodSpan;

			if (this.ValidFrom != other.ValidFrom)
			{
				return this.ValidFrom.CompareTo(other.ValidFrom);
			}
			return (this.ValidUpto.CompareTo(other.ValidUpto));
		}

		public bool isEqualToSpan(PeriodSpan other)
		{
			return (this.ValidFrom == other.ValidFrom && this.ValidUpto == other.ValidUpto);
		}

		public override bool Equals(object obj)
		{
			if (obj == this)
				return true;
			if (obj == null || this.GetType() != obj.GetType())
				return false;

			PeriodSpan other = obj as PeriodSpan;

			return this.isEqualToSpan(other);
		}

		public override int GetHashCode()
		{
			int prime = 31;
			int result = 1;

            result += prime * result + (int)this.ValidFrom.GetHashCode();
			result += prime * result + (int)this.ValidUpto.GetHashCode();

			return result;
		}

		public string ClassName()
		{
			StringBuilder classNameBuilder = new StringBuilder(ValidFrom.YearToString());

			return classNameBuilder.ToString();
		}

		public override string ToString()
		{
			return this.ClassName();
		}
	}
}
