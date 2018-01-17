using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bob
{
    class OrderItem
    {
        private int quantity;
        private MenuItem item;
        public OrderItem() { }
        public OrderItem(MenuItem I)
        {
            item = I;
        }
        public void AddQty()
        {

        }
        public bool RemoveQty()
        {
            return true;
        }
        public double GetItemGTotalAmt()
        {
            return 0.0;
        }
        public override string ToString()
        {
            return $"Quantity: {quantity} Item: {item}";
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public MenuItem Item
        {
            get { return item; }
            set { item = value; }
        }
    }
}
