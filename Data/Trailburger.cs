﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data 
{
    /// <summary>
    /// A class representing the Trailburger entree
    /// </summary>
    public class TrailBurger : Entree
    {
        private bool bun = true;
        /// <summary>
        /// If the burger has a bun
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }

        private bool pickle = true;
        /// <summary>
        /// If the burger has pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        
        /// <summary>
        /// If the burger has ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;
        
        
        /// <summary>
        /// If the burger has mustard
        /// </summary>
        public bool Mustard { get; set; } = true;

        
        /// <summary>
        /// If the burger has cheese
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// The price of the burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.50;
            }
        }

        /// <summary>
        /// The calories of the burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 288;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bun) instructions.Add("hold bun");
                if (!Ketchup) instructions.Add("hold ketchup");
                if (!Mustard) instructions.Add("hold mustard");
                if (!pickle) instructions.Add("hold pickle");
                if (!Cheese) instructions.Add("hold cheese");

                return instructions;
            }
        }
    }
}
