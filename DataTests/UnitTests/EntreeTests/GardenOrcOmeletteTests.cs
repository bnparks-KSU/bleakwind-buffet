﻿/*
 * Author: Zachery Brunner
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests {

    public class GardenOrcOmeletteTests {

        [Fact]
        public void ShouldBeAnEntree() {
            GardenOrcOmelette item = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(item);
        }

        [Fact]
        public void ShouldBeAnOrderItem() {
            GardenOrcOmelette item = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(item);
        }

        [Fact]
        public void ShouldInlcudeBroccoliByDefault() {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault() {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault() {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault() {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli() {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Broccoli = false;
            Assert.False(goo.Broccoli);
            goo.Broccoli = true;
            Assert.True(goo.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms() {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Mushrooms = false;
            Assert.False(goo.Mushrooms);
            goo.Mushrooms = true;
            Assert.True(goo.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato() {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Tomato = false;
            Assert.False(goo.Tomato);
            goo.Tomato = true;
            Assert.True(goo.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar() {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Cheddar = false;
            Assert.False(goo.Cheddar);
            goo.Cheddar = true;
            Assert.True(goo.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice() {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal(4.57, goo.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories() {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal((uint)404, goo.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar) {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Broccoli = includeBroccoli;
            goo.Mushrooms = includeMushrooms;
            goo.Tomato = includeTomato;
            goo.Cheddar = includeCheddar;

            if (includeBroccoli) {
                Assert.DoesNotContain("Hold broccoli", goo.SpecialInstructions);
            } else {
                Assert.Contains("Hold broccoli", goo.SpecialInstructions);
            }
            if (includeMushrooms) {
                Assert.DoesNotContain("Hold mushrooms", goo.SpecialInstructions);
            } else {
                Assert.Contains("Hold mushrooms", goo.SpecialInstructions);
            }
            if (includeTomato) {
                Assert.DoesNotContain("Hold tomato", goo.SpecialInstructions);
            } else {
                Assert.Contains("Hold tomato", goo.SpecialInstructions);
            }
            if (includeCheddar) {
                Assert.DoesNotContain("Hold cheddar", goo.SpecialInstructions);
            } else {
                Assert.Contains("Hold cheddar", goo.SpecialInstructions);
            }
            if (includeCheddar && includeBroccoli && includeMushrooms && includeTomato) {
                Assert.Empty(goo.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString() {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", goo.ToString());
        }

        [Fact]
        public void BroccoliChangeShouldTriggerPropertyChanged() {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.PropertyChanged(goo, "Broccoli", () => {
                goo.Broccoli = false;
            });
            Assert.PropertyChanged(goo, "SpecialInstructions", () => {
                goo.Broccoli = false;
            });
        }

        [Fact]
        public void MushroomChangeShouldTriggerPropertyChanged() {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.PropertyChanged(goo, "Mushrooms", () => {
                goo.Mushrooms = false;
            });
            Assert.PropertyChanged(goo, "SpecialInstructions", () => {
                goo.Mushrooms = false;
            });
        }

        [Fact]
        public void TomatoChangeShouldTriggerPropertyChanged() {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.PropertyChanged(goo, "Tomato", () => {
                goo.Tomato = false;
            });
            Assert.PropertyChanged(goo, "SpecialInstructions", () => {
                goo.Tomato = false;
            });
        }

        [Fact]
        public void CheddarChangeShouldTriggerPropertyChanged() {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.PropertyChanged(goo, "Cheddar", () => {
                goo.Cheddar = false;
            });
            Assert.PropertyChanged(goo, "SpecialInstructions", () => {
                goo.Cheddar = false;
            });
        }
        [Fact]
        public void TestDescription() {
            Assert.Equal("Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.", new GardenOrcOmelette().Description);
        }
    }
}