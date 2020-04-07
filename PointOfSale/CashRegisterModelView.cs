using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CashRegister;
using CowboyCafe.Data;
using CowboyCafe.PointOfSale;

namespace PointOfSale
{
    /// <summary>
    /// Modelview for Cash Register
    /// </summary>
    public class CashRegisterModelView
    {
        /// <summary>
        /// Notifies of property chnaged events
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// CashDrawer used by class
        /// </summary>
        public static CashDrawer drawer = new CashDrawer();

        /// <summary>
        /// total currency in drawer
        /// </summary>
        public double TotalValue => CashRegisterModelView.drawer.TotalValue;


        /// <summary>
        /// Pennies in drawer
        /// </summary>
        private int pennies = 0;
        public int Pennies
        {
            get => pennies;

            set
            {
                if (pennies == value || value < 0) return;
                var quantity = value - pennies;
                if (quantity > 0) CashRegisterModelView.drawer.AddCoin(Coins.Penny, quantity);
                else CashRegisterModelView.drawer.RemoveCoin(Coins.Penny, -quantity);
                InvokePropertyChanged("Pennies");

            }
        }

        /// <summary>
        /// Nickels in drawer
        /// </summary>
        public int Nickels
        {
            get => CashRegisterModelView.drawer.Nickels;

            set
            {
                if (CashRegisterModelView.drawer.Nickels == value || value < 0) return;
                var quantity = value - CashRegisterModelView.drawer.Nickels;
                if (quantity > 0) CashRegisterModelView.drawer.AddCoin(Coins.Nickel, quantity);
                else CashRegisterModelView.drawer.RemoveCoin(Coins.Nickel, -quantity);
                InvokePropertyChanged("Nickels");

            }
        }

        /// <summary>
        /// Dimes in drawer
        /// </summary>
        public int Dimes
        {
            get => CashRegisterModelView.drawer.Dimes;

            set
            {
                if (CashRegisterModelView.drawer.Dimes == value || value < 0) return;
                var quantity = value - CashRegisterModelView.drawer.Dimes;
                if (quantity > 0) CashRegisterModelView.drawer.AddCoin(Coins.Dime, quantity);
                else CashRegisterModelView.drawer.RemoveCoin(Coins.Dime, -quantity);
                InvokePropertyChanged("Dimes");

            }
        }

        /// <summary>
        /// Quarters in drawer
        /// </summary>
        public int Quarters
        {
            get => CashRegisterModelView.drawer.Quarters;

            set
            {
                if (CashRegisterModelView.drawer.Quarters == value || value < 0) return;
                var quantity = value - CashRegisterModelView.drawer.Quarters;
                if (quantity > 0) CashRegisterModelView.drawer.AddCoin(Coins.Quarter, quantity);
                else CashRegisterModelView.drawer.RemoveCoin(Coins.Quarter, -quantity);
                InvokePropertyChanged("Quarters");

            }
        }

        /// <summary>
        /// HalfDollars in drawer
        /// </summary>
        public int HalfDollars
        {
            get => CashRegisterModelView.drawer.HalfDollars;

            set
            {
                if (CashRegisterModelView.drawer.HalfDollars == value || value < 0) return;
                var quantity = value - CashRegisterModelView.drawer.HalfDollars;
                if (quantity > 0) CashRegisterModelView.drawer.AddCoin(Coins.HalfDollar, quantity);
                else CashRegisterModelView.drawer.RemoveCoin(Coins.HalfDollar, -quantity);
                InvokePropertyChanged("HalfDollars");

            }
        }

        /// <summary>
        /// Dollars in drawer
        /// </summary>
        public int Dollars
        {
            get => CashRegisterModelView.drawer.Dollars;

            set
            {
                if (CashRegisterModelView.drawer.Dollars == value || value < 0) return;
                var quantity = value - CashRegisterModelView.drawer.Dollars;
                if (quantity > 0) CashRegisterModelView.drawer.AddCoin(Coins.Dollar, quantity);
                else CashRegisterModelView.drawer.RemoveCoin(Coins.Dollar, -quantity);
                InvokePropertyChanged("Dollars");
            }
        }

        /// <summary>
        /// Ones in drawer
        /// </summary>
        public int Ones
        {
            get => CashRegisterModelView.drawer.Ones;

            set
            {
                if (CashRegisterModelView.drawer.Ones == value || value < 0) return;
                var quantity = value - CashRegisterModelView.drawer.Ones;
                if (quantity > 0) CashRegisterModelView.drawer.AddBill(Bills.One, quantity);
                else CashRegisterModelView.drawer.RemoveBill(Bills.One, -quantity);
                InvokePropertyChanged("Ones");
            }
        }

