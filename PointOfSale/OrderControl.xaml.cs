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

            DataContext = new Order();

            /*
            AddCowpokeChili.IsEnabled = false;
            AddRustlerRibs.IsEnabled = false;
            AddPecosPulledPork.IsEnabled = false;
            AddTrailBurger.IsEnabled = false;
            AddDakotaDoubleBurger.IsEnabled = false;
            AddTexasTripleBurger.IsEnabled = false;
            AddAngryChickenButton.IsEnabled = false;

            AddChiliCheeseFries.IsEnabled = false;
            AddCornDodgers.IsEnabled = false;
            AddPanDeCampo.IsEnabled = false;
            AddBakedBeans.IsEnabled = false;

            AddJerkedSoda.IsEnabled = false;
            AddTexasTea.IsEnabled = false;
            AddCowboyCoffe.IsEnabled = false;
            AddWater.IsEnabled = false;
            */
        }

        private void CompleteOrderButton_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
            /*           
            AddCowpokeChili.IsEnabled = false;
            AddRustlerRibs.IsEnabled = false;
            AddPecosPulledPork.IsEnabled = false;
            AddTrailBurger.IsEnabled = false;
            AddDakotaDoubleBurger.IsEnabled = false;
            AddTexasTripleBurger.IsEnabled = false;
            AddAngryChickenButton.IsEnabled = false;

            AddChiliCheeseFries.IsEnabled = false;
            AddCornDodgers.IsEnabled = false;
            AddPanDeCampo.IsEnabled = false;
            AddBakedBeans.IsEnabled = false;

            AddJerkedSoda.IsEnabled = false;
            AddTexasTea.IsEnabled = false;
            AddCowboyCoffe.IsEnabled = false;
            AddWater.IsEnabled = false;
            
            

            double total = 0;

            foreach(double x in SummaryColumn.PriceList.Items)
            {
                total += x;
            }
           
            SummaryColumn.SubtotalPrice.Text = total.ToString();

            ItemSelectionButton.IsEnabled = true;
            CompleteOrderButton.IsEnabled = false;
            CancelOrderButton.IsEnabled = false;
             */

        }

        private void CancelOrderButton_Click(object sender, RoutedEventArgs e)
        {
            /*
            SummaryColumn.OrderList.Items.Clear();
            SummaryColumn.PriceList.Items.Clear();
            
            AddCowpokeChili.IsEnabled = false;
            AddRustlerRibs.IsEnabled = false;
            AddPecosPulledPork.IsEnabled = false;
            AddTrailBurger.IsEnabled = false;
            AddDakotaDoubleBurger.IsEnabled = false;
            AddTexasTripleBurger.IsEnabled = false;
            AddAngryChickenButton.IsEnabled = false;

            AddChiliCheeseFries.IsEnabled = false;
            AddCornDodgers.IsEnabled = false;
            AddPanDeCampo.IsEnabled = false;
            AddBakedBeans.IsEnabled = false;

            AddJerkedSoda.IsEnabled = false;
            AddTexasTea.IsEnabled = false;
            AddCowboyCoffe.IsEnabled = false;
            AddWater.IsEnabled = false;

            ItemSelectionButton.IsEnabled = true;
            CompleteOrderButton.IsEnabled = false;
            CancelOrderButton.IsEnabled = false;
            */
        }

        private void ItemSelectionButton_Click(object sender, RoutedEventArgs e)
        {
            /*
            SummaryColumn.OrderList.Items.Clear();
            SummaryColumn.PriceList.Items.Clear();
            SummaryColumn.SubtotalPrice.Text = "";
            
            AddCowpokeChili.IsEnabled = true;
            AddRustlerRibs.IsEnabled = true;
            AddPecosPulledPork.IsEnabled = true;
            AddTrailBurger.IsEnabled = true;
            AddDakotaDoubleBurger.IsEnabled = true;
            AddTexasTripleBurger.IsEnabled = true;
            AddAngryChickenButton.IsEnabled = true;

            AddChiliCheeseFries.IsEnabled = true;
            AddCornDodgers.IsEnabled = true;
            AddPanDeCampo.IsEnabled = true;
            AddBakedBeans.IsEnabled = true;

            AddJerkedSoda.IsEnabled = true;
            AddTexasTea.IsEnabled = true;
            AddCowboyCoffe.IsEnabled = true;
            AddWater.IsEnabled = true;

            ItemSelectionButton.IsEnabled = false;
            CompleteOrderButton.IsEnabled = true;
            CancelOrderButton.IsEnabled = true;
            */
        }



    }
}
