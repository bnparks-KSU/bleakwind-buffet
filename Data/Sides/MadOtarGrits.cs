/*
 * Author: Brian Parks
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent the mad otar grits side.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Sides {
    /// <summary>
    /// Represents a mad otar grits side menu option.
    /// </summary>
    public class MadOtarGrits : Side {
        /// <summary>
        /// Gets the price of the side.
        /// </summary>
        public override double Price {
            get {
                switch (Size) {
                    case Size.Small: return 1.22;
                    case Size.Medium: return 1.58;
                    case Size.Large: return 1.93;
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
                    case Size.Small: return 105;
                    case Size.Medium: return 142;
                    case Size.Large: return 179;
                    default: throw new NotImplementedException("Should never occur");
                }
            }
        }
        /// <summary>
        /// Gets the name and size of the side menu option.
        /// </summary>
        /// <returns>The name of the side in the format {Size} Mad Otar Grits</returns>
        public override string ToString() {
            return Size + " Mad Otar Grits";
        }
    }
}
