﻿/*
 * Author: Brian Parks
 * Class name: IOrderItem.cs
 * Purpose: Interface that contains the fields shared by all menu items. Everything on the menu should implement this.
 */

using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data {

    /// <summary>
    /// IOrderItem is an interface for all menu items to implement containing the basic properties shared by all.
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged {

        /// <summary>
        /// The price of the item.
        /// </summary>
        /// <value>
        /// In United States Dollars.
        /// </value>
        double Price { get; }

        /// <summary>
        /// The amount of calories in the item.
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// The list of special instructions used to prepare the item.
        /// </summary>
        List<string> SpecialInstructions { get; }

        /// <summary>
        /// The name of the item.
        /// </summary>
        string ItemName { get; }

        /// <summary>
        /// The description of the item.
        /// </summary>
        string Description { get; }
    }
}