/*
 * Author: Brian Parks
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent the fried miraak side.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Sides {
    /// <summary>
    /// Represents a fried miraak side menu option.
    /// </summary>
    public class FriedMiraak : Side {
        /// <summary>
        /// Gets the price of the side.
        /// </summary>
        public override double Price {
            get {
                switch (Size) {
                    case Size.Small: return 1.78;
                    case Size.Medium: return 2.01;
                    case Size.Large: return 2.88;
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
                    case Size.Small: return 151;
                    case Size.Medium: return 236;
                    case Size.Large: return 306;
                    default: throw new NotImplementedException("Should never occur");
                }
            }
        }
        /// <summary>
        /// Gets the name and size of the side option.
        /// </summary>
        /// <returns>The name of the side in the format {Size} Fried Miraak</returns>
        public override string ToString() {
            return Size + " Fried Miraak";
        }
    }
}
