using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CornDodgersPropertyChangedTests
    {
        [Fact]
        public void CornDodgersShouldImplementINotifyPropertyChanged()
        {
            var side = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(side);
        }



    }
}
