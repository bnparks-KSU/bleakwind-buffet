/*
 * Author: Brian Parks
 * Class name: CurrencyPayment.xaml.cs
 * Purpose: Class used to handle the implementation of the CurrencyPayment control.
 */

using BleakwindBuffet.Data;
using Data.Enums;
using System;
using System.Windows;
using System.Windows.Controls;

namespace PointOfSale {

    /// <summary>
    /// Interaction logic for CurrencyPayment.xaml
    /// </summary>
    public partial class CurrencyPayment : UserControl {

        /// <summary>
        /// The ScreenChangeEvent handler.
        /// </summary>
        public event EventHandler<ScreenChangeEventArgs> ScreenChangeEvent;

        /// <summary>
        /// The NewOrderEvent handler.
        /// </summary>
        public event EventHandler<NewOrderEventArgs> NewOrderEvent;

        /// <summary>
        /// The current instance of the order object.
        /// </summary>
        private Order _orderInstance;

        /// <summary>
        /// Creates a new CurrencyPayment screen with the current instance of the order object.
        /// </summary>
        /// <param name="order">The current order object stored in the data context.</param>
        public CurrencyPayment(Order order) {
            _orderInstance = order;
            CashRegister cr = new CashRegister();
            cr.Total = _orderInstance.Total;
            DataContext = cr;
            InitializeComponent();
        }

        /// <summary>
        /// Finalizes the sale and prints the reciept.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The RoutedEventArgs of the event.</param>
        private void FinalizeSale_Click(object sender, RoutedEventArgs e) {
            if (((CashRegister)DataContext).Due <= 0) {
                _orderInstance.PrintReciept(PaymentType.Cash, ((CashRegister)DataContext).Owed);
                NewOrderEvent?.Invoke(this, new NewOrderEventArgs(new Order()));
            } else {
                MessageBox.Show("Cannot finalize sale until fully paid");
            }
        }

        /// <summary>
        /// Handles when the user wants to return to the order and make some changes.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The RoutedEventArgs of the event.</param>
        private void ReturnToOrder_Click(object sender, RoutedEventArgs e) {
            ScreenChangeEvent?.Invoke(this, new ScreenChangeEventArgs(new ItemSelectionScreen()));
        }
    }
}