/*
 * Author: Brian Parks
 * Class name: Order.cs
 * Purpose: The Order data object that represents a user's order and the items contained in it.
 */

using Data.Enums;
using RoundRegister;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data {

    /// <summary>
    /// This is the data model that represents a user's order and the items contained in it.
    /// </summary>
    public class Order : ICollection<IOrderItem>, INotifyPropertyChanged, INotifyCollectionChanged {

        //Basic private data fields.
        private ObservableCollection<IOrderItem> _items;

        private double _salesTaxRate = .12;
        private int _orderNumber;
        private static int nextOrderNumber = 1;

        /// <summary>
        /// The property changed event handler.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The notify collection changed event handler.
        /// </summary>
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        /// <summary>
        /// Gets or sets the sales tax rate.
        /// </summary>
        public double SalesTaxRate {
            get {
                return _salesTaxRate;
            }
            set {
                _salesTaxRate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TaxRate"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }

        /// <summary>
        /// Gets the subtotal of the order.
        /// </summary>
        public double Subtotal {
            get {
                double total = 0;
                foreach (IOrderItem item in this) {
                    total += item.Price;
                }
                return Double.Parse(String.Format("{0:0.00}", total));
            }
        }

        /// <summary>
        /// Gets the tax amount for the order.
        /// </summary>
        public double Tax {
            get {
                return Double.Parse(String.Format("{0:0.00}", _salesTaxRate * Subtotal));
            }
        }

        /// <summary>
        /// Gets the total amount for the order.
        /// </summary>
        public double Total {
            get {
                return Double.Parse(String.Format("{0:0.00}", Tax + Subtotal));
            }
        }

        /// <summary>
        /// Gets the order number.
        /// </summary>
        public int Number {
            get {
                return _orderNumber;
            }
        }

        /// <summary>
        /// Gets an IEnumerable of <IOrderItem>s containing all of the items in the order.
        /// </summary>
        public IEnumerable<IOrderItem> OrderItems => _items;

        /// <summary>
        /// Creates a new order instance.
        /// </summary>
        public Order() {
            _items = new ObservableCollection<IOrderItem>();
            _orderNumber = nextOrderNumber;
            nextOrderNumber += 1;
        }

        /// <summary>
        /// Gets the amount of items in the order.
        /// </summary>
        public int Count => _items.Count;

        /// <summary>
        /// The order object is not read only and can be edited (always returns false).
        /// </summary>
        public bool IsReadOnly => false;

        /// <summary>
        /// Adds an item to the order.
        /// </summary>
        /// <param name="item">The item being added to the order.</param>
        public void Add(IOrderItem item) {
            if (!_items.Contains(item)) {
                item.PropertyChanged += ItemPropChanged;
                _items.Add(item);
                CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, this));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <summary>
        /// Removes a specific item in the order.
        /// </summary>
        /// <param name="item">The item to remove in the order.</param>
        /// <returns>Returns true if it found and removed the item, false if it did not.</returns>
        public bool Remove(IOrderItem item) {
            bool didIt = _items.Remove(item);
            if (didIt) {
                item.PropertyChanged -= ItemPropChanged;
                CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, this));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
            return didIt;
        }

        /// <summary>
        /// WARNING: NOT IMPLEMENTED. DO NOT USE THIS METHOD!
        /// </summary>
        public void Clear() {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets if the order contains a certain item.
        /// </summary>
        /// <param name="item">The item to check if it is in the order.</param>
        /// <returns>Returns true if the item is in the order.</returns>
        public bool Contains(IOrderItem item) {
            return _items.Contains(item);
        }

        /// <summary>
        /// Copies the IOrderItems in the order to an array of IOrderItems
        /// </summary>
        /// <param name="array">The array to copy the items into.</param>
        /// <param name="arrayIndex">The start of the copying index.</param>
        public void CopyTo(IOrderItem[] array, int arrayIndex) {
            _items.CopyTo(array, arrayIndex);
        }

        /// <summary>
        /// Gets the enumerator for the items in the order.
        /// </summary>
        /// <returns>An IEnumerator that goes over all items in the order.</returns>
        public IEnumerator<IOrderItem> GetEnumerator() {
            return _items.GetEnumerator();
        }

        /// <summary>
        /// Gets the enumerator for the items in the order.
        /// </summary>
        /// <returns>An IEnumerator that goes over all items in the order.</returns>
        IEnumerator IEnumerable.GetEnumerator() {
            return _items.GetEnumerator();
        }

        /// <summary>
        /// Handles what happens when an item in the order's property changes.
        /// </summary>
        /// <param name="sender">The object that send the property changed event.</param>
        /// <param name="e">The property changed event arguments.</param>
        private void ItemPropChanged(object sender, PropertyChangedEventArgs e) {
            if (this.Contains(sender as IOrderItem)) {
                if (e.PropertyName.Equals("Price")) {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                } else if (e.PropertyName.Equals("Calories")) {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }

                Console.WriteLine(e.PropertyName);
            }
        }

        /// <summary>
        /// Prints out a reciept to the reciepts file after an order has been paid for.
        /// </summary>
        /// <param name="type">The PaymentType that was used to complete the order.</param>
        /// <param name="changeOwed">The amount of change that was owed to the customer.</param>
        public void PrintReciept(PaymentType type, double changeOwed) {
            RecieptPrinter.PrintLine("Bleakwind Buffet Order #" + _orderNumber);
            RecieptPrinter.PrintLine("Time: " + DateTime.Now);
            RecieptPrinter.PrintLine("\nItems: " + DateTime.Now);
            foreach (IOrderItem item in this) {
                string it = " " + item.ToString();
                if (it.Length >= 40) {
                    foreach (string s in LimitLine(it)) {
                        RecieptPrinter.PrintLine(s);
                    }
                } else {
                    RecieptPrinter.PrintLine(it);
                }

                foreach (string specialI in item.SpecialInstructions) {
                    string working = " - " + specialI;
                    if (working.Length >= 40) {
                        foreach (string s in LimitLine(working)) {
                            RecieptPrinter.PrintLine(s);
                        }
                    } else {
                        RecieptPrinter.PrintLine(working);
                    }
                }
            }
            RecieptPrinter.PrintLine("\nSubtotal: $" + Math.Truncate(Subtotal * 100) / 100);
            RecieptPrinter.PrintLine("Tax: $" + Math.Truncate(Tax * 100) / 100);
            RecieptPrinter.PrintLine("Total: $" + Math.Truncate(Total * 100) / 100);
            if (type == PaymentType.Card) {
                RecieptPrinter.PrintLine("Payment Type: Card");
            } else {
                RecieptPrinter.PrintLine("Payment Type: Cash");
            }
            RecieptPrinter.PrintLine("Change: $" + Math.Truncate(changeOwed * 100) / 100);
            RecieptPrinter.CutTape();
        }

        /// <summary>
        /// Helper method that can limit a line for the receipt to 40 characters or less.
        /// </summary>
        /// <param name="it">The line to limit</param>
        /// <returns>A List<string> of the line split into partitions of length <= 40 characters.</returns>
        public List<string> LimitLine(string it) {
            List<string> subSet = new List<string>();
            int i = 0;
            string[] subsets = it.Split(' ');
            while (it.Length >= 40) {
                StringBuilder sb = new StringBuilder();
                do {
                    sb.Append(subsets[i] + " ");
                    i++;
                } while (sb.Length + subsets[i].Length < 40 && i < subsets.Length);
                it = it.Remove(0, sb.Length);
                subSet.Add(sb.ToString());
            }
            subSet.Add(it + " ");
            return subSet;
        }
    }
}