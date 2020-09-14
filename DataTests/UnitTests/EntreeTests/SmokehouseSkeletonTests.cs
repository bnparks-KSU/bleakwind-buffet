/*
 * Author: Zachery Brunner
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests {
    public class SmokehouseSkeletonTests {
        [Fact]
        public void ShouldBeAnEntree() {
            SmokehouseSkeleton item = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(item);
        }

        [Fact]
        public void ShouldBeAnOrderItem() {
            SmokehouseSkeleton item = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(item);
        }

        [Fact]
        public void ShouldInlcudeSausageByDefault() {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault() {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault() {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault() {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage() {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.SausageLink = false;
            Assert.False(ss.SausageLink);
            ss.SausageLink = true;
            Assert.True(ss.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg() {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.Egg = false;
            Assert.False(ss.Egg);
            ss.Egg = true;
            Assert.True(ss.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns() {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.HashBrowns = false;
            Assert.False(ss.HashBrowns);
            ss.HashBrowns = true;
            Assert.True(ss.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake() {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.Pancake = false;
            Assert.False(ss.Pancake);
            ss.Pancake = true;
            Assert.True(ss.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice() {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal(5.62, ss.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories() {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal((uint)602, ss.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake) {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.SausageLink = includeSausage;
            ss.Egg = includeEgg;
            ss.HashBrowns = includeHashbrowns;
            ss.Pancake = includePancake;

            if (includeSausage) {
                Assert.DoesNotContain("Hold sausage", ss.SpecialInstructions);
            } else {
                Assert.Contains("Hold sausage", ss.SpecialInstructions);
            }
            if (includeEgg) {
                Assert.DoesNotContain("Hold egg", ss.SpecialInstructions);
            } else {
                Assert.Contains("Hold eggs", ss.SpecialInstructions);
            }
            if (includeHashbrowns) {
                Assert.DoesNotContain("Hold hash browns", ss.SpecialInstructions);
            } else {
                Assert.Contains("Hold hash browns", ss.SpecialInstructions);
            }
            if (includePancake) {
                Assert.DoesNotContain("Hold pancakes", ss.SpecialInstructions);
            } else {
                Assert.Contains("Hold pancakes", ss.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString() {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", ss.ToString());
        }
    }
}