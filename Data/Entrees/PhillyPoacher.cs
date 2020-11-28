/*
 * Author: Brian Parks
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent the philly cheesesteak menu option.
 */

using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees {

    /// <summary>
    /// PhillyPoacher is a philly cheesesteak food option.
    /// </summary>
    public class PhillyPoacher : Entree, INotifyPropertyChanged {
        private bool _sirloin = true;
        private bool _onion = true;
        private bool _roll = true;

        /// <summary>
        /// The property changed event handler.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets or sets if the customer wants sirloin.
        /// </summary>
        public bool Sirloin {
            get {
                return _sirloin;
            }
            set {
                _sirloin = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sirloin"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Gets or sets if the customer wants onion.
        /// </summary>
        public bool Onion {
            get {
                return _onion;
            }
            set {
                _onion = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Onion"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Gets or sets if the customer wants rolls.
        /// </summary>
        public bool Roll {
            get {
                return _roll;
            }
            set {
                _roll = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Roll"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Gets the price of the menu item.
        /// </summary>
        public override double Price => 7.23;

        /// <summary>
        /// Gets the amount of calories in the menu item.
        /// </summary>
        public override uint Calories => 784;

        /// <summary>
        /// Gets a list of special instructions for the menu item.
        /// </summary>
        public override List<string> SpecialInstructions {
            get {
                List<string> ret = new List<string>();
                if (!Sirloin) ret.Add("Hold sirloin");
                if (!Onion) ret.Add("Hold onions");
                if (!Roll) ret.Add("Hold roll");
                return ret;
            }
        }

        /// <summary>
        /// The description of the philly poacher.
        /// </summary>
        public override string Description => "Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.";

        /// <summary>
        /// Returns a string of the name of the menu item.
        /// </summary>
        /// <returns>The name of the entree Philly Poacher</returns>
        public override string ToString() {
            return "Philly Poacher";
        }
    }
}