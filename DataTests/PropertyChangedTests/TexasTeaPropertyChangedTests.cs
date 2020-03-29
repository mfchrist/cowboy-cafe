using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class TexasTeaPropertyChangedTests
    {
        [Fact]
        public void TexasTeaShouldImplementINotifyPropertyChanged()
        {
            var drink = new TexasTea();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(drink);
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var drink = new TexasTea();
            Assert.PropertyChanged(drink, "Ice", () =>
            {
                drink.Ice = false;
            });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var drink = new TexasTea();
            Assert.PropertyChanged(drink, "SpecialInstructions", () =>
            {
                drink.Ice = false;
            });
        }

        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForLemon()
        {
            var drink = new TexasTea();
            Assert.PropertyChanged(drink, "Lemon", () =>
            {
                drink.Lemon = true;
            });
        }

        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForSpecialInstructions()
        {
            var drink = new TexasTea();
            Assert.PropertyChanged(drink, "SpecialInstructions", () =>
            {
                drink.Lemon = true;
            });
        }

        [Fact]
        public void ChangingSweetShouldInvokePropertyChangedForSweet()
        {
            var drink = new TexasTea();
            Assert.PropertyChanged(drink, "Sweet", () =>
            {
                drink.Sweet = false;
            });
        }

        [Fact]
        public void ChangingSweetShouldInvokePropertyChangedForSpecialInstructions()
        {
            var drink = new TexasTea();
            Assert.PropertyChanged(drink, "SpecialInstructions", () =>
            {
                drink.Sweet = false;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var drink = new TexasTea();
            Assert.PropertyChanged(drink, "Price", () =>
            {
                drink.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var drink = new TexasTea();
            Assert.PropertyChanged(drink, "Calories", () =>
            {
                drink.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var drink = new TexasTea();
            Assert.PropertyChanged(drink, "Size", () =>
            {
                drink.Size = Size.Medium;
            });
        }

    }
}
