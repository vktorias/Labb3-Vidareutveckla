using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_Vidareutveckla
{
    internal class CappuccinoFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($"Pour {total} ml cappuccino in your cup"); // Utskrift av mängden cappuccino som hälls upp
            return new Cappuccino(); // Returnerar en ny instans av Cappuccino
        }
    }
}
