﻿using System;

namespace SoloLearnDance
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            int points1 = Convert.ToInt32(Console.ReadLine());
            string name2 = Console.ReadLine();
            int points2 = Convert.ToInt32(Console.ReadLine());

            DancerPoints dancer1 = new DancerPoints(name1, points1);
            DancerPoints dancer2 = new DancerPoints(name2, points2);
            DancerPoints total = dancer1 + dancer2;
            Console.WriteLine(total.name);
            Console.WriteLine(total.points);

        }

        class DancerPoints
        {
            public string name;
            public int points;

            public DancerPoints(string name, int points)
            {
                this.name = name;
                this.points = points;
            }

            public static DancerPoints operator +(DancerPoints a, DancerPoints b)
            {
                var h = a.name + " & " + b.name;
                var w = a.points + b.points;
                DancerPoints result = new DancerPoints(h, w);
                return result;

            }
            
        }
    }
}