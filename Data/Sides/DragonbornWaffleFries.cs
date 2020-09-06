/*
 * Author: Brian Parks
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent the dragonborn waffle fries side.
 */
using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Sides {
    /// <summary>
    /// Represents a dradonborn waffle fries side option.
    /// </summary>
    public class DragonbornWaffleFries {
        private Size size = Size.Small;
        /// <summary>
        /// Gets the price of the side.
        /// </summary>
        public double Price { get; private set; } = .42;
        /// <summary>
        /// Gets the amount of calories in the side.
        /// </summary>
        public uint Calories { get; private set; } = 77;
        /// <summary>
        /// Gets a list of special instructions for the side.
        /// </summary>
        public List<string> SpecialInstructions { get => new List<string>(); }
        /// <summary>
        /// Gets and sets the size of the side which also adjusts the Price and Calorie fields based off of the new size.
        /// </summary>
        public Size Size {
            get {
                return size;
            }
            set {
                size = value;
                if (value == Size.Small) {
                    Price = .42;
                    Calories = 77;
                } else if (value == Size.Medium) {
                    Price = .76;
                    Calories = 89;
                } else {
                    Price = .96;
                    Calories = 100;
                }
            }
        }
        /// <summary>
        /// Gets the name and size of the side option.
        /// </summary>
        /// <returns>The name of the side in the format {Size} Dragonborn Waffle Fries</returns>
        public override string ToString() {
            return size + " Dragonborn Waffle Fries";
        }
    }
}
