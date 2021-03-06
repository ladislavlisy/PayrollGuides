﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NetPayroll.Guides.Contract.Health
{
    class PropertiesHealth2011
    {
        public const uint LEGAL_YEAR = 2011;

        public const Int32 BASIS_MONTHLY_MINIMUM = 8000;

        public const decimal BASIS_ANNUAL_MAXIMUM = 1781280m;

        public const decimal FACTOR_COMPOUND = 13.5m;

        public const decimal INCOME_EMPLOY_MARGIN = 2000m;

        public const decimal INCOME_AGREEM_MARGIN = 0m;
    }
    class PropertiesHealth2012
    {
        public const uint LEGAL_YEAR = 2012;

        public const Int32 BASIS_MONTHLY_MINIMUM = PropertiesHealth2011.BASIS_MONTHLY_MINIMUM;

        public const decimal BASIS_ANNUAL_MAXIMUM = 1809864m;

        public const decimal FACTOR_COMPOUND = PropertiesHealth2011.FACTOR_COMPOUND;

        public const decimal INCOME_EMPLOY_MARGIN = 2500m;

        public const decimal INCOME_AGREEM_MARGIN = 10000m;
    }

    class PropertiesHealth2013
    {
        public const uint LEGAL_YEAR = 2013;

        public const Int32 BASIS_MONTHLY_MINIMUM_UPTO_07 = 8000;

        public const Int32 BASIS_MONTHLY_MINIMUM = 8500;

        public const decimal BASIS_ANNUAL_MAXIMUM = 0m;

        public const decimal FACTOR_COMPOUND = PropertiesHealth2012.FACTOR_COMPOUND;

        public const decimal INCOME_EMPLOY_MARGIN = PropertiesHealth2012.INCOME_EMPLOY_MARGIN;

        public const decimal INCOME_AGREEM_MARGIN = PropertiesHealth2012.INCOME_AGREEM_MARGIN;
    }

    class PropertiesHealth2014
    {
        public const uint LEGAL_YEAR = 2014;

        public const Int32 BASIS_MONTHLY_MINIMUM = 8500;

        public const decimal BASIS_ANNUAL_MAXIMUM = PropertiesHealth2013.BASIS_ANNUAL_MAXIMUM;

        public const decimal FACTOR_COMPOUND = PropertiesHealth2013.FACTOR_COMPOUND;

        public const decimal INCOME_EMPLOY_MARGIN = PropertiesHealth2013.INCOME_EMPLOY_MARGIN;

        public const decimal INCOME_AGREEM_MARGIN = PropertiesHealth2013.INCOME_AGREEM_MARGIN;
    }

    class PropertiesHealth2015
    {
        public const uint LEGAL_YEAR = 2015;

        public const Int32 BASIS_MONTHLY_MINIMUM = 9200;

        public const decimal BASIS_ANNUAL_MAXIMUM = PropertiesHealth2014.BASIS_ANNUAL_MAXIMUM;

        public const decimal FACTOR_COMPOUND = PropertiesHealth2014.FACTOR_COMPOUND;

        public const decimal INCOME_EMPLOY_MARGIN = PropertiesHealth2014.INCOME_EMPLOY_MARGIN;

        public const decimal INCOME_AGREEM_MARGIN = PropertiesHealth2014.INCOME_AGREEM_MARGIN;
    }
}
