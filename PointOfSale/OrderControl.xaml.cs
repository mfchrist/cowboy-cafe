using CowboyCafe.Data;
using System;
using System.Collections.Generic;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            // <summary>
            // Initialize all buttons with an event handler.
            // </summary>
            InitializeComponent();

            // Control Buttons
            ItemSelectionButton.Click += ItemSelectionButton_Click;
            CancelOrderButton.Click += CancelOrderButton_Click;
            CompleteOrderButton.Click += CompleteOrderButton_Click;

            // Create new order
            DataContext = new Order();

        }



        // <summary>
        // Complete current order.
        // </summary>
        private void CompleteOrderButton_Click(object sender, RoutedEventArgs e)
        {
            //this.DataContext = new Order();
            Container.Child = new TransactionControl();
            ItemSelectionButton.IsEnabled = false;
            CompleteOrderButton.IsEnabled = false;
        }

        // <summary>
        // Cancel current order.
        // </summary>
        public void CancelOrderButton_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
            Container.Child = new MenuItemSelectionControl();
            ItemSelectionButton.IsEnabled = true;
            CompleteOrderButton.IsEnabled = true;

        }
        // <summary>
        // Begin item selection.
        // </summary>
        private void ItemSelectionButton_Click(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }

        public void SwapScreen(FrameworkElement element)
        {
            Container.Child = element;
        }



    }
}
