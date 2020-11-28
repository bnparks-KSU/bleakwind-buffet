/*
 * Author: Brian Parks
 * Class name: ComboItem.cs
 * Purpose: Represents a combo item.
 */

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data {

    /// <summary>
    /// This represents a combo item of an entree, side, and a drink.
    /// </summary>
    public class ComboItem : IOrderItem {

        /// <summary>
        /// The entree for the combo item. By default it is a BriarheartBurger.
        /// </summary>
        private Entree _entree = new BriarheartBurger();

        /// <summary>
        /// The side for the combo item. By default it is a dragonborn waffle fry.
        /// </summary>
        private Side _side = new DragonbornWaffleFries();

        /// <summary>
        /// The drink for the combo item. By default it is a warrior water.
        /// </summary>
        private Drink _drink = new WarriorWater();

        /// <summary>
        /// The property changed event handler.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Creates a new combo item.
        /// </summary>
        public ComboItem() {
            _entree = new BriarheartBurger();
            _entree.PropertyChanged += EntreePropChanged;
            _side = new DragonbornWaffleFries();
            _side.PropertyChanged += SidePropChanged;
            _drink = new WarriorWater();
            _drink.PropertyChanged += DrinkPropChanged;
        }

        /// <summary>
        /// Gets or sets the entree for the combo item.
        /// </summary>
        public Entree Entree {
            get {
                return _entree;
            }
            set {
                if (!_entree.Equals(value)) {
                    _entree.PropertyChanged -= EntreePropChanged;
                    _entree = value;
                    _entree.PropertyChanged += EntreePropChanged;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ItemName"));
                }
            }
        }

        /// <summary>
        /// Gets or sets the side for the combo item.
        /// </summary>
        public Side Side {
            get {
                return _side;
            }
            set {
                if (!_side.Equals(value)) {
                    _side.PropertyChanged -= SidePropChanged;
                    _side = value;
                    _side.PropertyChanged += SidePropChanged;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Gets or sets the drink for the combo item.
        /// </summary>
        public Drink Drink {
            get {
                return _drink;
            }
            set {
                if (!_drink.Equals(value)) {
                    _drink.PropertyChanged -= DrinkPropChanged;
                    _drink = value;
                    _drink.PropertyChanged += DrinkPropChanged;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Represents the price for the combo item, after taking into account the $1 discount.
        /// </summary>
        public double Price {
            get {
                return Math.Truncate((_entree.Price + _side.Price + _drink.Price - 1) * 100) / 100;
            }
        }

        /// <summary>
        /// The amount of calories for all items in the combo together.
        /// </summary>
        public uint Calories {
            get {
                return _entree.Calories + _side.Calories + _drink.Calories;
            }
        }

        /// <summary>
        /// Returns a list of special instructions for this combo item.
        /// </summary>
        public List<string> SpecialInstructions {
            get {
                List<string> retlist = new List<string>();
                retlist.Add(_entree.ToString());
                foreach (string s in _entree.SpecialInstructions) {
                    retlist.Add(" - " + s);
                }
                retlist.Add(_side.ToString());
                foreach (string s in _side.SpecialInstructions) {
                    retlist.Add(" - " + s);
                }
                retlist.Add(_drink.ToString());
                foreach (string s in _drink.SpecialInstructions) {
                    retlist.Add(" - " + s);
                }
                return retlist;
            }
        }

        /// <summary>
        /// The description of a combo item. (Never displayed)
        /// </summary>
        public string Description => "A combination of an entree, drink, and side.";

        /// <summary>
        /// Handles when the entree has a property changed.
        /// </summary>
        /// <param name="sender">The object that sent the property changed event.</param>
        /// <param name="e">The property changed event arguments.</param>
        private void EntreePropChanged(object sender, PropertyChangedEventArgs e) {
            if (e.PropertyName == "Price") {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            } else if (e.PropertyName == "Calories") {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            } else if (e.PropertyName == "SpecialInstructions") {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Handles when the side has a property changed.
        /// </summary>
        /// <param name="sender">The object that sent the property changed event.</param>
        /// <param name="e">The property changed event arguments.</param>
        private void SidePropChanged(object sender, PropertyChangedEventArgs e) {
            if (e.PropertyName == "Price") {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            } else if (e.PropertyName == "Calories") {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            } else if (e.PropertyName == "SpecialInstructions" || e.PropertyName == "ItemName") {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Handles when the drink has a property changed.
        /// </summary>
        /// <param name="sender">The object that sent the property changed event.</param>
        /// <param name="e">The property changed event arguments.</param>
        private void DrinkPropChanged(object sender, PropertyChangedEventArgs e) {
            if (e.PropertyName == "Price") {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            } else if (e.PropertyName == "Calories") {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            } else if (e.PropertyName == "SpecialInstructions" || e.PropertyName == "ItemName") {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// The name of the combo item (just forwarding the ToString).
        /// </summary>
        public string ItemName => ToString();

        /// <summary>
        /// Gets the name of the combo in the form (Entree ItemName) + Combo
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return Entree.ItemName + " Combo";
        }
    }
}