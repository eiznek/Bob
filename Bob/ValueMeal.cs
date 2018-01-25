using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bob
{
    class ValueMeal : Product
    {
        private DateTime startTime;
        private DateTime endTime;
        public ValueMeal() { }
        public ValueMeal(string n, double p, DateTime st, DateTime et) : base(n, p)
        {
            startTime = st;
            endTime = et;
        }
        public override double GetPrice()
        {
            return 0.0;
        }
        public bool IsAvailable()
        {
            if (DateTime.Now.TimeOfDay >= startTime.TimeOfDay && DateTime.Now.TimeOfDay <= endTime.TimeOfDay)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public DateTime StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }
        public DateTime EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }
    }
}
