/*
 * Author: Brian Parks
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent the Thugs T-Bone menu option.
 */
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees {
    /// <summary>
    /// Represents a T-Bone menu option.
    /// </summary>
    public class ThugsTBone : Entree {
        /// <summary>
        /// Gets the price of the menu item.
        /// </summary>
        public override double Price => 6.44;
        /// <summary>
        /// Gets the amount of calories in the menu item.
        /// </summary>
        public override uint Calories => 982;
        /// <summary>
        /// Gets a list of the special instructions for the menu item (always an empty list).
        /// </summary>
        public override List<string> SpecialInstructions {
            get {
                return new List<string>();
            }
        }
        /// <summary>
        /// Returns the name of the menu item.
        /// </summary>
        /// <returns>The name of the entree Thugs T-Bone</returns>
        public override string ToString() {
            return "Thugs T-Bone";
        }
    }
}