using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bob
{
    class Side : Product
    {
        public Side() { }
        public Side (string n, double p) : base (n, p)
        {
            //taken from product
        }
        public override double GetPrice()
        {
            return 0.0;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
