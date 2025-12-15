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

namespace Laboratory_Management_System.UserControlsSafety.CutResistantGlass
{
    /// <summary>
    /// Interaction logic for Cut.xaml
    /// </summary>
    public partial class Cut : UserControl
    {
        private object pageLabel;
        public Cut(string v)
        {
            InitializeComponent();
        }

        private void btnCutTotal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Cut obj = new Cut();
                if (Convert.ToDouble(txtCutamount.Text) <= 0)
                {
                    throw new Exception("Amount can not be less than or equal to 0");
                }

                obj.Amount = (int)Convert.ToDouble(txtCutamount.Text);
                obj.findTotal();
                txtCuttotal.Text = obj.Total.ToString();
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Invalid Inputs");
                txtCutcount.Clear();
                txtCutamount.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}