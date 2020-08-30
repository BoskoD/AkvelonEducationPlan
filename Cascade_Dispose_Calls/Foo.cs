using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Cascade_Dispose_Calls
{
    class Foo : IDisposable
    {
        private readonly IDisposable _bar;
        public Foo()
        {
            _bar = new Bar();
        }

        public void Dispose()
        {
            _bar?.Dispose();
        }
    }
}
