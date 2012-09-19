using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    public sealed class SomethingThatNeedsDisposing : IDisposable
    {




        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
