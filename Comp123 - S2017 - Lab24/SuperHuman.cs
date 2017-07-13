using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Bal Krishna Dhakal
 * Date: July 13, 2017
 * Description: This is the Super Human Class that extends the Human abstract class 
 * Version: 0.2 - Added initialize method
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
    }
}

