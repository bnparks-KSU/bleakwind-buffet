/*
 * Author: Brian Parks
 * Class: MockSideImplementation.cs
 * Purpose: Act as a mock implementation of a random side to use for the combo item tests.
 */
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.DataTests.UnitTests.MockImplementation {
    public class MockSideImplementation : Side, INotifyPropertyChanged {
        //Private backing variables
        private double price;
        private uint calories;
        private Size size = Size.Small;
        private List<string> specialI = new List<string>();

        /// <summary>
        /// The property changed event handler for this mock implementation of a side.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The size property for this mock implementation of a side.
        /// </summary>
        public override Size Size {
            get => size; set {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ItemName"));
            }
        }
        /// <summary>
        /// The price property for this mock implementation of a side.
        /// </summary>
        public override double Price => price;
        /// <summary>
        /// The calories property for this mock implementation of a side.
        /// </summary>
        public override uint Calories => calories;
        /// <summary>
        /// Gets special instruction property for this mock implementation of a side.
        /// </summary>
        public override List<string> SpecialInstructions => specialI;

        /// <summary>
        /// The implementation of the description field.
        /// </summary>
        public override string Description => "Mock Side Implementation";
        /// <summary>
        /// Creates a new mock implementation of a side.
        /// </summary>
        /// <param name="price">The price of the mock implementation of a side.</param>
        /// <param name="calories">The calories of the mock implementation of a side.</param>
        public MockSideImplementation(double price, uint calories) {
            this.price = price;
            this.calories = calories;
        }

        /// <summary>
        /// Changes the price for this mock implementation of a side.
        /// </summary>
        /// <param name="newPrice">The new price for this mock implementation of a side.</param>
        public void ChangePrice(double newPrice) {
            this.price = newPrice;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }

        /// <summary>
        /// Changes the amount of calories for this mock implementation of a side.
        /// </summary>
        /// <param name="newCalories">The new amount of calories for this mock implementation of a side.</param>
        public void ChangeCalories(uint newCalories) {
            this.calories = newCalories;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }

        /// <summary>
        /// Adds a special instruction to this mock implementation of a side.
        /// </summary>
        /// <param name="newInstruction">The new instruction to add to this mock implementation of a side.</param>
        public void AddInstruction(string newInstruction) {
            this.specialI.Add(newInstruction);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }

        /// <summary>
        /// Returns the name of this mock implementation of a side.
        /// </summary>
        /// <returns>The name of this mock implementation of a side.</returns>
        public override string ToString() {
            return "Mock Side Implementation Object";
        }
    }
}
