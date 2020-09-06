/*
 * Author: Brian Parks
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the breakfast combo, the SmokehouseSkeleton.
 */
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees {
    /// <summary>
    /// Represents the SmokehouseSkeleton menu option.
    /// </summary>
    public class SmokehouseSkeleton {
        /// <summary>
        /// Gets or sets if the customer wants sausage.
        /// </summary>
        public bool SausageLink { get; set; } = true;
        /// <summary>
        /// Gets or sets if the customer wants eggs.
        /// </summary>
        public bool Egg { get; set; } = true;
        /// <summary>
        /// Gets or sets if the customer wants hash browns.
        /// </summary>
        public bool HashBrowns { get; set; } = true;
        /// <summary>
        /// Gets or sets if the customer wants pancakes.
        /// </summary>
        public bool Pancake { get; set; } = true;
        /// <summary>
        /// Gets the price of the menu item.
        /// </summary>
        public double Price => 5.62;
        /// <summary>
        /// Gets the amount of calories in the menu item.
        /// </summary>
        public uint Calories => 602;
        /// <summary>
        /// Gets a list of special instructions for the menu item.
        /// </summary>
        public List<string> SpecialInstructions {
            get {
                List<string> ret = new List<string>();
                if (!SausageLink) ret.Add("Hold sausage");
                if (!Egg) ret.Add("Hold eggs");
                if (!HashBrowns) ret.Add("Hold hash browns");
                if (!Pancake) ret.Add("Hold pancakes");
                return ret;
            }
        }
        /// <summary>
        /// Gets the name of the menu item.
        /// </summary>
        /// <returns>The name of the entree Smokehouse Skeleton</returns>
        public override string ToString() {
            return "Smokehouse Skeleton";
        }
    }
}
