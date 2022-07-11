using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4
{
    class Laptop : PersonalComputer
    {
        public static int laptopCounter { get; private set; }

        protected override void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                base.Dispose(isDisposing);
                Console.WriteLine("Deleting Laptop");
            }
        }

        public Laptop()
        {
            laptopCounter++;
        }
        public override string PlayGame()
        {
            return "I'm starting game in 720p 30 fps :(";
        }

        public override string WatchYouTube()
        {
            return "I'm playing YouTube in 720p :(";
        }

        public override string RenderVideos()
        {
            return "I can't render any video in OK quality :(";
        }

        public string WordWithoutElecricity()
        {
            return "Now I'm work without electricity!";
        }
    }
}
