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

namespace Laboratory_Management_System.UserControlsSafety.SafetyShield
{
    /// <summary>
    /// Interaction logic for SafetyShield.xaml
    /// </summary>
    public partial class SafetyShield : UserControl
    {
        private object pageLabel;
        public SafetyShield(string v)
        {
            InitializeComponent();
        }

        private void btnSafetyShieldsTotal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SafetyShield obj = new SafetyShield();
                if (Convert.ToDouble(txtSafetyShieldsamount.Text) <= 0)
                {
                    throw new Exception("Amount can not be less than or equal to 0");
                }

                obj.Amount = (int)Convert.ToDouble(txtSafetyShieldsamount.Text);
                obj.findTotal();
                txtSafetyShieldstotal.Text = obj.Total.ToString();
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Invalid Inputs");
                txtSafetyShieldscount.Clear();
                txtSafetyShieldsamount.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
