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
using PointOfSale.CustomizationScreens;
using CowboyCafe.PointOfSale.ExtensionMethods;

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

        /// <summary>
        /// Add water button event handler
        /// </summary>
        private void AddWater_Click(object sender, RoutedEventArgs e)
        {
            Water temp = new Water();
            if(DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        /// <summary>
        /// Add coffee button event handler
        /// </summary>
        private void AddCowboyCoffe_Click(object sender, RoutedEventArgs e)
        {
            CowboyCoffee temp = new CowboyCoffee();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        /// <summary>
        /// Add tea button event handler
        /// </summary>
        private void AddTexasTea_Click(object sender, RoutedEventArgs e)
        {
            TexasTea temp = new TexasTea();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        /// <summary>
        /// Add soda button event handler
        /// </summary>
        private void AddJerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            JerkedSoda temp = new JerkedSoda();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        /// Sides
        
        /// <summary>
        /// Add beans button event handler
        /// </summary>
        private void AddBakedBeans_Click(object sender, RoutedEventArgs e)
        {
            BakedBeans temp = new BakedBeans();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        /// <summary>
        /// Add pan de campo button event handler
        /// </summary>
        private void AddPanDeCampo_Click(object sender, RoutedEventArgs e)
        {
            PanDeCampo temp = new PanDeCampo();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        /// <summary>
        /// Add corn dodgers button event handler
        /// </summary>
        private void AddCornDodgers_Click(object sender, RoutedEventArgs e)
        {
            CornDodgers temp = new CornDodgers();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        /// <summary>
        /// Add chili button event handler
        /// </summary>
        private void AddChiliCheeseFries_Click(object sender, RoutedEventArgs e)
        {
            ChiliCheeseFries temp = new ChiliCheeseFries();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        /// Entrees

        /// <summary>
        /// Add double burger button event handler
        /// </summary>
        private void AddDakotaDoubleBurger_Click(object sender, RoutedEventArgs e)
        {
            DakotaDoubleBurger temp = new DakotaDoubleBurger();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        /// <summary>
        /// Add trailburger button event handler
        /// </summary>
        private void AddTrailBurger_Click(object sender, RoutedEventArgs e)
        {
            TrailBurger temp = new TrailBurger();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        /// <summary>
        /// Add ribs button event handler
        /// </summary>
        private void AddRustlerRibs_Click(object sender, RoutedEventArgs e)
        {
            RustlersRibs temp = new RustlersRibs();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        /// <summary>
        /// Add triple burger button event handler
        /// </summary>
        private void AddTexasTripleBurger_Click(object sender, RoutedEventArgs e)
        {
            TexasTripleBurger temp = new TexasTripleBurger();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        /// <summary>
        /// Add pulled pork button event handler
        /// </summary>
        private void AddPecosPulledPork_Click(object sender, RoutedEventArgs e)
        {
            PecosPulledPork temp = new PecosPulledPork();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        /// <summary>
        /// Add chili button event handler
        /// </summary>
        private void AddCowpokeChili_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            CowpokeChili temp = new CowpokeChili();
            if (DataContext is Order order)
            {
                var screen = new CowpokeChiliCustomization();
                screen.DataContext = temp;
                order.Add(temp);
                orderControl?.SwapScreen(screen);
                
            }
        }

        /// <summary>
        /// Add chicken button event handler
        /// </summary>
        private void AddAngryChicken_Click(object sender, RoutedEventArgs e)
        {
            AngryChicken temp = new AngryChicken();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }
    }
}
