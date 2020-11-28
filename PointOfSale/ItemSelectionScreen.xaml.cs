/*
 * Author: Brian Parks
 * Class name: ItemSelectionScreen.xaml.cs
 * Purpose: Class used to handle the implementation of the ItemSelectionScreen control.
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Windows;
using System.Windows.Controls;

namespace PointOfSale {

    /// <summary>
    /// Interaction logic for ItemSelectionScreen.xaml
    /// </summary>
    public partial class ItemSelectionScreen : UserControl {

        /// <summary>
        /// The ScreenChangeEvent handler.
        /// </summary>
        public event EventHandler<ScreenChangeEventArgs> ScreenChangeEvent;

        /// <summary>
        /// Creates a new ItemSelectionScreen.
        /// </summary>
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
            //this.Visibility = Visibility.Hidden;
            switch ((sender as Button).Name) {
                case "AddBriarheartBurgerButton":
                    ScreenChangeEvent?.Invoke(this, new ScreenChangeEventArgs(new CustomizationScreen(new BriarheartBurger(), null)));
                    break;

                case "AddDoubleDraugrButton":
                    ScreenChangeEvent?.Invoke(this, new ScreenChangeEventArgs(new CustomizationScreen(new DoubleDraugr(), null)));
                    break;

                case "AddThalmorTripleButton":
                    ScreenChangeEvent?.Invoke(this, new ScreenChangeEventArgs(new CustomizationScreen(new ThalmorTriple(), null)));
                    break;

                case "AddGardenOrcOmeletteButton":
                    ScreenChangeEvent?.Invoke(this, new ScreenChangeEventArgs(new CustomizationScreen(new GardenOrcOmelette(), null)));
                    break;

                case "AddPhillyPoacherButton":
                    ScreenChangeEvent?.Invoke(this, new ScreenChangeEventArgs(new CustomizationScreen(new PhillyPoacher(), null)));
                    break;

                case "AddSmokehouseSkeletonButton":
                    ScreenChangeEvent?.Invoke(this, new ScreenChangeEventArgs(new CustomizationScreen(new SmokehouseSkeleton(), null)));
                    break;

                case "AddThugsTBoneButton":
                    ScreenChangeEvent?.Invoke(this, new ScreenChangeEventArgs(new CustomizationScreen(new ThugsTBone(), null)));
                    break;

                case "AddAretinoAppleJuiceButton":
                    ScreenChangeEvent?.Invoke(this, new ScreenChangeEventArgs(new CustomizationScreen(new AretinoAppleJuice(), null)));
                    break;

                case "AddCandlehearthCoffeeButton":
                    ScreenChangeEvent?.Invoke(this, new ScreenChangeEventArgs(new CustomizationScreen(new CandlehearthCoffee(), null)));
                    break;

                case "AddMarkathMilkButton":
                    ScreenChangeEvent?.Invoke(this, new ScreenChangeEventArgs(new CustomizationScreen(new MarkarthMilk(), null)));
                    break;

                case "AddSailorSodaButton":
                    ScreenChangeEvent?.Invoke(this, new ScreenChangeEventArgs(new CustomizationScreen(new SailorSoda(), null)));
                    break;

                case "AddWarriorWaterButton":
                    ScreenChangeEvent?.Invoke(this, new ScreenChangeEventArgs(new CustomizationScreen(new WarriorWater(), null)));
                    break;

                case "AddDragonbornWaffleFriesButton":
                    ScreenChangeEvent?.Invoke(this, new ScreenChangeEventArgs(new CustomizationScreen(new DragonbornWaffleFries(), null)));
                    break;

                case "AddFriedMiraakButton":
                    ScreenChangeEvent?.Invoke(this, new ScreenChangeEventArgs(new CustomizationScreen(new FriedMiraak(), null)));
                    break;

                case "AddMadOtarGritsButton":
                    ScreenChangeEvent?.Invoke(this, new ScreenChangeEventArgs(new CustomizationScreen(new MadOtarGrits(), null)));
                    break;

                case "AddVokunSaladButton":
                    ScreenChangeEvent?.Invoke(this, new ScreenChangeEventArgs(new CustomizationScreen(new VokunSalad(), null)));
                    break;

                case "AddComboButton":
                    ScreenChangeEvent?.Invoke(this, new ScreenChangeEventArgs(new CustomizationScreen(new ComboItem(), null)));
                    break;

                default:
                    throw new InvalidOperationException("Some item does not exist!");
            }
        }
    }
}