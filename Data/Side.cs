using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// Gets the size of the entree
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        public abstract List<string> SpecialInstructions { get; }

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