        /// <summary>
        /// Twos in drawer
        /// </summary>
        public int Twos
        {
            get => CashRegisterModelView.drawer.Twos;

            set
            {
                if (CashRegisterModelView.drawer.Twos == value || value < 0) return;
                var quantity = value - CashRegisterModelView.drawer.Twos;
                if (quantity > 0) CashRegisterModelView.drawer.AddBill(Bills.Two, quantity);
                else CashRegisterModelView.drawer.RemoveBill(Bills.Two, -quantity);
                InvokePropertyChanged("Twos");
            }
        }

        /// <summary>
        /// Fives in drawer
        /// </summary>
        public int Fives
        {
            get => CashRegisterModelView.drawer.Fives;

            set
            {
                if (CashRegisterModelView.drawer.Fives == value || value < 0) return;
                var quantity = value - CashRegisterModelView.drawer.Fives;
                if (quantity > 0) CashRegisterModelView.drawer.AddBill(Bills.Five, quantity);
                else CashRegisterModelView.drawer.RemoveBill(Bills.Five, -quantity);
                InvokePropertyChanged("Fives");
            }
        }

        /// <summary>
        /// Tens in drawer
        /// </summary>
        public int Tens
        {
            get => CashRegisterModelView.drawer.Tens;

            set
            {
                if (CashRegisterModelView.drawer.Tens == value || value < 0) return;
                var quantity = value - CashRegisterModelView.drawer.Tens;
                if (quantity > 0) CashRegisterModelView.drawer.AddBill(Bills.Ten, quantity);
                else CashRegisterModelView.drawer.RemoveBill(Bills.Ten, -quantity);
                InvokePropertyChanged("Tens");
            }
        }

        /// <summary>
        /// Twenties in drawer
        /// </summary>
        public int Twenties
        {
            get => CashRegisterModelView.drawer.Twenties;

            set
            {
                if (CashRegisterModelView.drawer.Twenties == value || value < 0) return;
                var quantity = value - CashRegisterModelView.drawer.Twenties;
                if (quantity > 0) CashRegisterModelView.drawer.AddBill(Bills.Twenty, quantity);
                else CashRegisterModelView.drawer.RemoveBill(Bills.Twenty, -quantity);
                InvokePropertyChanged("Twenties");
            }
        }

        /// <summary>
        /// Fifties in drawer
        /// </summary>
        public int Fifties
        {
            get => CashRegisterModelView.drawer.Fifties;

            set
            {
                if (CashRegisterModelView.drawer.Fifties == value || value < 0) return;
                var quantity = value - CashRegisterModelView.drawer.Fifties;
                if (quantity > 0) CashRegisterModelView.drawer.AddBill(Bills.Fifty, quantity);
                else CashRegisterModelView.drawer.RemoveBill(Bills.Fifty, -quantity);
                InvokePropertyChanged("Fifties");
            }
        }

        /// <summary>
        /// Hundreds in drawer
        /// </summary>
        public int Hundreds
        {
            get => CashRegisterModelView.drawer.Hundreds;

            set
            {
                if (CashRegisterModelView.drawer.Hundreds == value || value < 0) return;
                var quantity = value - CashRegisterModelView.drawer.Hundreds;
                if (quantity > 0) CashRegisterModelView.drawer.AddBill(Bills.Hundred, quantity);
                else CashRegisterModelView.drawer.RemoveBill(Bills.Hundred, -quantity);
                InvokePropertyChanged("Hundreds");
                

            }
        }

        /// <summary>
        /// Helper method for triggering PropertyChanged Events
        /// </summary>
        /// <param name="denomination"></param>
        void InvokePropertyChanged(string denomination)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(denomination));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
        }

        public static double CalculateCashEntered()
        {

            //double coins = Pennies * 0.1 + Nickels * 0.05 + Dimes * 0.1 + Quarters * 0.25 + HalfDollars * 50 + Dollars * 1;
            //double bills = Ones * 1 + Twos * 2 + Fives * 5 + Tens * 10 + Twenties * 20 + Fifties * 50 + Hundreds * 100;

            double coins = drawer.Pennies * 0.1 + drawer.Nickels * 0.05 + drawer.Dimes * 0.1 + drawer.Quarters * 0.25 + drawer.HalfDollars * 50 + drawer.Dollars * 1;
            double bills = drawer.Ones * 1 + drawer.Twos * 2 + drawer.Fives * 5 + drawer.Tens * 10 + drawer.Twenties * 20 + drawer.Fifties * 50 + drawer.Hundreds * 100;

            return (coins + bills);

        }

        double y = CalculateCashEntered();





    }
}
