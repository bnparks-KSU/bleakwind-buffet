/*
 * Author: Brian Parks
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent the fried miraak side.
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides {

    /// <summary>
    /// Represents a fried miraak side menu option.
    /// </summary>
    public class FriedMiraak : Side, INotifyPropertyChanged {

        /// <summary>
        /// The property changed event handler.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets or sets the size of the side the customer wants.
        /// </summary>
        public override Size Size {
            get {
                return _size;
            }
            set {
                _size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ItemName"));
            }
        }

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
        /// The description of the FriedMiraak
        /// </summary>
        public override string Description => "Perfectly prepared hash brown pancakes.";

        /// <summary>
        /// Gets the name and size of the side option.
        /// </summary>
        /// <returns>The name of the side in the format {Size} Fried Miraak</returns>
        public override string ToString() {
            return Size + " Fried Miraak";
        }
    }
}