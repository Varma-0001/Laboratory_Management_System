using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Management_System.UserControlsSafety.SafetyShield
{
    public partial class SafetyShield
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
        public SafetyShield()
        {
            amount = 0;
        }
        public void findTotal()
        {
            total = amount * 2500;
        }
    }
}
