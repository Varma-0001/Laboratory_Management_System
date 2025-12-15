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

namespace Laboratory_Management_System.UserControlsSafety.SolventWasteBottles
{
    /// <summary>
    /// Interaction logic for Solvent.xaml
    /// </summary>
    public partial class Solvent : UserControl
    {
        private object pageLabel;
        public Solvent(string v)
        {
            InitializeComponent();
        }

        private void btnSolventTotal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Solvent obj = new Solvent();
                if (Convert.ToDouble(txtSolventamount.Text) <= 0)
                {
                    throw new Exception("Amount can not be less than or equal to 0");
                }

                obj.Amount = (int)Convert.ToDouble(txtSolventamount.Text);
                obj.findTotal();
                txtSolventtotal.Text = obj.Total.ToString();
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Invalid Inputs");
                txtSolventcount.Clear();
                txtSolventamount.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
