
namespace RegisterAuto
{
    partial class Admin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.product = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.label1.Location = new System.Drawing.Point(118, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Натуральный мёд";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.Location = new System.Drawing.Point(12, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(609, 290);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.label2.Location = new System.Drawing.Point(187, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Администратор/Пользователи";
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.save.Location = new System.Drawing.Point(12, 432);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(127, 34);
            this.save.TabIndex = 4;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.delete.Location = new System.Drawing.Point(145, 432);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(127, 34);
            this.delete.TabIndex = 5;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.edit.Location = new System.Drawing.Point(278, 432);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(127, 34);
            this.edit.TabIndex = 6;
            this.edit.Text = "Редактировать";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.add.Location = new System.Drawing.Point(12, 472);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(127, 34);
            this.add.TabIndex = 7;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.product.Location = new System.Drawing.Point(145, 472);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(127, 34);
            this.product.TabIndex = 8;
            this.product.Text = "Товары";
            this.product.UseVisualStyleBackColor = true;
            this.product.Click += new System.EventHandler(this.product_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.exit.Location = new System.Drawing.Point(278, 472);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(127, 34);
            this.exit.TabIndex = 9;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Close
            // 
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold);
            this.Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.Close.Location = new System.Drawing.Point(601, -11);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(34, 41);
            this.Close.TabIndex = 10;
            this.Close.Text = "x";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RegisterAuto.Properties.Resources.pngwing_com__31_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(633, 517);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.product);
            this.Controls.Add(this.add);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button product;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button Close;
    }
}