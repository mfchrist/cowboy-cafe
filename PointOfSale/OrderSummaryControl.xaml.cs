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
using CowboyCafe.Data;
using CowboyCafe.PointOfSale.ExtensionMethods;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the red x button next to each item in the order sumamry control. Removes that item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveItemButton(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if(DataContext is Order order)
            {
                var button = sender as Button;
                order.Remove(button.DataContext as IOrderItem);
            }

        }

        void ChangeItem(object sender, SelectionChangedEventArgs args)
        {
            ListBoxItem lbi = ((sender as ListBox).SelectedItem as ListBoxItem);
            /*
            if(lbi.GetValue() == typeof(PanDeCampo))
            {
                System.Environment.Exit(0);
            }
            
            if (lbi. != null && lbi.Content.ToString().Contains("Pan de Campo"))
            {
                System.Environment.Exit(0);
            }

            
            if (lbi.DataContext == typeof(PanDeCampo))
            {
                System.Environment.Exit(0);
            }
            */

            if (OrderList.SelectedItem.ToString().Contains("Pan de Campo"))
            {
                System.Environment.Exit(0);
            }

        }

    }
}
