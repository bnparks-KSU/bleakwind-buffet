/*
 * Author: Brian Parks
 * Class: MockEntreeImplementation.cs
 * Purpose: Act as a mock implementation of a random entree to use for the combo item tests.
 */
using BleakwindBuffet.Data.Entrees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.DataTests.UnitTests.MockImplementation {
    public class MockEntreeImplementation : Entree, INotifyPropertyChanged {
        //Private backing variables.
        private double price;
        private uint calories;
        private List<string> specialI = new List<string>();

        /// <summary>
        /// The price of this mock implementation of an entree.
        /// </summary>
        public override double Price => price;
        /// <summary>
        /// The calories of this mock implementation of an entree.
        /// </summary>
        public override uint Calories => calories;
        /// <summary>
        /// The special instructions of this mock implementation of an entree.
        /// </summary>
        public override List<string> SpecialInstructions => specialI;
        /// <summary>
        /// The implementation of the description field.
        /// </summary>
        public override string Description => "Mock Entree Implementation";

        /// <summary>
        /// The PropertyChanged event handler of this mock implementation of an entree.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;
        
        /// <summary>
        /// Creates a new mock implementation of an entree.
        /// </summary>
        /// <param name="price">The price for this mock implementation of an entree.</param>
        /// <param name="calories"></param>
        public MockEntreeImplementation(double price, uint calories) {
            this.price = price;
            this.calories = calories;
        }

        /// <summary>
        /// Changes the price for this mock implementation of an entree.
        /// </summary>
        /// <param name="newPrice">The new price for this mock implementation of an entree.</param>
        public void ChangePrice(double newPrice) {
            this.price = newPrice;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }

        /// <summary>
        /// Changes the amount of calories for this mock implementation of an entree.
        /// </summary>
        /// <param name="newCalories">The new amount of calories for this mock implementation of an entree.</param>
        public void ChangeCalories(uint newCalories) {
            this.calories = newCalories;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }

        /// <summary>
        /// Adds a special instruction to this mock implementation of an entree.
        /// </summary>
        /// <param name="newInstruction">The new instruction to add to this mock implementation of an entree.</param>
        public void AddInstruction(string newInstruction) {
            this.specialI.Add(newInstruction);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }

        /// <summary>
        /// Returns the name of this mock implementation of an entree.
        /// </summary>
        /// <returns>The name of this mock implementation of an entree.</returns>
        public override string ToString() {
            return "Mock Entree Implementation Object";
        }
    }
}
