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

        /// <summary>
        /// Boolean that is bound to the user control. Allows user to make the item small.
        /// </summary>
        public bool IsSmall
        {

            get { return this.Size == Size.Small; }

            set { if (value) this.Size = Size.Small; }

        }

        /// <summary>
        /// Boolean that is bound to the user control. Allows user to make the item medium.
        /// </summary>
        public bool IsMedium
        {

            get { return this.Size == Size.Medium; }

            set { if (value) this.Size = Size.Medium; }

        }

        /// <summary>
        /// Boolean that is bound to the user control. Allows user to make the item large.
        /// </summary>
        public bool IsLarge
        {

            get { return this.Size == Size.Large; }

            set { if (value) this.Size = Size.Large; }

        }
    }
}
