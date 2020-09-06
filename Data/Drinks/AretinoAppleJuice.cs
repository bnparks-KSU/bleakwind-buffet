/*
 * Author: Brian Parks
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent the Aretino Apple Juice drink.
 */
using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Drinks {
    /// <summary>
    /// Represents the Aretino Apple Juice drink.
    /// </summary>
    public class AretinoAppleJuice {
        private Size size = Size.Small;
        /// <summary>
        /// Gets the price of the drink.
        /// </summary>
        public double Price { get; private set; } = .62;
        /// <summary>
        /// Gets the amount of calories in the drink.
        /// </summary>
        public uint Calories { get; private set; } = 44;
        /// <summary>
        /// Gets or sets if the customer wants ice in their drink.
        /// </summary>
        public bool Ice { get; set; } = false;
        /// <summary>
        /// List of special instructions for the drink.
        /// </summary>
        public List<string> SpecialInstructions {
            get {
                List<string> ret = new List<string>();
                if (Ice) ret.Add("Add ice");
                return ret;
            }
        }
        /// <summary>
        /// Gets and sets the size of the drink which also adjusts the Price and Calorie fields based off of the new size.
        /// </summary>
        public Size Size {
            get {
                return size;
            }
            set {
                size = value;
                if (size == Size.Small) {
                    Price = .62;
                    Calories = 44;
                } else if (size == Size.Medium) {
                    Price = .87;
                    Calories = 88;
                } else {
                    Price = 1.01;
                    Calories = 132;
                }
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
