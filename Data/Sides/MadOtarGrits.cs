/*
 * Author: Brian Parks
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent the mad otar grits side.
 */
using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Sides {
    /// <summary>
    /// Represents a mad otar grits side menu option.
    /// </summary>
    public class MadOtarGrits {
        private Size size = Size.Small;
        /// <summary>
        /// Gets the price of the side.
        /// </summary>
        public double Price { get; private set; } = 1.22;
        /// <summary>
        /// Gets the amount of calories in the side.
        /// </summary>
        public uint Calories { get; private set; } = 105;
        /// <summary>
        /// Gets a list of special instructions for the side menu option.
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
                    Price = 1.22;
                    Calories = 105;
                } else if (value == Size.Medium) {
                    Price = 1.58;
                    Calories = 142;
                } else {
                    Price = 1.93;
                    Calories = 179;
                }
            }
        }
        /// <summary>
        /// Gets the name and size of the side menu option.
        /// </summary>
        /// <returns>The name of the side in the format {Size} Mad Otar Grits</returns>
        public override string ToString() {
            return size + " Mad Otar Grits";
        }
    }
}
