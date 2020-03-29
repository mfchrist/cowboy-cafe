using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the IOrderItem
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// Price variable
        /// </summary>
        public double Price { get; }
        /// <summary>
        /// Special Instructions variable
        /// </summary>
        public List<string> SpecialInstructions { get; }       
       
    }
}
