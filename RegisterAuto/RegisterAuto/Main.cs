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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
           // labelName.Text = name;
           // labelSurname.Text = surname;

           // Image photo = Image.FromFile(photoPath);
            //pictureBoxPhoto.Image = photo;
        }
        DB dB = new DB();
        DataTable dt = new DataTable();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        private void Main_Load(object sender, EventArgs e)
        {
           // MySqlCommand cmd = new MySqlCommand("SELECT * FROM `users`", dB.GetConnection());

            //adapter.SelectCommand = cmd;
            adapter.Fill(dt);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
