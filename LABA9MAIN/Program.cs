namespace LABA9MAIN
{
    internal class Program
    {
        public static void Task1()
        {
            Console.WriteLine("Объект clock1:");
            DialClock clock1 = new DialClock(12, 15);
            clock1.Show();
            Console.WriteLine($"Угол между часовой и минутной стрелками равен {clock1.AngleBetweenHnM()}°");
            Console.WriteLine("Объект clock2:");
            DialClock clock2 = new DialClock(24, 0);
            clock2.Show();
            Console.WriteLine($"Угол между часовой и минутной стрелками равен {clock2.AngleBetweenHnM()}°");
            Console.WriteLine("Объект clock3:");
            DialClock clock3 = new DialClock(12, 75);
            clock3.Show();
            Console.WriteLine($"Угол между часовой и минутной стрелками равен {clock3.AngleBetweenHnM()}°");
            Console.WriteLine("Объект clock4:");
            DialClock clock4 = new DialClock(clock3);
            clock4.Show();
            Console.WriteLine($"Угол между часовой и минутной стрелками равен {DialClock.AngleBetweenHnMStat(clock4)}°");
            Console.WriteLine($"Всего создано {DialClock.GetCount} объект(а, ов) класса DialClock");
        }
        public static void Task2()
        {
            Console.WriteLine("Объект clock1:");
            DialClock clock1 = new DialClock(23, 59);
            clock1.Show();
            clock1++;
            clock1.Show();
            clock1--;
            clock1.Show();
            clock1 = clock1 - 53;
            clock1.Show();
            clock1 = 53 + clock1;
            clock1.Show();
            clock1 = 53 - clock1;
            clock1.Show();
            clock1 = -53 - clock1;
            clock1.Show();
            Console.WriteLine("Объект clock2:");
            DialClock clock2 = new DialClock(0, 0);
            clock2.Show();
            clock2--;
            clock2.Show();
            Console.WriteLine("Объект clock3:");
            DialClock clock3 = new DialClock(21, 0);
            clock3.Show();
            clock3--;
            clock3.Show();
            Console.WriteLine("Объект clock4:");
            DialClock clock4 = new DialClock(4, 25);
            clock4.Show();
            Console.WriteLine($"Угол между часовой и минутной стрелками равен {DialClock.AngleBetweenHnMStat(clock4)}°");
            Console.WriteLine((bool)clock4);
            int mins = clock4;
            Console.WriteLine(mins);
        }
        public static void Task3()
        {
            Console.WriteLine("Коллекция Dca1:");
            DialClockArray Dca1 = new DialClockArray();
            Dca1.Show();
            Dca1.FindClockWithMaxAngle();
            Console.WriteLine("Коллекция Dca2:");
            DialClockArray Dca2 = new DialClockArray(5, 23, 59);
            Dca2.Show();
            Dca2.FindClockWithMaxAngle();
            Console.WriteLine("Коллекция Dca3:");
            DialClockArray Dca3 = new DialClockArray(3);
            Dca3.Show();
            Dca3.FindClockWithMaxAngle();
            Console.WriteLine("Коллекция Dca4:");
            DialClockArray Dca4 = new DialClockArray(Dca3);
            Dca4.Show();
            Dca4.FindClockWithMaxAngle();
            Console.WriteLine($"Всего создано {DialClockArray.GetCount} коллекций и {DialClock.GetCount} объектов");
            try
            {
                Dca4[2] = new DialClock(23, 59);
                Console.WriteLine(Dca4[2]);
                Dca4[100] = new DialClock();
                Console.WriteLine(Dca4[100]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            UI.Menu();
        }
    }
}
