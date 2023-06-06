using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RegisterAuto
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        DB dB = new DB();
        DataTable dt = new DataTable();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        private void Admin_Load(object sender, EventArgs e)
        {
            //MySqlCommand cmd = new MySqlCommand("SELECT * FROM `users`", dB.GetConnection());

            //adapter.SelectCommand = cmd;
           // adapter.Fill(dt);

            //dataGridView1.DataSource = dt;
            dataGridView1.Columns["Id"].ReadOnly = true;
            dataGridView1.Columns["Login"].ReadOnly = true;

            dataGridView1.Columns["Id"].Visible = false;

            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "Имя";
            dataGridView1.Columns[3].HeaderText = "Логин";
            dataGridView1.Columns[4].HeaderText = "Пароль";
            dataGridView1.Columns[5].HeaderText = "Фото";
            dataGridView1.Columns[6].HeaderText = "Роль";

            dataGridView1.DefaultCellStyle.Font = new Font("Roboto", 14);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 14);
        }

        private void save_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите сохранить изменения?", "Подтвердите сохранения", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //dt = (DataTable)dataGridView1.DataSource;
                //MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);
                //adapter.Update(dt);
                //dt.Clear();
                //adapter.Fill(dt); ;
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для удаления!");
                return;
            }

            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранную строку(и)?", "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
                //MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);
                //adapter.Update(dt);
                //dt.Clear();
                //adapter.Fill(dt);
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
           // if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                //string.IsNullOrWhiteSpace(textBox2.Text) ||
                //string.IsNullOrWhiteSpace(textBox3.Text) ||
                //string.IsNullOrWhiteSpace(textBox4.Text) ||
               // string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }

            // Получаем значения из текстбоксов
            //string col1Value = textBox1.Text;
            //string col2Value = textBox2.Text;
            //string col3Value = textBox3.Text;
            //string col4Value = textBox4.Text;
            //string col5Value = textBox5.Text;


            // Обновляем значения в базе данных
            //UPDATE `users` SET `Surname` = 'К', `Name` = 'К' WHERE `users`.`id` = 9;



            //MySqlCommand cmd = new MySqlCommand("UPDATE `users` SET `Surname` = @col1, `Name` = @col2, `Login` = @col3, `Pass` = @col4, `PhotoPath` = @col5 WHERE id = @id", dB.GetConnection());

            //cmd.Parameters.AddWithValue("@col1", col1Value);
            //cmd.Parameters.AddWithValue("@col2", col2Value);
           // cmd.Parameters.AddWithValue("@col3", col3Value);
            //cmd.Parameters.AddWithValue("@col4", col4Value);
            //cmd.Parameters.AddWithValue("@col5", col5Value);
            //cmd.Parameters.AddWithValue("@id", id);

            dB.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                dt.Clear();
                adapter.Fill(dt);
                MessageBox.Show("Значения успешно обновлены.");
                foreach (Control ctrl in Controls)
                {
                    if (ctrl is TextBox)
                    {
                        ((TextBox)ctrl).Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Ошибка при обновлении значений.");
            }

            dB.closeConnection();
        }

        private void add_Click(object sender, EventArgs e)
        {
            DataRow row = dt.NewRow();
            dt.Rows.Add(row);

            //EditForm edit = new EditForm();
            //edit.ShowDialog();

            dt.Clear();
            adapter.Fill(dt);

        }

        private void product_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminProduct productForm = new AdminProduct();
            productForm.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autorization loginForm = new Autorization();
            loginForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
