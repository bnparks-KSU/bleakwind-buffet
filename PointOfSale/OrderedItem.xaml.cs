using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for OrderedItem.xaml
    /// </summary>
    public partial class OrderedItem : Button {
        private IOrderItem item;
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
            this.item = orderItem;
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
            ((Grid)var).Children.Insert(0, new CustomizationScreen(item, iss));
            ((StackPanel)this.Parent).Children.Remove(this);
        }
    }
}
