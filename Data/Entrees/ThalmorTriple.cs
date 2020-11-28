/*
 * Author: Brian Parks
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent the triple burger, the Thalmor Triple.
 */

using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees {

    /// <summary>
    /// ThalmoreTriple represents a triple cheeseburger.
    /// </summary>
    public class ThalmorTriple : Entree, INotifyPropertyChanged {
        private bool _bun = true;
        private bool _ketchup = true;
        private bool _mustard = true;
        private bool _pickle = true;
        private bool _cheese = true;
        private bool _tomato = true;
        private bool _lettuce = true;
        private bool _mayo = true;
        private bool _bacon = true;
        private bool _egg = true;

        /// <summary>
        /// The property changed event handler.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets or sets if the customer wants a bun.
        /// </summary>
        public bool Bun {
            get {
                return _bun;
            }
            set {
                _bun = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Gets or sets if the customer wants ketchup.
        /// </summary>
        public bool Ketchup {
            get {
                return _ketchup;
            }
            set {
                _ketchup = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Gets or sets if the customer wants mustard.
        /// </summary>
        public bool Mustard {
            get {
                return _mustard;
            }
            set {
                _mustard = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Gets or sets if the customer wants pickles.
        /// </summary>
        public bool Pickle {
            get {
                return _pickle;
            }
            set {
                _pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Gets or sets if the customer wants cheese.
        /// </summary>
        public bool Cheese {
            get {
                return _cheese;
            }
            set {
                _cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Gets or sets if the customer wants tomato on their burger.
        /// </summary>
        public bool Tomato {
            get {
                return _tomato;
            }
            set {
                _tomato = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Gets or sets if the customer wants lettuce on their burger.
        /// </summary>
        public bool Lettuce {
            get {
                return _lettuce;
            }
            set {
                _lettuce = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Gets or sets if the customer wants mayo on their burger.
        /// </summary>
        public bool Mayo {
            get {
                return _mayo;
            }
            set {
                _mayo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Gets or sets if the customer wants bacon.
        /// </summary>
        public bool Bacon {
            get {
                return _bacon;
            }
            set {
                _bacon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bacon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Gets or sets if the customer wants eggs.
        /// </summary>
        public bool Egg {
            get {
                return _egg;
            }
            set {
                _egg = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Gets the price of the burger.
        /// </summary>
        public override double Price => 8.32;

        /// <summary>
        /// Gets the calories of the burger.
        /// </summary>
        public override uint Calories => 943;

        /// <summary>
        /// Gets a list of the special instructions for the menu item.
        /// </summary>
        public override List<string> SpecialInstructions {
            get {
                List<string> ret = new List<string>();
                if (!Bun) ret.Add("Hold bun");
                if (!Ketchup) ret.Add("Hold ketchup");
                if (!Mustard) ret.Add("Hold mustard");
                if (!Pickle) ret.Add("Hold pickle");
                if (!Cheese) ret.Add("Hold cheese");
                if (!Tomato) ret.Add("Hold tomato");
                if (!Lettuce) ret.Add("Hold lettuce");
                if (!Mayo) ret.Add("Hold mayo");
                if (!Bacon) ret.Add("Hold bacon");
                if (!Egg) ret.Add("Hold egg");
                return ret;
            }
        }

        /// <summary>
        /// The description of the thalmor triple.
        /// </summary>
        public override string Description => "Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.";

        /// <summary>
        /// Returns the name of the menu item
        /// </summary>
        /// <returns>The name of the entree Thalmor Triple</returns>
        public override string ToString() {
            return "Thalmor Triple";
        }
    }
}