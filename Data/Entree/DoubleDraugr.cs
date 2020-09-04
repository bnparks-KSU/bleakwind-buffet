/*
 * Author: Brian Parks
 * Class name: DoubleDraugr.cs
 * Purpose: Class used to represent the double burger, the Double Draugr.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree {
    /// <summary>
    /// DoubleDraugr represents a double cheeseburger and is built off of the BriarheartBurger object with additional topping choices.
    /// </summary>
    public class DoubleDraugr : BriarheartBurger {
        /// <summary>
        /// Gets or sets if the customer wants tomato on their burger.
        /// </summary>
        public bool Tomato { get; set; } = true;
        /// <summary>
        /// Gets or sets if the customer wants lettuce on their burger.
        /// </summary>
        public bool Lettuce { get; set; } = true;
        /// <summary>
        /// Gets or sets if the customer wants mayo on their burger.
        /// </summary>
        public bool Mayo { get; set; } = true;
        /// <summary>
        /// Gets the price of the burger.
        /// </summary>
        public override double Price => 7.32;
        /// <summary>
        /// Gets the calories of the burger.
        /// </summary>
        public override uint Calories => 843;
        /// <summary>
        /// Gets a list of the special instructions for the burger.
        /// </summary>
        public override List<string> SpecialInstructions { get {
                List<string> ret = base.SpecialInstructions;
                if (!Tomato) ret.Add("Hold tomato");
                if (!Lettuce) ret.Add("Hold lettuce");
                if (!Mayo) ret.Add("Hold mayo");
                return ret;
            }
        }
        /// <summary>
        /// Returns the name of the menu option.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return "Double Draugr";
        }
    }
}
