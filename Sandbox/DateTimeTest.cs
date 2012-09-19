using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Sandbox
{
    [TestFixture]
    class DateTimeTest
    {
        [Test]
        public void KindConfusion()
        {
            DateTime mystery = new DateTime(2012, 9, 14, 0, 0, 0);
            Assert.AreEqual(DateTimeKind.Unspecified, mystery.Kind);
        }

        [Test]
        public void EqualOrNotEqual()
        {

            DateTime utc1 = new DateTime(2012, 9, 14, 0, 30, 0,DateTimeKind.Utc);
            DateTime utc2 = new DateTime(2012, 9, 14, 1, 30, 0, DateTimeKind.Utc);
            Assert.AreNotEqual(utc1, utc2);

            DateTime local1 = utc1.ToLocalTime();
            DateTime local2 = utc2.ToLocalTime();
            Assert.AreNotEqual(local1, local2);


            DateTime utc3 = local1.ToUniversalTime();
            DateTime utc4 = local2.ToUniversalTime();
            Assert.AreNotEqual(utc3, utc4);

            long utc5 = local1.ToFileTime();
            long utc6 = local2.ToFileTime();
            Assert.AreNotEqual(utc5, utc6);
        
        }

    }
}
