namespace Assignment2_WinFormsApp
{
    partial class NewUsrScr
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
            this.usrTxtBx = new System.Windows.Forms.TextBox();
            this.passTxtBx = new System.Windows.Forms.TextBox();
            this.passConfirmTxtBx = new System.Windows.Forms.TextBox();
            this.fnTxtBx = new System.Windows.Forms.TextBox();
            this.lnTxtBx = new System.Windows.Forms.TextBox();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usrTxtBx
            // 
            this.usrTxtBx.Location = new System.Drawing.Point(124, 54);
            this.usrTxtBx.Name = "usrTxtBx";
            this.usrTxtBx.Size = new System.Drawing.Size(100, 23);
            this.usrTxtBx.TabIndex = 0;
            // 
            // passTxtBx
            // 
            this.passTxtBx.Location = new System.Drawing.Point(124, 83);
            this.passTxtBx.Name = "passTxtBx";
            this.passTxtBx.Size = new System.Drawing.Size(100, 23);
            this.passTxtBx.TabIndex = 1;
            // 
            // passConfirmTxtBx
            // 
            this.passConfirmTxtBx.Location = new System.Drawing.Point(124, 112);
            this.passConfirmTxtBx.Name = "passConfirmTxtBx";
            this.passConfirmTxtBx.Size = new System.Drawing.Size(100, 23);
            this.passConfirmTxtBx.TabIndex = 2;
            // 
            // fnTxtBx
            // 
            this.fnTxtBx.Location = new System.Drawing.Point(124, 141);
            this.fnTxtBx.Name = "fnTxtBx";
            this.fnTxtBx.Size = new System.Drawing.Size(100, 23);
            this.fnTxtBx.TabIndex = 3;
            // 
            // lnTxtBx
            // 
            this.lnTxtBx.Location = new System.Drawing.Point(124, 170);
            this.lnTxtBx.Name = "lnTxtBx";
            this.lnTxtBx.Size = new System.Drawing.Size(100, 23);
            this.lnTxtBx.TabIndex = 4;
            // 
            // dobPicker
            // 
            this.dobPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobPicker.Location = new System.Drawing.Point(124, 199);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(100, 23);
            this.dobPicker.TabIndex = 6;
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Guest",
            "View",
            "Edit"});
            this.typeComboBox.Location = new System.Drawing.Point(124, 228);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(100, 23);
            this.typeComboBox.TabIndex = 7;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(80, 291);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(236, 291);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 9;
            this.createBtn.Text = "Submit";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Retype Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Last Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Date Of Birth:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "User Type:";
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Location = new System.Drawing.Point(124, 264);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 15);
            this.errorLbl.TabIndex = 18;
            // 
            // NewUsrScr
            // 
            this.AcceptButton = this.createBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.dobPicker);
            this.Controls.Add(this.lnTxtBx);
            this.Controls.Add(this.fnTxtBx);
            this.Controls.Add(this.passConfirmTxtBx);
            this.Controls.Add(this.passTxtBx);
            this.Controls.Add(this.usrTxtBx);
            this.Name = "NewUsrScr";
            this.Text = "New User";
            this.Load += new System.EventHandler(this.NewUsrScr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox usrTxtBx;
        private TextBox passTxtBx;
        private TextBox passConfirmTxtBx;
        private TextBox fnTxtBx;
        private TextBox lnTxtBx;
        private DateTimePicker dobPicker;
        private ComboBox typeComboBox;
        private Button cancelBtn;
        private Button createBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label errorLbl;
    }
}