using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
using System.Windows.Threading;

namespace Laboratory_Management_System
{
    /// <summary>
    /// Interaction logic for frmuser.xaml
    /// </summary>
    public partial class frmuser : Window
    {
        private MySql.Data.MySqlClient.MySqlConnection con;

        private DispatcherTimer _timer;
        private Random random = new Random();
        public frmuser()
        {
            InitializeComponent();
            SetupTimer();
            SetupOtpLoop();
            con = new DbConnection.DbConnection().Getconnection();

        }

        private void SetupOtpLoop()
        {
            vCode = random.Next(1000, 9999);
        }

        private void SetupTimer()
        {
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1000); // Set interval to 1 second
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            vCode += 10;
            if (vCode == 9999)
            {
                vCode = 1000;
            }
        }

        int vCode = 1000;

        private void btncreate_Click(object sender, RoutedEventArgs e)
        {
            string email = txtmail.Text.Trim();
            string username = txtuser_name.Text.Trim();
            string password = txt_pass.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                // 1. Generate OTP
                int otp = new Random().Next(1000, 9999);

                // 2. Insert username + password into DB
                string query_register = "INSERT INTO login_user (User_Name, U_Password) VALUES (@User_Name, @U_Password)";
                using (var cmd = new MySqlCommand(query_register, con))
                {
                    cmd.Parameters.AddWithValue("@User_Name", username);
                    cmd.Parameters.AddWithValue("@U_Password", password);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                // 3. Send OTP email
                string from = "testgui.0024@gmail.com"; // your Gmail
                string appPassword = "zhyq riaf vipm qznj"; // your Gmail app password

                MailMessage message = new MailMessage();
                message.To.Add(email);
                message.From = new MailAddress(from);
                message.Subject = "Verification Code";
                message.Body = otp.ToString();

                SmtpClient smtp = new SmtpClient("smtp.gmail.com")
                {
                    EnableSsl = true,
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(from, appPassword)
                };

                smtp.Send(message);

                MessageBox.Show("Verification code sent successfully! Check your Gmail.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);

                // 4. Open OTP form
                otpuser otpForm = new otpuser(otp);
                otpForm.TxtOtp.IsEnabled = true;
                otpForm.BtnConfirm.IsEnabled = true;
                otpForm.Show();
                this.Hide();

                // 5. Clear fields AFTER sending
                txtmail.Clear();
                txtuser_name.Clear();
                txt_pass.Clear();
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

