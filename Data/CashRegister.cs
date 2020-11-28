/*
 * Author: Brian Parks
 * Class name: CashRegister.cs
 * Purpose: This is the viewmodel between the CashDrawer and the POS system.
 */

using RoundRegister;
using System;
using System.ComponentModel;

namespace BleakwindBuffet.Data {

    public class CashRegister : INotifyPropertyChanged {

        /// <summary>
        /// The property changed event handler.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the total amount paid.
        /// </summary>
        public double Total {
            get { return total; }
            set {
                total = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            }
        }

        /// <summary>
        /// Gets the amount left that is due to be paid.
        /// </summary>
        public double Due {
            get {
                return Math.Round((Total - AmountPaid > 0 ? Total - AmountPaid : 0) * 100) / 100;
            }
        }

        /// <summary>
        /// Gets the amount that is owed to the customer.
        /// </summary>
        public double Owed {
            get {
                UpdateChangeValues(Math.Round((AmountPaid - Total) * 100) / 100.00);
                return Math.Round((AmountPaid - Total > 0 ? AmountPaid - Total : 0) * 100) / 100.00;
            }
        }

        /// <summary>
        /// Gets the amount paid by the customer for the order.
        /// </summary>
        public double AmountPaid {
            get {
                return (HundredsCustomer * 10000 + FiftiesCustomer * 5000 + TwentiesCustomer * 2000 + TensCustomer * 1000 + FivesCustomer * 500 + TwosCustomer * 200 + OnesCustomer * 100
                + DollarCoinsCustomer * 100 + HalfDollarsCustomer * 50 + QuartersCustomer * 25 + DimesCustomer * 10 + NickelsCustomer * 5 + PenniesCustomer * 1) / 100.00;
            }
        }

        /// <summary>
        /// The amount of hundreds the customer is trying to pay the bill with.
        /// </summary>
        public int HundredsCustomer {
            get {
                return hundredsCustomer;
            }
            set {
                hundredsCustomer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HundredsCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Owed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Due"));
            }
        }

        /// <summary>
        /// The amount of fifties the customer is trying to pay the bill with.
        /// </summary>
        public int FiftiesCustomer {
            get {
                return fiftiesCustomer;
            }
            set {
                fiftiesCustomer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftiesCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Owed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Due"));
            }
        }

        /// <summary>
        /// The amount of twenties the customer is trying to pay the bill with.
        /// </summary>
        public int TwentiesCustomer {
            get {
                return twentiesCustomer;
            }
            set {
                twentiesCustomer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentiesCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Owed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Due"));
            }
        }

        /// <summary>
        /// The amount of tens the customer is trying to pay the bill with.
        /// </summary>
        public int TensCustomer {
            get {
                return tensCustomer;
            }
            set {
                tensCustomer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TensCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Owed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Due"));
            }
        }

        /// <summary>
        /// The amount of fives the customer is trying to pay the bill with.
        /// </summary>
        public int FivesCustomer {
            get {
                return fivesCustomer;
            }
            set {
                fivesCustomer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FivesCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Owed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Due"));
            }
        }

        /// <summary>
        /// The amount of twos the customer is trying to pay the bill with.
        /// </summary>
        public int TwosCustomer {
            get {
                return twosCustomer;
            }
            set {
                twosCustomer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwosCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Owed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Due"));
            }
        }

        /// <summary>
        /// The amount of ones the customer is trying to pay the bill with.
        /// </summary>
        public int OnesCustomer {
            get {
                return onesCustomer;
            }
            set {
                onesCustomer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OnesCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Owed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Due"));
            }
        }

        /// <summary>
        /// The amount of collar coins the customer is trying to pay the bill with.
        /// </summary>
        public int DollarCoinsCustomer {
            get {
                return dollarCoinsCustomer;
            }
            set {
                dollarCoinsCustomer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DollarCoinsCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Owed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Due"));
            }
        }

        /// <summary>
        /// The amount of half dollars the customer is trying to pay the bill with.
        /// </summary>
        public int HalfDollarsCustomer {
            get {
                return halfDollarsCustomer;
            }
            set {
                halfDollarsCustomer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollarsCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Owed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Due"));
            }
        }

        /// <summary>
        /// The amount of quarters the customer is trying to pay the bill with.
        /// </summary>
        public int QuartersCustomer {
            get {
                return quartersCustomer;
            }
            set {
                quartersCustomer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("QuartersCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Owed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Due"));
            }
        }

        /// <summary>
        /// The amount of dimes the customer is trying to pay the bill with.
        /// </summary>
        public int DimesCustomer {
            get {
                return dimesCustomer;
            }
            set {
                dimesCustomer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DimesCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Owed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Due"));
            }
        }

