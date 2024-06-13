using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_Vidareutveckla
{
    internal class CoffeeFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($"Pour {total} ml coffee in your cup"); // Utskrift av mängden kaffe som hälls upp
            return new Coffee(); // Returnerar en ny instans av Coffee
        }
    }
}
