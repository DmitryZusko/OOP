using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4
{
    class XBoxSeriesX : GameStation
    {
        public int seriesXcounter { get; private set; }

        public XBoxSeriesX()
        {
            seriesXcounter++;
        }

        protected override void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                base.Dispose(isDisposing);
                Console.WriteLine("Deleting XBox Series X.");
            }
        }
        public string HideMeBehindTV()
        {
            return "Now your XBox is hided behind the TV!";
        }
    }
}
