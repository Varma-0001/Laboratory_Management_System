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

namespace Laboratory_Management_System.UserControlsSafety.XRayPPE
{
    /// <summary>
    /// Interaction logic for XRayPPE.xaml
    /// </summary>
    public partial class XRayPPE : UserControl
    {
        private object pageLabel;
        public XRayPPE(string v)
        {
            InitializeComponent();
        }

        private void btnXRayPPETotal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                XRayPPE obj = new XRayPPE();
                if (Convert.ToDouble(txtXRayPPEamount.Text) <= 0)
                {
                    throw new Exception("Amount can not be less than or equal to 0");
                }

                obj.Amount = (int)Convert.ToDouble(txtXRayPPEamount.Text);
                obj.findTotal();
                txtXRayPPEtotal.Text = obj.Total.ToString();
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Invalid Inputs");
                txtXRayPPEcount.Clear();
                txtXRayPPEamount.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
