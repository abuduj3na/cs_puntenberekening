﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // initialize variables - graded assignments 
            int currentAssignments = 5;
            float sophiaAverage;
            float nicoAverage;
            float zahirahAverage;
            float jeongAverage;


            int sophia1 = 93;
            int sophia2 = 87;
            int sophia3 = 98;
            int sophia4 = 95;
            int sophia5 = 100;

            int nicolas1 = 80;
            int nicolas2 = 83;
            int nicolas3 = 82;
            int nicolas4 = 88;
            int nicolas5 = 85;

            int zahirah1 = 84;
            int zahirah2 = 96;
            int zahirah3 = 73;
            int zahirah4 = 85;
            int zahirah5 = 79;

            int jeong1 = 90;
            int jeong2 = 92;
            int jeong3 = 98;
            int jeong4 = 100;
            int jeong5 = 97;

            sophiaAverage = (float)(sophia1 + sophia2 + sophia3 + sophia4 + sophia5) / (float)currentAssignments;
            Console.WriteLine($"Sophia punten: {sophiaAverage}");

            nicoAverage = (float)(nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5) / (float)currentAssignments;
            Console.WriteLine($"Nicolas punten: {nicoAverage}");

            zahirahAverage = (float)(zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5) / (float)currentAssignments;
            Console.WriteLine($"Zahirah punten: {zahirahAverage}");

            jeongAverage = (float)(jeong1 + jeong2 + jeong3 + jeong4 + jeong5) / (float)currentAssignments;
            Console.WriteLine($"Jeong punten: {jeongAverage}");

            Console.ReadLine();

        }
    }
}
