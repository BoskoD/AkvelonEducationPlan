using System;
using System.Collections.Generic;
using System.Text;

namespace DisposePattern_OverrideFinalize
{
    class DerivedClass : BaseClass
    {
        bool _disposed = false;

        ~DerivedClass() => Dispose(false);

        protected override void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }
            if (disposing)
            {
                // TODO: dispose managed state
            }

            // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below
            // TODO: set large fields to null
            _disposed = true;

            // Call the base class implementation
            base.Dispose(disposing);
        }
    }
}
