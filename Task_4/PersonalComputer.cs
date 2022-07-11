using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4
{
    class PersonalComputer : GameStation
    {
        public static int computerCounter { get; private set; }

        protected override void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                base.Dispose(isDisposing);
                Console.WriteLine("Deleting PC.");
            }

        }

        public PersonalComputer()
        {
            computerCounter++;
        }
        public virtual string RenderVideos()
        {
            return "I'm rendering new video in 4K 60fps!";
        }

        public string PlayMusic(bool isFromVK)
        {
            if (isFromVK)
            {
                return $"Now I'm playing music from VK";
            }
            return "Other platforms can't play music from VK";
        }
    }
}
