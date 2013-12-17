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
            this.components = new System.ComponentModel.Container();
            this.textboxUsername = new System.Windows.Forms.TextBox();
            this.textboxPassword = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.myDBreceptionistDS = new OverSurgery.myDBreceptionistDS();
            this.receptionistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receptionistTableAdapter = new OverSurgery.myDBreceptionistDSTableAdapters.ReceptionistTableAdapter();
            this.tableAdapterManager = new OverSurgery.myDBreceptionistDSTableAdapters.TableAdapterManager();
            this.receptionistDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myDBreceptionistDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionistDataGridView)).BeginInit();
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
            // myDBreceptionistDS
            // 
            this.myDBreceptionistDS.DataSetName = "myDBreceptionistDS";
            this.myDBreceptionistDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receptionistBindingSource
            // 
            this.receptionistBindingSource.DataMember = "Receptionist";
            this.receptionistBindingSource.DataSource = this.myDBreceptionistDS;
            // 
            // receptionistTableAdapter
            // 
            this.receptionistTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ReceptionistTableAdapter = this.receptionistTableAdapter;
            this.tableAdapterManager.UpdateOrder = OverSurgery.myDBreceptionistDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // receptionistDataGridView
            // 
            this.receptionistDataGridView.AutoGenerateColumns = false;
            this.receptionistDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receptionistDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.receptionistDataGridView.DataSource = this.receptionistBindingSource;
            this.receptionistDataGridView.Location = new System.Drawing.Point(12, 708);
            this.receptionistDataGridView.Name = "receptionistDataGridView";
            this.receptionistDataGridView.Size = new System.Drawing.Size(10, 10);
            this.receptionistDataGridView.TabIndex = 7;
            this.receptionistDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn2.HeaderText = "username";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn3.HeaderText = "password";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "the username is username and the password is password FYI LOLZ";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.receptionistDataGridView);
            this.Controls.Add(this.labelError);
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
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDBreceptionistDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionistDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxUsername;
        private System.Windows.Forms.TextBox textboxPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelError;
        private myDBreceptionistDS myDBreceptionistDS;
        private System.Windows.Forms.BindingSource receptionistBindingSource;
        private myDBreceptionistDSTableAdapters.ReceptionistTableAdapter receptionistTableAdapter;
        private myDBreceptionistDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView receptionistDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;

    }
}