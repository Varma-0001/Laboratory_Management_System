using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Laboratory_Management_System.UserControlsSafety.FireBlanket
{
    /// <summary>
    /// Interaction logic for FireBlanket.xaml
    /// </summary>
    public partial class FireBlanket : UserControl
    {
        private object pageLabel;
        public FireBlanket(string v)
        {
            InitializeComponent();
        }

        private void btnFireBlanketTotal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FireBlanket obj = new FireBlanket();
                if (Convert.ToDouble(txtFireBlanketamount.Text) <= 0)
                {
                    throw new Exception("Amount can not be less than or equal to 0");
                }

                obj.Amount = (int)Convert.ToDouble(txtFireBlanketamount.Text);
                obj.findTotal();
                txtFireBlankettotal.Text = obj.Total.ToString();
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Invalid Inputs");
                txtFireBlanketcount.Clear();
                txtFireBlanketamount.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
