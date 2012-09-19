using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NodaTime.Testing;
using NodaTime;

namespace Sandbox
{
    [TestFixture]
    class DiaryTest
    {
        [Test]
        public void FormatToday_Iso_Utc()
        { 
            StubClock clock = new StubClock(Instant.UnixEpoch);
            Diary diary = new Diary(clock, CalendarSystem.Iso, DateTimeZone.Utc);

            string today = diary.FormatToday();
            Assert.AreEqual("1970-01-01", today);
        }

        [Test]
        public void FormatToday_Iso_NegativeOffset()
        {
            
            StubClock clock = new StubClock(Instant.UnixEpoch);
            Diary diary = new Diary(clock, CalendarSystem.Iso, DateTimeZone.GetSystemDefault());

            string today = diary.FormatToday();
            Assert.AreEqual("1970-01-01", today);
        }


        [Test]
        public void FormatToday_Julian_Utc()
        {
            StubClock clock = new StubClock(Instant.FromUtc(1970,1,1,0,0));
            Diary diary = new Diary(clock, CalendarSystem.GetJulianCalendar(7), DateTimeZone.Utc);

            string today = diary.FormatToday();
            Assert.AreEqual("1969-12-19", today);
        }

        [Test]
        public void FormatToday_Julian_Utcx()
        {
            StubClock clock = new StubClock(Instant.FromUtc(1970, 1, 1, 0, 0));
            Diary diary = new Diary(clock, CalendarSystem.GetJulianCalendar(7), DateTimeZone.Utc);

            string today = diary.FormatToday();
            Assert.AreEqual("1969-12-19", today);
        }
    }
}
