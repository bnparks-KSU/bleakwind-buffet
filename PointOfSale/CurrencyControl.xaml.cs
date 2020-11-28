/*
 * Author: Brian Parks
 * Class name: CurrencyConrol.xaml.cs
 * Purpose: Class used to handle the implementation of the CurrencyConrol control.
 */

using System.Windows;
using System.Windows.Controls;

namespace PointOfSale {

    /// <summary>
    /// Interaction logic for CurrencyControl.xaml
    /// </summary>
    public partial class CurrencyControl : UserControl {

        /// <summary>
        /// The DependencyProperty that represents the customer's money given for the payment.
        /// </summary>
        public static DependencyProperty CustomerMoney = DependencyProperty.Register(nameof(CustomerMoneyAmount), typeof(int), typeof(CurrencyControl), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault | FrameworkPropertyMetadataOptions.AffectsRender));

        /// <summary>
        /// The DependencyProperty that represents the change given for the payment.
        /// </summary>
        public static DependencyProperty ChangeMoney = DependencyProperty.Register(nameof(ChangeMoneyAmount), typeof(int), typeof(CurrencyControl));

        /// <summary>
        /// Builds the CurrencyControl object.
        /// </summary>
        public CurrencyControl() {
            InitializeComponent();
        }

        /// <summary>
        /// A string representing the value of the currency.
        /// </summary>
        public string ValueType {
            get {
                return this.ValueLabel.Content.ToString();
            }
            set {
                this.ValueLabel.Content = value;
            }
        }

        /// <summary>
        /// The amount of bills or coins of this type that the customer is paying with.
        /// </summary>
        public int CustomerMoneyAmount {
            get {
                return (int)GetValue(CustomerMoney);
            }
            set {
                SetValue(CustomerMoney, value);
            }
        }

        /// <summary>
        /// The amount of bills or coins of this type that the customer will recieve in change.
        /// </summary>
        public int ChangeMoneyAmount {
            get {
                return (int)GetValue(ChangeMoney);
            }
            set {
                SetValue(ChangeMoney, value);
            }
        }

        /// <summary>
        /// Handles when to add 1 to the customer amount.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The RoutedEventArgs of the event.</param>
        public void OnAddCustomerAmount(object sender, RoutedEventArgs rea) {
            CustomerMoneyAmount++;
        }

        /// <summary>
        /// Handles when to remove 1 from the customer amount
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The RoutedEventArgs of the event.</param>
        public void OnLowerCustomerAmount(object sender, RoutedEventArgs rea) {
            CustomerMoneyAmount = CustomerMoneyAmount > 0 ? CustomerMoneyAmount - 1 : 0;
        }
    }
}