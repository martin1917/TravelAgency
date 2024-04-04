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
            this.components = new System.ComponentModel.Container();
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
            this.btnAddTour = new System.Windows.Forms.Button();
            this.btnLoadTours = new System.Windows.Forms.Button();
            this.dataGridViewTours = new System.Windows.Forms.DataGridView();
            this.ColumnTourID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTourName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTourCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTourHotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTourTypeRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTourTypeFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTourPricePurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTourPriceSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTourDataStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTourDateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTourIsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabRequests = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.btnLoadRequests = new System.Windows.Forms.Button();
            this.dataGridViewRequests = new System.Windows.Forms.DataGridView();
            this.ColumnRequestsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRequestsClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRequestsTourID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRequestsTourAgentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRequestsStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRequestsDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabAnalytics = new System.Windows.Forms.TabPage();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.dataGridViewStats = new System.Windows.Forms.DataGridView();
            this.btnStatCountry = new System.Windows.Forms.Button();
            this.btnStatClient = new System.Windows.Forms.Button();
            this.contextMenuStripTours = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemBookToor = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCurrentRole = new System.Windows.Forms.TextBox();
            this.tbCurrentUsername = new System.Windows.Forms.TextBox();
            this.contextMenuStripRequests = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemChangeStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.tabTours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTours)).BeginInit();
            this.tabRequests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).BeginInit();
            this.tabAnalytics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStats)).BeginInit();
            this.contextMenuStripTours.SuspendLayout();
            this.contextMenuStripRequests.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabClients);
            this.tabControl1.Controls.Add(this.tabTours);
            this.tabControl1.Controls.Add(this.tabRequests);
            this.tabControl1.Controls.Add(this.tabAnalytics);
            this.tabControl1.Location = new System.Drawing.Point(12, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(966, 506);
            this.tabControl1.TabIndex = 0;
            // 
            // tabClients
            // 
            this.tabClients.Controls.Add(this.btnLoadClients);
            this.tabClients.Controls.Add(this.dataGridViewClients);
            this.tabClients.Location = new System.Drawing.Point(4, 24);
            this.tabClients.Name = "tabClients";
            this.tabClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabClients.Size = new System.Drawing.Size(958, 478);
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
            this.dataGridViewClients.Size = new System.Drawing.Size(943, 473);
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
            this.tabTours.Controls.Add(this.btnAddTour);
            this.tabTours.Controls.Add(this.btnLoadTours);
            this.tabTours.Controls.Add(this.dataGridViewTours);
            this.tabTours.Location = new System.Drawing.Point(4, 24);
            this.tabTours.Name = "tabTours";
            this.tabTours.Padding = new System.Windows.Forms.Padding(3);
            this.tabTours.Size = new System.Drawing.Size(958, 478);
            this.tabTours.TabIndex = 1;
            this.tabTours.Text = "Туры";
            this.tabTours.UseVisualStyleBackColor = true;
            // 
            // btnAddTour
            // 
            this.btnAddTour.Location = new System.Drawing.Point(796, 6);
            this.btnAddTour.Name = "btnAddTour";
            this.btnAddTour.Size = new System.Drawing.Size(75, 23);
            this.btnAddTour.TabIndex = 2;
            this.btnAddTour.Text = "Добавить";
            this.btnAddTour.UseVisualStyleBackColor = true;
            this.btnAddTour.Click += new System.EventHandler(this.btnAddTour_Click);
            // 
            // btnLoadTours
            // 
            this.btnLoadTours.Location = new System.Drawing.Point(877, 6);
            this.btnLoadTours.Name = "btnLoadTours";
            this.btnLoadTours.Size = new System.Drawing.Size(75, 23);
            this.btnLoadTours.TabIndex = 1;
            this.btnLoadTours.Text = "Загрузить";
            this.btnLoadTours.UseVisualStyleBackColor = true;
            this.btnLoadTours.Click += new System.EventHandler(this.btnLoadTours_Click);
            // 
            // dataGridViewTours
            // 
            this.dataGridViewTours.AllowUserToAddRows = false;
            this.dataGridViewTours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTours.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTourID,
            this.ColumnTourName,
            this.ColumnTourCountry,
            this.ColumnTourHotel,
            this.ColumnTourTypeRoom,
            this.ColumnTourTypeFood,
            this.ColumnTourPricePurchase,
            this.ColumnTourPriceSale,
            this.ColumnTourDataStart,
            this.ColumnTourDateEnd,
            this.ColumnTourIsActive});
            this.dataGridViewTours.Location = new System.Drawing.Point(6, 35);
            this.dataGridViewTours.Name = "dataGridViewTours";
            this.dataGridViewTours.RowHeadersVisible = false;
            this.dataGridViewTours.RowTemplate.Height = 25;
            this.dataGridViewTours.Size = new System.Drawing.Size(946, 473);
            this.dataGridViewTours.TabIndex = 0;
            this.dataGridViewTours.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTours_CellDoubleClick);
            // 
            // ColumnTourID
            // 
            this.ColumnTourID.FillWeight = 50F;
            this.ColumnTourID.HeaderText = "ID";
            this.ColumnTourID.Name = "ColumnTourID";
            this.ColumnTourID.ReadOnly = true;
            // 
            // ColumnTourName
            // 
            this.ColumnTourName.FillWeight = 101.8558F;
            this.ColumnTourName.HeaderText = "Название";
            this.ColumnTourName.Name = "ColumnTourName";
            this.ColumnTourName.ReadOnly = true;
            // 
            // ColumnTourCountry
            // 
            this.ColumnTourCountry.FillWeight = 101.8421F;
            this.ColumnTourCountry.HeaderText = "Страна";
            this.ColumnTourCountry.Name = "ColumnTourCountry";
            this.ColumnTourCountry.ReadOnly = true;
            // 
            // ColumnTourHotel
            // 
            this.ColumnTourHotel.FillWeight = 101.8271F;
            this.ColumnTourHotel.HeaderText = "Отель";
            this.ColumnTourHotel.Name = "ColumnTourHotel";
            this.ColumnTourHotel.ReadOnly = true;
            // 
            // ColumnTourTypeRoom
            // 
            this.ColumnTourTypeRoom.FillWeight = 101.8106F;
            this.ColumnTourTypeRoom.HeaderText = "Тип комнаты";
            this.ColumnTourTypeRoom.Name = "ColumnTourTypeRoom";
            this.ColumnTourTypeRoom.ReadOnly = true;
            // 
            // ColumnTourTypeFood
            // 
            this.ColumnTourTypeFood.FillWeight = 103.1594F;
            this.ColumnTourTypeFood.HeaderText = "Тип питания";
            this.ColumnTourTypeFood.Name = "ColumnTourTypeFood";
            this.ColumnTourTypeFood.ReadOnly = true;
            // 
            // ColumnTourPricePurchase
            // 
            this.ColumnTourPricePurchase.FillWeight = 101.909F;
            this.ColumnTourPricePurchase.HeaderText = "Цена покупки";
            this.ColumnTourPricePurchase.Name = "ColumnTourPricePurchase";
            this.ColumnTourPricePurchase.ReadOnly = true;
            // 
            // ColumnTourPriceSale
            // 
            this.ColumnTourPriceSale.FillWeight = 101.9007F;
            this.ColumnTourPriceSale.HeaderText = "Цена продажи";
            this.ColumnTourPriceSale.Name = "ColumnTourPriceSale";
            this.ColumnTourPriceSale.ReadOnly = true;
            // 
            // ColumnTourDataStart
            // 
            this.ColumnTourDataStart.FillWeight = 101.8915F;
            this.ColumnTourDataStart.HeaderText = "Начало";
            this.ColumnTourDataStart.Name = "ColumnTourDataStart";
            this.ColumnTourDataStart.ReadOnly = true;
            // 
            // ColumnTourDateEnd
            // 
            this.ColumnTourDateEnd.FillWeight = 101.8814F;
            this.ColumnTourDateEnd.HeaderText = "Окончание";
            this.ColumnTourDateEnd.Name = "ColumnTourDateEnd";
            this.ColumnTourDateEnd.ReadOnly = true;
            // 
            // ColumnTourIsActive
            // 
            this.ColumnTourIsActive.FillWeight = 75F;
            this.ColumnTourIsActive.HeaderText = "Активно";
            this.ColumnTourIsActive.Name = "ColumnTourIsActive";
            this.ColumnTourIsActive.ReadOnly = true;
            // 
            // tabRequests
            // 
            this.tabRequests.Controls.Add(this.label1);
            this.tabRequests.Controls.Add(this.comboBoxStatus);
            this.tabRequests.Controls.Add(this.btnLoadRequests);
            this.tabRequests.Controls.Add(this.dataGridViewRequests);
            this.tabRequests.Location = new System.Drawing.Point(4, 24);
            this.tabRequests.Name = "tabRequests";
            this.tabRequests.Padding = new System.Windows.Forms.Padding(3);
            this.tabRequests.Size = new System.Drawing.Size(958, 478);
            this.tabRequests.TabIndex = 2;
            this.tabRequests.Text = "Заявки";
            this.tabRequests.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(701, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Статус";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "НЕТ",
            "НЕОБРАБОТАНА",
            "ОЖИДАНИЕ",
            "ОПЛАЧЕНА",
            "ОТМЕНЕНА"});
            this.comboBoxStatus.Location = new System.Drawing.Point(750, 7);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 23);
            this.comboBoxStatus.TabIndex = 3;
            // 
            // btnLoadRequests
            // 
            this.btnLoadRequests.Location = new System.Drawing.Point(877, 6);
            this.btnLoadRequests.Name = "btnLoadRequests";
            this.btnLoadRequests.Size = new System.Drawing.Size(75, 23);
            this.btnLoadRequests.TabIndex = 2;
            this.btnLoadRequests.Text = "Загрузить";
            this.btnLoadRequests.UseVisualStyleBackColor = true;
            this.btnLoadRequests.Click += new System.EventHandler(this.btnLoadRequests_Click);
            // 
            // dataGridViewRequests
            // 
            this.dataGridViewRequests.AllowUserToAddRows = false;
            this.dataGridViewRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnRequestsID,
            this.ColumnRequestsClientID,
            this.ColumnRequestsTourID,
            this.ColumnRequestsTourAgentID,
            this.ColumnRequestsStatus,
            this.ColumnRequestsDate});
            this.dataGridViewRequests.Location = new System.Drawing.Point(6, 36);
            this.dataGridViewRequests.Name = "dataGridViewRequests";
            this.dataGridViewRequests.RowHeadersVisible = false;
            this.dataGridViewRequests.RowTemplate.Height = 25;
            this.dataGridViewRequests.Size = new System.Drawing.Size(946, 472);
            this.dataGridViewRequests.TabIndex = 0;
            this.dataGridViewRequests.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewRequests_CellMouseClick);
            // 
            // ColumnRequestsID
            // 
            this.ColumnRequestsID.FillWeight = 50F;
            this.ColumnRequestsID.HeaderText = "ID";
            this.ColumnRequestsID.Name = "ColumnRequestsID";
            this.ColumnRequestsID.ReadOnly = true;
            // 
            // ColumnRequestsClientID
            // 
            this.ColumnRequestsClientID.HeaderText = "ID Клиента";
            this.ColumnRequestsClientID.Name = "ColumnRequestsClientID";
            this.ColumnRequestsClientID.ReadOnly = true;
            // 
            // ColumnRequestsTourID
            // 
            this.ColumnRequestsTourID.HeaderText = "ID Тура";
            this.ColumnRequestsTourID.Name = "ColumnRequestsTourID";
            this.ColumnRequestsTourID.ReadOnly = true;
            // 
            // ColumnRequestsTourAgentID
            // 
            this.ColumnRequestsTourAgentID.HeaderText = "ID Турагента";
            this.ColumnRequestsTourAgentID.Name = "ColumnRequestsTourAgentID";
            this.ColumnRequestsTourAgentID.ReadOnly = true;
            // 
            // ColumnRequestsStatus
            // 
            this.ColumnRequestsStatus.HeaderText = "Статус";
            this.ColumnRequestsStatus.Name = "ColumnRequestsStatus";
            this.ColumnRequestsStatus.ReadOnly = true;
            // 
            // ColumnRequestsDate
            // 
            this.ColumnRequestsDate.HeaderText = "Дата";
            this.ColumnRequestsDate.Name = "ColumnRequestsDate";
            this.ColumnRequestsDate.ReadOnly = true;
            // 
            // tabAnalytics
            // 
            this.tabAnalytics.Controls.Add(this.plotView1);
            this.tabAnalytics.Controls.Add(this.dataGridViewStats);
            this.tabAnalytics.Controls.Add(this.btnStatCountry);
            this.tabAnalytics.Controls.Add(this.btnStatClient);
            this.tabAnalytics.Location = new System.Drawing.Point(4, 24);
            this.tabAnalytics.Name = "tabAnalytics";
            this.tabAnalytics.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnalytics.Size = new System.Drawing.Size(958, 478);
            this.tabAnalytics.TabIndex = 3;
            this.tabAnalytics.Text = "Статистика";
            this.tabAnalytics.UseVisualStyleBackColor = true;
            // 
            // plotView1
            // 
            this.plotView1.Location = new System.Drawing.Point(515, 35);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(437, 437);
            this.plotView1.TabIndex = 3;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // dataGridViewStats
            // 
            this.dataGridViewStats.AllowUserToAddRows = false;
            this.dataGridViewStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStats.Location = new System.Drawing.Point(6, 35);
            this.dataGridViewStats.Name = "dataGridViewStats";
            this.dataGridViewStats.RowHeadersVisible = false;
            this.dataGridViewStats.RowTemplate.Height = 25;
            this.dataGridViewStats.Size = new System.Drawing.Size(503, 437);
            this.dataGridViewStats.TabIndex = 2;
            // 
            // btnStatCountry
            // 
            this.btnStatCountry.Location = new System.Drawing.Point(558, 6);
            this.btnStatCountry.Name = "btnStatCountry";
            this.btnStatCountry.Size = new System.Drawing.Size(194, 23);
            this.btnStatCountry.TabIndex = 1;
            this.btnStatCountry.Text = "Статистика по странам";
            this.btnStatCountry.UseVisualStyleBackColor = true;
            this.btnStatCountry.Click += new System.EventHandler(this.btnStatCountry_Click);
            // 
            // btnStatClient
            // 
            this.btnStatClient.Location = new System.Drawing.Point(758, 6);
            this.btnStatClient.Name = "btnStatClient";
            this.btnStatClient.Size = new System.Drawing.Size(194, 23);
            this.btnStatClient.TabIndex = 0;
            this.btnStatClient.Text = "Статистика по клиентам";
            this.btnStatClient.UseVisualStyleBackColor = true;
            this.btnStatClient.Click += new System.EventHandler(this.btnStatClient_Click);
            // 
            // contextMenuStripTours
            // 
            this.contextMenuStripTours.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemBookToor});
            this.contextMenuStripTours.Name = "contextMenuStrip1";
            this.contextMenuStripTours.Size = new System.Drawing.Size(172, 26);
            this.contextMenuStripTours.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // menuItemBookToor
            // 
            this.menuItemBookToor.Name = "menuItemBookToor";
            this.menuItemBookToor.Size = new System.Drawing.Size(171, 22);
            this.menuItemBookToor.Text = "Оформить заявку";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Роль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(660, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Имя";
            // 
            // tbCurrentRole
            // 
            this.tbCurrentRole.Enabled = false;
            this.tbCurrentRole.Location = new System.Drawing.Point(353, 13);
            this.tbCurrentRole.Name = "tbCurrentRole";
            this.tbCurrentRole.ReadOnly = true;
            this.tbCurrentRole.Size = new System.Drawing.Size(259, 23);
            this.tbCurrentRole.TabIndex = 3;
            // 
            // tbCurrentUsername
            // 
            this.tbCurrentUsername.Enabled = false;
            this.tbCurrentUsername.Location = new System.Drawing.Point(697, 13);
            this.tbCurrentUsername.Name = "tbCurrentUsername";
            this.tbCurrentUsername.ReadOnly = true;
            this.tbCurrentUsername.Size = new System.Drawing.Size(259, 23);
            this.tbCurrentUsername.TabIndex = 4;
            // 
            // contextMenuStripRequests
            // 
            this.contextMenuStripRequests.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemChangeStatus});
            this.contextMenuStripRequests.Name = "contextMenuStripRequests";
            this.contextMenuStripRequests.Size = new System.Drawing.Size(166, 26);
            this.contextMenuStripRequests.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripRequests_ItemClicked);
            // 
            // menuItemChangeStatus
            // 
            this.menuItemChangeStatus.Name = "menuItemChangeStatus";
            this.menuItemChangeStatus.Size = new System.Drawing.Size(165, 22);
            this.menuItemChangeStatus.Text = "Изменить статус";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 566);
            this.Controls.Add(this.tbCurrentUsername);
            this.Controls.Add(this.tbCurrentRole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Учет и анализ клиентов в турагентстве";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.tabTours.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTours)).EndInit();
            this.tabRequests.ResumeLayout(false);
            this.tabRequests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).EndInit();
            this.tabAnalytics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStats)).EndInit();
            this.contextMenuStripTours.ResumeLayout(false);
            this.contextMenuStripRequests.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DataGridView dataGridViewTours;
        private DataGridViewTextBoxColumn ColumnTourID;
        private DataGridViewTextBoxColumn ColumnTourName;
        private DataGridViewTextBoxColumn ColumnTourCountry;
        private DataGridViewTextBoxColumn ColumnTourHotel;
        private DataGridViewTextBoxColumn ColumnTourTypeRoom;
        private DataGridViewTextBoxColumn ColumnTourTypeFood;
        private DataGridViewTextBoxColumn ColumnTourPricePurchase;
        private DataGridViewTextBoxColumn ColumnTourPriceSale;
        private DataGridViewTextBoxColumn ColumnTourDataStart;
        private DataGridViewTextBoxColumn ColumnTourDateEnd;
        private DataGridViewTextBoxColumn ColumnTourIsActive;
        private Button btnAddTour;
        private Button btnLoadTours;
        private Label label1;
        private ComboBox comboBoxStatus;
        private Button btnLoadRequests;
        private DataGridView dataGridViewRequests;
        private DataGridViewTextBoxColumn ColumnRequestsID;
        private DataGridViewTextBoxColumn ColumnRequestsClientID;
        private DataGridViewTextBoxColumn ColumnRequestsTourID;
        private DataGridViewTextBoxColumn ColumnRequestsTourAgentID;
        private DataGridViewTextBoxColumn ColumnRequestsStatus;
        private DataGridViewTextBoxColumn ColumnRequestsDate;
        private ContextMenuStrip contextMenuStripTours;
        private ToolStripMenuItem menuItemBookToor;
        private Label label2;
        private Label label3;
        private TextBox tbCurrentRole;
        private TextBox tbCurrentUsername;
        private ContextMenuStrip contextMenuStripRequests;
        private ToolStripMenuItem menuItemChangeStatus;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private DataGridView dataGridViewStats;
        private Button btnStatCountry;
        private Button btnStatClient;
    }
}