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
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace PointOfSale {
    /// <summary>
    /// Interaction logic for ItemSelectionScreen.xaml
    /// </summary>
    public partial class ItemSelectionScreen : UserControl {
        public ItemSelectionScreen() {
            InitializeComponent();
        }

        /// <summary>
        /// Handle adding an item into the POS.
        /// </summary>
        /// <param name="sender">The object that send the event, in this case a button.</param>
        /// <param name="e">The arguments of the event.</param>
        private void AddItem(object sender, RoutedEventArgs e) {
            //TODO: Find more elegant solution to this.
            this.Visibility = Visibility.Hidden;
            Console.WriteLine((sender as Button).Name);
            switch((sender as Button).Name) {
                case "AddBriarheartBurgerButton":
                    ((Grid)this.Parent).Children.Insert(0, new CustomizationScreen(new BriarheartBurger(), this));
                    break;
                case "AddDoubleDraugrButton":
                    ((Grid)this.Parent).Children.Insert(0, new CustomizationScreen(new DoubleDraugr(), this));
                    break;
                case "AddThalmorTripleButton":
                    ((Grid)this.Parent).Children.Insert(0, new CustomizationScreen(new ThalmorTriple(), this));
                    break;
                case "AddGardenOrcOmeletteButton":
                    ((Grid)this.Parent).Children.Insert(0, new CustomizationScreen(new GardenOrcOmelette(), this));
                    break;
                case "AddPhillyPoacherButton":
                    ((Grid)this.Parent).Children.Insert(0, new CustomizationScreen(new PhillyPoacher(), this));
                    break;
                case "AddSmokehouseSkeletonButton":
                    ((Grid)this.Parent).Children.Insert(0, new CustomizationScreen(new SmokehouseSkeleton(), this));
                    break;
                case "AddThugsTBoneButton":
                    ((Grid)this.Parent).Children.Insert(0, new CustomizationScreen(new ThugsTBone(), this));
                    break;
                case "AddAretinoAppleJuiceButton":
                    ((Grid)this.Parent).Children.Insert(0, new CustomizationScreen(new AretinoAppleJuice(), this));
                    break;
                case "AddCandlehearthCoffeeButton":
                    ((Grid)this.Parent).Children.Insert(0, new CustomizationScreen(new CandlehearthCoffee(), this));
                    break;
                case "AddMarkathMilkButton":
                    ((Grid)this.Parent).Children.Insert(0, new CustomizationScreen(new MarkarthMilk(), this));
                    break;
                case "AddSailorSodaButton":
                    ((Grid)this.Parent).Children.Insert(0, new CustomizationScreen(new SailorSoda(), this));
                    break;
                case "AddWarriorWaterButton":
                    ((Grid)this.Parent).Children.Insert(0, new CustomizationScreen(new WarriorWater(), this));
                    break;
                case "AddDragonbornWaffleFriesButton":
                    ((Grid)this.Parent).Children.Insert(0, new CustomizationScreen(new DragonbornWaffleFries(), this));
                    break;
                case "AddFriedMiraakButton":
                    ((Grid)this.Parent).Children.Insert(0, new CustomizationScreen(new FriedMiraak(), this));
                    break;
                case "AddMadOtarGritsButton":
                    ((Grid)this.Parent).Children.Insert(0, new CustomizationScreen(new MadOtarGrits(), this));
                    break;
                case "AddVokunSaladButton":
                    ((Grid)this.Parent).Children.Insert(0, new CustomizationScreen(new VokunSalad(), this));
                    break;
                default:
                    throw new InvalidOperationException("Some item does not exist!");
            }
        }
    }
}
