/*
 * Author: Brian Parks
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent the philly cheesesteak menu option.
 */
 using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree {
    /// <summary>
    /// PhillyPoacher is a philly cheesesteak food option.
    /// </summary>
    public class PhillyPoacher {
        /// <summary>
        /// Gets or sets if the customer wants sirloin.
        /// </summary>
        public bool Sirloin { get; set; } = true;
        /// <summary>
        /// Gets or sets if the customer wants onion.
        /// </summary>
        public bool Onion { get; set; } = true;
        /// <summary>
        /// Gets or sets if the customer wants rolls.
        /// </summary>
        public bool Roll { get; set; } = true;
        /// <summary>
        /// Gets the price of the menu item.
        /// </summary>
        public double Price => 7.23;
        /// <summary>
        /// Gets the amount of calories in the menu item.
        /// </summary>
        public uint Calories => 784;
        /// <summary>
        /// Gets a list of special instructions for the menu item.
        /// </summary>
        public List<string> SpecialInstructions {
            get {
                List<string> ret = new List<string>();
                if (!Sirloin) ret.Add("Hold sirloin");
                if (!Onion) ret.Add("Hold onions");
                if (!Roll) ret.Add("Hold roll");
                return ret;
            }
        }
        /// <summary>
        /// Returns a string of the name of the menu item.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return "Philly Poacher";
        }
    }
}
