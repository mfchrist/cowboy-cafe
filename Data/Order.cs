using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Order object
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// Allows orders to use the INotifyPropertyChanged interface
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Keeps track of the last order number
        /// </summary>
        private static uint lastOrderNumber = 0;

        /// <summary>
        /// List of items in order
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// Calculate and return price of all items in order
        /// </summary>
        public double Subtotal {
            get
            {
                double subtotal = 0.0;
                foreach (IOrderItem item in items)
                {
                    subtotal += item.Price;
                }
                return subtotal;
            }
        }

        /// <summary>
        /// Return order number for new orders
        /// </summary>
        public static uint OrderNumber { get { return lastOrderNumber++; } }

        /// <summary>
        /// Sends items to an array to be returned
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();

        /// <summary>
        /// Method to add items to order
        /// </summary>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            if (item is INotifyPropertyChanged pcitem)
            {
                pcitem.PropertyChanged += OnItemChnaged;
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }

        /// <summary>
        /// Method to remove items from order
        /// </summary>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            if (item is INotifyPropertyChanged pcitem)
            {
                pcitem.PropertyChanged -= OnItemChnaged;
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }

        private void OnItemChnaged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if(e.PropertyName == "Price")
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));

        }
    }
}
