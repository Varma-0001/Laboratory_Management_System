using MySql.Data.MySqlClient;
using System;
using System.Windows;


namespace Laboratory_Management_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MySql.Data.MySqlClient.MySqlConnection con;

        public MainWindow()
        {
            InitializeComponent();
            con = new DbConnection.DbConnection().Getconnection();

        }

        private void btncreate_Click(object sender, RoutedEventArgs e)
        {
            frmcreate newform = new frmcreate();
            newform.Show();
            this.Hide();
        }

        private void btnsingin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            try
            {
                string query = "SELECT COUNT(*) FROM login_user WHERE User_Name=@User_Name AND U_Password=@U_Password";
                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@User_Name", username);
                    cmd.Parameters.AddWithValue("@U_Password", password);

                    con.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();

                    if (count > 0)
                    {
                        MessageBox.Show("Login successful!");
                        Equipments eqForm = new Equipments();
                        eqForm.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }
    }
}


