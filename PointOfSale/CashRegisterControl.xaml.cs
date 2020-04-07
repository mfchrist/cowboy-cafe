using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CashRegister;
using CowboyCafe.Data;
using CowboyCafe.PointOfSale;
using CowboyCafe.PointOfSale.ExtensionMethods;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashDrawerControl.xaml
    /// </summary>
    public partial class CashRegisterControl : UserControl
    {
        /// <summary>
        /// Notifies of property chnaged events
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Initialize
        /// </summary>
        public CashRegisterControl()
        {
            InitializeComponent();
        }

        public void FinalizePayment(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            FrameworkElement screen = new MenuItemSelectionControl();
            orderControl.SwapScreen(screen);
            orderControl.CancelOrderButton_Click(this, e);
        }

        /// <summary>
        /// CashDrawer used by class
        /// </summary>
        public static CashDrawer drawer = new CashDrawer();

        /// <summary>
        /// total currency in drawer
        /// </summary>
        //public double TotalValue => CashRegisterControl.drawer.TotalValue;


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
                if (quantity > 0) CashRegisterControl.drawer.AddCoin(Coins.Penny, quantity);
                else CashRegisterControl.drawer.RemoveCoin(Coins.Penny, -quantity);
                InvokePropertyChanged("Pennies");

            }
        }

        /// <summary>
        /// Nickels in drawer
        /// </summary>
        public int Nickels
        {
            get => CashRegisterControl.drawer.Nickels;

            set
            {
                if (CashRegisterControl.drawer.Nickels == value || value < 0) return;
                var quantity = value - CashRegisterControl.drawer.Nickels;
                if (quantity > 0) CashRegisterControl.drawer.AddCoin(Coins.Nickel, quantity);
                else CashRegisterControl.drawer.RemoveCoin(Coins.Nickel, -quantity);
                InvokePropertyChanged("Nickels");

            }
        }

        /// <summary>
        /// Dimes in drawer
        /// </summary>
        public int Dimes
        {
            get => CashRegisterControl.drawer.Dimes;

            set
            {
                if (CashRegisterControl.drawer.Dimes == value || value < 0) return;
                var quantity = value - CashRegisterControl.drawer.Dimes;
                if (quantity > 0) CashRegisterControl.drawer.AddCoin(Coins.Dime, quantity);
                else CashRegisterControl.drawer.RemoveCoin(Coins.Dime, -quantity);
                InvokePropertyChanged("Dimes");

            }
        }

        /// <summary>
        /// Quarters in drawer
        /// </summary>
        public int Quarters
        {
            get => CashRegisterControl.drawer.Quarters;

            set
            {
                if (CashRegisterControl.drawer.Quarters == value || value < 0) return;
                var quantity = value - CashRegisterControl.drawer.Quarters;
                if (quantity > 0) CashRegisterControl.drawer.AddCoin(Coins.Quarter, quantity);
                else CashRegisterControl.drawer.RemoveCoin(Coins.Quarter, -quantity);
                InvokePropertyChanged("Quarters");

            }
        }

        /// <summary>
        /// HalfDollars in drawer
        /// </summary>
        public int HalfDollars
        {
            get => CashRegisterControl.drawer.HalfDollars;

            set
            {
                if (CashRegisterControl.drawer.HalfDollars == value || value < 0) return;
                var quantity = value - CashRegisterControl.drawer.HalfDollars;
                if (quantity > 0) CashRegisterControl.drawer.AddCoin(Coins.HalfDollar, quantity);
                else CashRegisterControl.drawer.RemoveCoin(Coins.HalfDollar, -quantity);
                InvokePropertyChanged("HalfDollars");

            }
        }

        /// <summary>
        /// Dollars in drawer
        /// </summary>
        public int Dollars
        {
            get => CashRegisterControl.drawer.Dollars;

            set
            {
                if (CashRegisterControl.drawer.Dollars == value || value < 0) return;
                var quantity = value - CashRegisterControl.drawer.Dollars;
                if (quantity > 0) CashRegisterControl.drawer.AddCoin(Coins.Dollar, quantity);
                else CashRegisterControl.drawer.RemoveCoin(Coins.Dollar, -quantity);
                InvokePropertyChanged("Dollars");
            }
        }

        /// <summary>
        /// Ones in drawer
        /// </summary>
        public int Ones
        {
            get => CashRegisterControl.drawer.Ones;

            set
            {
                if (CashRegisterControl.drawer.Ones == value || value < 0) return;
                var quantity = value - CashRegisterControl.drawer.Ones;
                if (quantity > 0) CashRegisterControl.drawer.AddBill(Bills.One, quantity);
                else CashRegisterControl.drawer.RemoveBill(Bills.One, -quantity);
                InvokePropertyChanged("Ones");
            }
        }

        /// <summary>
        /// Twos in drawer
        /// </summary>
        public int Twos
        {
            get => CashRegisterControl.drawer.Twos;

            set
            {
                if (CashRegisterControl.drawer.Twos == value || value < 0) return;
                var quantity = value - CashRegisterControl.drawer.Twos;
                if (quantity > 0) CashRegisterControl.drawer.AddBill(Bills.Two, quantity);
                else CashRegisterControl.drawer.RemoveBill(Bills.Two, -quantity);
                InvokePropertyChanged("Twos");
            }
        }

        /// <summary>
        /// Fives in drawer
        /// </summary>
        public int Fives
        {
            get => CashRegisterControl.drawer.Fives;

            set
            {
                if (CashRegisterControl.drawer.Fives == value || value < 0) return;
                var quantity = value - CashRegisterControl.drawer.Fives;
                if (quantity > 0) CashRegisterControl.drawer.AddBill(Bills.Five, quantity);
                else CashRegisterControl.drawer.RemoveBill(Bills.Five, -quantity);
                InvokePropertyChanged("Fives");
            }
        }

        /// <summary>
        /// Tens in drawer
        /// </summary>
        public int Tens
        {
            get => CashRegisterControl.drawer.Tens;

            set
            {
                if (CashRegisterControl.drawer.Tens == value || value < 0) return;
                var quantity = value - CashRegisterControl.drawer.Tens;
                if (quantity > 0) CashRegisterControl.drawer.AddBill(Bills.Ten, quantity);
                else CashRegisterControl.drawer.RemoveBill(Bills.Ten, -quantity);
                InvokePropertyChanged("Tens");
            }
        }

        /// <summary>
        /// Twenties in drawer
        /// </summary>
        public int Twenties
        {
            get => CashRegisterControl.drawer.Twenties;

            set
            {
                if (CashRegisterControl.drawer.Twenties == value || value < 0) return;
                var quantity = value - CashRegisterControl.drawer.Twenties;
                if (quantity > 0) CashRegisterControl.drawer.AddBill(Bills.Twenty, quantity);
                else CashRegisterControl.drawer.RemoveBill(Bills.Twenty, -quantity);
                InvokePropertyChanged("Twenties");
            }
        }

        /// <summary>
        /// Fifties in drawer
        /// </summary>
        public int Fifties
        {
            get => CashRegisterControl.drawer.Fifties;

            set
            {
                if (CashRegisterControl.drawer.Fifties == value || value < 0) return;
                var quantity = value - CashRegisterControl.drawer.Fifties;
                if (quantity > 0) CashRegisterControl.drawer.AddBill(Bills.Fifty, quantity);
                else CashRegisterControl.drawer.RemoveBill(Bills.Fifty, -quantity);
                InvokePropertyChanged("Fifties");
            }
        }

        /// <summary>
        /// Hundreds in drawer
        /// </summary>
        public int Hundreds
        {
            get => CashRegisterControl.drawer.Hundreds;

            set
            {
                if (CashRegisterControl.drawer.Hundreds == value || value < 0) return;
                var quantity = value - CashRegisterControl.drawer.Hundreds;
                if (quantity > 0) CashRegisterControl.drawer.AddBill(Bills.Hundred, quantity);
                else CashRegisterControl.drawer.RemoveBill(Bills.Hundred, -quantity);
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

        /// <summary>
        /// Calculates the ammount of money still needed to be paid.
        /// </summary>
        public double AmmountToPay
        {
            get
            {
                /* What total are you trying to call?
                 * The one in Order
                 Then you need a reference to the order
                 like this? one sec
                 i tried this earlier, but the datacontext error was an issue i couldnt figure out
                 Data context is a control. I was under the assumption this had xaml attached. What initializes this class?
                 ohhh, nothing -- Thats where i have mine is in the xaml.cs class :P it happens we live and we learn
                 So I have to make an instance of this class somewhere? Or could I just put all this code in my CashRegisterControl.xaml.cs file?
                 that would explain the error from before, iot was complaining since nothing was ever initialized
                 thank you so much for the help, that was a lot to debug
                 you too!
                 Have a quality night. and no problem please reach out any time*/
                if (DataContext is Order order)
                {                   
                    return order.Total - CashEntered;                    
                }
                return 0;
            }

            set
            {
                if (DataContext is Order order)
                {
                    value = order.Total - CashEntered;
                    InvokePropertyChanged("AmmountToPay");
                }
                InvokePropertyChanged("AmmountToPay");
            }

        }
        
        /// <summary>
        /// Calculates Cash entered
        /// </summary>
        public double CashEntered
        {
            get { return CashRegisterControl.CalculateCashEntered(); }
        }

    }
}
