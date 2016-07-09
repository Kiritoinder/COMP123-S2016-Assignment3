using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assinment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Console.WriteLine("******************************************");
            GiantPlanet giantPlanet = new GiantPlanet("Insigh", 4548626565, 4454548784, "Habitable i.e like earth");
            Console.WriteLine(giantPlanet.ToString());
            Console.WriteLine("******************************************");
            Console.WriteLine();
            Console.WriteLine("******************************************");
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Venus", 54500, 68420, true);
            Console.WriteLine(terrestrialPlanet.ToString());
            Console.WriteLine("******************************************");
            Console.WriteLine();
            waitForAnyKey();
        }
        public static void waitForAnyKey()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
