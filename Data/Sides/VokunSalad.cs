/*
 * Author: Brian Parks
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent the vokun salad side.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides {
    /// <summary>
    /// Represents a vokun salad side menu option.
    /// </summary>
    public class VokunSalad {
        private Size size = Size.Small;
        /// <summary>
        /// Gets the price of the side menu option.
        /// </summary>
        public double Price { get; private set; } = .93;
        /// <summary>
        /// Gets the amount of calories in the side menu option.
        /// </summary>
        public uint Calories { get; private set; } = 41;
        /// <summary>
        /// Gets a list of instructions for the side menu option.
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
                    Price = .93;
                    Calories = 41;
                } else if (value == Size.Medium) {
                    Price = 1.28;
                    Calories = 52;
                } else {
                    Price = 1.82;
                    Calories = 73;
                }
            }
        }
        /// <summary>
        /// Gets the name and size of the side menu option.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return size + " Vokun Salad";
        }
    }
}
