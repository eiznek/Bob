﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bob
{
    class MenuItem
    {
        private string name;
        private double price;
        private List<Product> productList = new List<Product>();

        public MenuItem() { }
        public MenuItem(string n, double p)
        {
            name = n;
            price = p;
        }
        public double GetTotalPrice()
        {
            return 0.0;
        }
        public override string ToString()
        {
            return $"Name: {name} Price: {price}";
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
