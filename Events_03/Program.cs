﻿using System;

// События.

namespace Events_03
{
    public delegate void PressKeyEventHandler();

    public class Keyboard
    {
        public event PressKeyEventHandler PressKeyA = null;
        public event PressKeyEventHandler PressKeyB = null;
        public event PressKeyEventHandler PressKeyC = null;
        //  C ... Z

        public void PressKeyAEvent()
        {
            if (PressKeyA != null)
            {
                PressKeyA.Invoke(); // вызываем метод Invoke на событии
            }
        }

        public void PressKeyBEvent()
        {
            if (PressKeyB != null)
            {
                PressKeyB.Invoke();
            }
        }

        public void PressKeyCEvent()
        {
            if (PressKeyC != null)
            {
                PressKeyC.Invoke();
            }
        }

        public void Start()
        {
            while (true)
            {
                string s = Console.ReadLine();

                switch (s)
                {
                    case "a":
                    case "A":
                        PressKeyAEvent();
                        break;
                    case "b":
                    case "B":
                        PressKeyBEvent();
                        break;
                    case "c":
                    case "C":
                        PressKeyCEvent();
                        break;
                    case "exit":
                        goto Exit;

                    default:
                        Console.WriteLine("Нет обработчика нажатия на клавишу {0}", s);
                        break;
                }
            }

            Exit:
            Console.WriteLine("Exit!");
        }
    }

    class Program
    {
        // Методы обработчики события.

        static private void PressKeyA_Handler()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("    X    ");
            Console.WriteLine("   X X   ");
            Console.WriteLine("  X   X  ");
            Console.WriteLine(" XXXXXXX ");
            Console.WriteLine("X       X");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static private void PressKeyB_Handler()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("XXXXX  ");
            Console.WriteLine("X    X ");
            Console.WriteLine("XXXXXX ");
            Console.WriteLine("X     X");
            Console.WriteLine("XXXXXX ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        static private void PressKeyC_Handler()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("XXXXXX  ");
            Console.WriteLine("X       ");
            Console.WriteLine("X       ");
            Console.WriteLine("X       ");
            Console.WriteLine("XXXXXXX ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void Main()
        {
            Keyboard keyboard = new Keyboard();

            // Подписка на событие.
            keyboard.PressKeyA += new PressKeyEventHandler(PressKeyA_Handler);
            keyboard.PressKeyB += PressKeyB_Handler;
            keyboard.PressKeyC += PressKeyC_Handler;

            // Запуск метода, который будет следить за нажатием клавиш 
            keyboard.Start();
        }
    }
}