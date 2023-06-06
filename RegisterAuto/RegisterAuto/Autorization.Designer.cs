
namespace RegisterAuto
{
    partial class Autorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.login = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.vxod = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Forma_Reg = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.login.Location = new System.Drawing.Point(101, 116);
            this.login.Multiline = true;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(196, 24);
            this.login.TabIndex = 0;
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.pass.Location = new System.Drawing.Point(102, 174);
            this.pass.Multiline = true;
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(196, 24);
            this.pass.TabIndex = 1;
            // 
            // vxod
            // 
            this.vxod.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.vxod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.vxod.Location = new System.Drawing.Point(143, 237);
            this.vxod.Name = "vxod";
            this.vxod.Size = new System.Drawing.Size(106, 43);
            this.vxod.TabIndex = 2;
            this.vxod.Text = "Войти";
            this.vxod.UseVisualStyleBackColor = true;
            this.vxod.Click += new System.EventHandler(this.vxod_Click);
            // 
            // Close
            // 
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold);
            this.Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.Close.Location = new System.Drawing.Point(386, -15);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(34, 41);
            this.Close.TabIndex = 3;
            this.Close.Text = "x";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.label1.Location = new System.Drawing.Point(98, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.label2.Location = new System.Drawing.Point(98, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.label3.Location = new System.Drawing.Point(93, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 45);
            this.label3.TabIndex = 6;
            this.label3.Text = "Авторизация";
            // 
            // Forma_Reg
            // 
            this.Forma_Reg.AutoSize = true;
            this.Forma_Reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Forma_Reg.Location = new System.Drawing.Point(149, 201);
            this.Forma_Reg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Forma_Reg.Name = "Forma_Reg";
            this.Forma_Reg.Size = new System.Drawing.Size(149, 13);
            this.Forma_Reg.TabIndex = 10;
            this.Forma_Reg.TabStop = true;
            this.Forma_Reg.Text = "Еще не зарегистрированы?";
            this.Forma_Reg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Forma_Reg_LinkClicked);
            // 
            // Autorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(415, 309);
            this.Controls.Add(this.Forma_Reg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.vxod);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Autorization";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button vxod;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel Forma_Reg;
    }
}

