/*
 * Author: Brian Parks
 * Class name: GardenOrcOmlette.cs
 * Purpose: Class used to represent the vegetarian food option.
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees {
    /// <summary>
    /// GardenOrcOmlette is a vegetarian breakfast option.
    /// </summary>
    public class GardenOrcOmelette : Entree, INotifyPropertyChanged {
        private bool _broccoli = true;
        private bool _mushroom = true;
        private bool _tomato = true;
        private bool _cheddar = true;
        /// <summary>
        /// The property changed event handler.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Gets or sets if the customer wants broccoli.
        /// </summary>
        public bool Broccoli {
            get {
                return _broccoli;
            }
            set {
                _broccoli = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli"));
            }
        }
        /// <summary>
        /// Gets or sets if the customer wants mushrooms.
        /// </summary>
        public bool Mushrooms {
            get {
                return _mushroom;
            }
            set {
                _mushroom = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));
            }
        }
        /// <summary>
        /// Gets or sets if the customer wants tomato.
        /// </summary>
        public bool Tomato {
            get {
                return _tomato;
            }
            set {
                _tomato = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
            }
        }
        /// <summary>
        /// Gets or sets if the customer wants cheddar.
        /// </summary>
        public bool Cheddar {
            get {
                return _cheddar;
            }
            set {
                _cheddar = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));
            }
        }
        /// <summary>
        /// Gets the price of the menu item.
        /// </summary>
        public override double Price => 4.57;
        /// <summary>
        /// Gets the amount of calories in the menu item.
        /// </summary>
        public override uint Calories => 404;
        /// <summary>
        /// Gets a list of the special instructions for the menu item.
        /// </summary>
        public override List<string> SpecialInstructions {
            get {
                List<string> ret = new List<string>();
                if (!Broccoli) ret.Add("Hold broccoli");
                if (!Mushrooms) ret.Add("Hold mushrooms");
                if (!Tomato) ret.Add("Hold tomato");
                if (!Cheddar) ret.Add("Hold cheddar");
                return ret;
            }
        }

        /// <summary>
        /// Gets the name of the menu item.
        /// </summary>
        /// <returns>The name of the entree Garden Orc Omelette</returns>
        public override string ToString() {
            return "Garden Orc Omelette";
        }
    }
}
