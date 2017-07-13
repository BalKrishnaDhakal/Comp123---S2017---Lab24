using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Bal Krishna Dhakal
 * Date: July 13, 2017
 * Description: Lab 24
 * Version: 0.3 - Added a power to the SuperHuman Object 
 *              - Also displayed all the powers in the powers List
 */
namespace Comp123_S2017_Lab24
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superHuman = new SuperHuman("Super Dude");
            superHuman.AddPower("Spider Climbing", 50);
            superHuman.AddPower("Webcasting", 40);
            superHuman.DisplayPowers();
           // Console.WriteLine(superHuman.ToString());

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++");
            SuperHero superHero = new SuperHero("SuperHero Dude", 20);

            superHero.Powers.Add(new Power("Teleportation", 50));

            superHero.Powers.Add(new Power("Phasing", 40));

            superHero.Powers.Add(new Power("Invisibility", 30));

            //Console.WriteLine(superHero.ToString());

             Console.WriteLine("Karma: " + superHero.Karma);

            //SuperHero superVillian = new SuperHero("SuperHero Dude", 20);

            //superHero.Powers.Add(new Power("Teleportation", 50));

            //superHero.Powers.Add(new Power("Phasing", 40));

            //superHero.Powers.Add(new Power("Invisibility", 30));

            //Console.WriteLine(superHero.ToString());
        }
    }
}
