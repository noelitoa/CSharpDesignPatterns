using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NodaTime;
using NodaTime.Testing;


namespace Sandbox
{
    [TestFixture]
    class Demo
    {
        [Test]
        public void ExpiredLicense()
        {

            Instant expiry = Instant.FromUtc(2000, 1, 1, 0, 0, 0);
            StubClock clock = new StubClock(expiry + Duration.OneMillisecond);
            License license = new License(expiry, clock);
            Assert.IsTrue(license.HasExpired);
            
        }

        [Test]
        public void NonExpiredLicense()
        {
            Instant expiry = Instant.FromUtc(2000, 1, 1, 0, 0, 0);
            StubClock clock = new StubClock(expiry - Duration.OneMillisecond);
            License license = new License(expiry, clock);
            Assert.IsFalse(license.HasExpired);

        }

        [Test]
        public void ExpiryAtExactInstance()
        {
            Instant expiry = Instant.FromUtc(2000, 1, 1, 0, 0, 0);
            StubClock clock = new StubClock(expiry);
            License license = new License(expiry, clock);
            Assert.IsTrue(license.HasExpired);

        }

        [Test]
        public void NonExpiredLicenseBecomesExpired()
        {
            Instant expiry = Instant.FromUtc(2000, 1, 1, 0, 0, 0);
            StubClock clock = new StubClock(expiry - Duration.OneMillisecond);
            License license = new License(expiry, clock);
            Assert.IsFalse(license.HasExpired);
            clock.AdvanceMilliseconds(1);
            Assert.IsTrue(license.HasExpired);

        }

    }
}
