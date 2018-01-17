﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bob
{
    class Order
    {
        private int orderNo;
        private List<OrderItem> itemList = new List<OrderItem>();

        public Order() { }
        public void Add(List<OrderItem> il)
        {
            itemList = il;
        }
        public void Remove(int no)
        {

        }
        public double GetTotalAmt()
        {
            return 0.0;
        }
        public override string ToString()
        {
            return $"Order Number: {orderNo} ItemList: {itemList}";
        }
        public int OrderNo
        {
            get { return orderNo; }
            set { orderNo = value; }
        }
        public List<OrderItem> ItemList
        {
            get { return itemList; }
            set { itemList = value; }
        }
    }
}
