using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Management_System.UserControlsSafety.EmergencyOxygenKit
{
    public partial class EmergencyOxygenKit
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
        public EmergencyOxygenKit()
        {
            amount = 0;
        }
        public void findTotal()
        {
            total = amount * 5000;
        }
    }
}
