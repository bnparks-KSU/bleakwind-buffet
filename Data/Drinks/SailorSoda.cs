/*
 * Author: Brian Parks
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the sailor soda drink.
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks {

    /// <summary>
    /// Represents the sailor soda drink.
    /// </summary>
    public class SailorSoda : Drink, INotifyPropertyChanged {

        /// <summary>
        /// The property changed event handler.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        private SodaFlavor _flavor = SodaFlavor.Cherry;
        private bool _ice = true;

        /// <summary>
        /// Gets or sets if the customer wants ice in their drink.
        /// </summary>
        public bool Ice {
            get {
                return _ice;
            }
            set {
                _ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Gets or sets the flavor of soda.
        /// </summary>
        public SodaFlavor Flavor {
            get {
                return _flavor;
            }
            set {
                _flavor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SodaFlavor"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ItemName"));
            }
        }

        /// <summary>
        /// Gets or sets the size of the drink the customer wants.
        /// </summary>
        public override Size Size {
            get {
                return _size;
            }
            set {
                _size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ItemName"));
            }
        }

        /// <summary>
        /// Gets the price of the drink.
        /// </summary>
        public override double Price {
            get {
                switch (Size) {
                    case Size.Small: return 1.42;
                    case Size.Medium: return 1.74;
                    case Size.Large: return 2.07;
                    default: throw new NotImplementedException("Should never occur");
                }
            }
        }

        /// <summary>
        /// Gets the amount of calories in the drink.
        /// </summary>
        public override uint Calories {
            get {
                switch (Size) {
                    case Size.Small: return 117;
                    case Size.Medium: return 153;
                    case Size.Large: return 205;
                    default: throw new NotImplementedException("Should never occur");
                }
            }
        }

        /// <summary>
        /// Gets a list of special instructions for the drink.
        /// </summary>
        public override List<string> SpecialInstructions {
            get {
                List<string> ret = new List<string>();
                if (!Ice) ret.Add("Hold ice");
                return ret;
            }
        }

        /// <summary>
        /// The description for the sailor's soda.
        /// </summary>
        public override string Description => "An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.";

        /// <summary>
        /// Gets the name and size of the drink.
        /// </summary>
        /// <returns>The name of the drink in the format {Size} {Flavor} Sailor Soda</returns>
        public override string ToString() {
            return Size + " " + Flavor + " Sailor Soda";
        }
    }
}