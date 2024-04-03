namespace WinFormsApp1
{
    partial class MainForm
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
            this.tabClients = new System.Windows.Forms.TabPage();
            this.btnLoadClients = new System.Windows.Forms.Button();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPatronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabTours = new System.Windows.Forms.TabPage();
            this.tabRequests = new System.Windows.Forms.TabPage();
            this.tabAnalytics = new System.Windows.Forms.TabPage();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabClients);
            this.tabControl1.Controls.Add(this.tabTours);
            this.tabControl1.Controls.Add(this.tabRequests);
            this.tabControl1.Controls.Add(this.tabAnalytics);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(966, 513);
            this.tabControl1.TabIndex = 0;
            // 
            // tabClients
            // 
            this.tabClients.Controls.Add(this.btnLoadClients);
            this.tabClients.Controls.Add(this.dataGridViewClients);
            this.tabClients.Location = new System.Drawing.Point(4, 24);
            this.tabClients.Name = "tabClients";
            this.tabClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabClients.Size = new System.Drawing.Size(958, 485);
            this.tabClients.TabIndex = 0;
            this.tabClients.Text = "Клиенты";
            this.tabClients.UseVisualStyleBackColor = true;
            // 
            // btnLoadClients
            // 
            this.btnLoadClients.Location = new System.Drawing.Point(877, 6);
            this.btnLoadClients.Name = "btnLoadClients";
            this.btnLoadClients.Size = new System.Drawing.Size(75, 23);
            this.btnLoadClients.TabIndex = 1;
            this.btnLoadClients.Text = "Загрузить";
            this.btnLoadClients.UseVisualStyleBackColor = true;
            this.btnLoadClients.Click += new System.EventHandler(this.btnLoadClients_Click);
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AllowUserToAddRows = false;
            this.dataGridViewClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnSecondName,
            this.ColumnName,
            this.ColumnPatronymic,
            this.ColumnBirthday,
            this.ColumnEmail,
            this.ColumnPhoneNumber});
            this.dataGridViewClients.Location = new System.Drawing.Point(9, 35);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.RowHeadersVisible = false;
            this.dataGridViewClients.RowTemplate.Height = 25;
            this.dataGridViewClients.Size = new System.Drawing.Size(943, 442);
            this.dataGridViewClients.TabIndex = 0;
            // 
            // ColumnID
            // 
            this.ColumnID.FillWeight = 39.23767F;
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnSecondName
            // 
            this.ColumnSecondName.FillWeight = 92.5895F;
            this.ColumnSecondName.HeaderText = "Фамилия";
            this.ColumnSecondName.Name = "ColumnSecondName";
            this.ColumnSecondName.ReadOnly = true;
            // 
            // ColumnName
            // 
            this.ColumnName.FillWeight = 100.7225F;
            this.ColumnName.HeaderText = "Имя";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnPatronymic
            // 
            this.ColumnPatronymic.FillWeight = 107.9437F;
            this.ColumnPatronymic.HeaderText = "Отчество";
            this.ColumnPatronymic.Name = "ColumnPatronymic";
            this.ColumnPatronymic.ReadOnly = true;
            // 
            // ColumnBirthday
            // 
            this.ColumnBirthday.FillWeight = 114.3554F;
            this.ColumnBirthday.HeaderText = "Дата рождения";
            this.ColumnBirthday.Name = "ColumnBirthday";
            this.ColumnBirthday.ReadOnly = true;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.FillWeight = 120.0483F;
            this.ColumnEmail.HeaderText = "Почта";
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.ReadOnly = true;
            // 
            // ColumnPhoneNumber
            // 
            this.ColumnPhoneNumber.FillWeight = 125.103F;
            this.ColumnPhoneNumber.HeaderText = "Номер телефона";
            this.ColumnPhoneNumber.Name = "ColumnPhoneNumber";
            this.ColumnPhoneNumber.ReadOnly = true;
            // 
            // tabTours
            // 
            this.tabTours.Location = new System.Drawing.Point(4, 24);
            this.tabTours.Name = "tabTours";
            this.tabTours.Padding = new System.Windows.Forms.Padding(3);
            this.tabTours.Size = new System.Drawing.Size(958, 485);
            this.tabTours.TabIndex = 1;
            this.tabTours.Text = "Туры";
            this.tabTours.UseVisualStyleBackColor = true;
            // 
            // tabRequests
            // 
            this.tabRequests.Location = new System.Drawing.Point(4, 24);
            this.tabRequests.Name = "tabRequests";
            this.tabRequests.Padding = new System.Windows.Forms.Padding(3);
            this.tabRequests.Size = new System.Drawing.Size(958, 485);
            this.tabRequests.TabIndex = 2;
            this.tabRequests.Text = "Заявки";
            this.tabRequests.UseVisualStyleBackColor = true;
            // 
            // tabAnalytics
            // 
            this.tabAnalytics.Location = new System.Drawing.Point(4, 24);
            this.tabAnalytics.Name = "tabAnalytics";
            this.tabAnalytics.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnalytics.Size = new System.Drawing.Size(958, 485);
            this.tabAnalytics.TabIndex = 3;
            this.tabAnalytics.Text = "Статистика";
            this.tabAnalytics.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(893, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Выйти";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 566);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Учет и анализ клиентов в турагентстве";
            this.tabControl1.ResumeLayout(false);
            this.tabClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabClients;
        private DataGridView dataGridViewClients;
        private TabPage tabTours;
        private TabPage tabRequests;
        private TabPage tabAnalytics;
        private Button btnLoadClients;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnSecondName;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnPatronymic;
        private DataGridViewTextBoxColumn ColumnBirthday;
        private DataGridViewTextBoxColumn ColumnEmail;
        private DataGridViewTextBoxColumn ColumnPhoneNumber;
        private Button btnLogout;
    }
}