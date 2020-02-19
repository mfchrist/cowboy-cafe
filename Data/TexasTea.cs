using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTea : Drink
    {
        /// <summary>
        /// Determines if tea is sweet, true by default.
        /// </summary>
        public bool Sweet { get; set; } = true;

        /// <summary>
        /// Determines if tea has lemon, false by default.
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Sets the calories of the drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Sweet == true)
                {
                    switch (Size)
                    {
                        case Size.Large:
                            return 36;
                        case Size.Medium:
                            return 22;
                        case Size.Small:
                            return 10;
                        default:
                            throw new NotImplementedException("Unknown Size");

                    }
                }
                else
                {
                    switch (Size)
                    {
                        case Size.Large:
                            return 18;
                        case Size.Medium:
                            return 11;
                        case Size.Small:
                            return 5;
                        default:
                            throw new NotImplementedException("Unknown Size");

                    }
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
                        return 2;
                    case Size.Medium:
                        return 1.5;
                    case Size.Small:
                        return 1;
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

                if (!Ice) instructions.Add("Hold Ice");
                if (Lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }

        public override string ToString()
        {
            if (Sweet)
            {
                return Size.ToString() + " Texas Sweet Tea";
            }
            else
            {
                return Size.ToString() + " Texas Plain Tea";
            }
        }
    }
}
