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
using System.Drawing.Configuration;
using System.Text.RegularExpressions;
using System.IO;

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
            continueRegistrationPanel.Visible = false;
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
            passwordTextBox.Text = "";
            loginTextBox.Text = "";
            passwordTextBox.PlaceholderText = "Пароль";
            loginTextBox.PlaceholderText = "Логин";
            logInPanel.Visible = true;
            mainAreaPanle.Visible = false;
            forgotPassPanel.Visible = false;
            registrationPanel.Visible = false;
            continueRegistrationPanel.Visible = false;
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
                profileExitTimer.Enabled = true;
                OpenChildForm(profileForm);
                forgotPassPanel.Visible = false;
                registrationPanel.Visible = false;
                continueRegistrationPanel.Visible = false;
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

        private void label1_Click(object sender, EventArgs e)
        {
            logInPanel.Visible = false;
            mainAreaPanle.Visible = false;
            enterEMailTextBox.Text = "";
            secretCodeTextBox.Text = "";
            forgotPassPanel.Visible = true;
            registrationPanel.Visible = false;
            continueRegistrationPanel.Visible = false;
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
                            Body = "<h1>Ваш секретный код: " + secretCode.ToString() + "</h1>"
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
            string userEMail = enterEMailTextBox.Text;

            DataBase DB = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM `users` WHERE `eMail` = @userEMail", DB.getConnection());
            sqlCommand.Parameters.Add("@userEMail", MySqlDbType.VarChar).Value = userEMail;

            dataAdapter.SelectCommand = sqlCommand;
            dataAdapter.Fill(table);

            if (kolForgotPassButtonClick == 0)
            {
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
                            Body = "<h1>Ваш секретный код: " + secretCode.ToString() + "</h1>"
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
                        kolForgotPassButtonClick++;
                    }
                    catch
                    {
                    
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
                    string eMailPass = table.Rows[0][3].ToString();
                    string eMailLogin = table.Rows[0][1].ToString();
                    try
                    {
                        MailAddress from = new MailAddress("wasteclothes.by@gmail.com");
                        MailAddress to = new MailAddress(enterEMailTextBox.Text);
                        MailMessage message = new MailMessage(from, to)
                        {
                            Subject = "ИСС \"Аэропорта\" - Восстановление пароля!",
                            IsBodyHtml = true,
                            Body = "<h1>Ваш логин: " + eMailLogin.ToString() + "</h1>" + "\n" + "<h1>Ваш пароль: " + eMailPass.ToString() + "</h1>"
                        };
                        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                        {
                            Credentials = new NetworkCredential("wasteclothes.by@gmail.com", "waste123"),
                            EnableSsl = true
                        };
                        smtp.Send(message);
                        logInPanel.Visible = false;
                        mainAreaPanle.Visible = true;
                        DialogResult accountCReate = MessageBox.Show("Данные вышего аккаунта были отправлены вам на почту!",
                        "Восстановление пароля", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        forgotPassPanel.Visible = false;
                        registrationPanel.Visible = false;
                        continueRegistrationPanel.Visible = false;
                    }
                    catch
                    {

                    }
                }
            }
        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            logInPanel.Visible = true;
            mainAreaPanle.Visible = false;
            forgotPassPanel.Visible = false;
            registrationPanel.Visible = false;
            continueRegistrationPanel.Visible = false;
        }

        private void backBtnLogInPanel_Click(object sender, EventArgs e)
        {
            logInPanel.Visible = false;
            mainAreaPanle.Visible = true;
            forgotPassPanel.Visible = false;
            registrationPanel.Visible = false;
            continueRegistrationPanel.Visible = false;
        }

        private void profileExitTimer_Tick(object sender, EventArgs e)
        {
            if (FormsConnection.Value2 == false)
            {
                logInPanel.Visible = false;
                mainAreaPanle.Visible = true;
                forgotPassPanel.Visible = false;
                registrationPanel.Visible = false;
                continueRegistrationPanel.Visible = false;
                FormsConnection.Value2 = true;
                profileForm.Hide();
                profileExitTimer.Enabled = false;
            }
        }

        bool loginFieldFlag;
        bool eMailFieldFlag;
        bool passwordFieldFlag;
        bool confirmPasswordFieldFlag;
        private void registrationContinueBtn_Click(object sender, EventArgs e)
        {
            if ((loginFieldFlag == true && eMailFieldFlag == true && passwordFieldFlag == true && confirmPasswordFieldFlag == true) && 
                (guna2TextBox13.Text != "" && guna2TextBox14.Text != "" && guna2TextBox15.Text != "" && guna2TextBox16.Text != ""))
            {
                DataBase DB = new DataBase();

                MySqlCommand sqlCommand = new MySqlCommand("INSERT INTO `users` (`userID`, `login`, `eMail`, `password`, `avatar`, `name`, `surname`, `dadName`, `birthdayDate`, `telephoneNumber`, `telephoneNumber2`, `country`, `city`, `street`, `house`, `part`, `flat`) " +
                    "VALUES (NULL, @userLogin, @userEMail, @userPassword, @useravatar, '-', '-', '-', '2020-06-01', '-', '-', '-', '-', '-', '-', '0', '0');", DB.getConnection());
                sqlCommand.Parameters.Add(@"userLogin", MySqlDbType.VarChar).Value = guna2TextBox14.Text;
                sqlCommand.Parameters.Add(@"userEMail", MySqlDbType.VarChar).Value = guna2TextBox15.Text;
                sqlCommand.Parameters.Add(@"userPassword", MySqlDbType.VarChar).Value = guna2TextBox16.Text;
                sqlCommand.Parameters.Add(@"useravatar", MySqlDbType.VarChar).Value = avatar_path;

                DB.openConnection();
                if (sqlCommand.ExecuteNonQuery() == 1)
                {
                    DialogResult accountCReate = MessageBox.Show("Аккаунт был успешно создан!",
                    "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult accountCReate = MessageBox.Show("Упс... Что-то пошло не так! \n Аккаунт не был создан",
                    "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                DB.closeConnection();

                FormsConnection.login = guna2TextBox14.Text;

                logInPanel.Visible = false;
                mainAreaPanle.Visible = false;
                forgotPassPanel.Visible = false;
                registrationPanel.Visible = false;
                continueRegistrationPanel.Visible = true;
            }
            else
            {
                DialogResult error = MessageBox.Show("Заполните все поля или проверьте правильность введенных данных",
                "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            logInPanel.Visible = false;
            mainAreaPanle.Visible = false;
            forgotPassPanel.Visible = false;
            registrationPanel.Visible = true;
            continueRegistrationPanel.Visible = false;
        }

        private void regPanel_backBtn_Click(object sender, EventArgs e)
        {
            logInPanel.Visible = false;
            mainAreaPanle.Visible = true;
            forgotPassPanel.Visible = false;
            registrationPanel.Visible = false;
            continueRegistrationPanel.Visible = false;
        }

        private void guna2TextBox14_TextChanged(object sender, EventArgs e)
        {
            string userLogin = guna2TextBox14.Text;

            DataBase DB = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @userLogin", DB.getConnection());
            sqlCommand.Parameters.Add(@"userLogin", MySqlDbType.VarChar).Value = userLogin;

            dataAdapter.SelectCommand = sqlCommand;
            dataAdapter.Fill(table);

            if (table.Rows.Count < 1)
            {
                Bitmap MyImage = new Bitmap("C:/Assets/AirportISSProject/img/tick (1).png");
                guna2TextBox14.IconRight = MyImage;
                guna2TextBox14.IconRightSize = new Size(20, 20);
                loginFieldFlag = true;
            }
            else
            {
                Bitmap MyImage = new Bitmap("C:/Assets/AirportISSProject/img/close (3).png");
                guna2TextBox14.IconRight = MyImage;
                guna2TextBox14.IconRightSize = new Size(20, 20);
                loginFieldFlag = false;
            }
            if (guna2TextBox14.Text == "")
            {
                guna2TextBox14.IconRightSize = new Size(0, 0);
            }
        }

        private void guna2TextBox15_TextChanged(object sender, EventArgs e)
        {
            string userEMail = guna2TextBox15.Text;

            DataBase DB = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM `users` WHERE `eMail` = @userEMail", DB.getConnection());
            sqlCommand.Parameters.Add(@"userEMail", MySqlDbType.VarChar).Value = userEMail;

            dataAdapter.SelectCommand = sqlCommand;
            dataAdapter.Fill(table);

            if (Regex.IsMatch(guna2TextBox15.Text,
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase | RegexOptions.Compiled, TimeSpan.FromMilliseconds(250)) && table.Rows.Count < 1)
            {
                Bitmap MyImage = new Bitmap("C:/Assets/AirportISSProject/img/tick (1).png");
                guna2TextBox15.IconRight = MyImage;
                guna2TextBox15.IconRightSize = new Size(20, 20);
                eMailFieldFlag = true;
            }
            else
            {
                Bitmap MyImage = new Bitmap("C:/Assets/AirportISSProject/img/close (3).png");
                guna2TextBox15.IconRight = MyImage;
                guna2TextBox15.IconRightSize = new Size(20, 20);
                eMailFieldFlag = false;
            }
            if (guna2TextBox15.Text == "")
            {
                guna2TextBox15.IconRightSize = new Size(0, 0);
            }
        }

        private void guna2TextBox16_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox16.Text.Length >= 5)
            {
                tickPictureBox.Visible = true;
                crossPictureBox.Visible = false;
                passwordFieldFlag = true;
            }
            else
            {
                tickPictureBox.Visible = false;
                crossPictureBox.Visible = true;
            }
            if (guna2TextBox16.Text.Length == 5)
            {
                progressBarTimer.Enabled = true;
                passwordFieldFlag = true;
            }
            if (guna2TextBox16.Text.Length < 5)
            {
                guna2ProgressBar1.Value = 0;
                guna2ProgressBar1.ProgressColor = Color.Maroon;
                guna2ProgressBar1.ProgressColor2 = Color.Red;
                progressBarTimer.Enabled = false;
                progressBarTimer50.Enabled = false;
                progressBarTimer75.Enabled = false;
                progressBarTimer100.Enabled = false;
                passwordFieldFlag = false;
            }
            if (guna2TextBox16.Text.Length == 7)
            {
                guna2ProgressBar1.ProgressColor = Color.DarkOrange;
                guna2ProgressBar1.ProgressColor2 = Color.Gold;
                progressBarTimer50.Enabled = true;
                passwordFieldFlag = true;
            }
            if (guna2TextBox16.Text.Length == 9)
            {
                guna2ProgressBar1.ProgressColor = Color.DarkBlue;
                guna2ProgressBar1.ProgressColor2 = Color.DeepSkyBlue;
                progressBarTimer75.Enabled = true;
                passwordFieldFlag = true;
            }
            if (guna2TextBox16.Text.Length == 12)
            {
                guna2ProgressBar1.ProgressColor = Color.DarkGreen;
                guna2ProgressBar1.ProgressColor2 = Color.LimeGreen;
                progressBarTimer100.Enabled = true;
                passwordFieldFlag = true;
            }
            if (guna2TextBox16.Text == "")
            {
                tickPictureBox.Visible = false;
                crossPictureBox.Visible = false;
                progressBarTimer.Enabled = false;
                progressBarTimer50.Enabled = false;
                progressBarTimer75.Enabled = false;
                progressBarTimer100.Enabled = false;
            }
        }

        private void guna2TextBox13_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox16.Text == guna2TextBox13.Text)
            {
                tickPictureBox2.Visible = true;
                crossPictureBox1.Visible = false;
                confirmPasswordFieldFlag = true;
            }
            else
            {
                tickPictureBox2.Visible = false;
                crossPictureBox1.Visible = true;
                confirmPasswordFieldFlag = false;
            }
            if (guna2TextBox13.Text == "")
            {
                tickPictureBox2.Visible = false;
                crossPictureBox1.Visible = false;
            }
        }

        private void progressBarTimer_Tick(object sender, EventArgs e)
        {
            if (guna2ProgressBar1.Value >= 25)
            {
                progressBarTimer.Enabled = false;
                return;
            }
            guna2ProgressBar1.Increment(1);
        }

        private void guna2TextBox16_IconRightClick(object sender, EventArgs e)
        {
            if (guna2TextBox16.UseSystemPasswordChar == false)
            {
                guna2TextBox16.UseSystemPasswordChar = true;
            }
            else
            {
                guna2TextBox16.UseSystemPasswordChar = false;
            }
        }

        private void guna2TextBox13_IconRightClick(object sender, EventArgs e)
        {
            if (guna2TextBox13.UseSystemPasswordChar == false)
            {
                guna2TextBox13.UseSystemPasswordChar = true;
            }
            else
            {
                guna2TextBox13.UseSystemPasswordChar = false;
            }
        }

        private void progressBarTimer50_Tick(object sender, EventArgs e)
        {
            if (guna2ProgressBar1.Value >= 50)
            {
                progressBarTimer.Enabled = false;
                return;
            }
            guna2ProgressBar1.Increment(1);
        }

        private void progressBarTimer75_Tick(object sender, EventArgs e)
        {
            if (guna2ProgressBar1.Value >= 75)
            {
                progressBarTimer.Enabled = false;
                return;
            }
            guna2ProgressBar1.Increment(1);
        }

        private void progressBarTimer100_Tick(object sender, EventArgs e)
        {
            if (guna2ProgressBar1.Value >= 100)
            {
                progressBarTimer.Enabled = false;
                return;
            }
            guna2ProgressBar1.Increment(1);
        }

        string avatar_path = "img/no_photo.png";
        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Bitmap image;

            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    guna2CirclePictureBox1.Image = image;
                    guna2CirclePictureBox1.Invalidate();
                    avatar_path = open_dialog.FileName;
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void guna2CirclePictureBox1_MouseHover(object sender, EventArgs e)
        {
            if (avatar_path == "img/no_photo.png")
            {
                guna2CirclePictureBox1.Image = Image.FromFile("img/add_photo.png");
                avatar_path = "img/add_photo.png";
            }
        }

        private void guna2CirclePictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (avatar_path == "img/add_photo.png")
            {
                guna2CirclePictureBox1.Image = Image.FromFile("img/no_photo.png");
                avatar_path = "img/no_photo.png";
            }
        }
    }
}
