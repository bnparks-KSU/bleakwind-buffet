/*
 * Author: Brian Parks
 * Class name: CustomizationScreen.xaml.cs
 * Purpose: Class used to handle the customization of any given IOrderItem and implementation of the CustomizationScreen control.
 */
using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace PointOfSale {
    /// <summary>
    /// Interaction logic for CustomizationScreen.xaml
    /// </summary>
    public partial class CustomizationScreen : UserControl {
        private ItemSelectionScreen iss;
        private List<Control> setControls;
        /// <summary>
        /// DO NOT USE THIS CONSTRUCTOR
        /// </summary>
        public CustomizationScreen() {
            InitializeComponent();
        }

        /// <summary>
        /// Creates the customization screen for any given IOrderItem.
        /// </summary>
        /// <param name="orderItem">The item the customer is trying to order.</param>
        public CustomizationScreen(IOrderItem orderItem, ItemSelectionScreen iss) {
            InitializeComponent();
            this.DataContext = orderItem;
            this.iss = iss;
            setControls = new List<Control>();
            List<CheckBox> addLast = new List<CheckBox>(); //Just to put the drop downs above them.

            MenuItemLabel.Text = orderItem.GetType().Name;
            foreach (PropertyInfo p in orderItem.GetType().GetProperties()) {
                if(p.CanWrite) {
                    if (p.PropertyType.Name == "Boolean") {
                        CheckBox cb = new CheckBox();
                        cb.FontSize = 16;
                        cb.Content = p.Name;
                        cb.IsChecked = (bool) p.GetValue(orderItem);
                        cb.HorizontalAlignment = HorizontalAlignment.Left;
                        cb.Margin = new Thickness(5, 0, 5, 0);
                        cb.SetBinding(CheckBox.IsCheckedProperty, new Binding(p.Name) {
                            Source = orderItem,
                            Mode = BindingMode.TwoWay
                        });
                        addLast.Add(cb);
                    } else if(p.PropertyType.IsEnum) {
                        //Handle what to do for enums somehow
                        ComboBox cb = new ComboBox();
                        cb.FontSize = 16;
                        cb.Margin = new Thickness(5, 0, 5, 0);
                        switch (p.PropertyType.Name) {
                            case "SodaFlavor":
                                cb.ItemsSource = Enum.GetValues(typeof(BleakwindBuffet.Data.Enums.SodaFlavor));
                                cb.SelectedItem = (BleakwindBuffet.Data.Enums.SodaFlavor)p.GetValue(orderItem);
                                break;
                            case "Size":
                                cb.ItemsSource = Enum.GetValues(typeof(BleakwindBuffet.Data.Enums.Size));
                                cb.SelectedItem = (BleakwindBuffet.Data.Enums.Size) p.GetValue(orderItem);
                                break;
                            case "Default":
                                throw new InvalidCastException("Enum is not accounted for.");
                        }
                        cb.HorizontalAlignment = HorizontalAlignment.Left;
                        cb.SetBinding(ComboBox.SelectedValueProperty, new Binding(p.Name) {
                            Source = orderItem,
                            Mode = BindingMode.TwoWay
                        });
                        MainPanel.Children.Add(cb);
                        setControls.Add(cb);
                    }
                }
            }
            //Add those checkboxes.
            foreach(CheckBox cb in addLast) {
                MainPanel.Children.Add(cb);
                setControls.Add(cb);
            }
        }

        /// <summary>
        /// Handles when you confirm an item's order.
        /// </summary>
        /// <param name="sender">The object that send the event, in this case a button.</param>
        /// <param name="e">The arguments of the event.</param>
        private void ConfirmItem_Click(object sender, RoutedEventArgs e) {
            //TODO: Find a better way to do this.
            iss.Visibility = Visibility.Visible;
            ((MainWindow)((Grid)this.Parent).Parent).OrderPanel.Children.Add(new OrderedItem(this.DataContext as IOrderItem, iss));
            ((Grid)this.Parent).Children.Remove(this);
        }

        /// <summary>
        /// Handles when you cancel an item's order.
        /// </summary>
        /// <param name="sender">The object that send the event, in this case a button.</param>
        /// <param name="e">The arguments of the event.</param>
        private void CancelItem_Click(object sender, RoutedEventArgs e) {
            //TODO: Find a better way to do this.
            iss.Visibility = Visibility.Visible;
            ((Grid)this.Parent).Children.Remove(this);
        }
    }
}
