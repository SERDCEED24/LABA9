﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA9MAIN
{
    internal class UI
    {
        public static int Input(string errorText, int minValue = -10000, int maxValue = 10000)
        {
            int x;
            string buf;
            bool isConvert;
            do
            {
                buf = Console.ReadLine();
                isConvert = int.TryParse(buf, out x);
                if (!((minValue <= x) && (x <= maxValue)))
                {
                    isConvert = false;
                }
                if (!isConvert)
                {
                    Console.WriteLine(errorText);
                }
            } while (!isConvert);
            return x;
        }
        public static void PrintMenu()
        {
            Console.WriteLine("Выберите задачу для демонстрации:");
            Console.WriteLine("1. Задача 1.");
            Console.WriteLine("2. Задача 2.");
            Console.WriteLine("3. Задача 3.");
            Console.WriteLine("4. Выход.");
        }
        public static void Menu() 
        {
            int x;
            do
            {
                PrintMenu();
                x = Input("Ошибка! Введите целое число от 1 до 4 включительно.", 1, 4);
                switch (x)
                {
                    case 1:
                        {
                            Program.Task1();
                            break;
                        }
                    case 2:
                        {
                            Program.Task2();
                            break;
                        }
                    case 3:
                        {
                            Program.Task3();
                            break;
                        }
                }
            } while (x != 4);
        }
    }
}
