using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4
{
    class GameStation : IDisposable
    {
        public static int stationCounter { get; private set; }
        private bool isDisposed = false;
        public GameStation()
        {
            stationCounter++;
        }

        public void Dispose()
        {
            if(isDisposed)
            {
                return;
            }
            Dispose(true);
            GC.SuppressFinalize(this);
            isDisposed = true;
        }

        protected virtual void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                Console.WriteLine("Deleting GameStation.");
            }
        }

        public virtual string PlayGame()
        {
            return "I'm starting the game in 4K 60fps!";
        }

        public virtual string WatchYouTube()
        {
            return "I'm playing YouTube in 4K!";
        }

        public string PlayMusic()
        {
            return "I'm playing music!";
        }
        public string PlayMusic(string songName)
        {
            return $"Now I'm playing «{songName}»";
        }



    }
}
