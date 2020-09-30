using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale {
    /// <summary>
    /// Interaction logic for CustomizationScreen.xaml
    /// </summary>
    public partial class CustomizationScreen : UserControl {
        private IOrderItem orderItem;
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
            this.orderItem = orderItem;
            this.iss = iss;
            setControls = new List<Control>();
            List<CheckBox> addLast = new List<CheckBox>(); //Just to put the drop downs above them.

            MenuItemLabel.Text = orderItem.GetType().Name;
            foreach (PropertyInfo p in orderItem.GetType().GetProperties()) {
                if(p.CanWrite) {
                    if (p.PropertyType.Name == "Boolean") {
                        Console.WriteLine(p.Name);
                        CheckBox cb = new CheckBox();
                        cb.FontSize = 16;
                        cb.Content = p.Name;
                        cb.IsChecked = (bool) p.GetValue(orderItem);
                        cb.HorizontalAlignment = HorizontalAlignment.Left;
                        cb.Margin = new Thickness(5, 0, 5, 0);
                        addLast.Add(cb);
                    } else if(p.PropertyType.IsEnum) {
                        //Handle what to do for enums somehow
                        Console.WriteLine("Enum: " + p.PropertyType.Name);
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
        private void ConfirmOrder_Click(object sender, RoutedEventArgs e) {
            //TODO: Find a better way to do this.
            iss.Visibility = Visibility.Visible;
            ((MainWindow)((Grid)this.Parent).Parent).OrderPanel.Children.Add(new OrderedItem(orderItem, iss));
            ((Grid)this.Parent).Children.Remove(this);
        }
    }
}
