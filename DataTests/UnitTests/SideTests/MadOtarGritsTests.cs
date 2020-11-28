/*
 * Author: Zachery Brunner
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests {
    public class MadOtarGritsTests {
        [Fact]
        public void ShouldBeASide() {
            MadOtarGrits item = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(item);
        }

        [Fact]
        public void ShouldBeAnOrderItem() {
            MadOtarGrits item = new MadOtarGrits();
            Assert.IsAssignableFrom<IOrderItem>(item);
        }

        [Fact]
        public void ShouldBeSmallByDefault() {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.Equal(Size.Small, mog.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize() {
            MadOtarGrits mog = new MadOtarGrits();
            mog.Size = Size.Medium;
            Assert.Equal(Size.Medium, mog.Size);
            mog.Size = Size.Large;
            Assert.Equal(Size.Large, mog.Size);
            mog.Size = Size.Small;
            Assert.Equal(Size.Small, mog.Size);
        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions() {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.Empty(mog.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price) {
            MadOtarGrits mog = new MadOtarGrits();
            mog.Size = size;
            Assert.Equal(price, mog.Price);
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories) {
            MadOtarGrits mog = new MadOtarGrits();
            mog.Size = size;
            Assert.Equal(calories, mog.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name) {
            MadOtarGrits mog = new MadOtarGrits();
            mog.Size = size;
            Assert.Equal(name, mog.ToString());
        }

        [Fact]
        public void SizeChangeShouldTriggerPropertyChanged() {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.PropertyChanged(mog, "Size", () => {
                mog.Size = Size.Medium;
            });
            Assert.PropertyChanged(mog, "Calories", () => {
                mog.Size = Size.Medium;
            });
            Assert.PropertyChanged(mog, "Price", () => {
                mog.Size = Size.Medium;
            });
        }
        [Fact]
        public void TestDescription() {
            Assert.Equal("Cheesey Grits.", new MadOtarGrits().Description);
        }
    }
}