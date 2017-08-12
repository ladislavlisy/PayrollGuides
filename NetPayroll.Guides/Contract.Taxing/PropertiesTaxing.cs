using System;
using System.Collections.Generic;
using System.Text;

namespace NetPayroll.Guides.Contract.Taxing
{
    class PropertiesTaxing2011
    {
        public const uint LEGAL_YEAR = 2011;

        public const Int32 ALLOWANCE_PAYER = 1970;
        public const Int32 ALLOWANCE_DISAB_1ST = 210;
        public const Int32 ALLOWANCE_DISAB_2ND = 420;
        public const Int32 ALLOWANCE_DISAB_3RD = 1345;
        public const Int32 ALLOWANCE_STUDY = 335;
        public const Int32 ALLOWANCE_CHILD_1ST = 1117;
        public const Int32 ALLOWANCE_CHILD_2ND = 1117;
        public const Int32 ALLOWANCE_CHILD_3RD = 1117;
        public const decimal FACTOR_ADVANCES = 15.0m;
        public const decimal FACTOR_WITHHOLD = 15.0m;
        public const decimal FACTOR_SOLIDARY = 0.0m;
        public const Int32 MIN_VALID_AMOUNT_OF_TAXBONUS = 50;
        public const Int32 MAX_VALID_AMOUNT_OF_TAXBONUS = 5025;
        public const Int32 MIN_VALID_INCOME_OF_TAXBONUS = 8000;
        public const Int32 MAX_VALID_INCOME_OF_ROUNDING = 100;
        public const Int32 MAX_VALID_INCOME_OF_WITHHOLD = 5000;
        public const Int32 MIN_VALID_INCOME_OF_SOLIDARY = 0;
    }

    class PropertiesTaxing2012
    {
        public const uint LEGAL_YEAR = 2012;

        public const Int32 ALLOWANCE_PAYER = 2070;
        public const Int32 ALLOWANCE_DISAB_1ST = PropertiesTaxing2011.ALLOWANCE_DISAB_1ST;
        public const Int32 ALLOWANCE_DISAB_2ND = PropertiesTaxing2011.ALLOWANCE_DISAB_2ND;
        public const Int32 ALLOWANCE_DISAB_3RD = PropertiesTaxing2011.ALLOWANCE_DISAB_3RD;
        public const Int32 ALLOWANCE_STUDY = PropertiesTaxing2011.ALLOWANCE_STUDY;
        public const Int32 ALLOWANCE_CHILD_1ST = PropertiesTaxing2011.ALLOWANCE_CHILD_1ST;
        public const Int32 ALLOWANCE_CHILD_2ND = PropertiesTaxing2011.ALLOWANCE_CHILD_2ND;
        public const Int32 ALLOWANCE_CHILD_3RD = PropertiesTaxing2011.ALLOWANCE_CHILD_3RD;
        public const decimal FACTOR_ADVANCES = PropertiesTaxing2011.FACTOR_ADVANCES;
        public const decimal FACTOR_WITHHOLD = PropertiesTaxing2011.FACTOR_WITHHOLD;
        public const decimal FACTOR_SOLIDARY = PropertiesTaxing2011.FACTOR_SOLIDARY;
        public const Int32 MIN_VALID_AMOUNT_OF_TAXBONUS = PropertiesTaxing2011.MIN_VALID_AMOUNT_OF_TAXBONUS;
        public const Int32 MAX_VALID_AMOUNT_OF_TAXBONUS = PropertiesTaxing2011.MAX_VALID_AMOUNT_OF_TAXBONUS;
        public const Int32 MIN_VALID_INCOME_OF_TAXBONUS = PropertiesTaxing2011.MIN_VALID_INCOME_OF_TAXBONUS;
        public const Int32 MAX_VALID_INCOME_OF_ROUNDING = PropertiesTaxing2011.MAX_VALID_INCOME_OF_ROUNDING;
        public const Int32 MAX_VALID_INCOME_OF_WITHHOLD = PropertiesTaxing2011.MAX_VALID_INCOME_OF_WITHHOLD;
        public const Int32 MIN_VALID_INCOME_OF_SOLIDARY = PropertiesTaxing2011.MIN_VALID_INCOME_OF_SOLIDARY;
    }

    class PropertiesTaxing2013
    {
        public const uint LEGAL_YEAR = 2013;

        public const Int32 ALLOWANCE_PAYER = PropertiesTaxing2012.ALLOWANCE_PAYER;
        public const Int32 ALLOWANCE_DISAB_1ST = PropertiesTaxing2012.ALLOWANCE_DISAB_1ST;
        public const Int32 ALLOWANCE_DISAB_2ND = PropertiesTaxing2012.ALLOWANCE_DISAB_2ND;
        public const Int32 ALLOWANCE_DISAB_3RD = PropertiesTaxing2012.ALLOWANCE_DISAB_3RD;
        public const Int32 ALLOWANCE_STUDY = PropertiesTaxing2012.ALLOWANCE_STUDY;
        public const Int32 ALLOWANCE_CHILD_1ST = PropertiesTaxing2012.ALLOWANCE_CHILD_1ST;
        public const Int32 ALLOWANCE_CHILD_2ND = PropertiesTaxing2012.ALLOWANCE_CHILD_2ND;
        public const Int32 ALLOWANCE_CHILD_3RD = PropertiesTaxing2012.ALLOWANCE_CHILD_3RD;
        public const decimal FACTOR_ADVANCES = PropertiesTaxing2012.FACTOR_ADVANCES;
        public const decimal FACTOR_WITHHOLD = PropertiesTaxing2012.FACTOR_WITHHOLD;
        public const decimal FACTOR_SOLIDARY = 7.0m;
        public const Int32 MIN_VALID_AMOUNT_OF_TAXBONUS = PropertiesTaxing2012.MIN_VALID_AMOUNT_OF_TAXBONUS;
        public const Int32 MAX_VALID_AMOUNT_OF_TAXBONUS = PropertiesTaxing2012.MAX_VALID_AMOUNT_OF_TAXBONUS;
        public const Int32 MIN_VALID_INCOME_OF_TAXBONUS = PropertiesTaxing2012.MIN_VALID_INCOME_OF_TAXBONUS;
        public const Int32 MAX_VALID_INCOME_OF_ROUNDING = PropertiesTaxing2012.MAX_VALID_INCOME_OF_ROUNDING;
        public const Int32 MAX_VALID_INCOME_OF_WITHHOLD = PropertiesTaxing2012.MAX_VALID_INCOME_OF_WITHHOLD;
        public const Int32 MIN_VALID_INCOME_OF_SOLIDARY = 103536;              
    }

