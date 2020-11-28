/*
 * Author: Zachery Brunner
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests {
    public class DragonbornWaffleFriesTests {
        [Fact]
        public void ShouldBeASide() {
            DragonbornWaffleFries item = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(item);
        }

        [Fact]
        public void ShouldBeAnOrderItem() {
            DragonbornWaffleFries item = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<IOrderItem>(item);
        }

        [Fact]
        public void ShouldBeSmallByDefault() {
            DragonbornWaffleFries wf = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, wf.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize() {
            DragonbornWaffleFries wf = new DragonbornWaffleFries();
            wf.Size = Size.Medium;
            Assert.Equal(Size.Medium, wf.Size);
            wf.Size = Size.Large;
            Assert.Equal(Size.Large, wf.Size);
            wf.Size = Size.Small;
            Assert.Equal(Size.Small, wf.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions() {
            DragonbornWaffleFries wf = new DragonbornWaffleFries();
            Assert.Empty(wf.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price) {
            DragonbornWaffleFries wf = new DragonbornWaffleFries();
            wf.Size = size;
            Assert.Equal(price, wf.Price);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories) {
            DragonbornWaffleFries wf = new DragonbornWaffleFries();
            wf.Size = size;
            Assert.Equal(calories, wf.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name) {
            DragonbornWaffleFries wf = new DragonbornWaffleFries();
            wf.Size = size;
            Assert.Equal(name, wf.ToString());
        }

        [Fact]
        public void SizeChangeShouldTriggerPropertyChanged() {
            DragonbornWaffleFries wf = new DragonbornWaffleFries();
            Assert.PropertyChanged(wf, "Size", () => {
                wf.Size = Size.Medium;
            });
            Assert.PropertyChanged(wf, "Calories", () => {
                wf.Size = Size.Medium;
            });
            Assert.PropertyChanged(wf, "Price", () => {
                wf.Size = Size.Medium;
            });
        }
        [Fact]
        public void TestDescription() {
            Assert.Equal("Crispy fried potato waffle fries.", new DragonbornWaffleFries().Description);
        }
    }
}