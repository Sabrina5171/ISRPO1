
namespace RegisterAuto
{
    partial class Director
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.product = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.label1.Location = new System.Drawing.Point(118, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Натуральный мёд";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RegisterAuto.Properties.Resources.pngwing_com__31_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Close
            // 
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold);
            this.Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.Close.Location = new System.Drawing.Point(602, -11);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(34, 41);
            this.Close.TabIndex = 11;
            this.Close.Text = "x";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.Location = new System.Drawing.Point(12, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(609, 290);
            this.dataGridView1.TabIndex = 12;
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.product.Location = new System.Drawing.Point(12, 108);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(127, 34);
            this.product.TabIndex = 13;
            this.product.Text = "Товары";
            this.product.UseVisualStyleBackColor = true;
            this.product.Click += new System.EventHandler(this.product_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.button1.Location = new System.Drawing.Point(145, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 34);
            this.button1.TabIndex = 31;
            this.button1.Text = "Пользователи";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.exit.Location = new System.Drawing.Point(278, 108);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(127, 34);
            this.exit.TabIndex = 32;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Director
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.product);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Director";
            this.Text = "Director";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button product;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exit;
    }
}