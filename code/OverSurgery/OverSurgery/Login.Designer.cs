namespace OverSurgery
{
    partial class Login
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
        	this.textboxUsername = new System.Windows.Forms.TextBox();
        	this.textboxPassword = new System.Windows.Forms.TextBox();
        	this.labelUsername = new System.Windows.Forms.Label();
        	this.labelPassword = new System.Windows.Forms.Label();
        	this.buttonLogin = new System.Windows.Forms.Button();
        	this.labelTitle = new System.Windows.Forms.Label();
        	this.labelError = new System.Windows.Forms.Label();
        	this.SuspendLayout();
        	// 
        	// textboxUsername
        	// 
        	this.textboxUsername.Location = new System.Drawing.Point(282, 176);
        	this.textboxUsername.Name = "textboxUsername";
        	this.textboxUsername.Size = new System.Drawing.Size(281, 20);
        	this.textboxUsername.TabIndex = 0;
        	// 
        	// textboxPassword
        	// 
        	this.textboxPassword.Location = new System.Drawing.Point(282, 249);
        	this.textboxPassword.Name = "textboxPassword";
        	this.textboxPassword.Size = new System.Drawing.Size(281, 20);
        	this.textboxPassword.TabIndex = 1;
        	this.textboxPassword.UseSystemPasswordChar = true;
        	// 
        	// labelUsername
        	// 
        	this.labelUsername.AutoSize = true;
        	this.labelUsername.Location = new System.Drawing.Point(279, 160);
        	this.labelUsername.Name = "labelUsername";
        	this.labelUsername.Size = new System.Drawing.Size(58, 13);
        	this.labelUsername.TabIndex = 2;
        	this.labelUsername.Text = "Username:";
        	// 
        	// labelPassword
        	// 
        	this.labelPassword.AutoSize = true;
        	this.labelPassword.Location = new System.Drawing.Point(279, 233);
        	this.labelPassword.Name = "labelPassword";
        	this.labelPassword.Size = new System.Drawing.Size(56, 13);
        	this.labelPassword.TabIndex = 3;
        	this.labelPassword.Text = "Password:";
        	// 
        	// buttonLogin
        	// 
        	this.buttonLogin.Location = new System.Drawing.Point(643, 304);
        	this.buttonLogin.Name = "buttonLogin";
        	this.buttonLogin.Size = new System.Drawing.Size(75, 23);
        	this.buttonLogin.TabIndex = 4;
        	this.buttonLogin.Text = "Login";
        	this.buttonLogin.UseVisualStyleBackColor = true;
        	this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
        	// 
        	// labelTitle
        	// 
        	this.labelTitle.AutoSize = true;
        	this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.labelTitle.Location = new System.Drawing.Point(277, 29);
        	this.labelTitle.Name = "labelTitle";
        	this.labelTitle.Size = new System.Drawing.Size(341, 25);
        	this.labelTitle.TabIndex = 5;
        	this.labelTitle.Text = "Over Surgery Receptionist System";
        	this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        	// 
        	// labelError
        	// 
        	this.labelError.AutoSize = true;
        	this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.labelError.ForeColor = System.Drawing.Color.Red;
        	this.labelError.Location = new System.Drawing.Point(639, 211);
        	this.labelError.Name = "labelError";
        	this.labelError.Size = new System.Drawing.Size(0, 24);
        	this.labelError.TabIndex = 6;
        	// 
        	// Login
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(1016, 738);
        	this.Controls.Add(this.labelError);
        	this.Controls.Add(this.labelTitle);
        	this.Controls.Add(this.buttonLogin);
        	this.Controls.Add(this.labelPassword);
        	this.Controls.Add(this.labelUsername);
        	this.Controls.Add(this.textboxPassword);
        	this.Controls.Add(this.textboxUsername);
        	this.MaximumSize = new System.Drawing.Size(1024, 768);
        	this.MinimumSize = new System.Drawing.Size(1024, 768);
        	this.Name = "Login";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Over Surgery";
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textboxUsername;
        private System.Windows.Forms.TextBox textboxPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelError;

    }
}