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

namespace Laboratory_Management_System.UserControlsSafety
{
    /// <summary>
    /// Interaction logic for Cloves.xaml
    /// </summary>
    public partial class Cloves : UserControl
    {
        private object pageLabel;

        public Cloves(string v)
        {
            InitializeComponent();
        }

        private void btnGLTotal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Cloves obj = new Cloves();
                if (Convert.ToDouble(txtamount.Text) <= 0)
                {
                    throw new Exception("Amount can not be less than or equal to 0");
                }

                obj.Amount = (int)Convert.ToDouble(txtamount.Text);
                obj.findTotal();
                txttotal.Text = obj.Total.ToString();
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Invalid Inputs");
                txtcount.Clear();
                txtamount.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
