namespace WinFormsApp1
{
    partial class CreateUpdateTourForm
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
            this.tbTourName = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.tbHotel = new System.Windows.Forms.TextBox();
            this.tbTypeRoom = new System.Windows.Forms.TextBox();
            this.tbTypeFood = new System.Windows.Forms.TextBox();
            this.tbPricePurchase = new System.Windows.Forms.TextBox();
            this.tbPriceSale = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.cbTourIsActive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbTourName
            // 
            this.tbTourName.Location = new System.Drawing.Point(157, 12);
            this.tbTourName.Name = "tbTourName";
            this.tbTourName.PlaceholderText = "Название";
            this.tbTourName.Size = new System.Drawing.Size(204, 23);
            this.tbTourName.TabIndex = 0;
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(157, 62);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.PlaceholderText = "Страна";
            this.tbCountry.Size = new System.Drawing.Size(204, 23);
            this.tbCountry.TabIndex = 1;
            // 
            // tbHotel
            // 
            this.tbHotel.Location = new System.Drawing.Point(157, 112);
            this.tbHotel.Name = "tbHotel";
            this.tbHotel.PlaceholderText = "Отель";
            this.tbHotel.Size = new System.Drawing.Size(204, 23);
            this.tbHotel.TabIndex = 2;
            // 
            // tbTypeRoom
            // 
            this.tbTypeRoom.Location = new System.Drawing.Point(157, 162);
            this.tbTypeRoom.Name = "tbTypeRoom";
            this.tbTypeRoom.PlaceholderText = "Тип комнаты";
            this.tbTypeRoom.Size = new System.Drawing.Size(204, 23);
            this.tbTypeRoom.TabIndex = 3;
            // 
            // tbTypeFood
            // 
            this.tbTypeFood.Location = new System.Drawing.Point(157, 212);
            this.tbTypeFood.Name = "tbTypeFood";
            this.tbTypeFood.PlaceholderText = "Тип питания";
            this.tbTypeFood.Size = new System.Drawing.Size(204, 23);
            this.tbTypeFood.TabIndex = 4;
            // 
            // tbPricePurchase
            // 
            this.tbPricePurchase.Location = new System.Drawing.Point(157, 262);
            this.tbPricePurchase.Name = "tbPricePurchase";
            this.tbPricePurchase.PlaceholderText = "Цена покупки";
            this.tbPricePurchase.Size = new System.Drawing.Size(204, 23);
            this.tbPricePurchase.TabIndex = 5;
            // 
            // tbPriceSale
            // 
            this.tbPriceSale.Location = new System.Drawing.Point(157, 312);
            this.tbPriceSale.Name = "tbPriceSale";
            this.tbPriceSale.PlaceholderText = "Цена продажи";
            this.tbPriceSale.Size = new System.Drawing.Size(204, 23);
            this.tbPriceSale.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(205, 460);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(286, 460);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Страна";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Отель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Тип комнаты";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Тип питания";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Цена покупки";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Цена продажи";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Дата начала";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 416);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Дата окончания";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(157, 362);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 23);
            this.dtpStart.TabIndex = 20;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(157, 412);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 23);
            this.dtpEnd.TabIndex = 21;
            // 
            // cbTourIsActive
            // 
            this.cbTourIsActive.AutoSize = true;
            this.cbTourIsActive.Checked = true;
            this.cbTourIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTourIsActive.Location = new System.Drawing.Point(20, 460);
            this.cbTourIsActive.Name = "cbTourIsActive";
            this.cbTourIsActive.Size = new System.Drawing.Size(91, 19);
            this.cbTourIsActive.TabIndex = 22;
            this.cbTourIsActive.Text = "Тур активен";
            this.cbTourIsActive.UseVisualStyleBackColor = true;
            // 
            // CreateUpdateTourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 502);
            this.Controls.Add(this.cbTourIsActive);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbPriceSale);
            this.Controls.Add(this.tbPricePurchase);
            this.Controls.Add(this.tbTypeFood);
            this.Controls.Add(this.tbTypeRoom);
            this.Controls.Add(this.tbHotel);
            this.Controls.Add(this.tbCountry);
            this.Controls.Add(this.tbTourName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreateUpdateTourForm";
            this.Text = "Добавление/Обновление тура";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbTourName;
        private TextBox tbCountry;
        private TextBox tbHotel;
        private TextBox tbTypeRoom;
        private TextBox tbTypeFood;
        private TextBox tbPricePurchase;
        private TextBox tbPriceSale;
        private Button btnCancel;
        private Button btnOk;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private CheckBox cbTourIsActive;
    }
}