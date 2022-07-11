using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4
{
    class PlayStation : GameStation
    {
        public int playStationCounter { get; private set; }

        protected override void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                base.Dispose(isDisposing);
                Console.WriteLine("Deleting PlayStation.");
            }
        }
        public PlayStation()
        {
            playStationCounter++;
        }

        public override string PlayGame()
        {
            return "I'm starting game in 2K 30 fps :(";
        }

        public string PlayLustOfAss2()
        {
            return "Oh, i see you are true pervert! So, let's play The Lust of Ass, my Master!";
        }
    }
}
