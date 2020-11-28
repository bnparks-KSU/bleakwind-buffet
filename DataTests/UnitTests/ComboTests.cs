/*
 * Author: Brian Parks
 * Class: ComboTests.cs
 * Purpose: Test the Combo.cs class.
 */
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;
using Xunit;
using BleakwindBuffet.DataTests.UnitTests.MockImplementation;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests {
    public class ComboTests {
        [Fact]
        public void ShouldImplementINotifyPropertyChanged() {
            ComboItem combo = new ComboItem();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(combo);
        }
        [Fact]
        public void DefaultBriarheartBurger() {
            ComboItem combo = new ComboItem();
            Assert.IsType<BriarheartBurger>(combo.Entree);
        }
        [Fact]
        public void ShouldSetEntree() {
            ComboItem combo = new ComboItem();
            MockEntreeImplementation mock = new MockEntreeImplementation(0, 0);
            combo.Entree = mock;
            Assert.Equal(mock, combo.Entree);
        }
        [Fact]
        public void ShouldFireEntreePropChangedOnEntreeChange() {
            ComboItem combo = new ComboItem();
            MockEntreeImplementation mock = new MockEntreeImplementation(0, 0);
            Assert.PropertyChanged(combo, "Entree", () => {
                combo.Entree = mock;
            });
        }
        [Fact]
        public void ShouldFirePricePropChangedOnEntreeChange() {
            ComboItem combo = new ComboItem();
            MockEntreeImplementation mock = new MockEntreeImplementation(0, 0);
            Assert.PropertyChanged(combo, "Price", () => {
                combo.Entree = mock;
            });
        }
        [Fact]
        public void ShouldFireCaloriesPropChangedOnEntreeChange() {
            ComboItem combo = new ComboItem();
            MockEntreeImplementation mock = new MockEntreeImplementation(0, 0);
            Assert.PropertyChanged(combo, "Calories", () => {
                combo.Entree = mock;
            });
        }
        [Fact]
        public void ShouldFireSpecialInstructionsPropChangedOnEntreeChange() {
            ComboItem combo = new ComboItem();
            MockEntreeImplementation mock = new MockEntreeImplementation(0, 0);
            Assert.PropertyChanged(combo, "SpecialInstructions", () => {
                combo.Entree = mock;
            });
        }
        [Fact]
        public void ShouldFireItemNamePropChangedOnEntreeChange() {
            ComboItem combo = new ComboItem();
            MockEntreeImplementation mock = new MockEntreeImplementation(0, 0);
            Assert.PropertyChanged(combo, "ItemName", () => {
                combo.Entree = mock;
            });
        }
        [Fact]
        public void EntreeForwardsPriceChange() {
            ComboItem combo = new ComboItem();
            MockEntreeImplementation mock = new MockEntreeImplementation(0, 0);
            combo.Entree = mock;
            Assert.PropertyChanged(combo, "Price", () => {
                mock.ChangePrice(10);
            });
        }
        [Fact]
        public void EntreeForwardsCaloriesChange() {
            ComboItem combo = new ComboItem();
            MockEntreeImplementation mock = new MockEntreeImplementation(0, 0);
            combo.Entree = mock;
            Assert.PropertyChanged(combo, "Calories", () => {
                mock.ChangeCalories(10);
            });
        }
        [Fact]
        public void EntreeForwardsSpecialInstructionsChange() {
            ComboItem combo = new ComboItem();
            MockEntreeImplementation mock = new MockEntreeImplementation(0, 0);
            combo.Entree = mock;
            Assert.PropertyChanged(combo, "SpecialInstructions", () => {
                mock.AddInstruction("Instruction");
            });
        }
        [Fact]
        public void DefaultDragonBornWaffleFries() {
            ComboItem combo = new ComboItem();
            Assert.IsType<DragonbornWaffleFries>(combo.Side);
        }
        [Fact]
        public void ShouldSetSide() {
            ComboItem combo = new ComboItem();
            MockSideImplementation mock = new MockSideImplementation(0, 0);
            combo.Side = mock;
            Assert.Equal(mock, combo.Side);
        }
        [Fact]
        public void ShouldFireSidePropChangedOnSideChange() {
            ComboItem combo = new ComboItem();
            MockSideImplementation mock = new MockSideImplementation(0, 0);
            Assert.PropertyChanged(combo, "Side", () => {
                combo.Side = mock;
            });
        }
        [Fact]
        public void ShouldFirePricePropChangedOnSideChange() {
            ComboItem combo = new ComboItem();
            MockSideImplementation mock = new MockSideImplementation(0, 0);
            Assert.PropertyChanged(combo, "Price", () => {
                combo.Side = mock;
            });
        }
        [Fact]
        public void ShouldFireCaloriesPropChangedOnSideChange() {
            ComboItem combo = new ComboItem();
            MockSideImplementation mock = new MockSideImplementation(0, 0);
            Assert.PropertyChanged(combo, "Calories", () => {
                combo.Side = mock;
            });
        }
        [Fact]
        public void ShouldFireSpecialInstructionsPropChangedOnSideChange() {
            ComboItem combo = new ComboItem();
            MockSideImplementation mock = new MockSideImplementation(0, 0);
            Assert.PropertyChanged(combo, "SpecialInstructions", () => {
                combo.Side = mock;
            });
        }
        [Fact]
        public void SideForwardsPriceChange() {
            ComboItem combo = new ComboItem();
            MockSideImplementation mock = new MockSideImplementation(0, 0);
            combo.Side = mock;
            Assert.PropertyChanged(combo, "Price", () => {
                mock.ChangePrice(10);
            });
        }
        [Fact]
        public void SideForwardsCaloriesChange() {
            ComboItem combo = new ComboItem();
            MockSideImplementation mock = new MockSideImplementation(0, 0);
            combo.Side = mock;
            Assert.PropertyChanged(combo, "Calories", () => {
                mock.ChangeCalories(10);
            });
        }
        [Fact]
        public void SideForwardsSpecialInstructionsChange() {
            ComboItem combo = new ComboItem();
            MockSideImplementation mock = new MockSideImplementation(0, 0);
            combo.Side = mock;
            Assert.PropertyChanged(combo, "SpecialInstructions", () => {
                mock.AddInstruction("An Instruction");
            });
        }
        [Fact]
        public void SideForwardsItemNameChange() {
            ComboItem combo = new ComboItem();
            MockSideImplementation mock = new MockSideImplementation(0, 0);
            combo.Side = mock;
            Assert.PropertyChanged(combo, "SpecialInstructions", () => {
                mock.Size = Size.Large;
            });
        }
        [Fact]
        public void DefaultWarriorWater() {
            ComboItem combo = new ComboItem();
            Assert.IsType<WarriorWater>(combo.Drink);
        }
        [Fact]
        public void ShouldSetDrink() {
            ComboItem combo = new ComboItem();
            MockDrinkImplementation mock = new MockDrinkImplementation(0, 0);
            combo.Drink = mock;
            Assert.Equal(mock, combo.Drink);
        }
        [Fact]
        public void ShouldFireDrinkPropChangedOnDrinkChange() {
            ComboItem combo = new ComboItem();
            MockDrinkImplementation mock = new MockDrinkImplementation(0, 0);
            Assert.PropertyChanged(combo, "Drink", () => {
                combo.Drink = mock;
            });
        }
        [Fact]
        public void ShouldFirePricePropChangedOnDrinkChange() {
            ComboItem combo = new ComboItem();
            MockDrinkImplementation mock = new MockDrinkImplementation(0, 0);
            Assert.PropertyChanged(combo, "Price", () => {
                combo.Drink = mock;
            });
        }
        [Fact]
        public void ShouldFireCaloriesPropChangedOnDrinkChange() {
            ComboItem combo = new ComboItem();
            MockDrinkImplementation mock = new MockDrinkImplementation(0, 0);
            Assert.PropertyChanged(combo, "Calories", () => {
                combo.Drink = mock;
            });
        }
        [Fact]
        public void ShouldFireSpecialInstructionsPropChangedOnDrinkChange() {
            ComboItem combo = new ComboItem();
            MockDrinkImplementation mock = new MockDrinkImplementation(0, 0);
            Assert.PropertyChanged(combo, "SpecialInstructions", () => {
                combo.Drink = mock;
            });
        }
        [Fact]
        public void DrinkForwardsPriceChange() {
            ComboItem combo = new ComboItem();
            MockDrinkImplementation mock = new MockDrinkImplementation(0, 0);
            combo.Drink = mock;
            Assert.PropertyChanged(combo, "Price", () => {
                mock.ChangePrice(10);
            });
        }
        [Fact]
        public void DrinkForwardsCaloriesChange() {
            ComboItem combo = new ComboItem();
            MockDrinkImplementation mock = new MockDrinkImplementation(0, 0);
            combo.Drink = mock;
            Assert.PropertyChanged(combo, "Calories", () => {
                mock.ChangeCalories(10);
            });
        }
        [Fact]
        public void DrinkForwardsSpecialInstructionsChange() {
            ComboItem combo = new ComboItem();
            MockDrinkImplementation mock = new MockDrinkImplementation(0, 0);
            combo.Drink = mock;
            Assert.PropertyChanged(combo, "SpecialInstructions", () => {
                mock.AddInstruction("An Instruction");
            });
        }
        [Fact]
        public void DrinkForwardsItemNameChange() {
            ComboItem combo = new ComboItem();
            MockDrinkImplementation mock = new MockDrinkImplementation(0, 0);
            combo.Drink = mock;
            Assert.PropertyChanged(combo, "SpecialInstructions", () => {
                mock.Size = Size.Large;
            });
        }
        [Theory]
        [InlineData(416, 712, 152, 1280)]
        [InlineData(127, 261, 612, 1000)]
        [InlineData(67, 12, 1, 80)]
        public void ShouldGetProperCalories(uint cal1, uint cal2, uint cal3, uint totalCal) {
            ComboItem combo = new ComboItem();
            combo.Entree = new MockEntreeImplementation(0, cal1);
            combo.Drink = new MockDrinkImplementation(0, cal2);
            combo.Side = new MockSideImplementation(0, cal3);
            Assert.Equal(totalCal, combo.Calories);
        }
        [Theory]
        [InlineData(4.16, 7.12, 1.52, 11.80)]
        [InlineData(1.27, 2.61, 6.12, 9.00)]
        [InlineData(.67, .12, 1.01, 0.80)]
        public void ShouldGetProperPrices(double p1, double p2, double p3, double totalPrice) {
            ComboItem combo = new ComboItem();
            combo.Entree = new MockEntreeImplementation(p1, 0);
            combo.Drink = new MockDrinkImplementation(p2, 0);
            combo.Side = new MockSideImplementation(p3, 0);
            Assert.Equal(totalPrice, combo.Price);
        }
        [Fact]
        public void ShouldGetSpecialInstructions() {
            ComboItem combo = new ComboItem();
            MockEntreeImplementation entree = new MockEntreeImplementation(0,0);
            combo.Entree = entree;
            entree.AddInstruction("Entree Instructions");
            MockDrinkImplementation drink = new MockDrinkImplementation(0, 0);
            combo.Drink = drink;
            drink.AddInstruction("Drink Instructions");
            MockSideImplementation side = new MockSideImplementation(0, 0);
            combo.Side = side;
            side.AddInstruction("Side Instructions");
            Assert.Collection(combo.SpecialInstructions,
                item => Assert.Equal(entree.ToString(), item),
                item => Assert.Equal(" - Entree Instructions", item),
                item => Assert.Equal(side.ToString(), item),
                item => Assert.Equal(" - Side Instructions", item),
                item => Assert.Equal(drink.ToString(), item),
                item => Assert.Equal(" - Drink Instructions", item)
                );
        }
        [Fact]
        public void ShouldGetProperName() {
            ComboItem combo = new ComboItem();
            Assert.Equal("Briarheart Burger Combo", combo.ToString());
        }
        [Fact]
        public void ShouldGetProperNameAfterChange() {
            ComboItem combo = new ComboItem();
            combo.Entree = new PhillyPoacher();
            Assert.Equal("Philly Poacher Combo", combo.ToString());
        }
    }
}
