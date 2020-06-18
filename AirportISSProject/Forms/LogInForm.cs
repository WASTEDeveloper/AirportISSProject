using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace AirportISSProject.Forms
{
    public partial class LogInForm : Form
    {
        public Form currentChildForm;
        ProfileForm profileForm = new ProfileForm();

        public LogInForm()
        {
            InitializeComponent();
            logInPanel.Visible = false;
            mainAreaPanle.Visible = true;
            forgotPassPanel.Visible = false;
            registrationPanel.Visible = false;
        }

        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Hide();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            mainAreaPanle.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            logInPanel.Visible = true;
            mainAreaPanle.Visible = false;
            forgotPassPanel.Visible = false;
            registrationPanel.Visible = false;
        }

        private void guna2TextBox1_IconRightClick(object sender, EventArgs e)
        {
            if (passwordTextBox.UseSystemPasswordChar == true)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            string userLogin = loginTextBox.Text;
            string userPassword = passwordTextBox.Text;

            DataBase DB = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @userLogin AND `password` = @userPassword", DB.getConnection());
            sqlCommand.Parameters.Add("@userLogin", MySqlDbType.VarChar).Value = userLogin;
            sqlCommand.Parameters.Add("@userPassword", MySqlDbType.VarChar).Value = userPassword;

            dataAdapter.SelectCommand = sqlCommand;
            dataAdapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                logInPanel.Visible = false;
                mainAreaPanle.Visible = true;
                OpenChildForm(profileForm);
                timer1.Enabled = true;
                forgotPassPanel.Visible = false;
                registrationPanel.Visible = false;
                loginTextBox.Text = "";
                passwordTextBox.Text = "";
            }
            else
            {
                loginTextBox.Text = "";
                passwordTextBox.Text = "";
                loginTextBox.PlaceholderText = "Логин или пароль введены не верно";
                passwordTextBox.PlaceholderText = "Логин или пароль введены не верно";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (FormsConnection.Value == false)
            {
                logInPanel.Visible = true;
                mainAreaPanle.Visible = false;
                forgotPassPanel.Visible = false;
                registrationPanel.Visible = false;
                FormsConnection.Value = true;
                timer1.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            logInPanel.Visible = false;
            mainAreaPanle.Visible = false;
            forgotPassPanel.Visible = true;
            registrationPanel.Visible = false;
        }

        private void enterEMailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string userEMail = enterEMailTextBox.Text;

                DataBase DB = new DataBase();

                DataTable table = new DataTable();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM `users` WHERE `eMail` = @userEMail", DB.getConnection());
                sqlCommand.Parameters.Add("@userEMail", MySqlDbType.VarChar).Value = userEMail;

                dataAdapter.SelectCommand = sqlCommand;
                dataAdapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    try
                    {
                        MailAddress from = new MailAddress("wasteclothes.by@gmail.com");
                        MailAddress to = new MailAddress(enterEMailTextBox.Text);
                        MailMessage message = new MailMessage(from, to)
                        {
                            Subject = "ИСС \"Аэропорта\" - Восстановление пароля!",
                            IsBodyHtml = true,
                            Body = "Ваш секретный код: "
                        };
                        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                        {
                            Credentials = new NetworkCredential("wasteclothes.by@gmail.com", "waste123"),
                            EnableSsl = true
                        };
                        smtp.Send(message);
                        e.Handled = true;
                        textLabel1.Visible = true;
                        textLabel2.Visible = true;
                        secretCodeTextBox.Visible = true;
                        enterEMail.Visible = false;
                        enterEMailTextBox.Visible = false;
                        forgotPass.Text = "Восстановить";
                    }
                    catch (FormatException)
                    {
                        enterEMailTextBox.Text = "";
                        enterEMailTextBox.PlaceholderText = "Не вырный формат e-mail";
                    }
                    catch (ArgumentException)
                    {
                        enterEMailTextBox.Text = "";
                        enterEMailTextBox.PlaceholderText = "Строка не должна быть пуста";
                    }
                }
                else
                {
                    enterEMailTextBox.Text = "";
                    enterEMailTextBox.PlaceholderText = "Данный e-mail не зарегистрирован";
                }
            }
        }

        public static int random()
        {
            Random rnd = new Random();
            int secretCode = rnd.Next(100000, 999999);
            return secretCode;
        }

        int kolForgotPassButtonClick = 0;
        int secretCode = random();
        private void forgotPass_Click(object sender, EventArgs e)
        {
            if (kolForgotPassButtonClick == 0)
            {
                string userEMail = enterEMailTextBox.Text;

                DataBase DB = new DataBase();

                DataTable table = new DataTable();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM `users` WHERE `eMail` = @userEMail", DB.getConnection());
                sqlCommand.Parameters.Add("@userEMail", MySqlDbType.VarChar).Value = userEMail;

                dataAdapter.SelectCommand = sqlCommand;
                dataAdapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    try
                    {
                        MailAddress from = new MailAddress("wasteclothes.by@gmail.com");
                        MailAddress to = new MailAddress(enterEMailTextBox.Text);
                        MailMessage message = new MailMessage(from, to)
                        {
                            Subject = "ИСС \"Аэропорта\" - Восстановление пароля!",
                            IsBodyHtml = true,
                            Body = "Ваш секретный код: "
                        };
                        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                        {
                            Credentials = new NetworkCredential("wasteclothes.by@gmail.com", "waste123"),
                            EnableSsl = true
                        };
                        smtp.Send(message);
                        textLabel1.Visible = true;
                        textLabel2.Visible = true;
                        secretCodeTextBox.Visible = true;
                        enterEMail.Visible = false;
                        enterEMailTextBox.Visible = false;
                        forgotPass.Text = "Восстановить";
                    }
                    catch (FormatException)
                    {
                        enterEMailTextBox.Text = "";
                        enterEMailTextBox.PlaceholderText = "Не вырный формат e-mail";
                    }
                    catch (ArgumentException)
                    {
                        enterEMailTextBox.Text = "";
                        enterEMailTextBox.PlaceholderText = "Строка не должна быть пуста";
                    }
                }
                else
                {
                    enterEMailTextBox.Text = "";
                    enterEMailTextBox.PlaceholderText = "Данный e-mail не зарегистрирован";
                }
            }
            else
            {
                if (secretCodeTextBox.Text == secretCode.ToString())
                {
                    try
                    {
                        string userEMail = enterEMailTextBox.Text;

                        DataBase DB = new DataBase();

                        DataTable table = new DataTable();

                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

                        MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM `users` WHERE `eMail` = @userEMail", DB.getConnection());
                        sqlCommand.Parameters.Add("@userEMail", MySqlDbType.VarChar).Value = userEMail;

                        dataAdapter.SelectCommand = sqlCommand;
                        dataAdapter.Fill(table);

                        MailAddress from = new MailAddress("wasteclothes.by@gmail.com");
                        MailAddress to = new MailAddress(enterEMailTextBox.Text);
                        MailMessage message = new MailMessage(from, to)
                        {
                            Subject = "ИСС \"Аэропорта\" - Восстановление пароля!",
                            IsBodyHtml = true,
                            Body = "Ваш пароль: " + secretCode.ToString()
                        };
                        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                        {
                            Credentials = new NetworkCredential("wasteclothes.by@gmail.com", "waste123"),
                            EnableSsl = true
                        };
                        smtp.Send(message);
                    }
                    catch
                    {

                    }
                }
            }
            enterEMailTextBox.Text = "";
        }
    }
}
