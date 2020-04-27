﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class OrderTests
    {
        
       
        //{
        //    var order = new Order(); public class MockOrderItem : IOrderItem
        //{
        //    public double Price { get; set; }

        //    public List<string> SpecialInstructions { get; set; }
        //}
        //[Fact]
        //public void ShouldBeAbleToAddItems()
        //    var item = new MockOrderItem();
        //    order.Add(item);
        //    Assert.Contains(item, order.Items);
        //}

        //[Fact]
        //public void ShouldBeAbleToRemoveItems()
        //{
        //    var order = new Order();
        //    var item = new MockOrderItem();
        //    order.Add(item);
        //    order.Remove(item);
        //    Assert.DoesNotContain(item, order.Items);
        //}


        //[Fact]
        //public void ShouldBeAbleToGetEnumerationOfItems()
        //{
        //    var order = new Order();
        //    var item0 = new MockOrderItem();
        //    var item1 = new MockOrderItem();
        //    var item2 = new MockOrderItem();
        //    order.Add(item0);
        //    order.Add(item1);
        //    order.Add(item2);
        //    Assert.Collection(order.Items,
        //        item => Assert.Equal(item0, item),
        //        item => Assert.Equal(item1, item),
        //        item => Assert.Equal(item2, item)
        //        );
        //}

        //[Theory]
        //[InlineData(new double[] { 1, 2, 3 })]
        //[InlineData(new double[] { 0, 0, 0 })]
        //[InlineData(new double[] { 199, 799 })]
        //[InlineData(new double[] { 798 })]
        //[InlineData(new double[] { })]
        //[InlineData(new double[] { -5 })]
        //[InlineData(new double[] { -4, 10, 8 })]
        //[InlineData(new double[] { 3.69696969669 })]
        //[InlineData(new double[] { double.NaN })]
        //public void SubtotalShouldBeSumOfItemPrices(double[] prices)
        //{
        //    var order = new Order();
        //    double total = 0;

        //    foreach (var price in prices)
        //    {
        //        total += price;
        //        order.Add(new MockOrderItem()
        //        {
        //            Price = price
        //        });
        //    }

        //    Assert.Equal(total, order.Subtotal);

        //}

        /*nope
        [Fact]
        public void AddingAnItemShouldTriggerPropertyChangedForPrice()
        {
            var order = new Order();
            var item = new MockOrderItem();
            Assert.PropertyChanged(order, "Price", () =>
            {
                order.Add(item);
            });

        }nope
        */
        
        //[Theory]
        //[InlineData("Price")]
        //[InlineData("Items")]
        //public void AddingAnItemShouldTriggerPropertyChangedForItem(string propertyName)
        //{
        //    var order = new Order();
        //    var item = new MockOrderItem();
        //    Assert.PropertyChanged(order, propertyName, () =>
        //    {
        //        order.Add(item);
        //    });
        //}

        //[Theory]
        //[InlineData("Price")]
        //[InlineData("Items")]
        //public void AddingAnItemShouldTriggerPropertyChanged(string propertyName)
        //{
        //    var order = new Order();
        //    var item = new MockOrderItem();
        //    order.Add(item);
        //    Assert.PropertyChanged(order, propertyName, () =>
        //    {
        //        order.Remove(item);
        //    });
        //}
        
       
    }
}

