using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Triple Burger entree
    /// </summary>
    public class TexasTripleBurger : Entree
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
        /// If the burger has tomato
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// If the burger has lettuce
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// If the burger has mayo
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// If the burger has bacon
        /// </summary>
        public bool Bacon { get; set; } = true;

        /// <summary>
        /// If the burger has egg
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// The price of the burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.45;
            }
        }

        /// <summary>
        /// The calories of the burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 698;
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
                if (!Tomato) instructions.Add("hold tomato");
                if (!Lettuce) instructions.Add("hold lettuce");
                if (!Mayo) instructions.Add("hold mayo");
                if (!Bacon) instructions.Add("hold bacon");
                if (!Egg) instructions.Add("hold egg");

                return instructions;
            }
        }

        /// <summary>
        /// Overiden ToString() method to return correct order information
        /// </summary>
        public override string ToString()
        {
            return "Texas Triple Burger";
        }
    }
}
