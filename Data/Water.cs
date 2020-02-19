using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Water : Drink
    {
        /// <summary>
        /// Determines if tea has lemon, false by default.
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Sets the price of the drink
        /// </summary>
        public override double Price
        {
            get { return 0.12; }
        }

        /// <summary>
        /// Sets the calories of the drink
        /// </summary>
        public override uint Calories
        {
            get { return 0; }
        }

        /// <summary>
        /// Special instructions for the preparation of the drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");
                if (Lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }

        public override string ToString()
        {
            return Size.ToString() + " Water";
        }
    }
}
