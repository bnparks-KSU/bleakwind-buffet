/*
 * Author: Brian Parks
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent the candlehearth coffee drink.
 */
 using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Drinks {
    /// <summary>
    /// Represents the Candlehearth coffee drink.
    /// </summary>
    public class CandlehearthCoffee {
        private Size size = Size.Small;
        /// <summary>
        /// Gets the price of the drink.
        /// </summary>
        public double Price { get; private set; } = .75;
        /// <summary>
        /// Gets the amount of calories in the drink.
        /// </summary>
        public uint Calories { get; private set; } = 7;
        /// <summary>
        /// Gets or sets if the customer wants ice in their drink.
        /// </summary>
        public bool Ice { get; set; } = true;
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
        public List<string> SpecialInstructions {
            get {
                List<string> ret = new List<string>();
                if (Ice) ret.Add("Add ice");
                if (RoomForCream) ret.Add("Add cream");
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
                    Price = .75;
                    Calories = 7;
                } else if (size == Size.Medium) {
                    Price = 1.25;
                    Calories = 10;
                } else {
                    Price = 1.75;
                    Calories = 20;
                }
            }
        }
        /// <summary>
        /// Gets the name and size of the drink.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return Size + (Decaf ? " Decaf Candlehearth Coffee" : " Candlehearth Coffee");
        }
    }
}
