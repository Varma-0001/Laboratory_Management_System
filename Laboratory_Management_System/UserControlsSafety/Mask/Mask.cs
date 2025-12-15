using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Management_System.UserControlsSafety.Mask
{
    public partial class Mask
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
        public Mask()
        {
            amount = 0;
        }
        public void findTotal()
        {
            total = amount * 500;
        }
    }
}
