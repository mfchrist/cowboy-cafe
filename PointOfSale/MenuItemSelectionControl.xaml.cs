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
            var orderControl = this.FindAncestor<OrderControl>();

            Water temp = new Water();
            if (DataContext is Order order)
            {
                var screen = new WaterCustomization();
                screen.DataContext = temp;
                order.Add(temp);
                orderControl?.SwapScreen(screen);

            }
        }

        /// <summary>
        /// Add coffee button event handler
        /// </summary>
        private void AddCowboyCoffe_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            CowboyCoffee temp = new CowboyCoffee();
            if (DataContext is Order order)
            {
                var screen = new CowboyCoffeeCustomization();
                screen.DataContext = temp;
                order.Add(temp);
                orderControl?.SwapScreen(screen);

            }
        }

        /// <summary>
        /// Add tea button event handler
        /// </summary>
        private void AddTexasTea_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            TexasTea temp = new TexasTea();
            if (DataContext is Order order)
            {
                var screen = new TexasTeaCustomization();
                screen.DataContext = temp;
                order.Add(temp);
                orderControl?.SwapScreen(screen);

            }
        }

        /// <summary>
        /// Add soda button event handler
        /// </summary>
        private void AddJerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            JerkedSoda temp = new JerkedSoda();
            if (DataContext is Order order)
            {
                var screen = new JerkedSodaCustomization();
                screen.DataContext = temp;
                order.Add(temp);
                orderControl?.SwapScreen(screen);

            }
        }

        /// Sides
        
        /// <summary>
        /// Add beans button event handler
        /// </summary>
        private void AddBakedBeans_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            BakedBeans temp = new BakedBeans();
            if (DataContext is Order order)
            {
                var screen = new BakedBeansCustomization();
                screen.DataContext = temp;
                order.Add(temp);
                orderControl?.SwapScreen(screen);

            }
        }

        /// <summary>
        /// Add pan de campo button event handler
        /// </summary>
        private void AddPanDeCampo_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            PanDeCampo temp = new PanDeCampo();
            if (DataContext is Order order)
            {
                var screen = new PanDeCampoCustomization();
                screen.DataContext = temp;
                order.Add(temp);
                orderControl?.SwapScreen(screen);

            }
        }

        /// <summary>
        /// Add corn dodgers button event handler
        /// </summary>
        private void AddCornDodgers_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            CornDodgers temp = new CornDodgers();
            if (DataContext is Order order)
            {
                var screen = new CornDodgersCustomization();
                screen.DataContext = temp;
                order.Add(temp);
                orderControl?.SwapScreen(screen);

            }
        }

        /// <summary>
        /// Add chili button event handler
        /// </summary>
        private void AddChiliCheeseFries_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            ChiliCheeseFries temp = new ChiliCheeseFries();
            if (DataContext is Order order)
            {
                var screen = new ChiliCheeseFriesCustomization();
                screen.DataContext = temp;
                order.Add(temp);
                orderControl?.SwapScreen(screen);

            }
        }

        /// Entrees

        /// <summary>
        /// Add double burger button event handler
        /// </summary>
        private void AddDakotaDoubleBurger_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            DakotaDoubleBurger temp = new DakotaDoubleBurger();
            if (DataContext is Order order)
            {
                var screen = new DakotaDoubleBurgerCustomization();
                screen.DataContext = temp;
                order.Add(temp);
                orderControl?.SwapScreen(screen);

            }
        }

        /// <summary>
        /// Add trailburger button event handler
        /// </summary>
        private void AddTrailBurger_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            TrailBurger temp = new TrailBurger();
            if (DataContext is Order order)
            {
                var screen = new TrailBurgerCustomization();
                screen.DataContext = temp;
                order.Add(temp);
                orderControl?.SwapScreen(screen);

            }
        }

        /// <summary>
        /// Add ribs button event handler
        /// </summary>
        private void AddRustlerRibs_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            RustlersRibs temp = new RustlersRibs();
            if (DataContext is Order order)
            {
                var screen = new RustlersRibsCustomization();
                screen.DataContext = temp;
                order.Add(temp);
                orderControl?.SwapScreen(screen);

            }
        }

        /// <summary>
        /// Add triple burger button event handler
        /// </summary>
        private void AddTexasTripleBurger_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            TexasTripleBurger temp = new TexasTripleBurger();
            if (DataContext is Order order)
            {
                var screen = new TexasTripleBurgerCustomization();
                screen.DataContext = temp;
                order.Add(temp);
                orderControl?.SwapScreen(screen);

            }
        }

        /// <summary>
        /// Add pulled pork button event handler
        /// </summary>
        private void AddPecosPulledPork_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            PecosPulledPork temp = new PecosPulledPork();
            if (DataContext is Order order)
            {
                var screen = new PecosPulledPorkCustomization();
                screen.DataContext = temp;
                order.Add(temp);
                orderControl?.SwapScreen(screen);

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
            var orderControl = this.FindAncestor<OrderControl>();

            AngryChicken temp = new AngryChicken();
            if (DataContext is Order order)
            {
                var screen = new AngryChickenCustomization();
                screen.DataContext = temp;
                order.Add(temp);
                orderControl?.SwapScreen(screen);

            }
        }
    }
}
