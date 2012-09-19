using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NodaTime;

namespace Sandbox
{
    class License
    {
        private readonly Instant expiry;
        private readonly IClock clock;

        public License(Instant expiry, IClock clock)
        {
            this.expiry = expiry;
            this.clock = clock;
        }


        public bool HasExpired
        {
            get { return clock.Now >= expiry; }
        }
    }
}
