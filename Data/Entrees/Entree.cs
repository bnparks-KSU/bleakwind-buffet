﻿/*
 * Author: Brian Parks
 * Class name: Entree.cs
 * Purpose: Base class that contains the fields shared by all entrees.
 */

using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees {

    /// <summary>
    /// A base class for common properties of all entrees.
    /// </summary>
    public abstract class Entree : IOrderItem {

        /// <summary>
        /// The property changed event handler.
        /// </summary>
        public abstract event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The price of the entree.
        /// </summary>
        /// <value>
        /// In United States Dollars.
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The amount of calories in the entree.
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// The list of special instructions used to prepare the entree.
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Forwards the Description of the entree.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// Forward the ToString of any entree item.
        /// </summary>
        public string ItemName { get { return this.ToString(); } }
    }
}