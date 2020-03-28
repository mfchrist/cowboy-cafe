using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class ChiliCheeseFriesPropertyChangedTests
    {
        [Fact]
        public void ChiliCheeseFriesShouldImplementINotifyPropertyChanged()
        {
            var side = new ChiliCheeseFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(side);
        }



    }
}