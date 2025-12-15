using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Management_System.UserControlsSafety.CircuitBreaker
{
    public partial class CircuitBreaker
    {
        private int amount;
        private double total;
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public double Total
        {
            get { return total; }
        }
        public CircuitBreaker()
        {
            amount = 0;
        }
        public void findTotal()
        {
            total = amount * 1500;
        }
    }
}
