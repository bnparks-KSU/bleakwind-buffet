/*
 * Author: Brian Parks
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent the Warrior Water drink.
 */
using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Drinks {
    /// <summary>
    /// Represents the WarriorWater drink.
    /// </summary>
    public class WarriorWater {
        /// <summary>
        /// Gets or sets the size of the drink.
        /// </summary>
        public Size Size { get; set; }
        /// <summary>
        /// Gets the price of the drink.
        /// </summary>
        public double Price { get; } = 0;
        /// <summary>
        /// Gets the amount of calories in the drink.
        /// </summary>
        public uint Calories { get; } = 0;
        /// <summary>
        /// Gets or sets if the customer wants ice in their drink.
        /// </summary>
        public bool Ice { get; set; } = true;
        /// <summary>
        /// Gets or sets if the customer wants lemon in their drink.
        /// </summary>
        public bool Lemon { get; set; } = false;
        /// <summary>
        /// Gets a list of special instructions for the drink.
        /// </summary>
        public List<string> SpecialInstructions {
            get {
                List<string> ret = new List<string>();
                if (!Ice) ret.Add("Hold ice");
                if (Lemon) ret.Add("Add lemon");
                return ret;
            }
        }
        /// <summary>
        /// Gets the name and size of the drink.
        /// </summary>
        /// <returns>Return the name of the drink in the format {Size} Warrior Water</returns>
        public override string ToString() {
            return Size + " Warrior Water";
        }
    }
}
