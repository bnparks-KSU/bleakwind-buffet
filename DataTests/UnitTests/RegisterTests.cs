/*
 * Author: Brian Parks
 * Class: RegisterTests.cs
 * Purpose: Test the RegisterTests.cs class.
 */
using BleakwindBuffet.Data;
using RoundRegister;
using System;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests {
    public class RegisterTests : IDisposable {

        CashRegister register = new CashRegister();
        public void Dispose() {
            CashDrawer.ResetDrawer();
        }

        [Fact]
        public void ShouldDefaultToNoPrice() {
            Assert.Equal(0, register.Total);
        }
        [Fact]
        public void CanSetTotalPrice() {
            register.Total = 100;
            Assert.Equal(100, register.Total);
        }
        [Fact]
        public void UpdateTotalShouldFirePropertyChanged() {
            Assert.PropertyChanged(register, "Total", () => {
                register.Total = 100;
            });
        }
        [Fact]
        public void ShouldDefaultToNoDue() {
            Assert.Equal(0, register.Due);
        }
        [Theory]
        [InlineData(51.26, 46.26)]
        [InlineData(12.62, 7.62)]
        [InlineData(1, 0)]
        public void ShouldCalculateAmountDue(double sale, double shouldBeDueAfter5) {
            register.FivesCustomer = 1;
            register.Total = sale;
            Assert.Equal(shouldBeDueAfter5, register.Due);
        }
        [Fact]
        public void ShouldDefaultToNoOwed() {
            Assert.Equal(0, register.Owed);
        }
        [Theory]
        [InlineData(25.26, 0)]
        [InlineData(5, 0)]
        [InlineData(1.00, 4.00)]
        public void ShouldCalculateAmountOwed(double sale, double shouldBeOwed) {
            register.FivesCustomer = 1;
            register.Total = sale;
            Assert.Equal(shouldBeOwed, register.Owed);
        }
        [Fact]
        public void ShouldDefaultToNoPaid() {
            Assert.Equal(0, register.AmountPaid);
        }
        [Theory]
        [InlineData(0,1,2,3, 20.75)]
        [InlineData(1,0,0,2, 100.50)]
        public void ShouldCalculateAmountPaid(int hund, int ten, int five, int quart, double paid) {
            register.HundredsCustomer = hund;
            register.TensCustomer = ten;
            register.FivesCustomer = five;
            register.QuartersCustomer = quart;
            Assert.Equal(paid, register.AmountPaid);
        }

        [Fact] 
        public void ShouldDefaultToNothingPaid() {
            Assert.Equal(0, register.HundredsCustomer);
            Assert.Equal(0, register.FiftiesCustomer);
            Assert.Equal(0, register.TwentiesCustomer);
            Assert.Equal(0, register.TensCustomer);
            Assert.Equal(0, register.FivesCustomer);
            Assert.Equal(0, register.TwosCustomer);
            Assert.Equal(0, register.OnesCustomer);
            Assert.Equal(0, register.DollarCoinsCustomer);
            Assert.Equal(0, register.HalfDollarsCustomer);
            Assert.Equal(0, register.QuartersCustomer);
            Assert.Equal(0, register.DimesCustomer);
            Assert.Equal(0, register.NickelsCustomer);
            Assert.Equal(0, register.PenniesCustomer);
        }

        [Fact]
        public void CanSetCustomerAmounts() {
            register.HundredsCustomer = 1;
            Assert.Equal(1, register.HundredsCustomer);
            register.FiftiesCustomer = 2;
            Assert.Equal(2, register.FiftiesCustomer);
            register.TwentiesCustomer = 3;
            Assert.Equal(3, register.TwentiesCustomer);
            register.TensCustomer = 4;
            Assert.Equal(4, register.TensCustomer);
            register.FivesCustomer = 5;
            Assert.Equal(5, register.FivesCustomer);
            register.TwosCustomer = 6;
            Assert.Equal(6, register.TwosCustomer);
            register.OnesCustomer = 7;
            Assert.Equal(7, register.OnesCustomer);
            register.DollarCoinsCustomer = 8;
            Assert.Equal(8, register.DollarCoinsCustomer);
            register.HalfDollarsCustomer = 9;
            Assert.Equal(9, register.HalfDollarsCustomer);
            register.QuartersCustomer = 10;
            Assert.Equal(10, register.QuartersCustomer);
            register.DimesCustomer = 11;
            Assert.Equal(11, register.DimesCustomer);
            register.NickelsCustomer = 12;
            Assert.Equal(12, register.NickelsCustomer);
            register.PenniesCustomer = 13;
            Assert.Equal(13, register.PenniesCustomer);
        }

        [Fact]
        public void ShouldDefaultToNothingOwed() {
            Assert.Equal(0, register.HundredsChange);
            Assert.Equal(0, register.FiftiesChange);
            Assert.Equal(0, register.TwentiesChange);
            Assert.Equal(0, register.TensChange);
            Assert.Equal(0, register.FivesChange);
            Assert.Equal(0, register.TwosChange);
            Assert.Equal(0, register.OnesChange);
            Assert.Equal(0, register.DollarCoinsChange);
            Assert.Equal(0, register.HalfDollarsChange);
            Assert.Equal(0, register.QuartersChange);
            Assert.Equal(0, register.DimesChange);
            Assert.Equal(0, register.NickelsChange);
            Assert.Equal(0, register.PenniesChange);
        }

        [Fact]
        public void ShouldUpdateDrawerValuesOnFinalization() {
            int lastHundreds = CashDrawer.Hundreds;
            int lastFifties= CashDrawer.Fifties;
            int lastTwenties = CashDrawer.Twenties;
            int lastTens = CashDrawer.Tens;
            int lastFives = CashDrawer.Fives;
            int lastTwos = CashDrawer.Twos;
            int lastOnes= CashDrawer.Ones;
            int lastDollarCoins = CashDrawer.Dollars;
            int lastHalfDolars = CashDrawer.HalfDollars;
            int lastQuarters = CashDrawer.Quarters;
            int lastDimes = CashDrawer.Dimes;
            int lastNickels = CashDrawer.Nickels;
            int lastPennies = CashDrawer.Pennies;
            register.HundredsCustomer = 1;
            register.FiftiesCustomer = 2;
            register.TwentiesCustomer = 3;
            register.TensCustomer = 4;
            register.FivesCustomer = 5;
            register.TwosCustomer = 6;
            register.OnesCustomer = 7;
            register.DollarCoinsCustomer = 8;
            register.HalfDollarsCustomer = 9;
            register.QuartersCustomer = 10;
            register.DimesCustomer = 11;
            register.NickelsCustomer = 12;
            register.PenniesCustomer = 13;
            register.FinalizeTransaction();
            Assert.Equal(CashDrawer.Hundreds, 1 + lastHundreds);
            Assert.Equal(CashDrawer.Fifties, 2 + lastFifties);
            Assert.Equal(CashDrawer.Twenties, 3 + lastTwenties);
            Assert.Equal(CashDrawer.Tens, 4 + lastTens);
            Assert.Equal(CashDrawer.Fives, 5 + lastFives);
            Assert.Equal(CashDrawer.Twos, 6 + lastTwos);
            Assert.Equal(CashDrawer.Ones, 7 + lastOnes);
            Assert.Equal(CashDrawer.Dollars, 8 + lastDollarCoins);
            Assert.Equal(CashDrawer.HalfDollars, 9 + lastHalfDolars);
            Assert.Equal(CashDrawer.Quarters, 10 + lastQuarters);
            Assert.Equal(CashDrawer.Dimes, 11 + lastDimes);
            Assert.Equal(CashDrawer.Nickels, 12 + lastNickels);
            Assert.Equal(CashDrawer.Pennies, 13 + lastPennies);
        }

        [Fact]
        public void ShouldFirePropertiesWhenHundredsCustomerChanges() {
            Assert.PropertyChanged(register, "HundredsCustomer", () => {
                register.HundredsCustomer = 5;
            });
            Assert.PropertyChanged(register, "Owed", () => {
                register.HundredsCustomer = 5;
            });
            Assert.PropertyChanged(register, "Due", () => {
                register.HundredsCustomer = 5;
            });
        }
        [Fact]
        public void ShouldFirePropertiesWhenFiftiesCustomerChanges() {
            Assert.PropertyChanged(register, "FiftiesCustomer", () => {
                register.FiftiesCustomer = 5;
            });
            Assert.PropertyChanged(register, "Owed", () => {
                register.FiftiesCustomer = 5;
            });
            Assert.PropertyChanged(register, "Due", () => {
                register.FiftiesCustomer = 5;
            });
        }
        [Fact]
        public void ShouldFirePropertiesWhenTwentiesCustomerChanges() {
            Assert.PropertyChanged(register, "TwentiesCustomer", () => {
                register.TwentiesCustomer = 5;
            });
            Assert.PropertyChanged(register, "Owed", () => {
                register.TwentiesCustomer = 5;
            });
            Assert.PropertyChanged(register, "Due", () => {
                register.TwentiesCustomer = 5;
            });
        }
        [Fact]
        public void ShouldFirePropertiesWhenTensCustomerChanges() {
            Assert.PropertyChanged(register, "TensCustomer", () => {
                register.TensCustomer = 5;
            });
            Assert.PropertyChanged(register, "Owed", () => {
                register.TensCustomer = 5;
            });
            Assert.PropertyChanged(register, "Due", () => {
                register.TensCustomer = 5;
            });
        }
        [Fact]
        public void ShouldFirePropertiesWhenFivesCustomerChanges() {
            Assert.PropertyChanged(register, "FivesCustomer", () => {
                register.FivesCustomer = 5;
            });
            Assert.PropertyChanged(register, "Owed", () => {
                register.FivesCustomer = 5;
            });
            Assert.PropertyChanged(register, "Due", () => {
                register.FivesCustomer = 5;
            });
        }
        [Fact]
        public void ShouldFirePropertiesWhenTwosCustomerChanges() {
            Assert.PropertyChanged(register, "TwosCustomer", () => {
                register.TwosCustomer = 5;
            });
            Assert.PropertyChanged(register, "Owed", () => {
                register.TwosCustomer = 5;
            });
            Assert.PropertyChanged(register, "Due", () => {
                register.TwosCustomer = 5;
            });
        }
        [Fact]
        public void ShouldFirePropertiesWhenOnesCustomerChanges() {
            Assert.PropertyChanged(register, "OnesCustomer", () => {
                register.OnesCustomer = 5;
            });
            Assert.PropertyChanged(register, "Owed", () => {
                register.OnesCustomer = 5;
            });
            Assert.PropertyChanged(register, "Due", () => {
                register.OnesCustomer = 5;
            });
        }
        [Fact]
        public void ShouldFirePropertiesWhenDollarCoinsCustomerChanges() {
            Assert.PropertyChanged(register, "DollarCoinsCustomer", () => {
                register.DollarCoinsCustomer = 5;
            });
            Assert.PropertyChanged(register, "Owed", () => {
                register.DollarCoinsCustomer = 5;
            });
            Assert.PropertyChanged(register, "Due", () => {
                register.DollarCoinsCustomer = 5;
            });
        }
        [Fact]
        public void ShouldFirePropertiesWhenHalfDollarsCustomerChanges() {
            Assert.PropertyChanged(register, "HalfDollarsCustomer", () => {
                register.HalfDollarsCustomer = 5;
            });
            Assert.PropertyChanged(register, "Owed", () => {
                register.HalfDollarsCustomer = 5;
            });
            Assert.PropertyChanged(register, "Due", () => {
                register.HalfDollarsCustomer = 5;
            });
        }
        [Fact]
        public void ShouldFirePropertiesWhenQuartersCustomerChanges() {
            Assert.PropertyChanged(register, "QuartersCustomer", () => {
                register.QuartersCustomer = 5;
            });
            Assert.PropertyChanged(register, "Owed", () => {
                register.QuartersCustomer = 5;
            });
            Assert.PropertyChanged(register, "Due", () => {
                register.QuartersCustomer = 5;
            });
        }
        [Fact]
        public void ShouldFirePropertiesWhenDimesCustomerChanges() {
            Assert.PropertyChanged(register, "DimesCustomer", () => {
                register.DimesCustomer = 5;
            });
            Assert.PropertyChanged(register, "Owed", () => {
                register.DimesCustomer = 5;
            });
            Assert.PropertyChanged(register, "Due", () => {
                register.DimesCustomer = 5;
            });
        }
        [Fact]
        public void ShouldFirePropertiesWhenNickelsCustomerChanges() {
            Assert.PropertyChanged(register, "NickelsCustomer", () => {
                register.NickelsCustomer = 5;
            });
            Assert.PropertyChanged(register, "Owed", () => {
                register.NickelsCustomer = 5;
            });
            Assert.PropertyChanged(register, "Due", () => {
                register.NickelsCustomer = 5;
            });
        }
        [Fact]
        public void ShouldFirePropertiesWhenPenniesCustomerChanges() {
            Assert.PropertyChanged(register, "PenniesCustomer", () => {
                register.PenniesCustomer = 5;
            });
            Assert.PropertyChanged(register, "Owed", () => {
                register.PenniesCustomer = 5;
            });
            Assert.PropertyChanged(register, "Due", () => {
                register.PenniesCustomer = 5;
            });
        }
    }
}
