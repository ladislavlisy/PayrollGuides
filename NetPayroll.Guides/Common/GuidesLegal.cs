﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NetPayroll.Guides.Common
{
    public class GuidesLegal
    {
        public GuidesLegal(uint year)
        {
            GuidesPeriod = new PeriodSpan(year);
        }

        public PeriodSpan GuidesPeriod { get; private set; }

        public bool IsPeriodValid(Period period)
        {
            return GuidesPeriod.IsPeriodValid(period);
        }

		public bool IsPeriodBetween(Period period, byte monthFrom, byte monthUpto)
		{
			return GuidesPeriod.IsPeriodBetween(period, monthFrom, monthUpto);
		}
	}
}
