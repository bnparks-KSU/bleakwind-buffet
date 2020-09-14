/*
 * Author: Brian Parks
 * Class name: Drink.cs
 * Purpose: Base class that contains the fields shared by all drinks.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks {
    /// <summary>
    /// A base class that represents the properties shared by all drinks.
    /// </summary>
    public abstract class Drink : IOrderItem {
        /// <summary>
        /// The size of the drink.
        /// </summary>
        public virtual Size Size { get; set; }
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
    }
}
