/*
 * Author: Brian Parks
 * Class name: CustomizationScreen.xaml.cs
 * Purpose: Class used to handle the customization of any given IOrderItem and implementation of the CustomizationScreen control.
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Menu = BleakwindBuffet.Data.Menu;

namespace PointOfSale {

    /// <summary>
    /// Interaction logic for CustomizationScreen.xaml
    /// </summary>
    public partial class CustomizationScreen : UserControl {
        private List<Control> setControls;
        private IOrderItem item;
        private IOrderItem parentItem;

        /// <summary>
        /// The ScreenChangeEvent handler.
        /// </summary>
        public event EventHandler<ScreenChangeEventArgs> ScreenChangeEvent;

        /// <summary>
        /// Creates the customization screen for any given IOrderItem.
        /// </summary>
        /// <param name="orderItem">The item the customer is trying to order.</param>
        public CustomizationScreen(IOrderItem orderItem, IOrderItem parentItem) {
            InitializeComponent();
            item = orderItem;
            this.parentItem = parentItem;
            Refresh();
        }

        /// <summary>
        /// Used for creating the actual CustomizationScreen window. This is done seperately to allow for the recreation of the screen
        /// to reflect recent updates to items, specifically when changed through a combo item.
        /// </summary>
        private void Refresh() {
            setControls = new List<Control>();
            List<CheckBox> addLast = new List<CheckBox>(); //Just to put the drop downs above them.
            MainPanel.Children.RemoveRange(2, MainPanel.Children.Count);
            MenuItemLabel.Text = item.GetType().Name;
            if (!(item is ComboItem)) {
                foreach (PropertyInfo p in item.GetType().GetProperties()) {
                    if (p.CanWrite) {
                        if (p.PropertyType.Name == "Boolean") {
                            CreateFromBoolean(item as IOrderItem, p, addLast);
                        } else if (p.PropertyType.IsEnum) {
                            CreateFromEnum(item as IOrderItem, p);
                        }
                    }
                }
                //Add those checkboxes.
                foreach (CheckBox cb in addLast) {
                    MainPanel.Children.Add(cb);
                    setControls.Add(cb);
                }
            } else {
                CreateComboItem(item as ComboItem);
            }
        }

        /// <summary>
        /// Creates and adds a checkbox for customization from a property of type boolean.
        /// </summary>
        /// <param name="orderItem">The item that the checkbox will be bound to.</param>
        /// <param name="p">The property of the item that the checkbox will be representing.</param>
        /// <param name="addLast">The list of all components to be added at the end of the screen.</param>
        private void CreateFromBoolean(IOrderItem orderItem, PropertyInfo p, List<CheckBox> addLast) {
            CheckBox cb = new CheckBox();
            cb.FontSize = 16;
            cb.Content = p.Name;
            cb.IsChecked = (bool)p.GetValue(orderItem);
            cb.HorizontalAlignment = HorizontalAlignment.Left;
            cb.Margin = new Thickness(5, 0, 5, 0);
            cb.SetBinding(CheckBox.IsCheckedProperty, new Binding(p.Name) {
                Source = orderItem,
                Mode = BindingMode.TwoWay
            });
            addLast.Add(cb);
        }

        /// <summary>
        /// Creates and adds a combobox control for customization of a property built off of an enum value.
        /// </summary>
        /// <param name="orderItem">The item that the combobox will be bound to.</param>
        /// <param name="p">The property of the item that the combobox will be representing.</param>
        private void CreateFromEnum(IOrderItem orderItem, PropertyInfo p) {
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
                    cb.SelectedItem = (BleakwindBuffet.Data.Enums.Size)p.GetValue(orderItem);
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

        /// <summary>
        /// Creates the window based off of a combo item being created.
        /// </summary>
        /// <param name="combo">The combo item being created.</param>
        private void CreateComboItem(ComboItem combo) {
            //Entree
            ComboBox entreeCb = new ComboBox();
            entreeCb.FontSize = 16;
            entreeCb.Margin = new Thickness(5, 0, 5, 0);
            entreeCb.ItemsSource = GetItemsForComboBox(Menu.Entrees(), combo.Entree);
            entreeCb.HorizontalAlignment = HorizontalAlignment.Left;
            entreeCb.SetBinding(ComboBox.SelectedValueProperty, new Binding(combo.GetType().GetProperty("Entree").Name) {
                Source = combo,
                Mode = BindingMode.TwoWay
            });
            MainPanel.Children.Add(entreeCb);
            setControls.Add(entreeCb);
            entreeCb.SelectedIndex = 0;

            Button customizeEntreeButton = new Button();
            customizeEntreeButton.Content = "Customize Entree";
            customizeEntreeButton.Click += CustomizeEntreeButtonClick;
            customizeEntreeButton.FontSize = 16;
            customizeEntreeButton.Margin = new Thickness(5, 0, 5, 0);
            customizeEntreeButton.HorizontalAlignment = HorizontalAlignment.Left;
            MainPanel.Children.Add(customizeEntreeButton);
            setControls.Add(customizeEntreeButton);

            //Side
            ComboBox sideCb = new ComboBox();
            sideCb.FontSize = 16;
            sideCb.Margin = new Thickness(5, 0, 5, 0);
            sideCb.ItemsSource = GetItemsForComboBox(Menu.Sides(), combo.Side);
            sideCb.SelectedItem = combo.Side;
            sideCb.HorizontalAlignment = HorizontalAlignment.Left;
            sideCb.SetBinding(ComboBox.SelectedValueProperty, new Binding(combo.GetType().GetProperty("Side").Name) {
                Source = combo,
                Mode = BindingMode.TwoWay
            });
            MainPanel.Children.Add(sideCb);
            setControls.Add(sideCb);
            sideCb.SelectedIndex = 0;

            Button customizeSideButton = new Button();
            customizeSideButton.Content = "Customize Side";
            customizeSideButton.Click += CustomizeSideButtonClick;
            customizeSideButton.FontSize = 16;
            customizeSideButton.Margin = new Thickness(5, 0, 5, 0);
            customizeSideButton.HorizontalAlignment = HorizontalAlignment.Left;
            MainPanel.Children.Add(customizeSideButton);
            setControls.Add(customizeSideButton);

            //Drink
            ComboBox drinkCb = new ComboBox();
            drinkCb.FontSize = 16;
            drinkCb.Margin = new Thickness(5, 0, 5, 0);
            drinkCb.ItemsSource = GetItemsForComboBox(Menu.Drinks(), combo.Drink);
            drinkCb.HorizontalAlignment = HorizontalAlignment.Left;
            drinkCb.SetBinding(ComboBox.SelectedValueProperty, new Binding(combo.GetType().GetProperty("Drink").Name) {
                Source = combo,
                Mode = BindingMode.TwoWay
            });
            MainPanel.Children.Add(drinkCb);
            setControls.Add(drinkCb);
            drinkCb.SelectedIndex = 0;

            Button customizeDrinkButton = new Button();
            customizeDrinkButton.Content = "Customize Drink";
            customizeDrinkButton.Click += CustomizeDrinkButtonClick;
            customizeDrinkButton.FontSize = 16;
            customizeDrinkButton.Margin = new Thickness(5, 0, 5, 0);
            customizeDrinkButton.HorizontalAlignment = HorizontalAlignment.Left;
            MainPanel.Children.Add(customizeDrinkButton);
            setControls.Add(customizeDrinkButton);
        }

        /// <summary>
        /// Handles when you confirm an item's order.
        /// </summary>
        /// <param name="sender">The object that send the event, in this case a button.</param>
        /// <param name="e">The arguments of the event.</param>
        private void ConfirmItem_Click(object sender, RoutedEventArgs e) {
            if (parentItem != null) {
                ScreenChangeEvent?.Invoke(this, new ScreenChangeEventArgs(new CustomizationScreen(parentItem, null)));
            } else {
                (this.DataContext as Order).Add(item);
                ScreenChangeEvent?.Invoke(this, new ScreenChangeEventArgs(new ItemSelectionScreen()));
            }
        }

        /// <summary>
        /// Handles when you cancel an item's order.
        /// </summary>
        /// <param name="sender">The object that send the event, in this case a button.</param>
        /// <param name="e">The arguments of the event.</param>
        private void CancelItem_Click(object sender, RoutedEventArgs e) {
            if (parentItem != null) {
                ScreenChangeEvent?.Invoke(this, new ScreenChangeEventArgs(new CustomizationScreen(parentItem, null)));
            } else {
                (this.DataContext as Order).Remove(item);
                ScreenChangeEvent?.Invoke(this, new ScreenChangeEventArgs(new ItemSelectionScreen()));
            }
        }

        /// <summary>
        /// Button that handles when a user decides to customize an entree in a combo.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The routed event args from the event.</param>
        private void CustomizeEntreeButtonClick(object sender, RoutedEventArgs e) {
            ScreenChangeEvent?.Invoke(this, new ScreenChangeEventArgs(new CustomizationScreen((this.item as ComboItem).Entree, this.item as ComboItem)));
        }

        /// <summary>
        /// Button that handles when a user decides to customize a side in a combo.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The routed event args from the event.</param>
        private void CustomizeSideButtonClick(object sender, RoutedEventArgs e) {
            ScreenChangeEvent?.Invoke(this, new ScreenChangeEventArgs(new CustomizationScreen((this.item as ComboItem).Side, this.item as ComboItem)));
        }

        /// <summary>
        /// Button that handles when a user decides to customize a drink in a combo.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The routed event args from the event.</param>
        private void CustomizeDrinkButtonClick(object sender, RoutedEventArgs e) {
            ScreenChangeEvent?.Invoke(this, new ScreenChangeEventArgs(new CustomizationScreen((this.item as ComboItem).Drink, this.item as ComboItem)));
        }

        /// <summary>
        /// Gets all of the items that would be used in a combo box for combo items.
        /// </summary>
        /// <param name="items">A list of all items that would be contained in the combo box</param>
        /// <param name="obj">An instance of an item that was already created to add to the combo box instead of the default value of that object.</param>
        /// <returns></returns>
        private IEnumerable<IOrderItem> GetItemsForComboBox(IEnumerable<IOrderItem> items, IOrderItem obj) {
            List<IOrderItem> _list = new List<IOrderItem>();
            List<Type> _usedTypes = new List<Type>();
            _list.Add(obj);
            _usedTypes.Add(obj.GetType());
            if (obj is Drink) {
                foreach (Drink e in items) {
                    if (!e.GetType().Equals(obj.GetType()) && !_usedTypes.Contains(e.GetType()) && e.Size == (obj as Drink).Size) {
                        _list.Add(e);
                        _usedTypes.Add(e.GetType());
                    }
                }
            } else if (obj is Side) {
                foreach (Side e in items) {
                    if (!e.GetType().Equals(obj.GetType()) && !_usedTypes.Contains(e.GetType()) && e.Size == (obj as Side).Size) {
                        _list.Add(e);
                        _usedTypes.Add(e.GetType());
                    }
                }
            } else if (obj is Entree) {
                foreach (Entree e in items) {
                    if (!e.GetType().Equals(obj.GetType()) && !_usedTypes.Contains(e.GetType())) {
                        _list.Add(e);
                        _usedTypes.Add(e.GetType());
                    }
                }
            }
            return _list;
        }
    }
}