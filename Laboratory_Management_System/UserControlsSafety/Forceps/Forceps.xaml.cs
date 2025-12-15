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

namespace Laboratory_Management_System.UserControlsSafety.Forceps
{
    /// <summary>
    /// Interaction logic for Forceps.xaml
    /// </summary>
    public partial class Forceps : UserControl
    {
        private object pageLabel;
        public Forceps(string v)
        {
            InitializeComponent();
        }

        private void btnForcepsTotal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Forceps obj = new Forceps();
                if (Convert.ToDouble(txtForcepsamount.Text) <= 0)
                {
                    throw new Exception("Amount can not be less than or equal to 0");
                }

                obj.Amount = (int)Convert.ToDouble(txtForcepsamount.Text);
                obj.findTotal();
                txtForcepstotal.Text = obj.Total.ToString();
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Invalid Inputs");
                txtForcepscount.Clear();
                txtForcepsamount.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
