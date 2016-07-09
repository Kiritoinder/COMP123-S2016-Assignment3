using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Author: Inderjeet Singh
 * StudentNumber: 300874118
 * Description: Driver class for Planet classes and Interfaces
 * Version: 0.1.3
 * DateCreated: July 6rd, 2016
 * DateModified: July 8rd, 2016
 */
namespace Assinment_3
{
    /**
     * this class is the "driver" class for my program
     * @class Program
     */
    class Program
    {
        /**Main method of driver class
         * 
         * @method Main
         * param {string} args
         */
        static void Main(string[] args)
        {
            Console.WriteLine();
            
            //Giant Planet's Specs i.e, Name, Diameter, Mass and Type
            Console.WriteLine("******************************************");
            GiantPlanet giantPlanet = new GiantPlanet("Insigh", 4548626565, 4454548784, "Habitable i.e like earth");
            Console.WriteLine(giantPlanet.ToString());
            Console.WriteLine("******************************************");
            Console.WriteLine();
            //Terrestrial Planet's Specs i.e, Name, Diameter, Mass and Type
            Console.WriteLine("******************************************");
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Venus", 54500, 68420, true);
            Console.WriteLine(terrestrialPlanet.ToString());
            Console.WriteLine("******************************************");
            Console.WriteLine();
        }
        }
    }

