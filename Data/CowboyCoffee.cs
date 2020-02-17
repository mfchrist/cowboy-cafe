using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// Gets or sets if the drink has ice. False by default.
        /// </summary>
        public CowboyCoffee()
        {
            Ice = false;
        }

        /// <summary>
        /// Determines if coffee has room for cream, false by default.
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Determines if coffee is decaf, false by default.
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// Sets the calories of the drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 7;
                    case Size.Medium:
                        return 5;
                    case Size.Small:
                        return 3;
                    default:
                        throw new NotImplementedException("Unknown Size");

                }
            }
        }

        /// <summary>
        /// Sets the price of the drink
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.6;
                    case Size.Medium:
                        return 1.1;
                    case Size.Small:
                        return 0.6;
                    default:
                        throw new NotImplementedException("Unknown Price");

                }
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (Ice) instructions.Add("Add Ice");
                if (RoomForCream) instructions.Add("Room for Cream");
                return instructions;
            }
        }
    }
}
