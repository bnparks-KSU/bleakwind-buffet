/*
 * Author: Brian Parks
 * Class name: MainWindow.xaml.cs
 * Purpose: Class used to handle the implementation of the MainWindow screen.
 */

using BleakwindBuffet.Data;
using System.Windows;
using System.Windows.Controls;

namespace PointOfSale {

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        /// <summary>
        /// The current main control of the screen. Only used so that it can remove event handlers on screen change.
        /// </summary>
        private UserControl currentControl;

        /// <summary>
        /// Creates a new MainWindow and builds the start of the display.
        /// </summary>
        public MainWindow() {
            InitializeComponent();
            OrderPanelScreen.NewOrderEvent += NewOrder;
            OrderPanelScreen.ScreenChangeEvent += ScreenChange;
            ItemSelectionScreen.ScreenChangeEvent += ScreenChange;
            currentControl = ItemSelectionScreen;
            DataContext = new Order();
        }

        /// <summary>
        /// Handles when a new order should occur.
        /// </summary>
        /// <param name="sender">The object that requested the new order.</param>
        /// <param name="e">The NewOrderEventArgs</param>
        private void NewOrder(object sender, NewOrderEventArgs e) {
            DataContext = e._newOrder;
            ScreenChange(this, new ScreenChangeEventArgs(new ItemSelectionScreen()));
        }

        /// <summary>
        /// Handles when a screen change should occur.
        /// </summary>
        /// <param name="sender">The object that requested the screen to be changed.</param>
        /// <param name="e">The ScreenChangeEventArgs</param>
        private void ScreenChange(object sender, ScreenChangeEventArgs e) {
            //Remove old handlers
            if (currentControl is PaymentOptions) {
                (currentControl as PaymentOptions).ScreenChangeEvent -= ScreenChange;
                (currentControl as PaymentOptions).NewOrderEvent -= NewOrder;
            }
            if (currentControl is CurrencyPayment) {
                (currentControl as CurrencyPayment).ScreenChangeEvent -= ScreenChange;
                (currentControl as CurrencyPayment).NewOrderEvent -= NewOrder;
            }
            if (currentControl is CustomizationScreen) {
                (currentControl as CustomizationScreen).ScreenChangeEvent -= ScreenChange;
            }
            if (currentControl is ItemSelectionScreen) {
                (currentControl as ItemSelectionScreen).ScreenChangeEvent -= ScreenChange;
            }

            //Add new handlers
            if (e._newScreen is PaymentOptions) {
                (e._newScreen as PaymentOptions).ScreenChangeEvent += ScreenChange;
                (e._newScreen as PaymentOptions).NewOrderEvent += NewOrder;
            }
            if (e._newScreen is CurrencyPayment) {
                (e._newScreen as CurrencyPayment).ScreenChangeEvent += ScreenChange;
                (e._newScreen as CurrencyPayment).NewOrderEvent += NewOrder;
            }
            if (e._newScreen is CustomizationScreen) {
                (e._newScreen as CustomizationScreen).ScreenChangeEvent += ScreenChange;
            }
            if (e._newScreen is ItemSelectionScreen) {
                (e._newScreen as ItemSelectionScreen).ScreenChangeEvent += ScreenChange;
            }
            currentControl = e._newScreen;
            MainGrid.Children.RemoveAt(0);
            MainGrid.Children.Insert(0, e._newScreen);
        }
    }
}