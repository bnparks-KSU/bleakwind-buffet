/*
 * Author: Brian Parks
 * Class name: NewOrderEventArgs.cs
 * Purpose: An event args used for new order events.
 */

using BleakwindBuffet.Data;

namespace PointOfSale {

    public class NewOrderEventArgs {

        /// <summary>
        /// The instance of the new order object for this event.
        /// </summary>
        public Order _newOrder { get; private set; }

        /// <summary>
        /// Creates a new NewOrderEventArgs with the provided new instance of a new order.
        /// </summary>
        /// <param name="order">The new order for this event.</param>
        public NewOrderEventArgs(Order order) {
            this._newOrder = order;
        }
    }
}