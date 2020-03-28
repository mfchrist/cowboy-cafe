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
using PointOfSale.CustomizationScreens;



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

        private void ChangeItem(object sender, SelectionChangedEventArgs args)
        {
            
                        
            if (OrderList.SelectedItem != null && OrderList.SelectedItem.ToString().Contains("Pan de Campo"))
            {
                PanDeCampo firstItem = args.AddedItems[0] as PanDeCampo;              
                var orderControl = this.FindAncestor<OrderControl>();
                if (DataContext is Order order1)
                {
                    var screen = new PanDeCampoCustomization();
                    screen.DataContext = firstItem;                   
                    orderControl?.SwapScreen(screen);
                    
                }
                
            }
            
        }

    }
}
