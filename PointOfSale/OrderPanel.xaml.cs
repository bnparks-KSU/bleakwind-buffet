/*
 * Author: Brian Parks
 * Class name: OrderPanel.xaml.cs
 * Purpose: Class used to handle the implementation of the OrderPanel control.
 */

using BleakwindBuffet.Data;
using System;
using System.Windows;
using System.Windows.Controls;

namespace PointOfSale {

    /// <summary>
    /// Interaction logic for OrderPanel.xaml
    /// </summary>
    public partial class OrderPanel : UserControl {

        /// <summary>
        /// The ScreenChangeEvent handler.
        /// </summary>
        public event EventHandler<ScreenChangeEventArgs> ScreenChangeEvent;

        /// <summary>
        /// The NewOrderEvent handler.
        /// </summary>
        public event EventHandler<NewOrderEventArgs> NewOrderEvent;

        /// <summary>
        /// Creates a new OrderPanel control
        /// </summary>
        public OrderPanel() {
            InitializeComponent();
        }

        /// <summary>
        /// Handles when the user clicks on the complete order button.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The RoutedEventArgs of the event.</param>
        private void CompleteOrder(object sender, RoutedEventArgs e) {
            ScreenChangeEvent?.Invoke(this, new ScreenChangeEventArgs(new PaymentOptions()));
        }

        /// <summary>
        /// Handles when the user clicks on the cancel order button.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The RoutedEventArgs of the event.</param>
        private void CancelOrder(object sender, RoutedEventArgs e) {
            NewOrderEvent?.Invoke(this, new NewOrderEventArgs(new Order()));
        }

        /// <summary>
        /// Handles when the user clicks on an item in the selection window.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The SelectionChangedEventArgs of the event.</param>
        private void OrderItemSelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (OrderListView.SelectedItem != null) {
                ScreenChangeEvent?.Invoke(this, new ScreenChangeEventArgs(new CustomizationScreen(OrderListView.SelectedItem as IOrderItem, null)));
                OrderListView.SelectedItem = null;
            }
        }
    }
}