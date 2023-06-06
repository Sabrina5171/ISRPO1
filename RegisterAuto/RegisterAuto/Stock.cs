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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
          //  DataRow row = dt.NewRow();
           // dt.Rows.Add(row);

           // EditProductForm edit = new EditProductForm();
          //  edit.ShowDialog();

           // dt.Clear();
            //adapter.Fill(dt);
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
               // MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);
               // adapter.Update(dt);
                //dt.Clear();
                //adapter.Fill(dt);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autorization loginForm = new Autorization();
            loginForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Stock_Load(object sender, EventArgs e)
        {

            //MySqlCommand cmd = new MySqlCommand("SELECT * FROM `priduct`", dB.GetConnection());

           // adapter.SelectCommand = cmd;
           // adapter.Fill(dt);

            //dataGridView1.DataSource = dt;

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Артикул";
            dataGridView1.Columns[2].HeaderText = "Название";
            dataGridView1.Columns[3].HeaderText = "Цена";
            dataGridView1.Columns[4].HeaderText = "Кол-во на складе";
            dataGridView1.Columns[5].HeaderText = "Фото";
            dataGridView1.Columns[6].HeaderText = "Категория";
            dataGridView1.Columns[7].HeaderText = "Бренд";
            dataGridView1.Columns[8].HeaderText = "Производитель";
            dataGridView1.Columns[9].HeaderText = "Страна";
            dataGridView1.Columns[10].HeaderText = "Единица измерения";
            dataGridView1.Columns[11].HeaderText = "Вес";
        }
    }
}
