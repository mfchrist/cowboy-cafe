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
            OrderList.Items.Add(new Water());
        }

        private void AddCowboyCoffe_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new CowboyCoffee());
        }

        private void AddTexasTea_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new TexasTea());
        }

        private void AddJerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new JerkedSoda());
        }

        /// Sides
        private void AddBakedBeans_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new BakedBeans());
        }

        private void AddPanDeCampo_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new PanDeCampo());
        }

        private void AddCornDodgers_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new CornDodgers());
        }

        private void AddChiliCheeseFries_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new ChiliCheeseFries());
        }

        /// Entrees
        private void AddDakotaDoubleBurger_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new DakotaDoubleBurger());
        }

        private void AddTrailBurger_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new TrailBurger());
        }

        private void AddRustlerRibs_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new RustlersRibs());
        }

        private void AddTexasTripleBurger_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new TexasTripleBurger());
        }

        private void AddPecosPulledPork_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new PecosPulledPork());
        }

        private void AddCowpokeChili_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new CowpokeChili());
        }

        private void AddAngryChicken_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new AngryChicken());
        }

    }
}
