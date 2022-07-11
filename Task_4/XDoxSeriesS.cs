using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4
{
    class XBoxSeriesS : XBoxSeriesX
    {
        public int seriesSCounter { get; private set; }

        public XBoxSeriesS()
        {
            seriesSCounter++;
        }

        protected override void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                base.Dispose(isDisposing);
                Console.WriteLine("Deleting XBox Series S.");
            }
        }
        public override string PlayGame()
        {
            return "I'm starting game in 900p 60fps!";
        }
    }
}
