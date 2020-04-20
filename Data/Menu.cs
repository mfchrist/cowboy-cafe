using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using CowboyCafe.Data;
using System.Linq;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class used for displaying menu items on the website.
    /// </summary>
    public static class Menu
    {
        public static IEnumerable<IOrderItem> Entrees()
        {
            var entrees = new List<IOrderItem>();

            AngryChicken chicken = new AngryChicken();
            CowpokeChili chili = new CowpokeChili();
            DakotaDoubleBurger dburg = new DakotaDoubleBurger();
            PecosPulledPork pork = new PecosPulledPork();
            RustlersRibs ribs = new RustlersRibs();
            TexasTripleBurger tburg = new TexasTripleBurger();
            TrailBurger burg = new TrailBurger();

            entrees.Add(chicken);
            entrees.Add(chili);
            entrees.Add(dburg);
            entrees.Add(pork);
            entrees.Add(ribs);
            entrees.Add(tburg);
            entrees.Add(burg);

            return entrees;

        }

        public static IEnumerable<IOrderItem> Sides()
        {
            var sides = new List<IOrderItem>();

            BakedBeans beans = new BakedBeans();
            ChiliCheeseFries fries = new ChiliCheeseFries();
            CornDodgers dodgers = new CornDodgers();
            PanDeCampo pan = new PanDeCampo();

            sides.Add(beans);
            sides.Add(fries);
            sides.Add(dodgers);
            sides.Add(pan);

            //BakedBeans sbeans = new BakedBeans();
            //sbeans.Size = Size.Small;
            //BakedBeans mbeans = new BakedBeans();
            //mbeans.Size = Size.Medium;
            //BakedBeans lbeans = new BakedBeans();
            //lbeans.Size = Size.Large;

            //ChiliCheeseFries sfries = new ChiliCheeseFries();
            //sfries.Size = Size.Small;
            //ChiliCheeseFries mfries = new ChiliCheeseFries();
            //mfries.Size = Size.Medium;
            //ChiliCheeseFries lfries = new ChiliCheeseFries();
            //lfries.Size = Size.Large;

            //CornDodgers sdodgers = new CornDodgers();
            //sdodgers.Size = Size.Small;
            //CornDodgers mdodgers = new CornDodgers();
            //mdodgers.Size = Size.Medium;
            //CornDodgers ldodgers = new CornDodgers();
            //ldodgers.Size = Size.Large;

            //PanDeCampo span = new PanDeCampo();
            //span.Size = Size.Small;
            //PanDeCampo mpan = new PanDeCampo();
            //mpan.Size = Size.Medium;
            //PanDeCampo lpan = new PanDeCampo();
            //lpan.Size = Size.Large;

            //sides.Add(sbeans);
            //sides.Add(mbeans);
            //sides.Add(lbeans);

            //sides.Add(sfries);
            //sides.Add(mfries);
            //sides.Add(lfries);

            //sides.Add(sbeans);
            //sides.Add(sbeans);
            //sides.Add(sbeans);

            //sides.Add(sbeans);
            //sides.Add(sbeans);
            //sides.Add(sbeans);

            return sides;
        }

        public static IEnumerable<IOrderItem> Drinks()
        {
            var drinks = new List<IOrderItem>();

            CowboyCoffee coffee = new CowboyCoffee();
            JerkedSoda soda = new JerkedSoda();
            TexasTea tea = new TexasTea();
            Water water = new Water();

            drinks.Add(coffee);
            drinks.Add(soda);
            drinks.Add(tea);
            drinks.Add(water);

            return drinks;

            //CowboyCoffee scoffee = new CowboyCoffee();
            //scoffee.Size = Size.Small;
            //CowboyCoffee mcoffee = new CowboyCoffee();
            //mcoffee.Size = Size.Medium;
            //CowboyCoffee lcoffee = new CowboyCoffee();
            //lcoffee.Size = Size.Large;

            //JerkedSoda ssoda = new JerkedSoda();
            //ssoda.Size = Size.Small;
            //JerkedSoda msoda = new JerkedSoda();
            //msoda.Size = Size.Medium;
            //JerkedSoda lsoda = new JerkedSoda();
            //lsoda.Size = Size.Large;

            //TexasTea stea = new TexasTea();
            //stea.Size = Size.Small;
            //TexasTea mtea = new TexasTea();
            //mtea.Size = Size.Medium;
            //TexasTea ltea = new TexasTea();
            //ltea.Size = Size.Large;

            //Water swater = new Water();
            //swater.Size = Size.Small;
            //Water mwater = new Water();
            //mwater.Size = Size.Medium;
            //Water lwater = new Water();
            //lwater.Size = Size.Large;

            //drinks.Add(scoffee);
            //drinks.Add(mcoffee);
            //drinks.Add(lcoffee);

            //drinks.Add(ssoda);
            //drinks.Add(msoda);
            //drinks.Add(lsoda);

            //drinks.Add(stea);
            //drinks.Add(mtea);
            //drinks.Add(ltea);

            //drinks.Add(swater);
            //drinks.Add(mwater);
            //drinks.Add(lwater);

        }
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            var drinks = Menu.Drinks();
            var entrees = Menu.Entrees();
            var sides = Menu.Sides();

            var complete = entrees.Concat(sides).Concat(drinks);

            return complete;
        }
    }
}
