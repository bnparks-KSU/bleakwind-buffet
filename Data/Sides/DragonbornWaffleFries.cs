/*
 * Author: Brian Parks
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent the dragonborn waffle fries side.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Sides {
    /// <summary>
    /// Represents a dradonborn waffle fries side option.
    /// </summary>
    public class DragonbornWaffleFries : Side {
        /// <summary>
        /// Gets the price of the side.
        /// </summary>
        public override double Price {
            get {
                switch (Size) {
                    case Size.Small: return 0.42;
                    case Size.Medium: return 0.76;
                    case Size.Large: return 0.96;
                    default: throw new NotImplementedException("Should never occur");
                }
            }
        }
        /// <summary>
        /// Gets the amount of calories in the side.
        /// </summary>
        public override uint Calories {
            get {
                switch (Size) {
                    case Size.Small: return 77;
                    case Size.Medium: return 89;
                    case Size.Large: return 100;
                    default: throw new NotImplementedException("Should never occur");
                }
            }
        }
        /// <summary>
        /// Gets the name and size of the side option.
        /// </summary>
        /// <returns>The name of the side in the format {Size} Dragonborn Waffle Fries</returns>
        public override string ToString() {
            return Size + " Dragonborn Waffle Fries";
        }
    }
}
