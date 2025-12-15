using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Management_System.DbConnection
{
    public class MySqlConnection
    {
        private string con_string;

        public MySqlConnection(string con_string)
        {
            this.con_string = con_string;
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}
