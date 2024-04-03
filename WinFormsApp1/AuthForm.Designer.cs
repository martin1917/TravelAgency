namespace WinFormsApp1
{
    partial class AuthForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tabRegistration = new System.Windows.Forms.TabPage();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRegistrate = new System.Windows.Forms.Button();
            this.tbRepeatPassword = new System.Windows.Forms.TextBox();
            this.tbPasswordNew = new System.Windows.Forms.TextBox();
            this.tbLoginNew = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPatronymic = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSecondName = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLogin);
            this.tabControl1.Controls.Add(this.tabRegistration);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(813, 360);
            this.tabControl1.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Controls.Add(this.label2);
            this.tabLogin.Controls.Add(this.label1);
            this.tabLogin.Controls.Add(this.tbPassword);
            this.tabLogin.Controls.Add(this.tbLogin);
            this.tabLogin.Location = new System.Drawing.Point(4, 24);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(805, 332);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Авторизация";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(461, 222);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(67, 23);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Логин:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(331, 171);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PlaceholderText = "Пароль";
            this.tbPassword.Size = new System.Drawing.Size(197, 23);
            this.tbPassword.TabIndex = 7;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(331, 114);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.PlaceholderText = "Логин";
            this.tbLogin.Size = new System.Drawing.Size(197, 23);
            this.tbLogin.TabIndex = 6;
            // 
            // tabRegistration
            // 
            this.tabRegistration.Controls.Add(this.dtpBirthday);
            this.tabRegistration.Controls.Add(this.label9);
            this.tabRegistration.Controls.Add(this.label8);
            this.tabRegistration.Controls.Add(this.label7);
            this.tabRegistration.Controls.Add(this.label6);
            this.tabRegistration.Controls.Add(this.label5);
            this.tabRegistration.Controls.Add(this.label4);
            this.tabRegistration.Controls.Add(this.label3);
            this.tabRegistration.Controls.Add(this.label10);
            this.tabRegistration.Controls.Add(this.label11);
            this.tabRegistration.Controls.Add(this.btnRegistrate);
            this.tabRegistration.Controls.Add(this.tbRepeatPassword);
            this.tabRegistration.Controls.Add(this.tbPasswordNew);
            this.tabRegistration.Controls.Add(this.tbLoginNew);
            this.tabRegistration.Controls.Add(this.tbPhoneNumber);
            this.tabRegistration.Controls.Add(this.tbEmail);
            this.tabRegistration.Controls.Add(this.tbPatronymic);
            this.tabRegistration.Controls.Add(this.tbName);
            this.tabRegistration.Controls.Add(this.tbSecondName);
            this.tabRegistration.Location = new System.Drawing.Point(4, 24);
            this.tabRegistration.Name = "tabRegistration";
            this.tabRegistration.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistration.Size = new System.Drawing.Size(805, 332);
            this.tabRegistration.TabIndex = 1;
            this.tabRegistration.Text = "Регистрация";
            this.tabRegistration.UseVisualStyleBackColor = true;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(169, 182);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(211, 23);
            this.dtpBirthday.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(465, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 15);
            this.label9.TabIndex = 39;
            this.label9.Text = "Повторите пароль:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(465, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 38;
            this.label8.Text = "Пароль:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(465, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 37;
            this.label7.Text = "Логин:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "Номер телефона:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "Почта: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Дата рождения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Отчество:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 15);
            this.label10.TabIndex = 32;
            this.label10.Text = "Имя:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 15);
            this.label11.TabIndex = 31;
            this.label11.Text = "Фамилия:";
            // 
            // btnRegistrate
            // 
            this.btnRegistrate.Location = new System.Drawing.Point(627, 268);
            this.btnRegistrate.Name = "btnRegistrate";
            this.btnRegistrate.Size = new System.Drawing.Size(143, 23);
            this.btnRegistrate.TabIndex = 29;
            this.btnRegistrate.Text = "Зарегистрироваться";
            this.btnRegistrate.UseVisualStyleBackColor = true;
            this.btnRegistrate.Click += new System.EventHandler(this.btnRegistrate_Click);
            // 
            // tbRepeatPassword
            // 
            this.tbRepeatPassword.Location = new System.Drawing.Point(595, 206);
            this.tbRepeatPassword.Name = "tbRepeatPassword";
            this.tbRepeatPassword.PlaceholderText = "Повторите пароль";
            this.tbRepeatPassword.Size = new System.Drawing.Size(175, 23);
            this.tbRepeatPassword.TabIndex = 28;
            // 
            // tbPasswordNew
            // 
            this.tbPasswordNew.Location = new System.Drawing.Point(595, 150);
            this.tbPasswordNew.Name = "tbPasswordNew";
            this.tbPasswordNew.PlaceholderText = "Пароль";
            this.tbPasswordNew.Size = new System.Drawing.Size(175, 23);
            this.tbPasswordNew.TabIndex = 27;
            // 
            // tbLoginNew
            // 
            this.tbLoginNew.Location = new System.Drawing.Point(595, 94);
            this.tbLoginNew.Name = "tbLoginNew";
            this.tbLoginNew.PlaceholderText = "Логин";
            this.tbLoginNew.Size = new System.Drawing.Size(175, 23);
            this.tbLoginNew.TabIndex = 26;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(169, 290);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.PlaceholderText = "Номер телефона";
            this.tbPhoneNumber.Size = new System.Drawing.Size(211, 23);
            this.tbPhoneNumber.TabIndex = 25;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(169, 236);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PlaceholderText = "Почта";
            this.tbEmail.Size = new System.Drawing.Size(211, 23);
            this.tbEmail.TabIndex = 24;
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.Location = new System.Drawing.Point(169, 128);
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.PlaceholderText = "Отчество";
            this.tbPatronymic.Size = new System.Drawing.Size(211, 23);
            this.tbPatronymic.TabIndex = 23;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(169, 74);
            this.tbName.Name = "tbName";
            this.tbName.PlaceholderText = "Имя";
            this.tbName.Size = new System.Drawing.Size(211, 23);
            this.tbName.TabIndex = 22;
            // 
            // tbSecondName
            // 
            this.tbSecondName.Location = new System.Drawing.Point(169, 20);
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.PlaceholderText = "Фамилия";
            this.tbSecondName.Size = new System.Drawing.Size(211, 23);
            this.tbSecondName.TabIndex = 21;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 384);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AuthForm";
            this.Text = "Вход";
            this.tabControl1.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabRegistration.ResumeLayout(false);
            this.tabRegistration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabLogin;
        private TabPage tabRegistration;
        private Button btnLogin;
        private Label label2;
        private Label label1;
        private TextBox tbPassword;
        private TextBox tbLogin;
        private DateTimePicker dtpBirthday;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label10;
        private Label label11;
        private Button btnRegistrate;
        private TextBox tbRepeatPassword;
        private TextBox tbPasswordNew;
        private TextBox tbLoginNew;
        private TextBox tbPhoneNumber;
        private TextBox tbEmail;
        private TextBox tbPatronymic;
        private TextBox tbName;
        private TextBox tbSecondName;
    }
}