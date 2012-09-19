using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NodaTime;

namespace Sandbox
{
    static class BigApplication
    {
        static void Mainx()
        {
            License license = new License(Instant.FromUtc(2012, 9, 11, 6, 30,0), SystemClock.Instance);

            if (license.HasExpired)
            {
                Console.WriteLine("License has expired");
                return;
            }
        
        }
    }
}
