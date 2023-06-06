using Razrabotka.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace Razrabotka
{
    public partial class Regestration : Form
    {
        public Regestration()
        {
            InitializeComponent();
        }

        private void Regestration_Load(object sender, EventArgs e)
        {
            SecretQuestion.DataSource = AppData.db.SecretQuestion.ToList();
            SecretQuestion.DisplayMember = "SecretQuestion1";
            SecretQuestion.ValueMember = "CodeSecretQuestion";
        }

        private void CodeWord_KeyPress(object sender, KeyPressEventArgs e)
        {

            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && l != '\b')
            {
                e.Handled = true;

            }


        }



        private void Button_Click(object sender, EventArgs e)
        {
            CheckPas.Text = "";

            if (Surname.Text == "" ||
          Name.Text == "" ||
          Login.Text == "" ||
          Password.Text == "" ||
          RepeatPassword.Text == "" ||
          SecretQuestion.Text == "" ||
          Answer.Text == "")
            {
                MessageBox.Show("Ни одно из полей не может быть пустым");
                return;
            }

            Regex regex1 = new Regex("^(?=.*?[mail])(?=.*?[gmail])(?=.*?[.ru])(?=.*?[@])");
            if (regex1.IsMatch(Login.Text) == false)
            {
                MessageBox.Show("Логин должен содержать @, mail или gmail, а также .ru");
                return;
            }

            if (Password.Text != RepeatPassword.Text)
            {
                CheckPas.Text = "Пароли не совпадают";
                return;
            }

            Regex regex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            if (regex.IsMatch(Password.Text) == false)
            {
                MessageBox.Show("Пароль должен содержать только латинские буквы, маленькие и заглавные. Должен содержать цифры и символы. Должен иметь не меньше 8 символов");
                return;
            }

          
            if (CheckAgreement.Checked == false)
            {
                MessageBox.Show("Вы не приняли согласие с условиями");
                return;
            }
            var UserCheck = AppData.db.User.FirstOrDefault(u => u.Email == Login.Text);

                if (UserCheck != null)
                {
                    MessageBox.Show("Пользователь с таким логином уже есть в базе");
                }
                else
                {
                    User user = new User();
                    user.Surname = Surname.Text;
                    user.Name = Name.Text;
                    user.Email = Login.Text;
                    user.Password = Password.Text;
                    user.ACodeword = CodeWord.Text;
                    user.SecretQuestionAnswer = Answer.Text;

                    var NumberSQ = SecretQuestion.SelectedItem as SecretQuestion;
                    user.CodeSecretQuestion1 = NumberSQ.CodeSecretQuestion;

                    AppData.db.User.Add(user);
                    AppData.db.SaveChanges();
                    MessageBox.Show("Пользователь был добавлен");
                    Surname.Text = "";

                    Name.Text = "";
                    Login.Text = "";
                    Password.Text = "";
                    RepeatPassword.Text = "";
                    SecretQuestion.Text = "";
                    Answer.Text = "";
                }
           
            

            
        }

        private void Close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверенны, что хотите закрыть приложение?",
                "Закрытие",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void CheckAgreement_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void CheckPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckPassword.Checked)
            {
                Password.UseSystemPasswordChar = false;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
            }
        }

        private void CheckRepeat_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckRepeat.Checked)
            {
                RepeatPassword.UseSystemPasswordChar = false;
            }
            else
            {
                RepeatPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
