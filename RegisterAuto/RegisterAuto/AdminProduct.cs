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
    public partial class AdminProduct : Form
    {
        public AdminProduct()
        {
            InitializeComponent();
        }
        DB dB = new DB();
        DataTable dt = new DataTable();
        //MySqlDataAdapter adapter = new MySqlDataAdapter();
        private void save_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите сохранить изменения?", "Подтвердите сохранения", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                dt = (DataTable)dataGridView1.DataSource;
                //MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);
                //adapter.Update(dt);
                dt.Clear();
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
               // adapter.Update(dt);
                dt.Clear();
                //adapter.Fill(dt);
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(ArticleNumber.Text) ||
                //string.IsNullOrWhiteSpace(ProductName.Text) ||
                //string.IsNullOrWhiteSpace(ProductCost.Text) ||
                //string.IsNullOrWhiteSpace(QuantityInStock.Text) ||
               // string.IsNullOrWhiteSpace(ProductCategory.Text) ||
                //string.IsNullOrWhiteSpace(ProductBrand.Text) ||
               // string.IsNullOrWhiteSpace(ProductManufacturer.Text) ||
               // string.IsNullOrWhiteSpace(ProductCountry.Text) ||
               // string.IsNullOrWhiteSpace(ProductUnit.Text) ||
                //string.IsNullOrWhiteSpace(ProductWeight.Text) ||
                //string.IsNullOrWhiteSpace(ProductPhoto.Text))

            {
                MessageBox.Show("Заполните все поля.");
                return;
            }

   
            //string col1Value = ArticleNumber.Text;
           // string col2Value = ProductName.Text;
            //string col3Value = ProductCost.Text;
            //string col4Value = QuantityInStock.Text;
            //string col5Value = ProductCategory.Text;
            //string col6Value = ProductBrand.Text;
            //string col7Value = ProductManufacturer.Text;
           // string col8Value = ProductCountry.Text;
            //string col9Value = ProductUnit.Text;
           // string col10Value = ProductWeight.Text;
           // string col11Value = ProductPhoto.Text;


            // Обновляем значения в базе данных
            //UPDATE `users` SET `Surname` = 'К', `Name` = 'К' WHERE `users`.`id` = 9;



            //MySqlCommand cmd = new MySqlCommand("UPDATE `priduct` SET `ProductArticleNumber` = @col1, `ProductName` = @col2, `ProductCost` = @col3, `ProductQuantityInStock` = @col4, `ProductPhoto` = @col11, `ProductCategory` = @col5, `ProductBrand` = @col6, `ProductManufacturer` = @col7, `ProductCountry` = @col8, `ProductUnit` = @col9, `ProductWeight` = @col10 WHERE ProductId = @id", dB.GetConnection());

            //cmd.Parameters.AddWithValue("@col1", col1Value);
            //cmd.Parameters.AddWithValue("@col2", col2Value);
            //cmd.Parameters.AddWithValue("@col3", col3Value);
            //cmd.Parameters.AddWithValue("@col4", col4Value);
            //cmd.Parameters.AddWithValue("@col5", col5Value);
            //cmd.Parameters.AddWithValue("@col6", col6Value);
            //cmd.Parameters.AddWithValue("@col7", col7Value);
           // cmd.Parameters.AddWithValue("@col8", col8Value);
            //cmd.Parameters.AddWithValue("@col9", col9Value);
            //cmd.Parameters.AddWithValue("@col10", col10Value);
            //cmd.Parameters.AddWithValue("@col11", col11Value);
            //cmd.Parameters.AddWithValue("@id", id);

            dB.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                dt.Clear();
                //adapter.Fill(dt);
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

           // EditProductForm edit = new EditProductForm();
            //edit.ShowDialog();

            dt.Clear();
           // adapter.Fill(dt);
        }

        private void product_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin adminForm = new Admin(null, null, null, false);
            adminForm.Show();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) 
               // DataGridViewRow row = dataGridView1.Rows[e.RowIndex]; 
                //ArticleNumber.Text = row.Cells[1].Value.ToString(); 
                //ProductName.Text = row.Cells[2].Value.ToString();
                //ProductCost.Text = row.Cells[3].Value.ToString();
                //QuantityInStock.Text = row.Cells[4].Value.ToString();
                //ProductCategory.Text = row.Cells[6].Value.ToString();
                //ProductBrand.Text = row.Cells[7].Value.ToString(); 
               // ProductManufacturer.Text = row.Cells[8].Value.ToString();
               // ProductCountry.Text = row.Cells[9].Value.ToString();
                //ProductUnit.Text = row.Cells[10].Value.ToString();
                //ProductWeight.Text = row.Cells[11].Value.ToString();
                //ProductPhoto.Text = row.Cells[5].Value.ToString();
               // id = Convert.ToInt32(row.Cells[0].Value);
            
                //string productPhotoPath = ProductPhoto.Text; 

                //if (!string.IsNullOrEmpty(productPhotoPath))
                {
                    
                    //pictureBoxProductPhoto.Image = Image.FromFile(productPhotoPath);
                }
                else
                {
                    
                    //pictureBoxProductPhoto.Image = Image.FromFile("C:\\Users\\User\\source\\repos\\ExampleApp_2\\ExampleApp_2\\Resources\\free-icon-no-photos-8404289.png");
                }

            }
        }
    }
}
