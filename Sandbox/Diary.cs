using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NodaTime;
using NodaTime.Text;

namespace Sandbox
{
    class Diary
    {

        private readonly LocalDatePattern outputPattern = LocalDatePattern.CreateWithInvariantInfo("yyyy-MM-dd");

        private readonly IClock clock;
        private readonly CalendarSystem calendar;
        private readonly DateTimeZone timeZone;

        public Diary(IClock clock, CalendarSystem calendar, DateTimeZone timeZone)
        {
            this.clock = clock;
            this.calendar = calendar;
            this.timeZone = timeZone;
        }

        public string FormatToday()
        {
            LocalDate date = clock.Now.InZone(timeZone, calendar).LocalDateTime.Date;
            return outputPattern.Format(date);
        }



    }
}
