using System;
using System.Windows;
using System.Windows.Controls;
using CowboyCafe.Data;
using CashRegister;
using CowboyCafe.PointOfSale.ExtensionMethods;
using CowboyCafe.PointOfSale;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public TransactionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create a cash drawer instance that will not change
        /// </summary>
        //public static CashDrawer CowBoyCashDrawer = new CashDrawer();

        private double ammountToPay = 0;

        public double AmmountToPay
        {
            get
            {
                return ammountToPay;
            }

            set
            {
                ammountToPay = ammountToPay - CashEntered;
            }
            
        }

        public double CashEntered
        {
            get { return 0; }
        }


    /// <summary>
    /// Event handler for pay with card button
    /// </summary>
    /// <param name="sender">sender</param>
    /// <param name="e">e</param>
    public void PayWithCard(object sender, RoutedEventArgs e)
        {
            CardTerminal terminal = new CardTerminal();

            var result = terminal.ProcessTransaction((Convert.ToDouble(TotalValue.Text)));


            if(result == ResultCode.Success)
            {
                PrintReciept(true);
                var orderControl = this.FindAncestor<OrderControl>();
                FrameworkElement screen = new MenuItemSelectionControl();
                orderControl.SwapScreen(screen);
                orderControl.CancelOrderButton_Click(this, e);
                      
            }
            else if(result == ResultCode.CancelledCard)
            {
                ErrorCodeDisplay.Text = "Card Canceled \nPlease try a different payment method";
            }
            else if (result == ResultCode.InsufficentFunds)
            {               
                ErrorCodeDisplay.Text = "Insufficent Funds on Card\nPlease try a different payment method";
            }
            else if (result == ResultCode.ReadError)
            {
                ErrorCodeDisplay.Text = "Card Read Error \nPlease try a different payment method";
            }
            else if (result == ResultCode.UnknownErrror)
            {
                ErrorCodeDisplay.Text = "Unknown Error \nPlease try a different payment method";
            }



        }

        /// <summary>
        /// Event handler for pay with cash button
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        public void PayWithCash(object sender, RoutedEventArgs e)
        {            
            //PrintReciept(false);

            var orderControl = this.FindAncestor<OrderControl>();
            FrameworkElement screen = new CashRegisterControl();
            orderControl.SwapScreen(screen);
           // orderControl.CancelOrderButton_Click(this, e);

            //var orderControl = this.FindAncestor<OrderControl>();
            //FrameworkElement screen = new MenuItemSelectionControl();
            //orderControl.SwapScreen(screen);
            //orderControl.CancelOrderButton_Click(this, e);
            
        }

        /// <summary>
        /// Prints reciept. 
        /// </summary>
        /// <param name="card">When true, prints reciept for card. When false, prints receipt for cash</param>
        public void PrintReciept(bool card)
        {
            ReceiptPrinter printer = new ReceiptPrinter();
            DateTime now = DateTime.Now;

            if (DataContext is Order order)
            {
                //time, date, and order number
                printer.Print("Order Number:\t" + Order.OrderNumber.ToString());
                printer.Print("\n");
                printer.Print(now.ToString());
                printer.Print("\n\n");

                //each item
                foreach (IOrderItem item in order.Items)
                {
                    printer.Print(item.ToString());
                    printer.Print("\t");
                    printer.Print(item.Price.ToString());
                    printer.Print("\n");
                    int length = item.SpecialInstructions.Count;
                    if (length > 0)
                    {


                        for (int i = 0; i < length; i++)
                        {
                            printer.Print("\t"+item.SpecialInstructions[i]);
                            printer.Print("\n");
                        }
                    }
                }


                //price
                printer.Print("\n");
                printer.Print("Subtotal: \t");
                printer.Print(order.Subtotal.ToString());
                printer.Print("\n");
                printer.Print("Total: \t");
                printer.Print(order.Total.ToString());
                printer.Print("\n");

                if (card)
                {
                    printer.Print("Payment Method:  Credit");
                }
                else
                {
                    printer.Print("Payment Method:  Cash");
                }

                printer.Print("\n\n\n");

            }
            
        }
    }
}
