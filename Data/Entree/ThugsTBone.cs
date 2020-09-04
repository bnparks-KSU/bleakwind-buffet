/*
 * Author: Brian Parks
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent the Thugs T-Bone menu option.
 */
 using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees {
    /// <summary>
    /// Represents a T-Bone menu option.
    /// </summary>
    public class ThugsTBone {
        /// <summary>
        /// Gets the price of the menu item.
        /// </summary>
        public double Price => 6.44;
        /// <summary>
        /// Gets the amount of calories in the menu item.
        /// </summary>
        public uint Calories => 982;
        /// <summary>
        /// Gets a list of the special instructions for the menu item (always an empty list).
        /// </summary>
        public List<string> SpecialInstructions {
            get {
                return new List<string>();
            }
        }
        /// <summary>
        /// Returns the name of the menu item.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return "Thugs T-Bone";
        }
    }
}