        /// <summary>
        /// The amount of nickels the customer is trying to pay the bill with.
        /// </summary>
        public int NickelsCustomer {
            get {
                return nickelsCustomer;
            }
            set {
                nickelsCustomer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NickelsCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Owed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Due"));
            }
        }

        /// <summary>
        /// The amount of pennies the customer is trying to pay the bill with.
        /// </summary>
        public int PenniesCustomer {
            get {
                return penniesCustomer;
            }
            set {
                penniesCustomer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PenniesCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Owed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Due"));
            }
        }

        /// <summary>
        /// The amount of hundreds the customer would recieve in change.
        /// </summary>
        public int HundredsChange {
            get {
                return hundredsChange;
            }
            private set {
                if (value != hundredsChange) {
                    hundredsChange = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HundredsChange"));
                }
            }
        }

        /// <summary>
        /// The amount of fifties the customer would recieve in change.
        /// </summary>
        public int FiftiesChange {
            get {
                return fiftiesChange;
            }
            private set {
                if (value != fiftiesChange) {
                    fiftiesChange = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftiesChange"));
                }
            }
        }

        /// <summary>
        /// The amount of twenties the customer would recieve in change.
        /// </summary>
        public int TwentiesChange {
            get {
                return twentiesChange;
            }
            private set {
                if (value != twentiesChange) {
                    twentiesChange = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentiesChange"));
                }
            }
        }

        /// <summary>
        /// The amount of tens the customer would recieve in change.
        /// </summary>
        public int TensChange {
            get {
                return tensChange;
            }
            private set {
                if (value != tensChange) {
                    tensChange = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TensChange"));
                }
            }
        }

        /// <summary>
        /// The amount of fives the customer would recieve in change.
        /// </summary>
        public int FivesChange {
            get {
                return fivesChange;
            }
            private set {
                if (value != fivesChange) {
                    fivesChange = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FivesChange"));
                }
            }
        }

        /// <summary>
        /// The amount of twos the customer would recieve in change.
        /// </summary>
        public int TwosChange {
            get {
                return twosChange;
            }
            private set {
                if (value != twosChange) {
                    twosChange = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwosChange"));
                }
            }
        }

        /// <summary>
        /// The amount of ones the customer would recieve in change.
        /// </summary>
        public int OnesChange {
            get {
                return onesChange;
            }
            private set {
                if (value != onesChange) {
                    onesChange = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OnesChange"));
                }
            }
        }

        /// <summary>
        /// The amount of collar coins the customer would recieve in change.
        /// </summary>
        public int DollarCoinsChange {
            get {
                return dollarCoinsChange;
            }
            private set {
                if (value != dollarCoinsChange) {
                    dollarCoinsChange = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DollarCoinsChange"));
                }
            }
        }

        /// <summary>
        /// The amount of half dollars the customer would recieve in change.
        /// </summary>
        public int HalfDollarsChange {
            get {
                return halfDollarsChange;
            }
            private set {
                if (value != halfDollarsChange) {
                    halfDollarsChange = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollarsChange"));
                }
            }
        }

