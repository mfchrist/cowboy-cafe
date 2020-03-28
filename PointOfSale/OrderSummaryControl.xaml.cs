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

            //Entrees

            ///Cowpoke Chili
            if (OrderList.SelectedItem != null && OrderList.SelectedItem.ToString().Contains("Cowpoke Chili"))
            {
                CowpokeChili firstItem = args.AddedItems[0] as CowpokeChili;
                var orderControl = this.FindAncestor<OrderControl>();
                if (DataContext is Order order1)
                {
                    var screen = new CowpokeChiliCustomization();
                    screen.DataContext = firstItem;
                    orderControl?.SwapScreen(screen);

                }

            }

            ///Rustlers Ribs
            if (OrderList.SelectedItem != null && OrderList.SelectedItem.ToString().Contains("Ribs"))
            {
                RustlersRibs firstItem = args.AddedItems[0] as RustlersRibs;
                var orderControl = this.FindAncestor<OrderControl>();
                if (DataContext is Order order1)
                {
                    var screen = new RustlersRibsCustomization();
                    screen.DataContext = firstItem;
                    orderControl?.SwapScreen(screen);

                }

            }

            ///Pecos Pulled Pork
            if (OrderList.SelectedItem != null && OrderList.SelectedItem.ToString().Contains("Pecos"))
            {
                PecosPulledPork firstItem = args.AddedItems[0] as PecosPulledPork;
                var orderControl = this.FindAncestor<OrderControl>();
                if (DataContext is Order order1)
                {
                    var screen = new PecosPulledPorkCustomization();
                    screen.DataContext = firstItem;
                    orderControl?.SwapScreen(screen);

                }

            }

            ///Trailburger
            if (OrderList.SelectedItem != null && OrderList.SelectedItem.ToString().Contains("Trail Burger"))
            {
                TrailBurger firstItem = args.AddedItems[0] as TrailBurger;
                var orderControl = this.FindAncestor<OrderControl>();
                if (DataContext is Order order1)
                {
                    var screen = new TrailBurgerCustomization();
                    screen.DataContext = firstItem;
                    orderControl?.SwapScreen(screen);

                }

            }

            ///Dakota Double Burger
            if (OrderList.SelectedItem != null && OrderList.SelectedItem.ToString().Contains("Dakota"))
            {
                DakotaDoubleBurger firstItem = args.AddedItems[0] as DakotaDoubleBurger;
                var orderControl = this.FindAncestor<OrderControl>();
                if (DataContext is Order order1)
                {
                    var screen = new DakotaDoubleBurgerCustomization();
                    screen.DataContext = firstItem;
                    orderControl?.SwapScreen(screen);

                }

            }

            ///Texas Triple Burger
            if (OrderList.SelectedItem != null && OrderList.SelectedItem.ToString().Contains("Triple"))
            {
                TexasTripleBurger firstItem = args.AddedItems[0] as TexasTripleBurger;
                var orderControl = this.FindAncestor<OrderControl>();
                if (DataContext is Order order1)
                {
                    var screen = new TexasTripleBurgerCustomization();
                    screen.DataContext = firstItem;
                    orderControl?.SwapScreen(screen);

                }

            }

            ///Angry Chicken
            if (OrderList.SelectedItem != null && OrderList.SelectedItem.ToString().Contains("Angry"))
            {
                AngryChicken firstItem = args.AddedItems[0] as AngryChicken;
                var orderControl = this.FindAncestor<OrderControl>();
                if (DataContext is Order order1)
                {
                    var screen = new AngryChickenCustomization();
                    screen.DataContext = firstItem;
                    orderControl?.SwapScreen(screen);

                }

            }

            //Sides

            ///Chili Cheese Fries
            if (OrderList.SelectedItem != null && OrderList.SelectedItem.ToString().Contains("Chili Cheese Fries"))
            {
                ChiliCheeseFries firstItem = args.AddedItems[0] as ChiliCheeseFries;
                var orderControl = this.FindAncestor<OrderControl>();
                if (DataContext is Order order1)
                {
                    var screen = new ChiliCheeseFriesCustomization();
                    screen.DataContext = firstItem;
                    orderControl?.SwapScreen(screen);

                }

            }

            //Corn Dodgers
            if (OrderList.SelectedItem != null && OrderList.SelectedItem.ToString().Contains("Corn Dodgers"))
            {
                CornDodgers firstItem = args.AddedItems[0] as CornDodgers;
                var orderControl = this.FindAncestor<OrderControl>();
                if (DataContext is Order order1)
                {
                    var screen = new CornDodgersCustomization();
                    screen.DataContext = firstItem;
                    orderControl?.SwapScreen(screen);

                }

            }

            //Baked Beans
            if (OrderList.SelectedItem != null && OrderList.SelectedItem.ToString().Contains("Baked Beans"))
            {
                BakedBeans firstItem = args.AddedItems[0] as BakedBeans;
                var orderControl = this.FindAncestor<OrderControl>();
                if (DataContext is Order order1)
                {
                    var screen = new BakedBeansCustomization();
                    screen.DataContext = firstItem;
                    orderControl?.SwapScreen(screen);

                }

            }

            //Pan De Campo
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

            //Drinks

            //Jerked Soda
            if (OrderList.SelectedItem != null && OrderList.SelectedItem.ToString().Contains("Soda"))
            {
                JerkedSoda firstItem = args.AddedItems[0] as JerkedSoda;
                var orderControl = this.FindAncestor<OrderControl>();
                if (DataContext is Order order1)
                {
                    var screen = new JerkedSodaCustomization();
                    screen.DataContext = firstItem;
                    orderControl?.SwapScreen(screen);

                }

            }

            //Texas Tea
            if (OrderList.SelectedItem != null && OrderList.SelectedItem.ToString().Contains("Tea"))
            {
                TexasTea firstItem = args.AddedItems[0] as TexasTea;
                var orderControl = this.FindAncestor<OrderControl>();
                if (DataContext is Order order1)
                {
                    var screen = new TexasTeaCustomization();
                    screen.DataContext = firstItem;
                    orderControl?.SwapScreen(screen);

                }

            }

            //Cowboy Coffee
            if (OrderList.SelectedItem != null && OrderList.SelectedItem.ToString().Contains("Coffee"))
            {
                CowboyCoffee firstItem = args.AddedItems[0] as CowboyCoffee;
                var orderControl = this.FindAncestor<OrderControl>();
                if (DataContext is Order order1)
                {
                    var screen = new CowboyCoffeeCustomization();
                    screen.DataContext = firstItem;
                    orderControl?.SwapScreen(screen);

                }

            }

            //Water
            if (OrderList.SelectedItem != null && OrderList.SelectedItem.ToString().Contains("Water"))
            {
                Water firstItem = args.AddedItems[0] as Water;
                var orderControl = this.FindAncestor<OrderControl>();
                if (DataContext is Order order1)
                {
                    var screen = new WaterCustomization();
                    screen.DataContext = firstItem;
                    orderControl?.SwapScreen(screen);

                }

            }



        }

    }
}
