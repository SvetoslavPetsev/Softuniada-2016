using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Sum_Time
{
    class Program
    {
        static void Main()
        {
            string inputA = Console.ReadLine();
            string inputB = Console.ReadLine();

            List<int> timeA = inputA.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> timeB = inputB.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            if (timeA.Count == 2)
            {
                timeA.Insert(0, 0);
            }
            if (timeB.Count == 2)
            {
                timeB.Insert(0, 0);
            }

            bool oneHourMore = false;
            int sumMinutes = timeA[2] + timeB[2];
            if (sumMinutes > 59)
            {
                sumMinutes -= 60;
                oneHourMore = true;
            }

            bool oneDayMore = false;
            int sumHours = timeA[1] + timeB[1];
            if (oneHourMore)
            {
                sumHours++;
            }
            if (sumHours > 23)
            {
                sumHours -= 24;
                oneDayMore = true;
            }

            int sumDays = timeA[0] + timeB[0];
            if (oneDayMore)
            {
                sumDays++;
            }

            if (sumDays > 0)
            {
                Console.WriteLine($"{sumDays}::{sumHours}:{sumMinutes:D2}");
            }
            else
            {
                Console.WriteLine($"{sumHours}:{sumMinutes:D2}");
            }
        }
    }
}
