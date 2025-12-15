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

namespace Laboratory_Management_System.UserControlsSafety.Tongs
{
    /// <summary>
    /// Interaction logic for Tongs.xaml
    /// </summary>
    public partial class Tongs : UserControl
    {
        private object pageLabel;
        public Tongs(string v)
        {
            InitializeComponent();
        }

        private void btnTongsTotal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Tongs obj = new Tongs();
                if (Convert.ToDouble(txtTongsamount.Text) <= 0)
                {
                    throw new Exception("Amount can not be less than or equal to 0");
                }

                obj.Amount = (int)Convert.ToDouble(txtTongsamount.Text);
                obj.findTotal();
                txtTongstotal.Text = obj.Total.ToString();
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Invalid Inputs");
                txtTongscount.Clear();
                txtTongsamount.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
