using Microsoft.VisualBasic;
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
using System.Windows.Shapes;

namespace Laboratory_Management_System
{
    /// <summary>
    /// Interaction logic for otpuser.xaml
    /// </summary>
    public partial class otpuser : Window
    {
        private int _vCode;
        public TextBox TxtOtp => txtotp;
        public Button BtnConfirm => btnconfirm;

        public otpuser(int vCode)
        {
            InitializeComponent();
            _vCode = vCode;
            _vCode = vCode;
        }

        private void btnconfirm_Click(object sender, RoutedEventArgs e)
        {
            if (txtotp.Text == _vCode.ToString())
            {
                Equipments newform = new Equipments();
                newform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid OTP. Please try again.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}

