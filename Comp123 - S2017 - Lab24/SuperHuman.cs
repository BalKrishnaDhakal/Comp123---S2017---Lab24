using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Bal Krishna Dhakal
 * Date: July 13, 2017
 * Description: This is the Super Human Class that extends the Human abstract class 
 * Version: 0.4 - Added DisplayPowers method
 */
namespace Comp123___S2017___Lab24
{/// <summary>
 /// This is the SupeHuman Class
 /// </summary>
    public class SuperHuman : Human
    {
        // PRIVATE INSTANCE VARIABLES
        private List<Power> _powers;
        // PUBLIC PROPERTIES
        public List<Power> Powers
        {
            get
            {
                return this._powers; // this reference

            }
           
        }
            
        // CONSTRUCTORS
        /// <summary>
        /// This is the main constructor for the superHuman Class.
        /// It takes one parameter - name (string)
        /// </summary>
        /// <param name="name"></param>
        public SuperHuman(string name)
            : base(name)
        {
            this._initialize();

        }

        // PRIVATE METHODS
        private void _initialize()
        {
            this._powers = new List<Power>();// create a empty list
        }

        // PUBLIC METHODS
        /// <summary>
        /// This method adds a power to the Power List
        /// It takes two parameter - name(string) - rank(int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public void AddPower(string name, int rank)
        {
            this.Powers.Add(new Power(name, rank));
        }
        /// <summary>
        /// This method dispayes each of the powers stored in the Powers List
        /// </summary>
        public void DisplayPowers()
        {
            foreach(Power power in this.Powers)
            {
                Console.WriteLine("Power:" + power.Name + "Rank:" + power.Rank);
            }
        }
    }
}

