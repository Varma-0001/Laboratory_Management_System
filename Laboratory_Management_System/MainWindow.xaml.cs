using System.Windows;


namespace Laboratory_Management_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btncreate_Click(object sender, RoutedEventArgs e)
        {
            frmcreate newform = new frmcreate();
            newform.Show();
            this.Hide();
        }
    }
}
