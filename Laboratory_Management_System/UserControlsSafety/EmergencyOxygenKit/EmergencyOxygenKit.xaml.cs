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

namespace Laboratory_Management_System.UserControlsSafety.EmergencyOxygenKit
{
    /// <summary>
    /// Interaction logic for EmergencyOxygenKit.xaml
    /// </summary>
    public partial class EmergencyOxygenKit : UserControl
    {
        private object pageLabel;
        public EmergencyOxygenKit(string v)
        {
            InitializeComponent();
        }

        private void btnOxygenTotal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                EmergencyOxygenKit obj = new EmergencyOxygenKit();
                if (Convert.ToDouble(txtOxygenamount.Text) <= 0)
                {
                    throw new Exception("Amount can not be less than or equal to 0");
                }

                obj.Amount = (int)Convert.ToDouble(txtOxygenamount.Text);
                obj.findTotal();
                txtOxygentotal.Text = obj.Total.ToString();
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Invalid Inputs");
                txtOxygencount.Clear();
                txtOxygenamount.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
