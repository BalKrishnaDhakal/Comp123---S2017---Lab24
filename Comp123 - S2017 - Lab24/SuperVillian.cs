using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comp123___S2017___Lab24
{
    public class SuperVillian
    {
        // PRIVATE INSTANCE VARIABLES
        private int _karma;
        // PUBLIC PROPERTIES
        public int Karma
        {
            get
            {
                return this._karma;

            }
            set
            {
                this._karma = value;

            }
        }

        // CONSTRUCTORS
        /// <summary>
        /// This is the main constructor for the SuperHuman class
        /// It takes one argument - name(string)
        /// </summary>
        /// <param name="name"></param>
        public SuperHero(string name, int karma)
            : base(name)
        {
            this.Karma = karma;

        }
        // PRIVATE METHODS
        // PUBLIC METHODS
    }
}