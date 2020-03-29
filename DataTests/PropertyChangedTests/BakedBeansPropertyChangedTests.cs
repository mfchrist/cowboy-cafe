using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class BakedBeansPropertyChangedTests
    {
        [Fact]
        public void BakedBeansShouldImplementINotifyPropertyChanged()
        {
            var side = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(side);
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSpecialInstructions()
        {
            var side = new BakedBeans();
            Assert.PropertyChanged(side, "SpecialInstructions", () =>
            {
                side.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var side = new BakedBeans();
            Assert.PropertyChanged(side, "Price", () =>
            {
                side.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var side = new BakedBeans();
            Assert.PropertyChanged(side, "Calories", () =>
            {
                side.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var side = new BakedBeans();
            Assert.PropertyChanged(side, "Size", () =>
            {
                side.Size = Size.Medium;
            });
        }

    }
}