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
            return true;
        }
        public override string ToString()
        {
            return $"Start: {startTime} End: {endTime}";
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
