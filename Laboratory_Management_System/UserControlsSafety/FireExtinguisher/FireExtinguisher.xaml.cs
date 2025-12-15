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

namespace Laboratory_Management_System.UserControlsSafety.FireExtinguisher
{
    /// <summary>
    /// Interaction logic for FireExtinguisher.xaml
    /// </summary>
    public partial class FireExtinguisher : UserControl
    {
        private object pageLabel;
        public FireExtinguisher(string v)
        {
            InitializeComponent();
        }

        private void btnFireExtinguisherTotal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FireExtinguisher obj = new FireExtinguisher();
                if (Convert.ToDouble(txtFireExtinguisheramount.Text) <= 0)
                {
                    throw new Exception("Amount can not be less than or equal to 0");
                }

                obj.Amount = (int)Convert.ToDouble(txtFireExtinguisheramount.Text);
                obj.findTotal();
                txtFireExtinguishertotal.Text = obj.Total.ToString();
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Invalid Inputs");
                txtFireExtinguishercount.Clear();
                txtFireExtinguisheramount.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}