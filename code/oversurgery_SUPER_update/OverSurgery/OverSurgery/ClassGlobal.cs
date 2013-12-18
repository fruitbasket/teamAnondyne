using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OverSurgery
{
    static class ClassGlobal
    {
        public static bool loginClose;
        public static int formYLocation = 0;
        public static int formXLocation = 0;

        static string[] dateCalc()
        {
            DateTime currDate = DateTime.Today;
            DateTime[] dates = new DateTime[10];

            for (int i = 0; i < 10; i++)
            {
                int n = 0;
                DateTime newDate = currDate.AddDays(i);

                if (newDate.DayOfWeek == DayOfWeek.Monday || newDate.DayOfWeek == DayOfWeek.Tuesday || newDate.DayOfWeek == DayOfWeek.Wednesday
                    || newDate.DayOfWeek == DayOfWeek.Thursday || newDate.DayOfWeek == DayOfWeek.Friday)
                {
                    dates[n] = newDate;
                    n++;
                }

                if (newDate.DayOfWeek == DayOfWeek.Saturday || newDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    n--;
                }
            }

            string[] appDates = new string[10];

            for (int j = 0; j < 10; j++)
            {
                appDates[j] = dates[j].ToShortDateString();
            }

            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine(appDates[k]);
            }

            Console.ReadKey();

            return appDates;
        }
    }
}
