using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace CowboyCafe.Data
{
    /// <summary>
    /// Base class for different drink classes
    /// </summary>
    public abstract class Drink : IOrderItem
    {

        /// <summary>
        /// Gets or sets the size of the drink. Small by default.
        /// </summary>
        public Size Size { get; set; } = Size.Small;        

        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets or sets if the drink has ice. True by default.
        /// </summary>
        // public bool Ice { get; set; } = true;

        /// <summary>
        /// Gets the special instructions of the drink
        /// </summary>
        public abstract List<String> SpecialInstructions { get; }
    }
}
