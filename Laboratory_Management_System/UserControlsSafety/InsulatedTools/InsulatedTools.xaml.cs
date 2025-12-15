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

namespace Laboratory_Management_System.UserControlsSafety.InsulatedTools
{
    /// <summary>
    /// Interaction logic for InsulatedTools.xaml
    /// </summary>
    public partial class InsulatedTools : UserControl
    {
        private object pageLabel;
        public InsulatedTools(string v)
        {
            InitializeComponent();
        }

        private void btnInsulatedToolsTotal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                InsulatedTools obj = new InsulatedTools();
                if (Convert.ToDouble(txtInsulatedToolsamount.Text) <= 0)
                {
                    throw new Exception("Amount can not be less than or equal to 0");
                }

                obj.Amount = (int)Convert.ToDouble(txtInsulatedToolsamount.Text);
                obj.findTotal();
                txtInsulatedToolstotal.Text = obj.Total.ToString();
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Invalid Inputs");
                txtInsulatedToolscount.Clear();
                txtInsulatedToolsamount.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
