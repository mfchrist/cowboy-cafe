﻿using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    /// <summary>
    /// A class containing the tests for Pan De Campo
    /// </summary>
    public class PanDeCampoPropertyChangedTests
    {
        /// <summary>
        /// Tests that the item implements INotifyPropertyChanged 
        /// </summary>
        [Fact]
        public void PanDeCampoShouldImplementINotifyPropertyChanged()
        {
            var side = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(side);
        }
        /// <summary>
        /// Tests that the item implements INotifyPropertyChanged for a certain property
        /// </summary>
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSpecialInstructions()
        {
            var side = new PanDeCampo();
            Assert.PropertyChanged(side, "SpecialInstructions", () =>
            {
                side.Size = Size.Medium;
            });
        }
        /// <summary>
        /// Tests that the item implements INotifyPropertyChanged for a certain property
        /// </summary>
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var side = new PanDeCampo();
            Assert.PropertyChanged(side, "Price", () =>
            {
                side.Size = Size.Medium;
            });
        }
        /// <summary>
        /// Tests that the item implements INotifyPropertyChanged for a certain property
        /// </summary>
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var side = new PanDeCampo();
            Assert.PropertyChanged(side, "Calories", () =>
            {
                side.Size = Size.Medium;
            });
        }
        /// <summary>
        /// Tests that the item implements INotifyPropertyChanged for a certain property
        /// </summary>
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var side = new PanDeCampo();
            Assert.PropertyChanged(side, "Size", () =>
            {
                side.Size = Size.Medium;
            });
        }

    }
}
