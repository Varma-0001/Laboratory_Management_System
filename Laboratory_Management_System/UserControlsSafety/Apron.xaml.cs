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
    /// Interaction logic for Apron.xaml
    /// </summary>
    public partial class Apron : UserControl
    {
        private object pageLabel;
        public Apron(string v)
        {
            InitializeComponent();
        }

        private void btnAPTotal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Apron obj = new Apron();
                if (Convert.ToDouble(txtapronamount.Text) <= 0)
                {
                    throw new Exception("Amount can not be less than or equal to 0");
                }

                obj.Amount = (int)Convert.ToDouble(txtapronamount.Text);
                obj.findTotal();
                txtaprontotal.Text = obj.Total.ToString();
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Invalid Inputs");
                txtaproncount.Clear();
                txtapronamount.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
