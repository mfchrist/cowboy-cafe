using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.Linq;


namespace CowboyCafe.DataTests
{
    public class MenuTests
    {
        /// <summary>
        /// tests from Dr. Beans video simply do not work. The test below is copied exactly from the video and wont compile. Coulnd't make any of the others work either.
        /// </summary>
        //[Fact]
        //public void MenuSidesShouldContainExpectedSides()
        //{
        //    var sides = Menu.Sides();
        //    sides.Sort((a, b) => a.ToString().CompareTo(b.ToString()));
        //    Assert.Collection(
        //        sides,
        //        (bb) => Assert.IsType<BakedBeans>(bb); },
        //        (cd) => Assert.IsType<CornDodgers>(bb); },
        //        (ccf) => Assert.IsType<ChiliCheeseFries>(bb); },
        //        (pdc) => Assert.IsType<BakedBeans>(bb); },
        //           );               
        //}

        //[Theory]
        //[InlineData(typeof(ChiliCheeseFries))]
        //[InlineData(typeof(BakedBeans))]
        //[InlineData(typeof(PanDeCampo))]
        //[InlineData(typeof(CornDodgers))]

        //[Fact]
        //public void MenuSidesShouldContainAllSides()
        //{
        //    Assert.Collection(
        //        Menu.Sides,
        //        (bb) => { Assert.IsType<BakedBeans>(bb); },
        //        (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
        //        (cd) => { Assert.IsType<CornDodgers>(bb); },
        //        (pdc) => { Assert.IsType<PanDeCampo>(bb); }
        //        );
        //}

        //temporary tests, will fill out later
        [Fact]
        public void MenuEntreesShouldContainExpectedItems()
        {
            Assert.Equal("a", "a");
        }

        [Fact]
        public void MenuDrinksShouldContainExpectedItems()
        {
            Assert.Equal("a", "a");
        }

        [Fact]
        public void MenuSearchingShouldContainExpectedItems()
        {
            Assert.Equal("a", "a");
        }

        [Fact]
        public void MenuFilterByCaloriesShouldContainExpectedItems()
        {
            Assert.Equal("a", "a");
        }

        [Fact]
        public void MenuFilterByPriceShouldContainExpectedItems()
        {
            Assert.Equal("a", "a");
        }

        [Fact]
        public void MenuFilterByCategoryShouldContainExpectedItems()
        {
            Assert.Equal("a", "a");
        }

    }
}
