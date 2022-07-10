using System;
using System.Collections.Generic;
using System.Text;

// here ara all Dispose methods
namespace test
{
    partial class Matrix
    {
        protected virtual void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                Console.WriteLine($"\nI dunno what I should clean here with matrix\n{Print()}");
            }
        }

        public void Dispose()
        {
            if (isDisposed)
            {
                return;
            }
            Dispose(true);
            GC.SuppressFinalize(this);
            isDisposed = true;
        }
    }
}
