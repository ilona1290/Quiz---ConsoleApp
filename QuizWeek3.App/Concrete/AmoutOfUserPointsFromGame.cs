using QuizWeek3.Domain.Entity;
using System;
using System.Diagnostics;

namespace QuizWeek3.App.Concrete
{
    public class AmoutOfUserPointsFromGame
    {
        public int AllPointsFromGame { get; set; }
        public HelperClass CountingTime()
        {
            Stopwatch stoper = new Stopwatch();
            stoper.Start();
            char choice = Char.Parse(Console.ReadLine().ToUpper());
            stoper.Stop();
            TimeSpan time = stoper.Elapsed;
            double elapsedTime = Double.Parse(String.Format("{0},{1}", time.Seconds, time.Milliseconds / 10));
            Console.WriteLine($"Odpowiedziałeś/aś na to pytanie w {elapsedTime} sekund.");
            if (elapsedTime > 10.0)
            {
                Console.WriteLine("Niestety przekroczyłeś/aś 10 sekund. Za to pytanie otrzymasz minusowe punkty.");
            }
            stoper.Reset();
            HelperClass helper = new HelperClass(choice, elapsedTime);
            return helper;
        }
        public int ChangeTimeToPoints(double time)
        {
            double countedPoints = 10000 - time * 1000;
            int points = (int)countedPoints;
            AllPointsFromGame += points;
            return points;
        }

        public int ReturnAllPoints()
        {
            return AllPointsFromGame;
        }
    }
}
