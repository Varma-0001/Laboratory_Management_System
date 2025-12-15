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

namespace Laboratory_Management_System.UserControlsSafety.Mask
{
    /// <summary>
    /// Interaction logic for Mask.xaml
    /// </summary>
    public partial class Mask : UserControl
    {
        private object pageLabel;
        public Mask(string v)
        {
            InitializeComponent();
        }

        private void btnMSKTotal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Mask obj = new Mask();
                if (Convert.ToDouble(txtmaskamount.Text) <= 0)
                {
                    throw new Exception("Amount can not be less than or equal to 0");
                }

                obj.Amount = (int)Convert.ToDouble(txtmaskamount.Text);
                obj.findTotal();
                txtmasktotal.Text = obj.Total.ToString();
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Invalid Inputs");
                txtmaskcount.Clear();
                txtmaskamount.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
