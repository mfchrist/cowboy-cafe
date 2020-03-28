using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PanDeCampoPropertyChangedTests
    {
        [Fact]
        public void PanDeCampoShouldImplementINotifyPropertyChanged()
        {
            var side = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(side);
        }

        

    }
}
