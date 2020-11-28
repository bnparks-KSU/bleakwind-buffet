/*
 * Author: Brian Parks
 * Class: OrderTests.cs
 * Purpose: Test the Order.cs class.
 */
using BleakwindBuffet.Data;
using BleakwindBuffet.DataTests.UnitTests.MockImplementation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests {
    public class OrderTests {
        [Fact]
        public void ShouldImplementICollectionInterface() {
            Order order = new Order();
            Assert.IsAssignableFrom<ICollection<IOrderItem>>(order);
        }
        [Fact]
        public void ShouldImplementINotifyPropertyChangedInterface() {
            Order order = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(order);
        }
        [Fact]
        public void ShouldImplementINotifyCollectionChangedInterface() {
            Order order = new Order();
            Assert.IsAssignableFrom<INotifyCollectionChanged>(order);
        }

        [Fact]
        public void ShouldStartEmpty() {
            Order order = new Order();
            Assert.Empty(order);
        }

        [Fact]
        public void ShouldFirePropertiesWhenAdded() {
            Order order = new Order();
            MockEntreeImplementation mockEntree1 = new MockEntreeImplementation(1, 1);
            MockEntreeImplementation mockEntree2 = new MockEntreeImplementation(1, 1);
            MockEntreeImplementation mockEntree3 = new MockEntreeImplementation(1, 1);
            MockEntreeImplementation mockEntree4 = new MockEntreeImplementation(1, 1);
            MockEntreeImplementation mockEntree5 = new MockEntreeImplementation(1, 1);
            MockEntreeImplementation mockEntree6 = new MockEntreeImplementation(1, 1);
            Assert.PropertyChanged(order, "Total", () => {
                order.Add(mockEntree1);
            });
            Assert.PropertyChanged(order, "Tax", () => {
                order.Add(mockEntree2);
            });
            Assert.PropertyChanged(order, "Subtotal", () => {
                order.Add(mockEntree3);
            });
            Assert.PropertyChanged(order, "Calories", () => {
                order.Add(mockEntree4);
            });
        }

        [Fact]
        public void ShouldFirePropertiesWhenRemoved() {
            Order order = new Order();
            MockEntreeImplementation mockEntree1 = new MockEntreeImplementation(1, 1);
            MockEntreeImplementation mockEntree2 = new MockEntreeImplementation(1, 1);
            MockEntreeImplementation mockEntree3 = new MockEntreeImplementation(1, 1);
            MockEntreeImplementation mockEntree4 = new MockEntreeImplementation(1, 1);
            MockEntreeImplementation mockEntree5 = new MockEntreeImplementation(1, 1);
            MockEntreeImplementation mockEntree6 = new MockEntreeImplementation(1, 1);
            order.Add(mockEntree1);
            order.Add(mockEntree2);
            order.Add(mockEntree3);
            order.Add(mockEntree4);
            order.Add(mockEntree5);
            order.Add(mockEntree6);
            Assert.PropertyChanged(order, "Total", () => {
                order.Remove(mockEntree1);
            });
            Assert.PropertyChanged(order, "Tax", () => {
                order.Remove(mockEntree2);
            });
            Assert.PropertyChanged(order, "Subtotal", () => {
                order.Remove(mockEntree3);
            });
            Assert.PropertyChanged(order, "Calories", () => {
                order.Remove(mockEntree4);
            });
        }

        [Fact]
        public void ShouldFirePropertiesWhenTaxRateChanged() {
            Order order = new Order();
            Assert.PropertyChanged(order, "Total", () => {
                order.SalesTaxRate = .15;
            });
            Assert.PropertyChanged(order, "Tax", () => {
                order.SalesTaxRate = .15;
            });
            Assert.PropertyChanged(order, "Subtotal", () => {
                order.SalesTaxRate = .15;
            });
            Assert.PropertyChanged(order, "TaxRate", () => {
                order.SalesTaxRate = .15;
            });
        }


        [Fact]
        public void ShouldFirePropertiesWhenPriceChanged() {
            Order order = new Order();
            MockEntreeImplementation mockEntree1 = new MockEntreeImplementation(1, 1);
            order.Add(mockEntree1);
            Assert.PropertyChanged(order, "Total", () => {
                mockEntree1.ChangePrice(1.00);
            });
            Assert.PropertyChanged(order, "Tax", () => {
                mockEntree1.ChangePrice(1.00);
            });
            Assert.PropertyChanged(order, "Subtotal", () => {
                mockEntree1.ChangePrice(1.00);
            });
        }

        [Fact]
        public void ShouldFirePropertiesWhenCaloriesChanged() {
            Order order = new Order();
            MockEntreeImplementation mockEntree1 = new MockEntreeImplementation(1, 1);
            order.Add(mockEntree1);
            Assert.PropertyChanged(order, "Calories", () => {
                mockEntree1.ChangeCalories(547);
            });
        }

        [Fact]
        public void ShouldIncreaseNumbers() {
            Order order1 = new Order();
            Order order2 = new Order();
            Order order3 = new Order();
            Order order4 = new Order();
            Assert.Equal(order1.Number, order2.Number - 1);
            Assert.Equal(order2.Number, order3.Number - 1);
            Assert.Equal(order3.Number, order4.Number - 1);
        }

        [Theory]
        [InlineData(17.25, 154)]
        [InlineData(5.17, 42)]
        public void ShouldAddSides(double price, uint calories) {
            Order order = new Order();
            MockSideImplementation msi = new MockSideImplementation(price, calories);
            order.Add(msi);
            Assert.Contains(msi, order);
        }

        [Theory]
        [InlineData(17.25, 154)]
        [InlineData(5.17, 42)]
        public void ShouldAddEntrees(double price, uint calories) {
            Order order = new Order();
            MockEntreeImplementation mei = new MockEntreeImplementation(price, calories);
            order.Add(mei);
            Assert.Contains(mei, order);
        }

        [Theory]
        [InlineData(17.25, 154)]
        [InlineData(5.17, 42)]
        public void ShouldAddDrinks(double price, uint calories) {
            Order order = new Order();
            MockDrinkImplementation mdi = new MockDrinkImplementation(price, calories);
            order.Add(mdi);
            Assert.Contains(mdi, order);
        }

        [Theory]
        [InlineData(.18)]
        [InlineData(.76)]
        public void ShouldSetSalesTax(double newRate) {
            Order order = new Order();
            order.SalesTaxRate = newRate;
            Assert.Equal(newRate, order.SalesTaxRate);
        }

        [Theory]
        [InlineData(7.18, 34.48, 12.14)]
        [InlineData(8, 42, 311)]
        public void ShouldGetProperSubToal(double item1Price, double item2Price, double item3Price) {
            Order order = new Order();
            double subTotal = item1Price + item2Price + item3Price;
            order.Add(new MockEntreeImplementation(item1Price, 1));
            order.Add(new MockEntreeImplementation(item2Price, 1));
            order.Add(new MockEntreeImplementation(item3Price, 1));
            Assert.Equal(subTotal, order.Subtotal);
        }

        [Theory]
        [InlineData(7.18, 34.48, 12.14, 6.46)]
        [InlineData(8.16, 42, 311, 43.34)]
        public void ShouldGetProperTax(double item1Price, double item2Price, double item3Price, double taxAmount) {
            Order order = new Order();
            order.Add(new MockEntreeImplementation(item1Price, 1));
            order.Add(new MockEntreeImplementation(item2Price, 1));
            order.Add(new MockEntreeImplementation(item3Price, 1));
            Assert.Equal(taxAmount, order.Tax);
        }

        [Theory]
        [InlineData(7.18, 34.48, 12.14, 60.26)]
        [InlineData(8.16, 42, 311, 404.5)]
        public void ShouldGetProperTotal(double item1Price, double item2Price, double item3Price, double totalAmount) {
            Order order = new Order();
            order.Add(new MockEntreeImplementation(item1Price, 1));
            order.Add(new MockEntreeImplementation(item2Price, 1));
            order.Add(new MockEntreeImplementation(item3Price, 1));
            Assert.Equal(totalAmount, order.Total);
        }

        [Fact]
        public void ShouldBreakLinesCorrectly() {
            Order order = new Order();
            string line = "This line is more than 40 characters long. Therefore it should wrap at a space in here.";
            Assert.Collection(order.LimitLine(line),
                part => Assert.Equal("This line is more than 40 characters ", part),
                part => Assert.Equal("long. Therefore it should wrap at a ", part),
                part => Assert.Equal("space in here. ", part));
        }
    }
}
