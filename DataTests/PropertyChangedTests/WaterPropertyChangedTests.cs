using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class WaterPropertyChangedTests
    {
        [Fact]
        public void WaterShouldImplementINotifyPropertyChanged()
        {
            var drink = new Water();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(drink);
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var drink = new Water();
            Assert.PropertyChanged(drink, "Ice", () =>
            {
                drink.Ice = false;
            });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var drink = new Water();
            Assert.PropertyChanged(drink, "SpecialInstructions", () =>
            {
                drink.Ice = false;
            });
        }

        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForLemon()
        {
            var drink = new Water();
            Assert.PropertyChanged(drink, "Lemon", () =>
            {
                drink.Lemon = true;
            });
        }

        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForSpecialInstructions()
        {
            var drink = new Water();
            Assert.PropertyChanged(drink, "SpecialInstructions", () =>
            {
                drink.Lemon = true;
            });
        }
    }
}
