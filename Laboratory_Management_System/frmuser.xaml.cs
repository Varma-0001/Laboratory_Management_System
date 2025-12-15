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
        private DispatcherTimer _timer;
        private Random random = new Random();
        public frmuser()
        {
            InitializeComponent();
            SetupTimer();
            SetupOtpLoop();
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
            _timer.Stop();
            string to, from, pass, mail;
            to = txtmail.Text;
            from = "testgui.0024@gmail.com";//your gmail goees here
            mail = vCode.ToString();
            pass = "zhyq riaf vipm qznj";//your app password goes here
            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = vCode.ToString();
            message.Subject = "your app neme - varification code";// // mail subject
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                System.Windows.MessageBox.Show("Verification code sent successful! Check your gmail", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                otpuser otpuser = new otpuser(vCode);
                otpuser.TxtOtp.IsEnabled = true;
                otpuser.BtnConfirm.IsEnabled = true;
                otpuser.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }
    }
}
