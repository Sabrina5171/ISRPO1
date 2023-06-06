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
    public partial class Regisrtation : Form
    {
        public Regisrtation()
        {
            InitializeComponent();
        }

        private void vxod_Click(object sender, EventArgs e)
        {

            //if (string.IsNullOrEmpty(SurnameBox.Text) || string.IsNullOrEmpty(NameBox.Text) || string.IsNullOrEmpty(LoginBox.Text) || (string.IsNullOrEmpty(PassBox.Text)))
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }
           // else if (pbPhoto.Image == null)
            {
                MessageBox.Show("Фото не было выбрано");
                return;
            }
           // else if (checkUser())
                return;


          //  string surnameUser = SurnameBox.Text;
            //string nameUser = NameBox.Text;
           // string loginUser = LoginBox.Text;
           // string passUser = PassBox.Text;
          //  string photoPath = labelPhoto.Text; // получаем путь к выбранному файлу

            DB dB = new DB();
           // MySqlCommand cmd = new MySqlCommand("INSERT INTO `users` (`Surname`, `Name`, `Login`, `Pass`, `PhotoPath`, `Role`) VALUES (@surname, @name, @login, @pass, @photo,'buyer');", dB.GetConnection());
           // cmd.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surnameUser;
           // cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameUser;
           // cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginUser;
            //cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passUser;

            //byte[] photo = null;
            //MemoryStream ms = new MemoryStream();
            //pbPhoto.Image.Save(ms, pbPhoto.Image.RawFormat);
            //photo = ms.ToArray();
            //cmd.Parameters.Add("@photo", MySqlDbType.LongBlob).Value = photo;

           // cmd.Parameters.Add("@photo", MySqlDbType.VarChar).Value = photoPath; // сохраняем путь к файлу в базе данных

            dB.openConnection();

            //if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт был создан");

                this.Hide();
              //  MainForm mainForm = new MainForm(nameUser, surnameUser, photoPath);
               // mainForm.Show();
            }
            else
            {
                MessageBox.Show("Аккаунт не был создан");
            }

            dB.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image Files(*.png; *.jpg; *.jpeg)|*.png; *.jpg; *.jpeg|All files(*.*)|*.*";
            if (file.ShowDialog() == DialogResult.OK)
            {
                
               // pbPhoto.ImageLocation = file.FileName;
               // labelPhoto.Text = file.FileName;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
