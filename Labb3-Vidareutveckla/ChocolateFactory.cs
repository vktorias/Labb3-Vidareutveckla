using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_Vidareutveckla
{
    internal class ChocolateFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($"Pour {total} ml chocolate in your cup"); // Utskrift av mängden choklad som hälls upp
            return new Chocolate(); // Returnerar en ny instans av Chocolate
        }
    }
}
