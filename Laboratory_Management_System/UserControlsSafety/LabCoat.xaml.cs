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
    /// Interaction logic for LabCoat.xaml
    /// </summary>
    public partial class LabCoat : UserControl
    {
        private object pageLabel;
        public LabCoat(string v)
        {
            InitializeComponent();
        }

        private void btnCTFinish_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCTTotal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LabCoat obj = new LabCoat();
                if (Convert.ToDouble(txtcoatamount.Text) <= 0)
                {
                    throw new Exception("Amount can not be less than or equal to 0");
                }

                obj.Amount = (int)Convert.ToDouble(txtcoatamount.Text);
                obj.findTotal();
                txtcoattotal.Text = obj.Total.ToString();
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Invalid Inputs");
                txtcoatcount.Clear();
                txtcoatamount.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}