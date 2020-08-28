/*
 * Author: Brian Parks
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent the triple burger, the Thalmor Triple.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entree {
    /// <summary>
    /// ThalmoreTriple represents a double cheeseburger and is built off of the DoubleDraugr object with additional topping choices.
    /// </summary>
    public class ThalmorTriple : DoubleDraugr {
        /// <summary>
        /// Gets or sets if the customer wants bacon.
        /// </summary>
        public bool Bacon { get; set; } = true;
        /// <summary>
        /// Gets or sets if the customer wants eggs.
        /// </summary>
        public bool Egg { get; set; } = true;
        /// <summary>
        /// Gets the price of the burger.
        /// </summary>
        public override double Price => 8.32;
        /// <summary>
        /// Gets the calories of the burger.
        /// </summary>
        public override uint Calories => 943;
        /// <summary>
        /// Gets a list of the special instructions for the menu item.
        /// </summary>
        public override List<string> SpecialInstructions {
            get {
                List<string> ret = base.SpecialInstructions;
                if (!Bacon) ret.Add("Hold bacon");
                if (!Egg) ret.Add("Hold egg");
                return ret;
            }
        }
        /// <summary>
        /// Returns the name of the menu item
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return "Thalmmore Triple";
        }
    }
}
