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
    public partial class EditProduct : Form
    {
        public EditProduct()
        {
            InitializeComponent();
        }
        DB dB = new DB();
        DataTable dt = new DataTable();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(ProductPhoto.Text))
            {
                MessageBox.Show("Фото не было выбрано");
                return;
            }
            //else if (string.IsNullOrWhiteSpace(ArticleNumber.Text) ||
               // string.IsNullOrWhiteSpace(ProductName.Text) ||
               // string.IsNullOrWhiteSpace(ProductCost.Text) ||
               // string.IsNullOrWhiteSpace(QuantityInStock.Text) ||
               // string.IsNullOrWhiteSpace(ProductCategory.Text) ||
               // string.IsNullOrWhiteSpace(ProductBrand.Text) ||
               // string.IsNullOrWhiteSpace(ProductManufacturer.Text) ||
               // string.IsNullOrWhiteSpace(ProductCountry.Text) ||
              //  string.IsNullOrWhiteSpace(ProductUnit.Text) ||
               // string.IsNullOrWhiteSpace(ProductWeight.Text))
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }


            
           //string col1Value = ArticleNumber.Text;
           // string col2Value = ProductName.Text;
            //string col3Value = ProductCost.Text;
            //string col4Value = QuantityInStock.Text;
           // string col5Value = ProductCategory.Text;
           // string col6Value = ProductBrand.Text;
           // string col7Value = ProductManufacturer.Text;
          //  string col8Value = ProductCountry.Text;
           // string col9Value = ProductUnit.Text;
          // string col10Value = ProductWeight.Text;
           // string col11Value = ProductPhoto.Text;

            dB.openConnection();

            string query = "INSERT INTO `priduct` (`ProductArticleNumber`, `ProductName`, `ProductCost`, `ProductQuantityInStock`, `ProductPhoto`, `ProductCategory`, `ProductBrand`, `ProductManufacturer`, `ProductCountry`, `ProductUnit`, `ProductWeight`) VALUES (@col1, @col2, @col3, @col4, @col11, @col5, @col6, @col7, @col8, @col9, @col10);";
           // MySqlCommand command = new MySqlCommand(query, dB.GetConnection());

           // command.Parameters.AddWithValue("@col1", col1Value);
           // command.Parameters.AddWithValue("@col2", col2Value);
           // command.Parameters.AddWithValue("@col3", col3Value);
           // command.Parameters.AddWithValue("@col4", col4Value);
            //command.Parameters.AddWithValue("@col5", col5Value);
           // command.Parameters.AddWithValue("@col6", col6Value);
           // command.Parameters.AddWithValue("@col7", col7Value);
           // command.Parameters.AddWithValue("@col8", col8Value);
           // command.Parameters.AddWithValue("@col9", col9Value);
            //command.Parameters.AddWithValue("@col10", col10Value);
           // command.Parameters.AddWithValue("@col11", col11Value);
           // command.ExecuteNonQuery(); // выполнение запроса к базе данных
            dB.closeConnection();


            // Закрываем соединение с базой данных

            this.Close();
        }

        private void picture_Click(object sender, EventArgs e)
        {

            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image Files(*.png; *.jpg; *.jpeg)|*.png; *.jpg; *.jpeg|All files(*.*)|*.*";
            if (file.ShowDialog() == DialogResult.OK)
            {
               //pictureBox1.Image = Image.FromFile(file.FileName);
               // ProductPhoto.Text = file.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
