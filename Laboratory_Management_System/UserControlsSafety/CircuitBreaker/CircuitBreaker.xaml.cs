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

namespace Laboratory_Management_System.UserControlsSafety.CircuitBreaker
{
    /// <summary>
    /// Interaction logic for CircuitBreaker.xaml
    /// </summary>
    public partial class CircuitBreaker : UserControl
    {
        private object pageLabel;
        public CircuitBreaker(string v)
        {
            InitializeComponent();
        }

        private void btnCircuitBreakerTotal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CircuitBreaker obj = new CircuitBreaker();
                if (Convert.ToDouble(txtCircuitBreakeramount.Text) <= 0)
                {
                    throw new Exception("Amount can not be less than or equal to 0");
                }

                obj.Amount = (int)Convert.ToDouble(txtCircuitBreakeramount.Text);
                obj.findTotal();
                txtCircuitBreakertotal.Text = obj.Total.ToString();
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Invalid Inputs");
                txtCircuitBreakercount.Clear();
                txtCircuitBreakeramount.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}