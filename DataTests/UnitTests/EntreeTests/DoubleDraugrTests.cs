/*
 * Author: Zachery Brunner
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests {

    public class DoubleDraugrTests {

        [Fact]
        public void ShouldBeAnEntree() {
            DoubleDraugr item = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(item);
        }

        [Fact]
        public void ShouldBeAnOrderItem() {
            DoubleDraugr item = new DoubleDraugr();
            Assert.IsAssignableFrom<IOrderItem>(item);
        }

        [Fact]
        public void ShouldIncludeBunByDefault() {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault() {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault() {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault() {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault() {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault() {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault() {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault() {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun() {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Bun = false;
            Assert.False(dd.Bun);
            dd.Bun = true;
            Assert.True(dd.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup() {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Ketchup = false;
            Assert.False(dd.Ketchup);
            dd.Ketchup = true;
            Assert.True(dd.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard() {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mustard = false;
            Assert.False(dd.Mustard);
            dd.Mustard = true;
            Assert.True(dd.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle() {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Pickle = false;
            Assert.False(dd.Pickle);
            dd.Pickle = true;
            Assert.True(dd.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese() {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Cheese = false;
            Assert.False(dd.Cheese);
            dd.Cheese = true;
            Assert.True(dd.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato() {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Tomato = false;
            Assert.False(dd.Tomato);
            dd.Tomato = true;
            Assert.True(dd.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce() {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Lettuce = false;
            Assert.False(dd.Lettuce);
            dd.Lettuce = true;
            Assert.True(dd.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo() {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mayo = false;
            Assert.False(dd.Mayo);
            dd.Mayo = true;
            Assert.True(dd.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice() {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal(7.32, dd.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories() {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal((uint)843, dd.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo) {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Bun = includeBun;
            dd.Ketchup = includeKetchup;
            dd.Mustard = includeMustard;
            dd.Pickle = includePickle;
            dd.Cheese = includeCheese;
            dd.Tomato = includeTomato;
            dd.Lettuce = includeLettuce;
            dd.Mayo = includeMayo;

            if (includeBun) {
                Assert.DoesNotContain("Hold bun", dd.SpecialInstructions);
            } else {
                Assert.Contains("Hold bun", dd.SpecialInstructions);
            }
            if (includeKetchup) {
                Assert.DoesNotContain("Hold ketchup", dd.SpecialInstructions);
            } else {
                Assert.Contains("Hold ketchup", dd.SpecialInstructions);
            }
            if (includeMustard) {
                Assert.DoesNotContain("Hold mustard", dd.SpecialInstructions);
            } else {
                Assert.Contains("Hold mustard", dd.SpecialInstructions);
            }
            if (includePickle) {
                Assert.DoesNotContain("Hold pickle", dd.SpecialInstructions);
            } else {
                Assert.Contains("Hold pickle", dd.SpecialInstructions);
            }
            if (includeCheese) {
                Assert.DoesNotContain("Hold cheese", dd.SpecialInstructions);
            } else {
                Assert.Contains("Hold cheese", dd.SpecialInstructions);
            }
            if (includeTomato) {
                Assert.DoesNotContain("Hold tomato", dd.SpecialInstructions);
            } else {
                Assert.Contains("Hold tomato", dd.SpecialInstructions);
            }
            if (includeLettuce) {
                Assert.DoesNotContain("Hold lettuce", dd.SpecialInstructions);
            } else {
                Assert.Contains("Hold lettuce", dd.SpecialInstructions);
            }
            if (includeMayo) {
                Assert.DoesNotContain("Hold mayo", dd.SpecialInstructions);
            } else {
                Assert.Contains("Hold mayo", dd.SpecialInstructions);
            }
            if (includeBun && includeCheese && includeKetchup && includeMustard && includePickle && includeTomato && includeLettuce && includeMayo) {
                Assert.Empty(dd.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString() {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal("Double Draugr", dd.ToString());
        }

        [Fact]
        public void BunChangeShouldTriggerPropertyChanged() {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Bun", () => {
                dd.Bun = false;
            });
            Assert.PropertyChanged(dd, "SpecialInstructions", () => {
                dd.Bun = false;
            });
        }

        [Fact]
        public void KetchupChangeShouldTriggerPropertyChanged() {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Ketchup", () => {
                dd.Ketchup = false;
            });
            Assert.PropertyChanged(dd, "SpecialInstructions", () => {
                dd.Ketchup = false;
            });
        }

        [Fact]
        public void MustardChangeShouldTriggerPropertyChanged() {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Mustard", () => {
                dd.Mustard = false;
            });
            Assert.PropertyChanged(dd, "SpecialInstructions", () => {
                dd.Mustard = false;
            });
        }

        [Fact]
        public void PickleChangeShouldTriggerPropertyChanged() {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Pickle", () => {
                dd.Pickle = false;
            });
            Assert.PropertyChanged(dd, "SpecialInstructions", () => {
                dd.Pickle = false;
            });
        }

        [Fact]
        public void CheeseChangeShouldTriggerPropertyChanged() {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Cheese", () => {
                dd.Cheese = false;
            });
            Assert.PropertyChanged(dd, "SpecialInstructions", () => {
                dd.Cheese = false;
            });
        }

        [Fact]
        public void TomatoChangeShouldTriggerPropertyChanged() {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Tomato", () => {
                dd.Tomato = false;
            });
            Assert.PropertyChanged(dd, "SpecialInstructions", () => {
                dd.Tomato = false;
            });
        }

        [Fact]
        public void LettuceChangeShouldTriggerPropertyChanged() {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Lettuce", () => {
                dd.Lettuce = false;
            });
            Assert.PropertyChanged(dd, "SpecialInstructions", () => {
                dd.Lettuce = false;
            });
        }

        [Fact]
        public void MayoChangeShouldTriggerPropertyChanged() {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Mayo", () => {
                dd.Mayo = false;
            });
            Assert.PropertyChanged(dd, "SpecialInstructions", () => {
                dd.Mayo = false;
            });
        }
        [Fact]
        public void TestDescription() {
            Assert.Equal("Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.", new DoubleDraugr().Description);
        }
    }
}