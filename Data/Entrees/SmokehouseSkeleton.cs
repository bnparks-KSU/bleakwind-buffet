/*
 * Author: Brian Parks
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the breakfast combo, the SmokehouseSkeleton.
 */

using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees {

    /// <summary>
    /// Represents the SmokehouseSkeleton menu option.
    /// </summary>
    public class SmokehouseSkeleton : Entree, INotifyPropertyChanged {
        private bool _sausage = true;
        private bool _egg = true;
        private bool _hashbrown = true;
        private bool _pancake = true;

        /// <summary>
        /// The property changed event handler.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets or sets if the customer wants sausage.
        /// </summary>
        public bool SausageLink {
            get {
                return _sausage;
            }
            set {
                _sausage = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sausage"));
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
        /// Gets or sets if the customer wants hash browns.
        /// </summary>
        public bool HashBrowns {
            get {
                return _hashbrown;
            }
            set {
                _hashbrown = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HashBrowns"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Gets or sets if the customer wants pancakes.
        /// </summary>
        public bool Pancake {
            get {
                return _pancake;
            }
            set {
                _pancake = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pancake"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Gets the price of the menu item.
        /// </summary>
        public override double Price => 5.62;

        /// <summary>
        /// Gets the amount of calories in the menu item.
        /// </summary>
        public override uint Calories => 602;

        /// <summary>
        /// Gets a list of special instructions for the menu item.
        /// </summary>
        public override List<string> SpecialInstructions {
            get {
                List<string> ret = new List<string>();
                if (!SausageLink) ret.Add("Hold sausage");
                if (!Egg) ret.Add("Hold eggs");
                if (!HashBrowns) ret.Add("Hold hash browns");
                if (!Pancake) ret.Add("Hold pancakes");
                return ret;
            }
        }

        /// <summary>
        /// The description of the smokehouse skeleton.
        /// </summary>
        public override string Description => "Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.";

        /// <summary>
        /// Gets the name of the menu item.
        /// </summary>
        /// <returns>The name of the entree Smokehouse Skeleton</returns>
        public override string ToString() {
            return "Smokehouse Skeleton";
        }
    }
}