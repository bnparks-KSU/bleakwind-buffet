﻿/*
 * Author: Brian Parks
 * Class name: GardenOrcOmlette.cs
 * Purpose: Class used to represent the vegetarian food option.
 */
 using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entree {
    /// <summary>
    /// GardenOrcOmlette is a vegetarian breakfast option.
    /// </summary>
    public class GardenOrcOmlette {
        /// <summary>
        /// Gets or sets if the customer wants broccoli.
        /// </summary>
        public bool Broccoli { get; set; } = true;
        /// <summary>
        /// Gets or sets if the customer wants mushrooms.
        /// </summary>
        public bool Mushrooms { get; set; } = true;
        /// <summary>
        /// Gets or sets if the customer wants tomato.
        /// </summary>
        public bool Tomato { get; set; } = true;
        /// <summary>
        /// Gets or sets if the customer wants cheddar.
        /// </summary>
        public bool Cheddar { get; set; } = true;
        /// <summary>
        /// Gets the price of the menu item.
        /// </summary>
        public double Price => 4.57;
        /// <summary>
        /// Gets the amount of calories in the menu item.
        /// </summary>
        public uint Calories => 404;
        /// <summary>
        /// Gets a list of the special instructions for the menu item.
        /// </summary>
        public List<string> SpecialInstructions {
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
        /// <returns></returns>
        public override string ToString() {
            return "Garden Orc Omlette";
        }
    }
}
