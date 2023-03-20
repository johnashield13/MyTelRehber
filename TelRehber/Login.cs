using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TelRehber.Models;

namespace TelRehber
{
    public partial class FormLogin : Form
    {
        private ConnectionTelRehberDBEntities db = new ConnectionTelRehberDBEntities();

        public void conncetDb()
        {
            string connectionString = "Server=NCAN\\MSSQLSERVER01;Database=TelRehber;User Id='NCAN\\JohnK';Password='';";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            MessageBox.Show("BAŞARILI");
        }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;

            var UsersHave = from user in db.kullanicilar // Replace 'db' with your actual database context object
                            where user.username == username && user.password == password
                            select user;

            if (UsersHave.Count() == 1)
            {
                var authorize = from us in db.kullanicilar
                                where us.username == username && us.password == password && us.author == 1
                                select us;
                if (authorize.Count() == 1)
                {
                    FormRehber formRehber = new FormRehber();
                    formRehber.Show();
                }
                else
                {
                    MessageBox.Show("Bu İşlem İçin Yetkiniz Bulunmamaktadır.", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void sendMail()
        {
            // Set up SMTP client and credentials
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential("n.cankalkan2275@gmail.com", "gtqpyccpfaoxsjnw");

            // Create email message
            MailMessage message = new MailMessage();
            message.From = new MailAddress("n.cankalkan2275@gmail.com");
            message.To.Add(new MailAddress("n.cankalkan2275@gmail.com"));
            message.Subject = "Uygulamanın Şifresini mi unuttun?";
            message.Body = "Kullanıcı adı : Nuri , Şifre : 2275" + "\n" +
                "kullanıcı adı : Can , Şifre : 2350" + "\n" +
                "Kullanıcı adı : Kalkan Şifre : 3366 yetki :0" + "\n";

            // Send email
            smtpClient.Send(message);
        }

        private void buttonLostPasswrd_Click(object sender, EventArgs e)
        {
            sendMail();
            MessageBox.Show("Uygulama Şifreler n.cankalkan2275@gmail.com adresine mail olarak gönderilmiş bulunmaktadır. Lütfen mail adresinizi kontrol ediniz. ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}