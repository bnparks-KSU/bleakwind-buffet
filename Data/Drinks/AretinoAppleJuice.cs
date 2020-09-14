/*
 * Author: Brian Parks
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent the Aretino Apple Juice drink.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Drinks {
    /// <summary>
    /// Represents the Aretino Apple Juice drink.
    /// </summary>
    public class AretinoAppleJuice : Drink {
        /// <summary>
        /// Gets the price of the drink.
        /// </summary>
        public override double Price {
            get {
                switch (Size) {
                    case Size.Small: return 0.62;
                    case Size.Medium: return 0.87;
                    case Size.Large: return 1.01;
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
                    case Size.Small: return 44;
                    case Size.Medium: return 88;
                    case Size.Large: return 132;
                    default: throw new NotImplementedException("Should never occur");
                }
            }
        }
        /// <summary>
        /// Gets or sets if the customer wants ice in their drink.
        /// </summary>
        public bool Ice { get; set; } = false;
        /// <summary>
        /// List of special instructions for the drink.
        /// </summary>
        public override List<string> SpecialInstructions {
            get {
                List<string> ret = new List<string>();
                if (Ice) ret.Add("Add ice");
                return ret;
            }
        }
        /// <summary>
        /// Returns the name and size of the drink.
        /// </summary>
        /// <returns>The name of the drink in the format {Size} Aretino Apple Juice</returns>
        public override string ToString() {
            return Size + " Aretino Apple Juice";
        }
    }
}
