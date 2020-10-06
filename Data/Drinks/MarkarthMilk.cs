/*
 * Author: Brian Parks
 * Class name: MarkathMilk.cs
 * Purpose: Class used to represent the Markath Milk drink.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks {
    /// <summary>
    /// Represents the Markath Milk drink.
    /// </summary>
    public class MarkarthMilk : Drink, INotifyPropertyChanged {
        /// <summary>
        /// The property changed event handler.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;
        private bool _ice = false;
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
            }
        }
        /// <summary>
        /// Gets the price of the drink.
        /// </summary>
        public override double Price {
            get {
                switch (Size) {
                    case Size.Small: return 1.05;
                    case Size.Medium: return 1.11;
                    case Size.Large: return 1.22;
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
                    case Size.Small: return 56;
                    case Size.Medium: return 72;
                    case Size.Large: return 93;
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
                if (Ice) ret.Add("Add ice");
                return ret;
            }
        }
        /// <summary>
        /// Gets the name and size and size of the drink.
        /// </summary>
        /// <returns>The name of the drink in the format {Size} Markarth Milk</returns>
        public override string ToString() {
            return Size + " Markarth Milk";
        }
    }
}
