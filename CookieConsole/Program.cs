using System;
using Humanizer;

namespace CookieConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantities:");
            HumanizeQuantities();
            
            Console.WriteLine("\nDate/Time Manipulation:");
            HumanizeDates();
        }

        private static void HumanizeQuantities()
        {
            Console.WriteLine("case".ToQuantity(0));
            Console.WriteLine("case".ToQuantity(1));
            Console.WriteLine("case".ToQuantity(5));
        }

        private static void HumanizeDates()
        {
            Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
            Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
            Console.WriteLine(TimeSpan.FromDays(1).Humanize());
            Console.WriteLine(TimeSpan.FromDays(16).Humanize());
        }
    }
}
