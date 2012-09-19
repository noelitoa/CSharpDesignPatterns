using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NodaTime;
using Ninject.Modules;

namespace Sandbox
{
    class Injector : NinjectModule
    {

        public override void Load()
        {
            Bind<IClock>().To<SystemClock>();

        }


        
        //public IClock CreateClock()
        //{
        //    return SystemClock.Instance;
        //}

        //public License CreateLicense()
        //{
        //    return new License(Instant.UnixEpoch, CreateClock());
        //}

        //public CalendarSystem CreateCalendarSystem()
        //{
        //    return CalendarSystem.Iso;
        //}

        //public DateTimeZone CreateDateTimeZone()
        //{
        //    return DateTimeZone.GetSystemDefault();
        //}

        //public Diary CreateDiary()
        //{
        //    return new Diary(CreateClock(), CreateCalendarSystem(), CreateDateTimeZone());
        //}

        //public DiaryPresenter CreateDiaryPresenter()
        //{
        //    return new DiaryPresenter(CreateDiary(), CreateLicense());
        //}

        //IClock clock = SystemClock.Instance;

        //License license = new License(Instant.UnixEpoch, clock);
        //Diary diary = new Diary(clock, CalendarSystem.Iso, DateTimeZone.GetSystemDefault());
        //DiaryPresenter diaryPresenter = new DiaryPresenter(diary, license);

        
    }
}
