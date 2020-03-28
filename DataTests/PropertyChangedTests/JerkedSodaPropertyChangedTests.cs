using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class JerkedSodaPropertyChangedTests
    {
        [Fact]
        public void JerkedSodaShouldImplementINotifyPropertyChanged()
        {
            var drink = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(drink);
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var drink = new JerkedSoda();
            Assert.PropertyChanged(drink, "Ice", () =>
            {
                drink.Ice = false;
            });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var drink = new JerkedSoda();
            Assert.PropertyChanged(drink, "SpecialInstructions", () =>
            {
                drink.Ice = false;
            });
        }
    }
}
