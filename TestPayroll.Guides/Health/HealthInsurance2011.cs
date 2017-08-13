﻿using NUnit.Framework;
using System;
using NetPayroll.Guides.Common;
using NetPayroll.Guides.Interfaces;
using NetPayroll.Guides.Contract.Health;

namespace TestPayroll.Guides
{
    [TestFixture()]
    public class HealthInsurance2011
    {
        [Test()]
        public void Should_Return_Employee_Contribution_X_CZK_For_Basis_Y_CZK()
        {
            Period periodInTest = new Period(2011, 1);

            decimal basisInTest = 10000m;

            decimal valueExpect = 650m;

            IHealthContract contract = new HealthContract2011();

            decimal valueTested = contract.EmployeeContribution(periodInTest, basisInTest);

            Assert.AreEqual(valueExpect, valueTested);
 
        }
    }
}
