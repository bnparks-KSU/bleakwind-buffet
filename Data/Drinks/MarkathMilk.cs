/*
 * Author: Brian Parks
 * Class name: MarkathMilk.cs
 * Purpose: Class used to represent the Markath Milk drink.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks {
    /// <summary>
    /// Represents the Markath Milk drink.
    /// </summary>
    public class SailorSoda2 {
        private Size size = Size.Small;
        /// <summary>
        /// Gets the price of the drink.
        /// </summary>
        public double Price { get; private set; } = 1.05;
        /// <summary>
        /// Gets the amount of calories in the drink.
        /// </summary>
        public uint Calories { get; private set; } = 56;
        /// <summary>
        /// Gets or sets if the customer wants ice in their drink.
        /// </summary>
        public bool Ice { get; set; } = false;
        /// <summary>
        /// Gets a list of special instructions for the drink.
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
                    Price = 1.05;
                    Calories = 56;
                } else if (size == Size.Medium) {
                    Price = 1.11;
                    Calories = 72;
                } else {
                    Price = 1.22;
                    Calories = 93;
                }
            }
        }
        /// <summary>
        /// Gets the name and size and size of the drink.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return Size + " Markath Milk";
        }
    }
}
