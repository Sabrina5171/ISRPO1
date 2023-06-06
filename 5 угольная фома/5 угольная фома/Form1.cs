using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_угольная_фома
{
    public partial class Close : Form
    {
        public Close()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Close_Load(object sender, EventArgs e)
        {
            
                System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
             
                Point[] mp = new Point[5];

                mp[0] = new Point(0, 100);
                mp[1] = new Point(70, 500);
                mp[2] = new Point(400, 350);
                mp[3] = new Point(600, 100);
                mp[4] = new Point(500, 10);

          
                gp.AddPolygon(mp);

              
                Region rg = new Region(gp);

              
                this.Region = rg;
            

        }
    }
}
