/*
 * Author: Brian Parks
 * Class name: DoubleDraugr.cs
 * Purpose: Class used to represent the double burger, the Double Draugr.
 */
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees {
    /// <summary>
    /// DoubleDraugr represents a double cheeseburger.
    /// </summary>
    public class DoubleDraugr : Entree {
        /// <summary>
        /// Gets or sets if the customer wants a bun.
        /// </summary>
        public bool Bun { get; set; } = true;
        /// <summary>
        /// Gets or sets if the customer wants ketchup.
        /// </summary>
        public bool Ketchup { get; set; } = true;
        /// <summary>
        /// Gets or sets if the customer wants mustard.
        /// </summary>
        public bool Mustard { get; set; } = true;
        /// <summary>
        /// Gets or sets if the customer wants pickles.
        /// </summary>
        public bool Pickle { get; set; } = true;
        /// <summary>
        /// Gets or sets if the customer wants cheese.
        /// </summary>
        public bool Cheese { get; set; } = true;
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
        public override List<string> SpecialInstructions {
            get {
                List<string> ret = new List<string>();
                if (!Bun) ret.Add("Hold bun");
                if (!Ketchup) ret.Add("Hold ketchup");
                if (!Mustard) ret.Add("Hold mustard");
                if (!Pickle) ret.Add("Hold pickle");
                if (!Cheese) ret.Add("Hold cheese");
                if (!Tomato) ret.Add("Hold tomato");
                if (!Lettuce) ret.Add("Hold lettuce");
                if (!Mayo) ret.Add("Hold mayo");
                return ret;
            }
        }
        /// <summary>
        /// Returns the name of the menu option.
        /// </summary>
        /// <returns>The name of the entree Double Draugr</returns>
        public override string ToString() {
            return "Double Draugr";
        }
    }
}
