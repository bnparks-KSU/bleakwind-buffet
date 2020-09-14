/*
 * Author: Brian Parks
 * Class name: Side.cs
 * Purpose: Base class that contains the fields shared by all side items.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides {
    /// <summary>
    /// A base class used for all common properties of side items.
    /// </summary>
    public abstract class Side : IOrderItem {
        /// <summary>
        /// The size of the side item.
        /// </summary>
        public virtual Size Size { get; set; }
        /// <summary>
        /// The price of the side item.
        /// </summary>
        /// <value>
        /// In United States Dollars.
        /// </value>
        public abstract double Price { get; }
        /// <summary>
        /// The amount of calories in the side item.
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// The list of special instructions used to prepare the side item.
        /// </summary>
        public virtual List<string> SpecialInstructions { get => new List<string>(); }
    }
}
