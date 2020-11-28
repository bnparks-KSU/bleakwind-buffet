/*
 * Author: Brian Parks
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent the base burger, the Briarheart Burger.
 */

using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees {

    /// <summary>
    /// BriarheartBurger represents the base cheeseburger object.
    /// </summary>
    public class BriarheartBurger : Entree, INotifyPropertyChanged {
        private bool _bun = true;
        private bool _ketchup = true;
        private bool _mustard = true;
        private bool _pickle = true;
        private bool _cheese = true;

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
        /// Gets the price of the item.
        /// </summary>
        public override double Price => 6.32;

        /// <summary>
        /// Gets the calories of the item.
        /// </summary>
        public override uint Calories => 743;

        /// <summary>
        /// Returns a list of the special instructions for the food item.
        /// </summary>
        public override List<string> SpecialInstructions {
            get {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                return instructions;
            }
        }

        /// <summary>
        /// The description for the briarheart burger.
        /// </summary>
        public override string Description => "Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.";

        /// <summary>
        /// Returns the name of the item.
        /// </summary>
        /// <returns>The name of the entree Briarheart Burger</returns>
        public override string ToString() {
            return "Briarheart Burger";
        }
    }
}