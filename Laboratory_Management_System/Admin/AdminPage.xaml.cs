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

namespace Laboratory_Management_System.Admin
{
    /// <summary>
    /// Interaction logic for AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Window
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void BtnEquDet_Click(object sender, RoutedEventArgs e)
        {
            RightPanel.Content = new EquDetails.EquDetails();
        }

        private void BtnStatus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnUseDet_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnPayDet_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnReport_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
