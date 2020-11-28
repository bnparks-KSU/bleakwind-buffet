/*
 * Author: Brian Parks
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent the dragonborn waffle fries side.
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides {

    /// <summary>
    /// Represents a dradonborn waffle fries side option.
    /// </summary>
    public class DragonbornWaffleFries : Side, INotifyPropertyChanged {

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
        /// The description of the dragonborn waffle fries.
        /// </summary>
        public override string Description => "Crispy fried potato waffle fries.";

        /// <summary>
        /// Gets the name and size of the side option.
        /// </summary>
        /// <returns>The name of the side in the format {Size} Dragonborn Waffle Fries</returns>
        public override string ToString() {
            return Size + " Dragonborn Waffle Fries";
        }
    }
}