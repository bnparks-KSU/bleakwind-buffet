/*
 * Author: Brian Parks
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the sailor soda drink.
 */
using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Drinks {
    /// <summary>
    /// Represents the sailor soda drink.
    /// </summary>
    public class SailorSoda {
        private Size size = Size.Small;
        /// <summary>
        /// Gets the price of the drink.
        /// </summary>
        public double Price { get; private set; } = 1.42;
        /// <summary>
        /// Gets the amount of calories in the drink.
        /// </summary>
        public uint Calories { get; private set; } = 117;
        /// <summary>
        /// Gets or sets if the user wants ice in their drink.
        /// </summary>
        public bool Ice { get; set; } = true;
        /// <summary>
        /// Gets or sets the flavor of soda.
        /// </summary>
        public SodaFlavor Flavor { get; set; } = SodaFlavor.Cherry;
        /// <summary>
        /// Gets a list of special instructions for the drink.
        /// </summary>
        public List<string> SpecialInstructions {
            get {
                List<string> ret = new List<string>();
                if (!Ice) ret.Add("Hold ice");
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
                    Price = 1.42;
                    Calories = 117;
                } else if (size == Size.Medium) {
                    Price = 1.74;
                    Calories = 153;
                } else {
                    Price = 2.07;
                    Calories = 205;
                }
            }
        }
        /// <summary>
        /// Gets the name and size of the drink.
        /// </summary>
        /// <returns>The name of the drink in the format {Size} {Flavor} Sailor Soda</returns>
        public override string ToString() {
            return Size + " " + Flavor + " Sailor Soda";
        }
    }
}
