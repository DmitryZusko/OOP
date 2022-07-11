//Розробити ієрархію класів кля поштових листів. Але в листах я не шарю, придумав кароч своє.
//Створити базовий, похідні класи. Використати public, protected наслідування. Використати множинне наслідування (в шарпах цього нема для класів, ага).
//Виконати перевантаження функцій в базовому класі, перевизначити їх в похідних.

using System;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var pc = new PersonalComputer();
            using var lt = new Laptop();
            using var ps = new PlayStation();
            using var xBoxX = new XBoxSeriesX();
            using var xBoxS = new XBoxSeriesS();

            Console.WriteLine("Personal Computer: " + '\n' + pc.PlayGame() + '\n' + pc.WatchYouTube() + '\n' + pc.PlayMusic() + '\n' + pc.PlayMusic(true) + 
                '\n' + pc.PlayMusic("People = Shit") + '\n' + pc.RenderVideos());
            Console.WriteLine('\n');
            Console.WriteLine("Laptop: " + '\n' + lt.PlayGame() + '\n' + lt.WatchYouTube() + '\n' + lt.PlayMusic() + '\n' + lt.PlayMusic(false) + '\n' + lt.PlayMusic("DagothWave")
                + '\n' + lt.RenderVideos() + '\n' + lt.WordWithoutElecricity());
            Console.WriteLine('\n');
            Console.WriteLine("PlayStation: " + '\n' + ps.PlayGame() + '\n' + ps.WatchYouTube() + '\n' + ps.PlayMusic() + '\n' + ps.PlayLustOfAss2());
            Console.WriteLine('\n');
            Console.WriteLine("XBox Series X: " + '\n' + xBoxX.PlayGame() + '\n' + xBoxX.WatchYouTube() + '\n' + xBoxX.PlayMusic() + '\n' + xBoxX.HideMeBehindTV());
            Console.WriteLine('\n');
            Console.WriteLine("XBox Series S: " + '\n' + xBoxS.PlayGame() + '\n' + xBoxS.WatchYouTube() + '\n' + xBoxS.PlayMusic() + '\n' + xBoxS.HideMeBehindTV());
            Console.WriteLine('\n');
            Console.WriteLine($"Where created {PersonalComputer.computerCounter} personal computer(-s).");
            Console.WriteLine('\n');
        }
    }
}
