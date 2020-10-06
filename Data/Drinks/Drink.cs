/*
 * Author: Brian Parks
 * Class name: Drink.cs
 * Purpose: Base class that contains the fields shared by all drinks.
 */
using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks {
    /// <summary>
    /// A base class that represents the properties shared by all drinks.
    /// </summary>
    public abstract class Drink : IOrderItem {
        protected Size _size = Size.Small;
        /// <summary>
        /// The size of the drink.
        /// </summary>
        public abstract Size Size { get; set; }
        /// <summary>
        /// The price of the drink.
        /// </summary>
        /// <value>
        /// In United States Dollars.
        /// </value>
        public abstract double Price { get; }
        /// <summary>
        /// The amount of calories in the drink.
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// The list of special instructions used to prepare the drink.
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        public abstract event PropertyChangedEventHandler PropertyChanged;
    }
}
