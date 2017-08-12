using System;
using System.Collections.Generic;
using System.Text;

namespace RadPayroll.Guides.Garant
{
    class PropertiesGarant2011
    {
        public const uint LEGAL_YEAR = 2011;

        public const decimal FACTOR_EMPLOYEE = 0m;
    }

    class PropertiesGarant2012
    {
        public const uint LEGAL_YEAR = 2012;

        public const decimal FACTOR_EMPLOYEE = PropertiesGarant2011.FACTOR_EMPLOYEE;
    }

    class PropertiesGarant2013
    {
        public const uint LEGAL_YEAR = 2013;

        public const decimal FACTOR_EMPLOYEE = 2m;
    }

    class PropertiesGarant2014
    {
        public const uint LEGAL_YEAR = 2014;

        public const decimal FACTOR_EMPLOYEE = PropertiesGarant2013.FACTOR_EMPLOYEE;
    }

    class PropertiesGarant2015
    {
        public const uint LEGAL_YEAR = 2015;

        public const decimal FACTOR_EMPLOYEE = PropertiesGarant2014.FACTOR_EMPLOYEE;
    }
}
