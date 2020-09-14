/*
 * Author: Brian Parks
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent the vokun salad side.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Sides {
    /// <summary>
    /// Represents a vokun salad side menu option.
    /// </summary>
    public class VokunSalad : Side {
        /// <summary>
        /// Gets the price of the side.
        /// </summary>
        public override double Price {
            get {
                switch (Size) {
                    case Size.Small: return 0.93;
                    case Size.Medium: return 1.28;
                    case Size.Large: return 1.82;
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
                    case Size.Small: return 41;
                    case Size.Medium: return 52;
                    case Size.Large: return 73;
                    default: throw new NotImplementedException("Should never occur");
                }
            }
        }
        /// <summary>
        /// Gets the name and size of the side menu option.
        /// </summary>
        /// <returns>The name of the side in the format {Size} Vokun Salad</returns>
        public override string ToString() {
            return Size + " Vokun Salad";
        }
    }
}
