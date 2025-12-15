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
    /// Interaction logic for Equipments.xaml
    /// </summary>
    public partial class Equipments : Window
    {
        public Equipments()
        {
            InitializeComponent();
        }

        private void BtnSafety_Click(object sender, RoutedEventArgs e)
        {
            MiddlePanel.Content = new UserControls.Safety(RightPanel);
        }

        private void BtnEqu_Click(object sender, RoutedEventArgs e)
        {
            OverlayPanel.Visibility = Visibility.Collapsed;

            BtnEqu.Visibility = Visibility.Visible;

            BtnSafety.Visibility = Visibility.Visible;
            BtnAcid.Visibility = Visibility.Visible;
        }

        private void BtnAcid_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnPay_Click(object sender, RoutedEventArgs e)
        {
            // Show overlay covering Left + Middle
            OverlayPanel.Visibility = Visibility.Visible;

            // Load Payment control into overlay
            OverlayContent.Content = new UC_Payment.Payment();

            BtnSafety.Visibility = Visibility.Collapsed;
            BtnAcid.Visibility = Visibility.Collapsed;
        }
    }
}
