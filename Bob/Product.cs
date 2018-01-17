﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bob
{
    abstract class Product
    {
        private string name;
        private double price;
        public Product() { }
        public Product(string n, double p)
        {
            name = n;
            price = p;
        }
        public virtual double GetPrice()
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
