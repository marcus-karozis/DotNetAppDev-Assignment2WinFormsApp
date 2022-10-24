namespace Assignment2_WinFormsApp
{
    partial class LoginSc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.newUsrBtn = new System.Windows.Forms.Button();
            this.usrTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(189, 156);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(270, 156);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // newUsrBtn
            // 
            this.newUsrBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newUsrBtn.Location = new System.Drawing.Point(397, 156);
            this.newUsrBtn.Name = "newUsrBtn";
            this.newUsrBtn.Size = new System.Drawing.Size(75, 23);
            this.newUsrBtn.TabIndex = 2;
            this.newUsrBtn.Text = "New User";
            this.newUsrBtn.UseVisualStyleBackColor = true;
            this.newUsrBtn.Click += new System.EventHandler(this.newUsrBtn_Click);
            // 
            // usrTextBox
            // 
            this.usrTextBox.Location = new System.Drawing.Point(174, 60);
            this.usrTextBox.Name = "usrTextBox";
            this.usrTextBox.Size = new System.Drawing.Size(171, 23);
            this.usrTextBox.TabIndex = 3;
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(174, 89);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(171, 23);
            this.passTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password:";
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Location = new System.Drawing.Point(174, 127);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 15);
            this.errorLbl.TabIndex = 7;
            // 
            // LoginSc
            // 
            this.AcceptButton = this.loginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(484, 191);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.usrTextBox);
            this.Controls.Add(this.newUsrBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.exitBtn);
            this.Name = "LoginSc";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginSc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button exitBtn;
        private Button loginBtn;
        private Button newUsrBtn;
        private TextBox usrTextBox;
        private TextBox passTextBox;
        private Label label1;
        private Label label2;
        private Label errorLbl;
    }
}