﻿namespace OverSurgery
{
    partial class MainScreen
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
        	this.buttonPatient = new System.Windows.Forms.Button();
        	this.button2 = new System.Windows.Forms.Button();
        	this.button3 = new System.Windows.Forms.Button();
        	this.button4 = new System.Windows.Forms.Button();
        	this.SuspendLayout();
        	// 
        	// buttonPatient
        	// 
        	this.buttonPatient.Location = new System.Drawing.Point(12, 12);
        	this.buttonPatient.Name = "buttonPatient";
        	this.buttonPatient.Size = new System.Drawing.Size(75, 23);
        	this.buttonPatient.TabIndex = 0;
        	this.buttonPatient.Text = "Patient";
        	this.buttonPatient.UseVisualStyleBackColor = true;
        	// 
        	// button2
        	// 
        	this.button2.Location = new System.Drawing.Point(12, 41);
        	this.button2.Name = "button2";
        	this.button2.Size = new System.Drawing.Size(75, 23);
        	this.button2.TabIndex = 1;
        	this.button2.Text = "button2";
        	this.button2.UseVisualStyleBackColor = true;
        	// 
        	// button3
        	// 
        	this.button3.Location = new System.Drawing.Point(12, 99);
        	this.button3.Name = "button3";
        	this.button3.Size = new System.Drawing.Size(75, 23);
        	this.button3.TabIndex = 2;
        	this.button3.Text = "button3";
        	this.button3.UseVisualStyleBackColor = true;
        	// 
        	// button4
        	// 
        	this.button4.Location = new System.Drawing.Point(12, 70);
        	this.button4.Name = "button4";
        	this.button4.Size = new System.Drawing.Size(75, 23);
        	this.button4.TabIndex = 3;
        	this.button4.Text = "button4";
        	this.button4.UseVisualStyleBackColor = true;
        	// 
        	// MainScreen
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(1016, 738);
        	this.Controls.Add(this.button3);
        	this.Controls.Add(this.button4);
        	this.Controls.Add(this.button2);
        	this.Controls.Add(this.buttonPatient);
        	this.MaximumSize = new System.Drawing.Size(1024, 768);
        	this.MinimumSize = new System.Drawing.Size(1024, 768);
        	this.Name = "MainScreen";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Over Surgery";
        	this.ResumeLayout(false);
        }
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonPatient;

        #endregion

    }
}

