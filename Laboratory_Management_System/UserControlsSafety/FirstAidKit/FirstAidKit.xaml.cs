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

namespace Laboratory_Management_System.UserControlsSafety.FirstAidKit
{
    /// <summary>
    /// Interaction logic for FirstAidKit.xaml
    /// </summary>
    public partial class FirstAidKit : UserControl
    {
        private object pageLabel;
        public FirstAidKit(string v)
        {
            InitializeComponent();
        }

        private void btnFirstAidKitTotal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FirstAidKit obj = new FirstAidKit();
                if (Convert.ToDouble(txtFirstAidKitamount.Text) <= 0)
                {
                    throw new Exception("Amount can not be less than or equal to 0");
                }

                obj.Amount = (int)Convert.ToDouble(txtFirstAidKitamount.Text);
                obj.findTotal();
                txtFirstAidKittotal.Text = obj.Total.ToString();
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Invalid Inputs");
                txtFirstAidKitcount.Clear();
                txtFirstAidKitamount.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
