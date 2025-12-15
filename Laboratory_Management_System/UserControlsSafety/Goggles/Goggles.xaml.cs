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

namespace Laboratory_Management_System.UserControlsSafety.Goggles
{
    /// <summary>
    /// Interaction logic for Goggles.xaml
    /// </summary>
    public partial class Goggles : UserControl
    {
        private object pageLabel;
        public Goggles(string v)
        {
            InitializeComponent();
        }

        private void btnGogglesTotal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Goggles obj = new Goggles();
                if (Convert.ToDouble(txtGogglesamount.Text) <= 0)
                {
                    throw new Exception("Amount can not be less than or equal to 0");
                }

                obj.Amount = (int)Convert.ToDouble(txtGogglesamount.Text);
                obj.findTotal();
                txtGogglestotal.Text = obj.Total.ToString();
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Invalid Inputs");
                txtGogglescount.Clear();
                txtGogglesamount.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
