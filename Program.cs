using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = Convert.ToInt32(Console.ReadLine());
            var runners = Convert.ToInt32(Console.ReadLine());
            var laps = Convert.ToInt32(Console.ReadLine());
            var lenght = Convert.ToInt32(Console.ReadLine());
            var capacity = Convert.ToInt32(Console.ReadLine());
            var donations = Convert.ToDouble(Console.ReadLine());

            long maxRunners = 0;

            if (capacity * days >= runners)
            {
                maxRunners = runners;
                long totalKm = ((long)maxRunners * laps * lenght) / 1000;
                Calculate(donations, totalKm);
            }
            else
            {
                maxRunners = capacity * days;
                long totalKm = ((long)maxRunners * laps * lenght) / 1000;
                Calculate(donations, totalKm);
            }
        }
        private static void Calculate(double donations, long totalKm)
        {
            double moneyGained = donations * totalKm;
            Console.WriteLine("Money raised: {0:F2}", moneyGained);
        }
    }
}
