/*
 * Author: Brian Parks
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent the base burger, the Briarheart Burger.
 */
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees {
    /// <summary>
    /// BriarheartBurger represents the base cheeseburger object.
    /// </summary>
    public class BriarheartBurger : Entree {
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
        /// Gets the price of the item.
        /// </summary>
        public override double Price => 6.32;
        /// <summary>
        /// Gets the calories of the item.
        /// </summary>
        public override uint Calories => 743;
        /// <summary>
        /// Returns a list of the special instructions for the food item.
        /// </summary>
        public override List<string> SpecialInstructions {
            get {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                return instructions;
            }
        }

        /// <summary>
        /// Returns the name of the item.
        /// </summary>
        /// <returns>The name of the entree Briarheart Burger</returns>
        public override string ToString() {
            return "Briarheart Burger";
        }
    }
}
