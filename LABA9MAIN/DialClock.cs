using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA9MAIN
{
    public class DialClock
    {
        static int count = 0;
        public static int GetCount => count;
        private int hours;
        public int Hours
        {
            get => hours;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Ошибка. Кол-во часов не может быть меньше 0.");
                    hours = 0;
                }
                else hours = value % 24;
            }
        }
        private int minutes;
        public int Minutes
        {
            get => minutes;
            set
            {
                if (value >= 60)
                {
                    Hours += value / 60;
                    minutes = value % 60;
                }
                else minutes = value;
                if (value < 0)
                {
                    Console.WriteLine("Ошибка. Кол-во минут не может быть меньше 0.");
                    minutes = 0;
                }
            }
        }
        public DialClock()
        {
            Hours = 0;
            Minutes = 0;
            count++;
        }
        public DialClock(int h, int m)
        {
            Hours = h;
            Minutes = m;
            count++;
        }
        public DialClock(DialClock dc)
        {
            Hours = dc.Hours;
            Minutes = dc.Minutes;
            count++;
        }
        public void Show()
        {
            Console.WriteLine($"{Hours}:{Minutes}");
        }
        public double AngleBetweenHnM()
        {
            double angle = Math.Abs(30 * this.Hours - 5.5 * this.Minutes) % 360;
            if (angle > (360 - angle))
            {
                return Math.Round(360 - angle, 4);
            }
            else
            {
                return Math.Round(angle, 4);
            }
        }
        public static double AngleBetweenHnMStat(DialClock dc)
        {
            double angle = Math.Abs(30 * dc.Hours - 5.5 * dc.Minutes) % 360;
            if (angle > (360 - angle))
            {
                return Math.Round(360 - angle, 4);
            }
            else
            {
                return Math.Round(angle, 4);
            }
        }
        public static DialClock operator ++(DialClock dc)
        {
            DialClock result = new DialClock(dc);
            result.Minutes++;
            return result;
        }
        public static DialClock operator --(DialClock dc)
        {
            DialClock result = new DialClock(dc);
            if (result.Minutes > 0)
            {
                result.Minutes--;
            }
            else if (result.Hours > 0) 
            {
                result.Hours--;
                result.Minutes = 59;
            }
            else
            {
                result.Hours = 23;
                result.Minutes = 59;
            }
            return result;
        }
        public static DialClock operator +(int mins, DialClock dc)
        {
            DialClock sum = new DialClock(dc);
            sum.Minutes += mins;
            return sum;
        }
        public static DialClock operator +(DialClock dc, int mins)
        {
            DialClock sum = new DialClock(dc);
            sum.Minutes += mins;
            return sum;
        }
        public static DialClock operator -(int mins, DialClock dc)
        {
            DialClock sum = new DialClock(dc);
            int time = dc.Hours * 60 + dc.Minutes;
            if (mins - time < 0)
            {
                Console.WriteLine("Вычитание произвести невозможно. Разность получится меньше 0.");
                if (mins > 0 ) 
                {
                    sum.Hours = mins / 60;
                    sum.Minutes = mins % 60;
                }
                else
                {
                    sum.Hours = 0;
                    sum.Minutes = 0;
                }
            }
            else
            {
                mins -= time;
                sum.Hours = mins / 60;
                sum.Minutes = mins % 60;
            }
            return sum;
        }
        public static DialClock operator -(DialClock dc, int mins)
        {
            DialClock sum = new DialClock(dc);
            int time = dc.Hours * 60 + dc.Minutes;
            if (time - mins < 0)
            {
                Console.WriteLine("Вычитание произвести невозможно. Разность получится меньше 0.");
            }
            else
            {
                time -= mins;
                sum.Hours = time / 60;
                sum.Minutes = time % 60;
            }
            return sum;
        }
        public static explicit operator bool(DialClock dc)
        {
            return AngleBetweenHnMStat(dc) % 2.5 == 0;
        }
        public static implicit operator int(DialClock dc)
        {
            return dc.Minutes + dc.Hours * 60;
        }
        public override bool Equals(object? obj)
        {
            if(obj == null) return false;
            if (obj is not DialClock) return false;
            return ((DialClock)obj).Hours == this.Hours && ((DialClock)obj).Minutes == this.Minutes;
        }
    }
}
