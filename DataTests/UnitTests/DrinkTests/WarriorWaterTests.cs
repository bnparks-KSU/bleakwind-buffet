/*
 * Author: BrianParks
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests {
    public class WarriorWaterTests {
        [Fact]
        public void ShouldBeADrink() {
            WarriorWater item = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(item);
        }

        [Fact]
        public void ShouldBeAnOrderItem() {
            WarriorWater item = new WarriorWater();
            Assert.IsAssignableFrom<IOrderItem>(item);
        }

        [Fact]
        public void ShouldContainIceByDefault() {
            WarriorWater ww = new WarriorWater();
            Assert.True(ww.Ice);
        }

        [Fact]
        public void ShouldntContainLemonByDefault() {
            WarriorWater ww = new WarriorWater();
            Assert.False(ww.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToSetIce() {
            WarriorWater ww = new WarriorWater();
            ww.Ice = false;
            Assert.False(ww.Ice);
            ww.Ice = true;
            Assert.True(ww.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetLemon() {
            WarriorWater ww = new WarriorWater();
            ww.Lemon = true;
            Assert.True(ww.Lemon);
            ww.Lemon = false;
            Assert.False(ww.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToSetSize() {
            SailorSoda ss = new SailorSoda();
            ss.Size = Size.Large;
            Assert.Equal(Size.Large, ss.Size);
            ss.Size = Size.Medium;
            Assert.Equal(Size.Medium, ss.Size);
            ss.Size = Size.Small;
            Assert.Equal(Size.Small, ss.Size);
        }

        //As there is no code to change the price or calories, there is no need to test it for differing size values like I did on other drinks.

        [Fact]
        public void ShouldHaveCorrectCalories() {
            WarriorWater ww = new WarriorWater();
            Assert.Equal((uint)0, ww.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPrice() {
            WarriorWater ww = new WarriorWater();
            Assert.Equal(0, ww.Price);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon) {
            WarriorWater ww = new WarriorWater();
            ww.Ice = includeIce;
            ww.Lemon = includeLemon;

            if (includeIce) {
                Assert.DoesNotContain("Hold ice", ww.SpecialInstructions);
            } else {
                Assert.Contains("Hold ice", ww.SpecialInstructions);
            }
            if (includeLemon) {
                Assert.Contains("Add lemon", ww.SpecialInstructions);
            } else {
                Assert.DoesNotContain("Add lemon", ww.SpecialInstructions);
            }
            if (includeIce && !includeLemon) {
                Assert.Empty(ww.SpecialInstructions);
            }
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name) {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(name, ww.ToString());
        }

        [Fact]
        public void SizeChangeShouldTriggerPropertyChanged() {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Size", () => {
                ww.Size = Size.Large;
            });
        }

        [Fact]
        public void IceChangeShouldTriggerPropertyChanged() {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Ice", () => {
                ww.Ice = true;
            });
            Assert.PropertyChanged(ww, "SpecialInstructions", () => {
                ww.Ice = true;
            });
        }

        [Fact]
        public void LemonChangeShouldTriggerPropertyChanged() {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Ice", () => {
                ww.Ice = true;
            });
            Assert.PropertyChanged(ww, "SpecialInstructions", () => {
                ww.Lemon = true;
            });
        }
        [Fact]
        public void TestDescription() {
            Assert.Equal("It’s water. Just water.", new WarriorWater().Description);
        }
    }
}
