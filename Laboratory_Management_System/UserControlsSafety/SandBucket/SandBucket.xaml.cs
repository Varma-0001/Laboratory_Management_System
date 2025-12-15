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

namespace Laboratory_Management_System.UserControlsSafety.SandBucket
{
    /// <summary>
    /// Interaction logic for SandBucket.xaml
    /// </summary>
    public partial class SandBucket : UserControl
    {
        private object pageLabel;

        public SandBucket(string v)
        {
            InitializeComponent();
        }

        private void btnSandbucketTotal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SandBucket obj = new SandBucket();
                if (Convert.ToDouble(txtSandBucketamount.Text) <= 0)
                {
                    throw new Exception("Amount can not be less than or equal to 0");
                }

                obj.Amount = (int)Convert.ToDouble(txtSandBucketamount.Text);
                obj.findTotal();
                txtSandBuckettotal.Text = obj.Total.ToString();
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Invalid Inputs");
                txtSandBucketcount.Clear();
                txtSandBucketamount.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
