/*
 * Author: Brian Parks
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent the Warrior Water drink.
 */

using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks {

    /// <summary>
    /// Represents the WarriorWater drink.
    /// </summary>
    public class WarriorWater : Drink, INotifyPropertyChanged {

        /// <summary>
        /// The property changed event handler.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        private bool _ice = true;
        private bool _lemon = false;

        /// <summary>
        /// Gets or sets if the customer wants ice in their drink.
        /// </summary>
        public bool Ice {
            get {
                return _ice;
            }
            set {
                _ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Gets or sets if the customer wants lemon in their drink.
        /// </summary>
        public bool Lemon {
            get {
                return _lemon;
            }
            set {
                _lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Gets or sets the size of the drink the customer wants.
        /// </summary>
        public override Size Size {
            get {
                return _size;
            }
            set {
                _size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ItemName"));
            }
        }

        /// <summary>
        /// Gets the price of the drink.
        /// </summary>
        public override double Price { get; } = 0;

        /// <summary>
        /// Gets the amount of calories in the drink.
        /// </summary>
        public override uint Calories { get; } = 0;

        /// <summary>
        /// Gets a list of special instructions for the drink.
        /// </summary>
        public override List<string> SpecialInstructions {
            get {
                List<string> ret = new List<string>();
                if (!Ice) ret.Add("Hold ice");
                if (Lemon) ret.Add("Add lemon");
                return ret;
            }
        }

        /// <summary>
        /// The description for the WarriorWater
        /// </summary>
        public override string Description => "It’s water. Just water.";

        /// <summary>
        /// Gets the name and size of the drink.
        /// </summary>
        /// <returns>Return the name of the drink in the format {Size} Warrior Water</returns>
        public override string ToString() {
            return Size + " Warrior Water";
        }
    }
}