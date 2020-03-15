using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class BakedBeans : Side, INotifyPropertyChanged
    {
        /// <summary>
        /// Property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Boolean that is bound to the user control. Allows user to make the item small.
        /// </summary>
        public bool isSmall = true;
        public bool IsSmall
        {
            get
            {
                return isSmall;
            }
            set
            {
                Size = Size.Small;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));

            }
        }

        /// <summary>
        /// Boolean that is bound to the user control. Allows user to make the item medium.
        /// </summary>
        public bool isMedium = false;
        public bool IsMedium
        {
            get
            {
                return isMedium;
            }
            set
            {
                Size = Size.Medium;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));

            }
        }

        /// <summary>
        /// Boolean that is bound to the user control. Allows user to make the item large.
        /// </summary>
        public bool isLarge = false;
        public bool IsLarge
        {
            get
            {
                return isLarge;
            }
            set
            {
                Size = Size.Large;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));

            }
        }

        /// <summary>
        /// Sets the calories of the entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 410;
                    case Size.Medium:
                        return 378;
                    case Size.Small:
                        return 312;
                    default:
                        throw new NotImplementedException("Unknown Size");

                }
            }
        }

        /// <summary>
        /// Sets the price of the entree
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.99;
                    case Size.Medium:
                        return 1.79;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown Price");

                }
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the side
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                return instructions;
            }
        }

        /// <summary>
        /// Overiden ToString() method to return correct order information
        /// </summary>
        public override string ToString()
        {
            return Size.ToString() + " Baked Beans";
        }
    }
}
