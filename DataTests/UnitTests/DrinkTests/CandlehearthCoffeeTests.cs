/*
 * Author: Zachery Brunner
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests {
    public class CandlehearthCoffeeTests {
        [Fact]
        public void ShouldNotIncludeIceByDefault() {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            Assert.False(cof.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault() {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            Assert.False(cof.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault() {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            Assert.False(cof.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault() {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            Assert.Equal(Size.Small, cof.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce() {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            cof.Ice = true;
            Assert.True(cof.Ice);
            cof.Ice = false;
            Assert.False(cof.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf() {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            cof.Decaf = true;
            Assert.True(cof.Decaf);
            cof.Decaf = false;
            Assert.False(cof.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream() {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            cof.RoomForCream = true;
            Assert.True(cof.RoomForCream);
            cof.RoomForCream = false;
            Assert.False(cof.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetSize() {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            cof.Size = Size.Medium;
            Assert.Equal(Size.Medium, cof.Size);
            cof.Size = Size.Large;
            Assert.Equal(Size.Large, cof.Size);
            cof.Size = Size.Small;
            Assert.Equal(Size.Small, cof.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price) {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            cof.Size = size;
            Assert.Equal(price, cof.Price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal) {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            cof.Size = size;
            Assert.Equal(cal, cof.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream) {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            cof.Ice = includeIce;
            cof.RoomForCream = includeCream;
            if (includeIce) {
                Assert.Contains("Add ice", cof.SpecialInstructions);
            } else {
                Assert.DoesNotContain("Add ice", cof.SpecialInstructions);
            }
            if (includeCream) {
                Assert.Contains("Add cream", cof.SpecialInstructions);
            } else {
                Assert.DoesNotContain("Add cream", cof.SpecialInstructions);
            }
            if (!includeIce && !includeCream) {
                Assert.Empty(cof.SpecialInstructions);
            }
        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name) {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            cof.Decaf = decaf;
            cof.Size = size;

            Assert.Equal(cof.ToString(), name);
        }
    }
}