        /// <summary>
        /// The amount of quarters the customer would recieve in change.
        /// </summary>
        public int QuartersChange {
            get {
                return quartersChange;
            }
            private set {
                if (value != quartersChange) {
                    quartersChange = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("QuartersChange"));
                }
            }
        }

        /// <summary>
        /// The amount of dimes the customer would recieve in change.
        /// </summary>
        public int DimesChange {
            get {
                return dimesChange;
            }
            private set {
                if (value != dimesChange) {
                    dimesChange = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DimesChange"));
                }
            }
        }

        /// <summary>
        /// The amount of nickels the customer would recieve in change.
        /// </summary>
        public int NickelsChange {
            get {
                return nickelsChange;
            }
            private set {
                if (value != nickelsChange) {
                    nickelsChange = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NickelsChange"));
                }
            }
        }

        /// <summary>
        /// The amount of pennies the customer would recieve in change.
        /// </summary>
        public int PenniesChange {
            get {
                return penniesChange;
            }
            private set {
                if (value != penniesChange) {
                    penniesChange = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PenniesChange"));
                }
            }
        }

        /// <summary>
        /// Updates all of the change values owed to the customer.
        /// </summary>
        /// <param name="amount">The amount of change owed to the customer.</param>
        public void UpdateChangeValues(double amount) {
            int workingAmount = (int)(amount * 100);
            Console.WriteLine("Initial working amount: " + workingAmount);
            HundredsChange = 0;
            FiftiesChange = 0;
            TwentiesChange = 0;
            TensChange = 0;
            FivesChange = 0;
            TwosChange = 0;
            OnesChange = 0;
            DollarCoinsChange = 0;
            HalfDollarsChange = 0;
            QuartersChange = 0;
            DimesChange = 0;
            NickelsChange = 0;
            PenniesChange = 0;
            while (workingAmount >= 10000 && CashDrawer.Hundreds > HundredsChange) {
                workingAmount -= 10000;
                HundredsChange += 1;
            }
            while (workingAmount >= 5000 && CashDrawer.Fifties > FiftiesChange) {
                workingAmount -= 5000;
                FiftiesChange += 1;
            }
            while (workingAmount >= 2000 && CashDrawer.Twenties > TwentiesChange) {
                workingAmount -= 2000;
                TwentiesChange += 1;
            }
            while (workingAmount >= 1000 && CashDrawer.Tens > TensChange) {
                workingAmount -= 1000;
                TensChange += 1;
            }
            while (workingAmount >= 500 && CashDrawer.Fives > FivesChange) {
                workingAmount -= 500;
                FivesChange += 1;
            }
            while (workingAmount >= 200 && CashDrawer.Twos > TwosChange) {
                workingAmount -= 200;
                TwosChange += 1;
            }
            while (workingAmount >= 100 && CashDrawer.Ones > OnesChange) {
                workingAmount -= 100;
                OnesChange += 1;
            }
            while (workingAmount >= 100 && CashDrawer.Dollars > DollarCoinsChange) {
                workingAmount -= 100;
                DollarCoinsChange += 1;
            }
            while (workingAmount >= 5 && CashDrawer.HalfDollars > HalfDollarsChange) {
                workingAmount -= 5;
                HalfDollarsChange += 1;
            }
            while (workingAmount >= 25 && CashDrawer.Quarters > QuartersChange) {
                workingAmount -= 25;
                QuartersChange += 1;
            }
            while (workingAmount >= 10 && CashDrawer.Dimes > DimesChange) {
                workingAmount -= 10;
                DimesChange += 1;
            }
            while (workingAmount >= 05 && CashDrawer.Nickels > NickelsChange) {
                workingAmount -= 05;
                NickelsChange += 1;
            }
            while (workingAmount > 0 && CashDrawer.Pennies > PenniesChange) {
                Console.WriteLine("HIT, Working at: " + workingAmount);
                workingAmount -= 1;
                PenniesChange += 1;
            }
        }

        /// <summary>
        /// Finalizes the transaction, opens the CashDrawer, and sets the new amounts in the drawer.
        /// </summary>
        public void FinalizeTransaction() {
            CashDrawer.OpenDrawer();
            CashDrawer.Hundreds += HundredsCustomer - HundredsChange;
            CashDrawer.Fifties += FiftiesCustomer - FiftiesChange;
            CashDrawer.Twenties += TwentiesCustomer - TwentiesChange;
            CashDrawer.Tens += TensCustomer - TensChange;
            CashDrawer.Fives += FivesCustomer - FivesChange;
            CashDrawer.Twos += TwosCustomer - TwosChange;
            CashDrawer.Ones += OnesCustomer - OnesChange;
            CashDrawer.Dollars += DollarCoinsCustomer - DollarCoinsChange;
            CashDrawer.HalfDollars += HalfDollarsCustomer - HalfDollarsChange;
            CashDrawer.Quarters += QuartersCustomer - QuartersChange;
            CashDrawer.Dimes += DimesCustomer - DimesChange;
            CashDrawer.Nickels += NickelsCustomer - NickelsChange;
            CashDrawer.Pennies += PenniesCustomer - PenniesChange;
        }

        //These are all just private backing variables. You know what these do.
        private int hundredsCustomer;
        private int fiftiesCustomer;
        private int twentiesCustomer;
        private int tensCustomer;
        private int fivesCustomer;
        private int twosCustomer;
        private int onesCustomer;
        private int dollarCoinsCustomer;
        private int halfDollarsCustomer;
        private int quartersCustomer;
        private int dimesCustomer;
        private int nickelsCustomer;
        private int penniesCustomer;

        private int hundredsChange;
        private int fiftiesChange;
        private int twentiesChange;
        private int tensChange;
        private int fivesChange;
        private int twosChange;
        private int onesChange;
        private int dollarCoinsChange;
        private int halfDollarsChange;
        private int quartersChange;
        private int dimesChange;
        private int nickelsChange;
        private int penniesChange;

        private double total = 0;
    }
}