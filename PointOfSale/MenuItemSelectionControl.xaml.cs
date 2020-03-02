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
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        /// <summary>
        /// All the buttons for adding an item.
        /// </summary>
        public MenuItemSelectionControl()
        {
            // <summary>
            // Initialize all buttons with an event handler.
            // </summary>
            InitializeComponent();

            // Entrees
            AddCowpokeChili.Click += AddCowpokeChili_Click;
            AddRustlerRibs.Click += AddRustlerRibs_Click;
            AddPecosPulledPork.Click += AddPecosPulledPork_Click;
            AddTrailBurger.Click += AddTrailBurger_Click;
            AddDakotaDoubleBurger.Click += AddDakotaDoubleBurger_Click;
            AddTexasTripleBurger.Click += AddTexasTripleBurger_Click;
            AddAngryChickenButton.Click += AddAngryChicken_Click;

            // Sides
            AddChiliCheeseFries.Click += AddChiliCheeseFries_Click;
            AddCornDodgers.Click += AddCornDodgers_Click;
            AddPanDeCampo.Click += AddPanDeCampo_Click;
            AddBakedBeans.Click += AddBakedBeans_Click;

            // Drinks
            AddJerkedSoda.Click += AddJerkedSoda_Click;
            AddTexasTea.Click += AddTexasTea_Click;
            AddCowboyCoffe.Click += AddCowboyCoffe_Click;
            AddWater.Click += AddWater_Click;
        }

        /// <summary>
        /// All the functionality for the event handlers declared above is created in the code below.
        /// </summary>

        /// Drinks
        private void AddWater_Click(object sender, RoutedEventArgs e)
        {
            Water temp = new Water();
            OrderList.Items.Add(temp);
            SummaryColumn.PriceList.Items.Add(temp.Price);
            foreach (string s in temp.SpecialInstructions)
            {
                SummaryColumn.OrderList.Items.Add("  " + s);
                SummaryColumn.PriceList.Items.Add("");
            }
        }

        private void AddCowboyCoffe_Click(object sender, RoutedEventArgs e)
        {
            CowboyCoffee temp = new CowboyCoffee();
            SummaryColumn.OrderList.Items.Add(temp);
            SummaryColumn.PriceList.Items.Add(temp.Price);
            foreach (string s in temp.SpecialInstructions)
            {
                SummaryColumn.OrderList.Items.Add("  " + s);
                SummaryColumn.PriceList.Items.Add("");
            }
        }

        private void AddTexasTea_Click(object sender, RoutedEventArgs e)
        {
            TexasTea temp = new TexasTea();
            SummaryColumn.OrderList.Items.Add(temp);
            SummaryColumn.PriceList.Items.Add(temp.Price);
            foreach (string s in temp.SpecialInstructions)
            {
                SummaryColumn.OrderList.Items.Add("  " + s);
                SummaryColumn.PriceList.Items.Add("");
            }
        }

        private void AddJerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            JerkedSoda temp = new JerkedSoda();
            SummaryColumn.OrderList.Items.Add(temp);
            SummaryColumn.PriceList.Items.Add(temp.Price);
            foreach (string s in temp.SpecialInstructions)
            {
                SummaryColumn.OrderList.Items.Add("  " + s);
                SummaryColumn.PriceList.Items.Add("");
            }
        }

        /// Sides
        private void AddBakedBeans_Click(object sender, RoutedEventArgs e)
        {
            BakedBeans temp = new BakedBeans();
            SummaryColumn.OrderList.Items.Add(temp);
            SummaryColumn.PriceList.Items.Add(temp.Price);
            foreach (string s in temp.SpecialInstructions)
            {
                SummaryColumn.OrderList.Items.Add("  " + s);
                SummaryColumn.PriceList.Items.Add("");
            }
        }

        private void AddPanDeCampo_Click(object sender, RoutedEventArgs e)
        {
            PanDeCampo temp = new PanDeCampo();
            SummaryColumn.OrderList.Items.Add(temp);
            SummaryColumn.PriceList.Items.Add(temp.Price);
            foreach (string s in temp.SpecialInstructions)
            {
                SummaryColumn.OrderList.Items.Add("  " + s);
                SummaryColumn.PriceList.Items.Add("");
            }
        }

        private void AddCornDodgers_Click(object sender, RoutedEventArgs e)
        {
            CornDodgers temp = new CornDodgers();
            SummaryColumn.OrderList.Items.Add(temp);
            SummaryColumn.PriceList.Items.Add(temp.Price);
            foreach (string s in temp.SpecialInstructions)
            {
                SummaryColumn.OrderList.Items.Add("  " + s);
                SummaryColumn.PriceList.Items.Add("");
            }
        }

        private void AddChiliCheeseFries_Click(object sender, RoutedEventArgs e)
        {
            ChiliCheeseFries temp = new ChiliCheeseFries();
            SummaryColumn.OrderList.Items.Add(temp);
            SummaryColumn.PriceList.Items.Add(temp.Price);
            foreach (string s in temp.SpecialInstructions)
            {
                SummaryColumn.OrderList.Items.Add("  " + s);
                SummaryColumn.PriceList.Items.Add("");
            }
        }

        /// Entrees
        private void AddDakotaDoubleBurger_Click(object sender, RoutedEventArgs e)
        {
            DakotaDoubleBurger temp = new DakotaDoubleBurger();
            SummaryColumn.OrderList.Items.Add(temp);
            SummaryColumn.PriceList.Items.Add(temp.Price);
            foreach (string s in temp.SpecialInstructions)
            {
                SummaryColumn.OrderList.Items.Add("  " + s);
                SummaryColumn.PriceList.Items.Add("");
            }
        }

        private void AddTrailBurger_Click(object sender, RoutedEventArgs e)
        {
            TrailBurger temp = new TrailBurger();
            SummaryColumn.OrderList.Items.Add(temp);
            SummaryColumn.PriceList.Items.Add(temp.Price);
            foreach (string s in temp.SpecialInstructions)
            {
                SummaryColumn.OrderList.Items.Add("  " + s);
                SummaryColumn.PriceList.Items.Add("");
            }
        }

        private void AddRustlerRibs_Click(object sender, RoutedEventArgs e)
        {
            RustlersRibs temp = new RustlersRibs();
            SummaryColumn.OrderList.Items.Add(temp);
            SummaryColumn.PriceList.Items.Add(temp.Price);
            foreach (string s in temp.SpecialInstructions)
            {
                SummaryColumn.OrderList.Items.Add("  " + s);
                SummaryColumn.PriceList.Items.Add("");
            }
        }

        private void AddTexasTripleBurger_Click(object sender, RoutedEventArgs e)
        {
            TexasTripleBurger temp = new TexasTripleBurger();
            SummaryColumn.OrderList.Items.Add(temp);
            SummaryColumn.PriceList.Items.Add(temp.Price);
            foreach (string s in temp.SpecialInstructions)
            {
                SummaryColumn.OrderList.Items.Add("  " + s);
                SummaryColumn.PriceList.Items.Add("");
            }
        }

        private void AddPecosPulledPork_Click(object sender, RoutedEventArgs e)
        {
            PecosPulledPork temp = new PecosPulledPork();
            SummaryColumn.OrderList.Items.Add(temp);
            SummaryColumn.PriceList.Items.Add(temp.Price);
            foreach (string s in temp.SpecialInstructions)
            {
                SummaryColumn.OrderList.Items.Add("  " + s);
                SummaryColumn.PriceList.Items.Add("");
            }
        }

        private void AddCowpokeChili_Click(object sender, RoutedEventArgs e)
        {
            CowpokeChili temp = new CowpokeChili();
            SummaryColumn.OrderList.Items.Add(temp);
            SummaryColumn.PriceList.Items.Add(temp.Price);
            foreach (string s in temp.SpecialInstructions)
            {
                SummaryColumn.OrderList.Items.Add("  " + s);
                SummaryColumn.PriceList.Items.Add("");
            }
        }

        private void AddAngryChicken_Click(object sender, RoutedEventArgs e)
        {
            AngryChicken temp = new AngryChicken();
            SummaryColumn.OrderList.Items.Add(temp);
            SummaryColumn.PriceList.Items.Add(temp.Price);
            foreach (string s in temp.SpecialInstructions)
            {
                SummaryColumn.OrderList.Items.Add("  " + s);
                SummaryColumn.PriceList.Items.Add("");
            }
        }
    }
}
