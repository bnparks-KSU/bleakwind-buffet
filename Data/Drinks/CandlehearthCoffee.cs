/*
 * Author: Brian Parks
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent the candlehearth coffee drink.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Drinks {
    /// <summary>
    /// Represents the Candlehearth coffee drink.
    /// </summary>
    public class CandlehearthCoffee : Drink {
        /// <summary>
        /// Gets the price of the drink.
        /// </summary>
        public override double Price {
            get {
                switch (Size) {
                    case Size.Small: return 0.75;
                    case Size.Medium: return 1.25;
                    case Size.Large: return 1.75;
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
                    case Size.Small: return 7;
                    case Size.Medium: return 10;
                    case Size.Large: return 20;
                    default: throw new NotImplementedException("Should never occur");
                }
            }
        }
        /// <summary>
        /// Gets or sets if the customer wants ice in their drink.
        /// </summary>
        public bool Ice { get; set; } = false;
        /// <summary>
        /// Gets or sets of the customer wants cream in their drink.
        /// </summary>
        public bool RoomForCream { get; set; } = false;
        /// <summary>
        /// Gets or sets if the user wants their drink caffinated or decaf.
        /// </summary>
        public bool Decaf { get; set; } = false;
        /// <summary>
        /// Gets a list of special instructions for the drink.
        /// </summary>
        public override List<string> SpecialInstructions {
            get {
                List<string> ret = new List<string>();
                if (Ice) ret.Add("Add ice");
                if (RoomForCream) ret.Add("Add cream");
                return ret;
            }
        }
        /// <summary>
        /// Gets the name and size of the drink.
        /// </summary>
        /// <returns>The name of the drink in the format {Size} {Decaf?} Candlehearth Coffee</returns>
        public override string ToString() {
            return Size + (Decaf ? " Decaf Candlehearth Coffee" : " Candlehearth Coffee");
        }
    }
}
