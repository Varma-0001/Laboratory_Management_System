using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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
    /// Interaction logic for frmcreate.xaml
    /// </summary>
    public partial class frmcreate : Window
    {
        private MySql.Data.MySqlClient.MySqlConnection con;

        public frmcreate()
        {
            InitializeComponent();
            con = new DbConnection.DbConnection().Getconnection();
        }

        private void btnnxt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string fname = txtfirstname.Text;
                string lname = txtlastname.Text;
                string mobile = txtpnumber.Text;
                string address = txtaddress.Text;
                string email = txtemail.Text;
                if (DOBirth.SelectedDate == null)
                {
                    MessageBox.Show("Date of Birth is required");
                    return;
                }
                DateTime dob = DOBirth.SelectedDate.Value;
                string gender;
                if (rbmale.IsChecked == true)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                string profession = txtprofession.Text;
                string nic = txtnic.Text;


                string query_register = "INSERT INTO user (First_Name, Last_Name, Phone_No, Address, EMail, DOB, Gender, Profession, NIC) " +
                                            "VALUES (@First_Name, @Last_Name, @Phone_No, @Address, @EMail ,@DOB ,@Gender ,@Profession ,@NIC)";

                using (var cmd = new MySqlCommand(query_register, con))
                {
                    cmd.Parameters.AddWithValue("@First_Name", fname);
                    cmd.Parameters.AddWithValue("@Last_Name", lname);
                    cmd.Parameters.AddWithValue("@Phone_No", mobile);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@EMail", email);
                    cmd.Parameters.AddWithValue("@DOB", dob);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Profession", profession);
                    cmd.Parameters.AddWithValue("@NIC", nic);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    System.Windows.MessageBox.Show("Record inserted successfully!" , "Information" , MessageBoxButton.OK , MessageBoxImage.Information);
                    frmuser frmuser = new frmuser();
                    frmuser.Show();
                    this.Hide();
                }

            }
            catch (Exception ex)
            {
                // show the real error while developing; switch to friendlier message for production
                MessageBox.Show("Error while registering: " + ex.Message);

                if (con == null) MessageBox.Show("Connection is null");
                if (txtfirstname == null) MessageBox.Show("txtfirstname is null");
                if (DOBirth == null) MessageBox.Show("DOBirth is null");
                if (txtpnumber == null) MessageBox.Show("txtpnumber is null");
                if (txtaddress == null) MessageBox.Show("txtaddress is null");
                if (txtemail == null) MessageBox.Show("txtemail is null");
                if (txtprofession == null) MessageBox.Show("txtprofession is null");
                if (txtlastname == null) MessageBox.Show("txtlastname is null");
            }
            finally
            {
                if (con != null)
                    con.Close();

                txtfirstname.Clear();
                txtlastname.Clear();
                txtpnumber.Clear();
                txtaddress.Clear();
                txtemail.Clear();
                txtprofession.Clear();
                txtnic.Clear();
                rbmale.IsChecked = false;
                rbfemale.IsChecked = false;
            }
        }

        private void btnback2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

            MainWindow main = new MainWindow();
            main.Show();
        }
    }
}