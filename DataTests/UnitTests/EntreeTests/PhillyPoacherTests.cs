/*
 * Author: Zachery Brunner
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests {

    public class PhillyPoacherTests {

        [Fact]
        public void ShouldBeAnEntree() {
            PhillyPoacher item = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(item);
        }

        [Fact]
        public void ShouldBeAnOrderItem() {
            PhillyPoacher item = new PhillyPoacher();
            Assert.IsAssignableFrom<IOrderItem>(item);
        }

        [Fact]
        public void ShouldInlcudeSirloinByDefault() {
            PhillyPoacher p = new PhillyPoacher();
            Assert.True(p.Sirloin);
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault() {
            PhillyPoacher p = new PhillyPoacher();
            Assert.True(p.Onion);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault() {
            PhillyPoacher p = new PhillyPoacher();
            Assert.True(p.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin() {
            PhillyPoacher p = new PhillyPoacher();
            p.Sirloin = false;
            Assert.False(p.Sirloin);
            p.Sirloin = true;
            Assert.True(p.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions() {
            PhillyPoacher p = new PhillyPoacher();
            p.Onion = false;
            Assert.False(p.Onion);
            p.Onion = true;
            Assert.True(p.Onion);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll() {
            PhillyPoacher p = new PhillyPoacher();
            p.Roll = false;
            Assert.False(p.Roll);
            p.Roll = true;
            Assert.True(p.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice() {
            PhillyPoacher p = new PhillyPoacher();
            Assert.Equal(7.23, p.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories() {
            PhillyPoacher p = new PhillyPoacher();
            Assert.Equal((uint)784, p.Calories);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll) {
            PhillyPoacher p = new PhillyPoacher();
            p.Sirloin = includeSirloin;
            p.Onion = includeOnion;
            p.Roll = includeRoll;

            if (includeSirloin) {
                Assert.DoesNotContain("Hold sirloin", p.SpecialInstructions);
            } else {
                Assert.Contains("Hold sirloin", p.SpecialInstructions);
            }
            if (includeOnion) {
                Assert.DoesNotContain("Hold onions", p.SpecialInstructions);
            } else {
                Assert.Contains("Hold onions", p.SpecialInstructions);
            }
            if (includeRoll) {
                Assert.DoesNotContain("Hold roll", p.SpecialInstructions);
            } else {
                Assert.Contains("Hold roll", p.SpecialInstructions);
            }
            if (includeSirloin && includeRoll && includeOnion) {
                Assert.Empty(p.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString() {
            PhillyPoacher p = new PhillyPoacher();
            Assert.Equal("Philly Poacher", p.ToString());
        }

        [Fact]
        public void SirloinChangeShouldTriggerPropertyChanged() {
            PhillyPoacher p = new PhillyPoacher();
            Assert.PropertyChanged(p, "Sirloin", () => {
                p.Sirloin = false;
            });
            Assert.PropertyChanged(p, "SpecialInstructions", () => {
                p.Sirloin = false;
            });
        }

        [Fact]
        public void OnionChangeShouldTriggerPropertyChanged() {
            PhillyPoacher p = new PhillyPoacher();
            Assert.PropertyChanged(p, "Onion", () => {
                p.Onion = false;
            });
            Assert.PropertyChanged(p, "SpecialInstructions", () => {
                p.Onion = false;
            });
        }

        [Fact]
        public void RollChangeShouldTriggerPropertyChanged() {
            PhillyPoacher p = new PhillyPoacher();
            Assert.PropertyChanged(p, "Roll", () => {
                p.Roll = false;
            });
            Assert.PropertyChanged(p, "SpecialInstructions", () => {
                p.Roll = false;
            });
        }
        [Fact]
        public void TestDescription() {
            Assert.Equal("Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.", new PhillyPoacher().Description);
        }
    }
}