    class PropertiesTaxing2014
    {
        public const uint LEGAL_YEAR = 2014;

        public const Int32 ALLOWANCE_PAYER = PropertiesTaxing2013.ALLOWANCE_PAYER;
        public const Int32 ALLOWANCE_DISAB_1ST = PropertiesTaxing2013.ALLOWANCE_DISAB_1ST;
        public const Int32 ALLOWANCE_DISAB_2ND = PropertiesTaxing2013.ALLOWANCE_DISAB_2ND;
        public const Int32 ALLOWANCE_DISAB_3RD = PropertiesTaxing2013.ALLOWANCE_DISAB_3RD;
        public const Int32 ALLOWANCE_STUDY = PropertiesTaxing2013.ALLOWANCE_STUDY;
        public const Int32 ALLOWANCE_CHILD_1ST = PropertiesTaxing2013.ALLOWANCE_CHILD_1ST;
        public const Int32 ALLOWANCE_CHILD_2ND = PropertiesTaxing2013.ALLOWANCE_CHILD_2ND;
        public const Int32 ALLOWANCE_CHILD_3RD = PropertiesTaxing2013.ALLOWANCE_CHILD_3RD;
        public const decimal FACTOR_ADVANCES = PropertiesTaxing2013.FACTOR_ADVANCES;
        public const decimal FACTOR_WITHHOLD = PropertiesTaxing2013.FACTOR_WITHHOLD;
        public const decimal FACTOR_SOLIDARY = PropertiesTaxing2013.FACTOR_SOLIDARY;
        public const Int32 MIN_VALID_AMOUNT_OF_TAXBONUS = PropertiesTaxing2013.MIN_VALID_AMOUNT_OF_TAXBONUS;
        public const Int32 MAX_VALID_AMOUNT_OF_TAXBONUS = PropertiesTaxing2013.MAX_VALID_AMOUNT_OF_TAXBONUS;
        public const Int32 MIN_VALID_INCOME_OF_TAXBONUS = 8500;
        public const Int32 MAX_VALID_INCOME_OF_ROUNDING = PropertiesTaxing2013.MAX_VALID_INCOME_OF_ROUNDING;
        public const Int32 MAX_VALID_INCOME_OF_WITHHOLD = 10000;
        public const Int32 MIN_VALID_INCOME_OF_SOLIDARY = 103768;
    }

    class PropertiesTaxing2015
    {
        public const uint LEGAL_YEAR = 2015;

        public const Int32 ALLOWANCE_PAYER = PropertiesTaxing2014.ALLOWANCE_PAYER;
        public const Int32 ALLOWANCE_DISAB_1ST = PropertiesTaxing2014.ALLOWANCE_DISAB_1ST;
        public const Int32 ALLOWANCE_DISAB_2ND = PropertiesTaxing2014.ALLOWANCE_DISAB_2ND;
        public const Int32 ALLOWANCE_DISAB_3RD = PropertiesTaxing2014.ALLOWANCE_DISAB_3RD;
        public const Int32 ALLOWANCE_STUDY = PropertiesTaxing2014.ALLOWANCE_STUDY;
        public const Int32 ALLOWANCE_CHILD_1ST = PropertiesTaxing2014.ALLOWANCE_CHILD_1ST;
        public const Int32 ALLOWANCE_CHILD_2ND = 1317;
        public const Int32 ALLOWANCE_CHILD_3RD = 1417;
        public const decimal FACTOR_ADVANCES = PropertiesTaxing2014.FACTOR_ADVANCES;
        public const decimal FACTOR_WITHHOLD = PropertiesTaxing2014.FACTOR_WITHHOLD;
        public const decimal FACTOR_SOLIDARY = PropertiesTaxing2014.FACTOR_SOLIDARY;
        public const Int32 MIN_VALID_AMOUNT_OF_TAXBONUS = PropertiesTaxing2014.MIN_VALID_AMOUNT_OF_TAXBONUS;
        public const Int32 MAX_VALID_AMOUNT_OF_TAXBONUS = PropertiesTaxing2014.MAX_VALID_AMOUNT_OF_TAXBONUS;
        public const Int32 MIN_VALID_INCOME_OF_TAXBONUS = 9200;
        public const Int32 MAX_VALID_INCOME_OF_ROUNDING = PropertiesTaxing2014.MAX_VALID_INCOME_OF_ROUNDING;
        public const Int32 MAX_VALID_INCOME_OF_WITHHOLD = PropertiesTaxing2014.MAX_VALID_INCOME_OF_WITHHOLD;
        public const Int32 MIN_VALID_INCOME_OF_SOLIDARY = 106444;
    }
}
