using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace DisposePattern_SafeHandle
{
    class DerivedClass : BaseClass
    {
        private bool _disposed = false;

        private SafeHandle _safeHandle = new SafeFileHandle(IntPtr.Zero, true);

        protected override void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }
            if (disposing)
            {
                _safeHandle?.Dispose();
            }
            _disposed = true;

            base.Dispose(disposing);
        }
    }
}
