/*
 * Author: Brian Parks
 * Class name: PaymentOptions.xaml.cs
 * Purpose: Class used to handle the implementation of the PaymentOptions control.
 */

using BleakwindBuffet.Data;
using Data.Enums;
using RoundRegister;
using System;
using System.Windows;
using System.Windows.Controls;

namespace PointOfSale {

    /// <summary>
    /// Interaction logic for PaymentOptions.xaml
    /// </summary>
    public partial class PaymentOptions : UserControl {

        /// <summary>
        /// The ScreenChangeEvent handler.
        /// </summary>
        public event EventHandler<ScreenChangeEventArgs> ScreenChangeEvent;

        /// <summary>
        /// The NewOrderEvent handler.
        /// </summary>
        public event EventHandler<NewOrderEventArgs> NewOrderEvent;

        /// <summary>
        /// Creates a new PaymentOptions control.
        /// </summary>
        public PaymentOptions() {
            InitializeComponent();
        }

        /// <summary>
        /// Handles when a user clicks on the cash button option.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The RoutedEventArgs of the event.</param>
        private void CashButton_Click(object sender, RoutedEventArgs e) {
            ScreenChangeEvent?.Invoke(this, new ScreenChangeEventArgs(new CurrencyPayment(DataContext as Order)));
        }

        /// <summary>
        /// Handles when a user clicks on the card button option.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The RoutedEventArgs of the event.</param>
        private void CreditDebitButton_Click(object sender, RoutedEventArgs e) {
            CardTransactionResult res = CardReader.RunCard((DataContext as Order).Total);
            switch (res) {
                case CardTransactionResult.Approved:
                    ((Order)this.DataContext).PrintReciept(PaymentType.Card, 0.00);
                    NewOrderEvent?.Invoke(this, new NewOrderEventArgs(new Order()));
                    break;

                case CardTransactionResult.Declined:
                    MessageBox.Show("Your card was declined, contact your bank.");
                    break;

                case CardTransactionResult.ReadError:
                    MessageBox.Show("Error reading your card, try again.");
                    break;

                case CardTransactionResult.InsufficientFunds:
                    MessageBox.Show("Your card was rejected due to a lack of funds.");
                    break;

                case CardTransactionResult.IncorrectPin:
                    MessageBox.Show("Your pin was incorrect, try re-enterring");
                    break;
            }
        }
    }
}