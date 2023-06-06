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
    public partial class Director : Form
    {
        public Director()
        {
            InitializeComponent();
        }

        private void product_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (e.RowIndex >= 0 && e.ColumnIndex >= 0) 
            //{
               // DataGridViewRow row = dataGridView1.Rows[e.RowIndex]; 
               // ArticleNumber.Text = row.Cells[1].Value.ToString(); 
               // ProductName.Text = row.Cells[2].Value.ToString();
               // ProductCost.Text = row.Cells[3].Value.ToString();
               // QuantityInStock.Text = row.Cells[4].Value.ToString();
               //  ProductCategory.Text = row.Cells[6].Value.ToString();
               // ProductBrand.Text = row.Cells[7].Value.ToString(); 
               // ProductManufacturer.Text = row.Cells[8].Value.ToString();
               // ProductCountry.Text = row.Cells[9].Value.ToString();
               // ProductUnit.Text = row.Cells[10].Value.ToString();
               // ProductWeight.Text = row.Cells[11].Value.ToString();
               // ProductPhoto.Text = row.Cells[5].Value.ToString();
               // id = Convert.ToInt32(row.Cells[0].Value);

                    //pictureBoxProductPhoto.Image = Image.FromFile(ProductPhoto.Text);


                    // string productPhotoPath = ProductPhoto.Text; 

                    //if (!string.IsNullOrEmpty(productPhotoPath))
                    //{

                    //pictureBoxProductPhoto.Image = Image.FromFile(productPhotoPath);
                    // }
                //else
                //{

                    //pictureBoxProductPhoto.Image = Image.FromFile("C:\\Users\\User\\source\\repos\\ExampleApp_2\\ExampleApp_2\\Resources\\free-icon-no-photos-8404289.png");
               // }

           // }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Autorization loginForm = new Autorization();
            loginForm.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
