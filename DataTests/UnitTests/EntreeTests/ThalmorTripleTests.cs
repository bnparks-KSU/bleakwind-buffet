/*
 * Author: Zachery Brunner
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests {

    public class ThalmorTripleTests {

        [Fact]
        public void ShouldBeAnEntree() {
            ThalmorTriple item = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(item);
        }

        [Fact]
        public void ShouldBeAnOrderItem() {
            ThalmorTriple item = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(item);
        }

        [Fact]
        public void ShouldIncludeBunByDefault() {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault() {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault() {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault() {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault() {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault() {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault() {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault() {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault() {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault() {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun() {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bun = false;
            Assert.False(tt.Bun);
            tt.Bun = true;
            Assert.True(tt.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup() {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Ketchup = false;
            Assert.False(tt.Ketchup);
            tt.Ketchup = true;
            Assert.True(tt.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard() {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Mustard = false;
            Assert.False(tt.Mustard);
            tt.Mustard = true;
            Assert.True(tt.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle() {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Pickle = false;
            Assert.False(tt.Pickle);
            tt.Pickle = true;
            Assert.True(tt.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese() {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Cheese = false;
            Assert.False(tt.Cheese);
            tt.Cheese = true;
            Assert.True(tt.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato() {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Tomato = false;
            Assert.False(tt.Tomato);
            tt.Tomato = true;
            Assert.True(tt.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce() {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Lettuce = false;
            Assert.False(tt.Lettuce);
            tt.Lettuce = true;
            Assert.True(tt.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo() {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Mayo = false;
            Assert.False(tt.Mayo);
            tt.Mayo = true;
            Assert.True(tt.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon() {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bacon = false;
            Assert.False(tt.Bacon);
            tt.Bacon = true;
            Assert.True(tt.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg() {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Egg = false;
            Assert.False(tt.Egg);
            tt.Egg = true;
            Assert.True(tt.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice() {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal(8.32, tt.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories() {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal((uint)943, tt.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg) {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bun = includeBun;
            tt.Ketchup = includeKetchup;
            tt.Mustard = includeMustard;
            tt.Pickle = includePickle;
            tt.Cheese = includeCheese;
            tt.Tomato = includeTomato;
            tt.Lettuce = includeLettuce;
            tt.Mayo = includeMayo;
            tt.Bacon = includeBacon;
            tt.Egg = includeEgg;

            if (includeBun) {
                Assert.DoesNotContain("Hold bun", tt.SpecialInstructions);
            } else {
                Assert.Contains("Hold bun", tt.SpecialInstructions);
            }
            if (includeKetchup) {
                Assert.DoesNotContain("Hold ketchup", tt.SpecialInstructions);
            } else {
                Assert.Contains("Hold ketchup", tt.SpecialInstructions);
            }
            if (includeMustard) {
                Assert.DoesNotContain("Hold mustard", tt.SpecialInstructions);
            } else {
                Assert.Contains("Hold mustard", tt.SpecialInstructions);
            }
            if (includePickle) {
                Assert.DoesNotContain("Hold pickle", tt.SpecialInstructions);
            } else {
                Assert.Contains("Hold pickle", tt.SpecialInstructions);
            }
            if (includeCheese) {
                Assert.DoesNotContain("Hold cheese", tt.SpecialInstructions);
            } else {
                Assert.Contains("Hold cheese", tt.SpecialInstructions);
            }
            if (includeTomato) {
                Assert.DoesNotContain("Hold tomato", tt.SpecialInstructions);
            } else {
                Assert.Contains("Hold tomato", tt.SpecialInstructions);
            }
            if (includeLettuce) {
                Assert.DoesNotContain("Hold lettuce", tt.SpecialInstructions);
            } else {
                Assert.Contains("Hold lettuce", tt.SpecialInstructions);
            }
            if (includeMayo) {
                Assert.DoesNotContain("Hold mayo", tt.SpecialInstructions);
            } else {
                Assert.Contains("Hold mayo", tt.SpecialInstructions);
            }
            if (includeBacon) {
                Assert.DoesNotContain("Hold bacon", tt.SpecialInstructions);
            } else {
                Assert.Contains("Hold bacon", tt.SpecialInstructions);
            }
            if (includeEgg) {
                Assert.DoesNotContain("Hold egg", tt.SpecialInstructions);
            } else {
                Assert.Contains("Hold egg", tt.SpecialInstructions);
            }
            if (includeBun && includeCheese && includeKetchup && includeMustard && includePickle && includeTomato && includeLettuce && includeMayo && includeBacon && includeEgg) {
                Assert.Empty(tt.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString() {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", tt.ToString());
        }

        [Fact]
        public void BunChangeShouldTriggerPropertyChanged() {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Bun", () => {
                tt.Bun = false;
            });
            Assert.PropertyChanged(tt, "SpecialInstructions", () => {
                tt.Bun = false;
            });
        }

        [Fact]
        public void KetchupChangeShouldTriggerPropertyChanged() {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Ketchup", () => {
                tt.Ketchup = false;
            });
            Assert.PropertyChanged(tt, "SpecialInstructions", () => {
                tt.Ketchup = false;
            });
        }

        [Fact]
        public void MustardChangeShouldTriggerPropertyChanged() {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Mustard", () => {
                tt.Mustard = false;
            });
            Assert.PropertyChanged(tt, "SpecialInstructions", () => {
                tt.Mustard = false;
            });
        }

        [Fact]
        public void PickleChangeShouldTriggerPropertyChanged() {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Pickle", () => {
                tt.Pickle = false;
            });
            Assert.PropertyChanged(tt, "SpecialInstructions", () => {
                tt.Pickle = false;
            });
        }

        [Fact]
        public void CheeseChangeShouldTriggerPropertyChanged() {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Cheese", () => {
                tt.Cheese = false;
            });
            Assert.PropertyChanged(tt, "SpecialInstructions", () => {
                tt.Cheese = false;
            });
        }

        [Fact]
        public void TomatoChangeShouldTriggerPropertyChanged() {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Tomato", () => {
                tt.Tomato = false;
            });
            Assert.PropertyChanged(tt, "SpecialInstructions", () => {
                tt.Tomato = false;
            });
        }

        [Fact]
        public void LettuceChangeShouldTriggerPropertyChanged() {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Lettuce", () => {
                tt.Lettuce = false;
            });
            Assert.PropertyChanged(tt, "SpecialInstructions", () => {
                tt.Lettuce = false;
            });
        }

        [Fact]
        public void MayoChangeShouldTriggerPropertyChanged() {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Mayo", () => {
                tt.Mayo = false;
            });
            Assert.PropertyChanged(tt, "SpecialInstructions", () => {
                tt.Mayo = false;
            });
        }

        [Fact]
        public void BacoChangeShouldTriggerPropertyChanged() {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Bacon", () => {
                tt.Bacon = false;
            });
            Assert.PropertyChanged(tt, "SpecialInstructions", () => {
                tt.Bacon = false;
            });
        }

        [Fact]
        public void EggChangeShouldTriggerPropertyChanged() {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Egg", () => {
                tt.Egg = false;
            });
            Assert.PropertyChanged(tt, "SpecialInstructions", () => {
                tt.Egg = false;
            });
        }
        [Fact]
        public void TestDescription() {
            Assert.Equal("Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.", new ThalmorTriple().Description);
        }
    }
}