using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace CowboyCafe.Data
{
    public class JerkedSoda : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets or sets if the drink has ice. True by default.
        /// </summary>
        private bool ice = true;
        public bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));

            }
        }        

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
        /// Sets or gets soda flavor
        /// </summary>
        public SodaFlavor Flavor { get; set; }

        /// <summary>
        /// Boolean that is bound to the user control. Allows user to make the soda a cream soda.
        /// </summary>
        public bool isCreamSoda = true;
        public bool IsCreamSoda
        {
            get
            {
                return isCreamSoda;
            }
            set
            {
                Flavor = SodaFlavor.CreamSoda;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));

            }
        }

        /// <summary>
        /// Boolean that is bound to the user control. Allows user to make the soda a orange soda.
        /// </summary>
        public bool isOrangeSoda = false;
        public bool IsOrangeSoda
        {
            get
            {
                return isOrangeSoda;
            }
            set
            {
                Flavor = SodaFlavor.OrangeSoda;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));

            }
        }

        /// <summary>
        /// Boolean that is bound to the user control. Allows user to make the soda to be sarsparilla flavor.
        /// </summary>
        public bool isSasparilla = false;
        public bool IsSasparilla
        {
            get
            {
                return isSasparilla;
            }
            set
            {
                Flavor = SodaFlavor.Sarsparilla;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));

            }
        }

        /// <summary>
        /// Boolean that is bound to the user control. Allows user to make the soda to be birch beer flavor.
        /// </summary>
        public bool isBirchBeer = false;
        public bool IsBirchBeer
        {
            get
            {
                return isBirchBeer;
            }
            set
            {
                Flavor = SodaFlavor.BirchBeer;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));

            }
        }

        /// <summary>
        /// Boolean that is bound to the user control. Allows user to make the soda to be root beer flavor.
        /// </summary>
        public bool isRootBeer = false;
        public bool IsRootBeer
        {
            get
            {
                return isRootBeer;
            }
            set
            {
                Flavor = SodaFlavor.RootBeer;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));

            }
        }

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
                        return 198;
                    case Size.Medium:
                        return 146;
                    case Size.Small:
                        return 110;
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
                        return 2.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Small:
                        return 1.59;
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
                return instructions;
            }
        }

        /// <summary>
        /// Overiden ToString() method to return correct order information
        /// </summary>
        public override string ToString()
        {
            switch (Flavor)
            {
                case SodaFlavor.CreamSoda:
                    return Size.ToString()  + " Cream Soda Jerked Soda";
                case SodaFlavor.OrangeSoda:
                    return Size.ToString() + " Orange Soda Jerked Soda";
                case SodaFlavor.Sarsparilla:
                    return Size.ToString() + " Sarsparilla Jerked Soda";
                case SodaFlavor.BirchBeer:
                    return Size.ToString() + " Birch Beer Jerked Soda";
                case SodaFlavor.RootBeer:
                    return Size.ToString() + " Root Beer Jerked Soda";
                default:
                    return "Invalid Flavor";
            }
            
        }

        
    }
}
