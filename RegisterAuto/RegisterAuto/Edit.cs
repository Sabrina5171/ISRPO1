using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterAuto
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        DB dB = new DB();
        DataTable dt = new DataTable();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        private void save_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Фото не было выбрано");
                return;
            }
           // else if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || (string.IsNullOrEmpty(textBox4.Text)))
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }


            // Получаем данные нового пользователя из текстовых полей и элемента управления для выбора изображения
            //string firstName = textBox1.Text;
           /// string lastName = textBox2.Text;
           // string login = textBox3.Text;
           // string password = textBox4.Text;
           // string imageFilePath = textBox5.Text;
           // dB.openConnection();

            string query = "INSERT INTO `users` (`Surname`, `Name`, `Login`, `Pass`, `PhotoPath`, `Role`) VALUES (@surname, @name, @login, @pass, @photo,'user');";
            //MySqlCommand command = new MySqlCommand(query, dB.GetConnection());

            //command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = firstName;
           // command.Parameters.Add("@name", MySqlDbType.VarChar).Value = lastName;
            //command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
           // command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
           //command.Parameters.Add("@photo", MySqlDbType.VarChar).Value = imageFilePath;
            //command.ExecuteNonQuery(); // выполнение запроса к базе данных
            dB.closeConnection();


            // Закрываем соединение с базой данных

            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image Files(*.png; *.jpg; *.jpeg)|*.png; *.jpg; *.jpeg|All files(*.*)|*.*";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(file.FileName);
                //textBox5.Text = file.FileName;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
