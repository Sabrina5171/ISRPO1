namespace Razrabotka
{
    partial class Regestration
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
            this.Header = new System.Windows.Forms.Label();
            this.Surnamelabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Loginlabel = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.RepeatPassword = new System.Windows.Forms.TextBox();
            this.RepeatPasswordlabel = new System.Windows.Forms.Label();
            this.SecretQuestionsHeader = new System.Windows.Forms.Label();
            this.CodWordHeader = new System.Windows.Forms.Label();
            this.CodeWord = new System.Windows.Forms.TextBox();
            this.CodeWordlabel = new System.Windows.Forms.Label();
            this.SecretQuestionlabel = new System.Windows.Forms.Label();
            this.SecretQuestion = new System.Windows.Forms.ComboBox();
            this.Answer = new System.Windows.Forms.TextBox();
            this.Answerlabel = new System.Windows.Forms.Label();
            this.CheckAgreement = new System.Windows.Forms.CheckBox();
            this.Button = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Label();
            this.Conditionlabel = new System.Windows.Forms.Label();
            this.CheckPassword = new System.Windows.Forms.CheckBox();
            this.CheckRepeat = new System.Windows.Forms.CheckBox();
            this.CheckPas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.SystemColors.Window;
            this.Header.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.Header.Location = new System.Drawing.Point(12, 9);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(261, 25);
            this.Header.TabIndex = 0;
            this.Header.Text = "Персональная информация";
            this.Header.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Surnamelabel
            // 
            this.Surnamelabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.Surnamelabel.Location = new System.Drawing.Point(15, 34);
            this.Surnamelabel.Name = "Surnamelabel";
            this.Surnamelabel.Size = new System.Drawing.Size(68, 18);
            this.Surnamelabel.TabIndex = 1;
            this.Surnamelabel.Text = "Фамилия";
            // 
            // Namelabel
            // 
            this.Namelabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.Namelabel.Location = new System.Drawing.Point(15, 85);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(33, 18);
            this.Namelabel.TabIndex = 2;
            this.Namelabel.Text = "Имя";
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(16, 55);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(252, 20);
            this.Surname.TabIndex = 3;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(18, 106);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(252, 20);
            this.Name.TabIndex = 4;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(18, 148);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(252, 20);
            this.Login.TabIndex = 6;
            // 
            // Loginlabel
            // 
            this.Loginlabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.Loginlabel.Location = new System.Drawing.Point(15, 129);
            this.Loginlabel.Name = "Loginlabel";
            this.Loginlabel.Size = new System.Drawing.Size(94, 16);
            this.Loginlabel.TabIndex = 5;
            this.Loginlabel.Text = "E-mail (Логин)";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(16, 195);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(252, 20);
            this.Password.TabIndex = 8;
            this.Password.UseSystemPasswordChar = true;
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.Passwordlabel.Location = new System.Drawing.Point(15, 171);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(50, 21);
            this.Passwordlabel.TabIndex = 7;
            this.Passwordlabel.Text = "Пароль";
            // 
            // RepeatPassword
            // 
            this.RepeatPassword.ForeColor = System.Drawing.Color.Black;
            this.RepeatPassword.Location = new System.Drawing.Point(16, 238);
            this.RepeatPassword.Name = "RepeatPassword";
            this.RepeatPassword.Size = new System.Drawing.Size(252, 20);
            this.RepeatPassword.TabIndex = 10;
            this.RepeatPassword.UseSystemPasswordChar = true;
            // 
            // RepeatPasswordlabel
            // 
            this.RepeatPasswordlabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.RepeatPasswordlabel.Location = new System.Drawing.Point(15, 218);
            this.RepeatPasswordlabel.Name = "RepeatPasswordlabel";
            this.RepeatPasswordlabel.Size = new System.Drawing.Size(115, 17);
            this.RepeatPasswordlabel.TabIndex = 9;
            this.RepeatPasswordlabel.Text = "Повторите пароль";
            // 
            // SecretQuestionsHeader
            // 
            this.SecretQuestionsHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.SecretQuestionsHeader.Location = new System.Drawing.Point(14, 371);
            this.SecretQuestionsHeader.Name = "SecretQuestionsHeader";
            this.SecretQuestionsHeader.Size = new System.Drawing.Size(433, 23);
            this.SecretQuestionsHeader.TabIndex = 11;
            this.SecretQuestionsHeader.Text = "Секретный вопрос для восстановления пароля";
            this.SecretQuestionsHeader.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CodWordHeader
            // 
            this.CodWordHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.CodWordHeader.Location = new System.Drawing.Point(12, 276);
            this.CodWordHeader.Name = "CodWordHeader";
            this.CodWordHeader.Size = new System.Drawing.Size(141, 23);
            this.CodWordHeader.TabIndex = 12;
            this.CodWordHeader.Text = "Кодовое слово";
            this.CodWordHeader.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CodeWord
            // 
            this.CodeWord.Location = new System.Drawing.Point(18, 323);
            this.CodeWord.Name = "CodeWord";
            this.CodeWord.Size = new System.Drawing.Size(252, 20);
            this.CodeWord.TabIndex = 14;
            this.CodeWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodeWord_KeyPress);
            // 
            // CodeWordlabel
            // 
            this.CodeWordlabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.CodeWordlabel.Location = new System.Drawing.Point(13, 299);
            this.CodeWordlabel.Name = "CodeWordlabel";
            this.CodeWordlabel.Size = new System.Drawing.Size(130, 21);
            this.CodeWordlabel.TabIndex = 13;
            this.CodeWordlabel.Text = "Кодовое слово (одно)";
            // 
            // SecretQuestionlabel
            // 
            this.SecretQuestionlabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.SecretQuestionlabel.Location = new System.Drawing.Point(15, 394);
            this.SecretQuestionlabel.Name = "SecretQuestionlabel";
            this.SecretQuestionlabel.Size = new System.Drawing.Size(217, 31);
            this.SecretQuestionlabel.TabIndex = 15;
            this.SecretQuestionlabel.Text = "Секретный вопрос";
            // 
            // SecretQuestion
            // 
            this.SecretQuestion.FormattingEnabled = true;
            this.SecretQuestion.Location = new System.Drawing.Point(19, 421);
            this.SecretQuestion.Name = "SecretQuestion";
            this.SecretQuestion.Size = new System.Drawing.Size(252, 21);
            this.SecretQuestion.TabIndex = 16;
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(19, 478);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(252, 20);
            this.Answer.TabIndex = 18;
            this.Answer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodeWord_KeyPress);
            // 
            // Answerlabel
            // 
            this.Answerlabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.Answerlabel.Location = new System.Drawing.Point(15, 452);
            this.Answerlabel.Name = "Answerlabel";
            this.Answerlabel.Size = new System.Drawing.Size(217, 31);
            this.Answerlabel.TabIndex = 17;
            this.Answerlabel.Text = "Ответ на вопрос";
            // 
            // CheckAgreement
            // 
            this.CheckAgreement.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckAgreement.Location = new System.Drawing.Point(19, 506);
            this.CheckAgreement.Name = "CheckAgreement";
            this.CheckAgreement.Size = new System.Drawing.Size(160, 25);
            this.CheckAgreement.TabIndex = 19;
            this.CheckAgreement.Text = "Согласен с условиями";
            this.CheckAgreement.UseVisualStyleBackColor = true;
            this.CheckAgreement.CheckedChanged += new System.EventHandler(this.CheckAgreement_CheckedChanged);
            // 
            // Button
            // 
            this.Button.BackColor = System.Drawing.SystemColors.Window;
            this.Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Button.Location = new System.Drawing.Point(19, 537);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(251, 23);
            this.Button.TabIndex = 20;
            this.Button.Text = "Далее";
            this.Button.UseVisualStyleBackColor = false;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.SystemColors.Window;
            this.Close.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Close.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Close.Location = new System.Drawing.Point(548, 9);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(19, 20);
            this.Close.TabIndex = 21;
            this.Close.Text = "х";
            this.Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Conditionlabel
            // 
            this.Conditionlabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.Conditionlabel.ForeColor = System.Drawing.Color.Red;
            this.Conditionlabel.Location = new System.Drawing.Point(414, 260);
            this.Conditionlabel.Name = "Conditionlabel";
            this.Conditionlabel.Size = new System.Drawing.Size(252, 23);
            this.Conditionlabel.TabIndex = 22;
            // 
            // CheckPassword
            // 
            this.CheckPassword.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckPassword.Location = new System.Drawing.Point(274, 195);
            this.CheckPassword.Name = "CheckPassword";
            this.CheckPassword.Size = new System.Drawing.Size(18, 25);
            this.CheckPassword.TabIndex = 23;
            this.CheckPassword.UseVisualStyleBackColor = true;
            this.CheckPassword.CheckedChanged += new System.EventHandler(this.CheckPassword_CheckedChanged);
            // 
            // CheckRepeat
            // 
            this.CheckRepeat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckRepeat.Location = new System.Drawing.Point(274, 238);
            this.CheckRepeat.Name = "CheckRepeat";
            this.CheckRepeat.Size = new System.Drawing.Size(18, 25);
            this.CheckRepeat.TabIndex = 24;
            this.CheckRepeat.UseVisualStyleBackColor = true;
            this.CheckRepeat.CheckedChanged += new System.EventHandler(this.CheckRepeat_CheckedChanged);
            // 
            // CheckPas
            // 
            this.CheckPas.Location = new System.Drawing.Point(414, 260);
            this.CheckPas.Name = "CheckPas";
            this.CheckPas.Size = new System.Drawing.Size(279, 18);
            this.CheckPas.TabIndex = 26;
            // 
            // Regestration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(575, 578);
            this.Controls.Add(this.CheckPas);
            this.Controls.Add(this.CheckRepeat);
            this.Controls.Add(this.CheckPassword);
            this.Controls.Add(this.Conditionlabel);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.CheckAgreement);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Answerlabel);
            this.Controls.Add(this.SecretQuestion);
            this.Controls.Add(this.SecretQuestionlabel);
            this.Controls.Add(this.CodeWord);
            this.Controls.Add(this.CodeWordlabel);
            this.Controls.Add(this.CodWordHeader);
            this.Controls.Add(this.SecretQuestionsHeader);
            this.Controls.Add(this.RepeatPassword);
            this.Controls.Add(this.RepeatPasswordlabel);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Passwordlabel);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Loginlabel);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.Surnamelabel);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Regestration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Label Surnamelabel;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Label Loginlabel;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.TextBox RepeatPassword;
        private System.Windows.Forms.Label RepeatPasswordlabel;
        private System.Windows.Forms.Label SecretQuestionsHeader;
        private System.Windows.Forms.Label CodWordHeader;
        private System.Windows.Forms.TextBox CodeWord;
        private System.Windows.Forms.Label CodeWordlabel;
        private System.Windows.Forms.Label SecretQuestionlabel;
        private System.Windows.Forms.ComboBox SecretQuestion;
        private System.Windows.Forms.TextBox Answer;
        private System.Windows.Forms.Label Answerlabel;
        private System.Windows.Forms.CheckBox CheckAgreement;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Label Conditionlabel;
        private System.Windows.Forms.CheckBox CheckPassword;
        private System.Windows.Forms.CheckBox CheckRepeat;
        private System.Windows.Forms.Label CheckPas;
    }
}

