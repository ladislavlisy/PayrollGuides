using System;
using System.Collections.Generic;
using System.Text;

namespace NetPayroll.Guides.Contract.Social
{
    class PropertiesSocial2011
    {
        public const uint LEGAL_YEAR = 2011;

        public const Int32 MONTHLY_BASIS = 0;

        public const decimal ANNUAL_BASIS_MAXIMUM = 1781280m;

        public const decimal FACTOR_EMPLOYER = 25.0m;

        public const decimal FACTOR_EMPLOYER_HIGHER = 26.0m;

        public const decimal FACTOR_EMPLOYEE = 6.5m;

        public const decimal FACTOR_EMPLOYEE_GARANT = 0.0m;

        public const decimal FACTOR_REDUCE_GARANT = 0.0m;

        public const decimal INCOME_EMPLOY_MARGIN = 2000m;

        public const decimal INCOME_AGREEM_MARGIN = 0m;
    }

    class PropertiesSocial2012
    {
        public const uint LEGAL_YEAR = 2012;

        public const Int32 MONTHLY_BASIS = PropertiesSocial2011.MONTHLY_BASIS;

        public const decimal BASIS_ANNUAL = 1206576m;

        public const decimal FACTOR_EMPLOYER = PropertiesSocial2011.FACTOR_EMPLOYER;

        public const decimal FACTOR_EMPLOYER_HIGHER = PropertiesSocial2011.FACTOR_EMPLOYER_HIGHER;

        public const decimal FACTOR_EMPLOYEE = PropertiesSocial2011.FACTOR_EMPLOYEE;

        public const decimal FACTOR_EMPLOYEE_GARANT = PropertiesSocial2011.FACTOR_EMPLOYEE_GARANT;

        public const decimal FACTOR_REDUCE_GARANT = PropertiesSocial2011.FACTOR_REDUCE_GARANT;

        public const decimal INCOME_EMPLOY_MARGIN = 2500m;

        public const decimal INCOME_AGREEM_MARGIN = 10000m;
    }

    class PropertiesSocial2013
    {
        public const uint LEGAL_YEAR = 2013;

        public const Int32 MONTHLY_BASIS = PropertiesSocial2012.MONTHLY_BASIS;

        public const decimal BASIS_ANNUAL = 1242432m;

        public const decimal FACTOR_EMPLOYER = PropertiesSocial2012.FACTOR_EMPLOYER;

        public const decimal FACTOR_EMPLOYER_HIGHER = PropertiesSocial2012.FACTOR_EMPLOYER_HIGHER;

        public const decimal FACTOR_EMPLOYEE = PropertiesSocial2012.FACTOR_EMPLOYEE;

        public const decimal FACTOR_EMPLOYEE_GARANT = 5.0m;

        public const decimal FACTOR_REDUCE_GARANT = 3.0m;

        public const decimal INCOME_EMPLOY_MARGIN = PropertiesSocial2012.INCOME_EMPLOY_MARGIN;

        public const decimal INCOME_AGREEM_MARGIN = PropertiesSocial2012.INCOME_AGREEM_MARGIN;
    }

    class PropertiesSocial2014
    {
        public const uint LEGAL_YEAR = 2014;

        public const Int32 MONTHLY_BASIS = PropertiesSocial2013.MONTHLY_BASIS;

        public const decimal BASIS_ANNUAL = 1245216m;

        public const decimal FACTOR_EMPLOYER = PropertiesSocial2013.FACTOR_EMPLOYER;

        public const decimal FACTOR_EMPLOYER_HIGHER = PropertiesSocial2013.FACTOR_EMPLOYER_HIGHER;

        public const decimal FACTOR_EMPLOYEE = PropertiesSocial2013.FACTOR_EMPLOYEE;

        public const decimal FACTOR_EMPLOYEE_GARANT = PropertiesSocial2013.FACTOR_EMPLOYEE_GARANT;

        public const decimal FACTOR_REDUCE_GARANT = PropertiesSocial2013.FACTOR_REDUCE_GARANT;

        public const decimal INCOME_EMPLOY_MARGIN = PropertiesSocial2013.INCOME_EMPLOY_MARGIN;

        public const decimal INCOME_AGREEM_MARGIN = PropertiesSocial2013.INCOME_AGREEM_MARGIN;
    }

    class PropertiesSocial2015
    {
        public const uint LEGAL_YEAR = 2015;

        public const Int32 MONTHLY_BASIS = PropertiesSocial2014.MONTHLY_BASIS;

        public const decimal BASIS_ANNUAL = 1277328m;

        public const decimal FACTOR_EMPLOYER = PropertiesSocial2014.FACTOR_EMPLOYER;

        public const decimal FACTOR_EMPLOYER_HIGHER = 25.0m;

        public const decimal FACTOR_EMPLOYEE = PropertiesSocial2014.FACTOR_EMPLOYEE;

        public const decimal FACTOR_EMPLOYEE_GARANT = PropertiesSocial2014.FACTOR_EMPLOYEE_GARANT;

        public const decimal FACTOR_REDUCE_GARANT = PropertiesSocial2014.FACTOR_REDUCE_GARANT;

        public const decimal INCOME_EMPLOY_MARGIN = PropertiesSocial2014.INCOME_EMPLOY_MARGIN;

        public const decimal INCOME_AGREEM_MARGIN = PropertiesSocial2014.INCOME_AGREEM_MARGIN;
    }

}
