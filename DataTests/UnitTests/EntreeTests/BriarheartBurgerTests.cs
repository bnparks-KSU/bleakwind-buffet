﻿/*
 * Author: Zachery Brunner
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests {

    public class BriarheartBurgerTests {

        [Fact]
        public void ShouldBeAnEntree() {
            BriarheartBurger item = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(item);
        }

        [Fact]
        public void ShouldBeAnOrderItem() {
            BriarheartBurger item = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(item);
        }

        [Fact]
        public void ShouldIncludeBunByDefault() {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault() {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault() {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault() {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault() {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun() {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Bun = false;
            Assert.False(bb.Bun);
            bb.Bun = true;
            Assert.True(bb.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup() {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Ketchup = false;
            Assert.False(bb.Ketchup);
            bb.Ketchup = true;
            Assert.True(bb.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard() {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Mustard = false;
            Assert.False(bb.Mustard);
            bb.Mustard = true;
            Assert.True(bb.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle() {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Pickle = false;
            Assert.False(bb.Pickle);
            bb.Pickle = true;
            Assert.True(bb.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese() {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Cheese = false;
            Assert.False(bb.Cheese);
            bb.Cheese = true;
            Assert.True(bb.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice() {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Equal(6.32, bb.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories() {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Equal((uint)743, bb.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese) {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Bun = includeBun;
            bb.Ketchup = includeKetchup;
            bb.Mustard = includeMustard;
            bb.Pickle = includePickle;
            bb.Cheese = includeCheese;

            if (includeBun) {
                Assert.DoesNotContain("Hold bun", bb.SpecialInstructions);
            } else {
                Assert.Contains("Hold bun", bb.SpecialInstructions);
            }
            if (includeKetchup) {
                Assert.DoesNotContain("Hold ketchup", bb.SpecialInstructions);
            } else {
                Assert.Contains("Hold ketchup", bb.SpecialInstructions);
            }
            if (includeMustard) {
                Assert.DoesNotContain("Hold mustard", bb.SpecialInstructions);
            } else {
                Assert.Contains("Hold mustard", bb.SpecialInstructions);
            }
            if (includePickle) {
                Assert.DoesNotContain("Hold pickle", bb.SpecialInstructions);
            } else {
                Assert.Contains("Hold pickle", bb.SpecialInstructions);
            }
            if (includeCheese) {
                Assert.DoesNotContain("Hold cheese", bb.SpecialInstructions);
            } else {
                Assert.Contains("Hold cheese", bb.SpecialInstructions);
            }
            if (includeBun && includeCheese && includeKetchup && includeMustard && includePickle) {
                Assert.Empty(bb.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString() {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", bb.ToString());
        }

        [Fact]
        public void BunChangeShouldTriggerPropertyChanged() {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Bun", () => {
                bb.Bun = false;
            });
            Assert.PropertyChanged(bb, "SpecialInstructions", () => {
                bb.Bun = false;
            });
        }

        [Fact]
        public void KetchupChangeShouldTriggerPropertyChanged() {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Ketchup", () => {
                bb.Ketchup = false;
            });
            Assert.PropertyChanged(bb, "SpecialInstructions", () => {
                bb.Ketchup = false;
            });
        }

        [Fact]
        public void MustardChangeShouldTriggerPropertyChanged() {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Mustard", () => {
                bb.Mustard = false;
            });
            Assert.PropertyChanged(bb, "SpecialInstructions", () => {
                bb.Mustard = false;
            });
        }

        [Fact]
        public void PickleChangeShouldTriggerPropertyChanged() {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Pickle", () => {
                bb.Pickle = false;
            });
            Assert.PropertyChanged(bb, "SpecialInstructions", () => {
                bb.Pickle = false;
            });
        }

        [Fact]
        public void CheeseChangeShouldTriggerPropertyChanged() {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Cheese", () => {
                bb.Cheese = false;
            });
            Assert.PropertyChanged(bb, "SpecialInstructions", () => {
                bb.Cheese = false;
            });
        }
        [Fact]
        public void TestDescription() {
            Assert.Equal("Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.", new BriarheartBurger().Description);
        }
    }
}