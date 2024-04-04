namespace WinFormsApp1
{
    partial class ChangeStatusForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxNewStatus = new System.Windows.Forms.ComboBox();
            this.tbCurrentStatus = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текущий статус";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Новый статус";
            // 
            // comboBoxNewStatus
            // 
            this.comboBoxNewStatus.FormattingEnabled = true;
            this.comboBoxNewStatus.Items.AddRange(new object[] {
            "НЕОБРАБОТАНА",
            "ОЖИДАНИЕ",
            "ОПЛАЧЕНА",
            "ОТМЕНЕНА"});
            this.comboBoxNewStatus.Location = new System.Drawing.Point(154, 74);
            this.comboBoxNewStatus.Name = "comboBoxNewStatus";
            this.comboBoxNewStatus.Size = new System.Drawing.Size(178, 23);
            this.comboBoxNewStatus.TabIndex = 2;
            // 
            // tbCurrentStatus
            // 
            this.tbCurrentStatus.Enabled = false;
            this.tbCurrentStatus.Location = new System.Drawing.Point(154, 30);
            this.tbCurrentStatus.Name = "tbCurrentStatus";
            this.tbCurrentStatus.ReadOnly = true;
            this.tbCurrentStatus.Size = new System.Drawing.Size(178, 23);
            this.tbCurrentStatus.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(257, 123);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ChangeStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 171);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbCurrentStatus);
            this.Controls.Add(this.comboBoxNewStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangeStatus";
            this.Text = "Изменение статуса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBoxNewStatus;
        private TextBox tbCurrentStatus;
        private Button btnOK;
    }
}