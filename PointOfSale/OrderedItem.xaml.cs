/*
 * Author: Brian Parks
 * Class name: OrderedItem.xaml.cs
 * Purpose: Class used to handle the implementation of an ordered item button side control.
 */
using BleakwindBuffet.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace PointOfSale {
    /// <summary>
    /// Interaction logic for OrderedItem.xaml
    /// </summary>
    public partial class OrderedItem : Button {
        private ItemSelectionScreen iss;

        /// <summary>
        /// DO NOT USE THIS CONSTRUCTOR.
        /// </summary>
        public OrderedItem() {
            InitializeComponent();
        }
        /// <summary>
        /// Creates a new OrderedItem button and stores the orderItem to it.
        /// </summary>
        /// <param name="orderItem"></param>
        public OrderedItem(IOrderItem orderItem, ItemSelectionScreen iss) {
            InitializeComponent();
            this.DataContext = orderItem;
            this.iss = iss;
            this.Content = orderItem.GetType().Name;
        }

        /// <summary>
        /// Handles when you click on the ordered item in the sidebar.
        /// </summary>
        /// <param name="sender">The object that send the event, in this case a button.</param>
        /// <param name="e">The arguments of the event.</param>
        private void OrderedItem_Click(object sender, RoutedEventArgs e) {
            //TODO: Find a better way to do this.
            
            DependencyObject var = LogicalTreeHelper.GetParent(this);
            do {
                var = LogicalTreeHelper.GetParent(var);
            } while (!(var is MainWindow));
            var = LogicalTreeHelper.GetChildren(var).OfType<Grid>().ToArray()[0];//Get down 1 more level

            //((Grid)var).Children.RemoveAt(0);
            iss.Visibility = Visibility.Hidden;
            ((Grid)var).Children.Insert(0, new CustomizationScreen(this.DataContext as IOrderItem, iss));
            ((StackPanel)this.Parent).Children.Remove(this);
        }
    }
}
