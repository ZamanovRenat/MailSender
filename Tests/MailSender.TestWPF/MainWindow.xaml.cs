using System;
using System.Net;
using System.Net.Mail;
using System.Windows;

namespace MailSender.TestWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using var message = new MailMessage(MailSmtpClass.OutPutMail, MailSmtpClass.InPutMail);
            message.Subject = SubjectEdit.Text;
            message.Body = BodyEdit.Text;

            //message.Attachments.Add(new Attachment());

            using var client = new SmtpClient(MailSmtpClass.SmtpServer, MailSmtpClass.ServerPort)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential
                {
                    UserName = LoginEdit.Text,
                    SecurePassword = PasswordEdit.SecurePassword,
                }
            };

            try
            {
                client.Send(message);
                MessageBox.Show("Почта успешно отправлена", "Отправка почты", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (SmtpException smtp_exception)
            {
                MessageBox.Show(smtp_exception.Message, "Ошибка при отправке почты", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
