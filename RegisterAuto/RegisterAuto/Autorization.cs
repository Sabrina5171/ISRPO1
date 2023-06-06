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
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void vxod_Click(object sender, EventArgs e)
        {
            string loginUser = login.Text;
            string passUser = pass.Text;

            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE `Login`=@ul AND `Password`=@up", db.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@up", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                Regisrtation form = new Regisrtation();
                form.Show();
            }
            else MessageBox.Show("No");
        }

        private void Forma_Reg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Regisrtation form = new Regisrtation();
            form.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
