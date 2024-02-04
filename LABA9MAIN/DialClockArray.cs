using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA9MAIN
{
    public class DialClockArray
    {
        static Random rnd = new Random();
        DialClock[] arr;
        public int Length
        {
            get => arr.Length;
        }
        static int count = 0;
        public static int GetCount => count;
        public DialClock this[int index] 
        {
            get
            { 
                if(index >= 0 && index < arr.Length)
                    return arr[index];
                throw new IndexOutOfRangeException("Ошибка. Выход за границу коллекции.");
            }
            set
            {
                if (index >= 0 && index < arr.Length)
                    arr[index] = value;
                else throw new IndexOutOfRangeException("Ошибка. Выход за границу коллекции."); 
            }
        }
        public DialClockArray()
        {
            int len = rnd.Next(1, 10);  
            arr = new DialClock[len];
            for (int i = 0; i < len; i++)
            {
                arr[i] = new DialClock(rnd.Next(0, 23), rnd.Next(0, 59));
            }
            count++;
        }
        public DialClockArray(int len, int rhours, int rmins)
        {
            arr = new DialClock[len];
            for (int i = 0; i < len; i++)
            {
                arr[i] = new DialClock(rnd.Next(0, rhours), rnd.Next(0, rmins));
            }
            count++;
        }
        public DialClockArray(int len)
        {
            arr = new DialClock[len];
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine($"Введите кол-во часов {i + 1} объекта:");
                int hours = UI.Input("Ошибка! Кол-во часов не может быть отрицательным.", 0);
                Console.WriteLine($"Введите кол-во минут {i + 1} объекта:");
                int minutes = UI.Input("Ошибка! Кол-во минут не может быть отрицательным.", 0);
                arr[i] = new DialClock(hours, minutes);
            }
            count++;
        }
        public DialClockArray(DialClockArray dca)
        {
            arr = new DialClock[dca.Length];
            for (int i = 0; i < dca.Length; i++)
            {
                arr[i] = new DialClock(dca[i]);
            }
            count++;
        }
        public void Show()
        {
            for (int i = 0; i < this.Length; i++)
            {
                arr[i].Show();
            }
        }
        public void FindClockWithMaxAngle()
        {
            double maxangle = 0;
            int maxi = 0;
            double angle;
            for (int i = 0; i < this.Length; i++)
            {
                angle = this[i].AngleBetweenHnM();
                if (angle > maxangle)
                {
                    maxangle = angle;
                    maxi = i;
                }
            }
            Console.WriteLine($"Максимальный угол между часовой и минутной стрелками составил {maxangle}. Он оказался у {maxi + 1} элемента. Его время составляет:");
            this[maxi].Show();
        }
        public bool IsEqual(DialClockArray other)
        {
            if (other == null || arr.Length != other.arr.Length)
            {
                return false;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (!arr[i].Equals(other.arr[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
