/*
 * Author: Brian Parks
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent the fried miraak side.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides {
    /// <summary>
    /// Represents a fried miraak side menu option.
    /// </summary>
    public class FriedMiraak {
        private Size size = Size.Small;
        /// <summary>
        /// Gets the price of the side option.
        /// </summary>
        public double Price { get; private set; } = 1.78;
        /// <summary>
        /// Gets the amount of calories in the side option.
        /// </summary>
        public uint Calories { get; private set; } = 151;
        /// <summary>
        /// Gets a list of special instructions for the side option.
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
                    Price = 1.78;
                    Calories = 151;
                } else if (value == Size.Medium) {
                    Price = 2.01;
                    Calories = 236;
                } else {
                    Price = 2.88;
                    Calories = 306;
                }
            }
        }
        /// <summary>
        /// Gets the name and size of the side option.
        /// </summary>
        /// <returns>The name of the side in the format {Size} Fried Miraak</returns>
        public override string ToString() {
            return size + " Fried Miraak";
        }
    }
}
