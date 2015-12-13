﻿namespace SWGSetupHolder
{
    partial class WeaponInputInformation
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
            this.WeaponDPSInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WeaponNameInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WeaponElementInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WeaponExoticsInput = new System.Windows.Forms.TextBox();
            this.SaveWeaponInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WeaponDPSInput
            // 
            this.WeaponDPSInput.Location = new System.Drawing.Point(170, 32);
            this.WeaponDPSInput.Name = "WeaponDPSInput";
            this.WeaponDPSInput.Size = new System.Drawing.Size(100, 20);
            this.WeaponDPSInput.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Weapon Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Weapon DPS";
            // 
            // WeaponNameInput
            // 
            this.WeaponNameInput.Location = new System.Drawing.Point(16, 32);
            this.WeaponNameInput.Name = "WeaponNameInput";
            this.WeaponNameInput.Size = new System.Drawing.Size(100, 20);
            this.WeaponNameInput.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Weapon Element";
            // 
            // WeaponElementInput
            // 
            this.WeaponElementInput.Location = new System.Drawing.Point(16, 106);
            this.WeaponElementInput.Name = "WeaponElementInput";
            this.WeaponElementInput.Size = new System.Drawing.Size(100, 20);
            this.WeaponElementInput.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Weapon Exotics";
            // 
            // WeaponExoticsInput
            // 
            this.WeaponExoticsInput.Location = new System.Drawing.Point(169, 106);
            this.WeaponExoticsInput.Name = "WeaponExoticsInput";
            this.WeaponExoticsInput.Size = new System.Drawing.Size(100, 20);
            this.WeaponExoticsInput.TabIndex = 16;
            // 
            // SaveWeaponInfoButton
            // 
            this.SaveWeaponInfoButton.Location = new System.Drawing.Point(98, 226);
            this.SaveWeaponInfoButton.Name = "SaveWeaponInfoButton";
            this.SaveWeaponInfoButton.Size = new System.Drawing.Size(75, 23);
            this.SaveWeaponInfoButton.TabIndex = 18;
            this.SaveWeaponInfoButton.Text = "Save";
            this.SaveWeaponInfoButton.UseVisualStyleBackColor = true;
            this.SaveWeaponInfoButton.Click += new System.EventHandler(this.SaveWeaponInfoButton_Click);
            // 
            // WeaponInputInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.SaveWeaponInfoButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WeaponExoticsInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WeaponElementInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WeaponNameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WeaponDPSInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WeaponInputInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weapon Setup";
            this.Load += new System.EventHandler(this.WeaponInputInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WeaponDPSInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WeaponNameInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WeaponElementInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WeaponExoticsInput;
        private System.Windows.Forms.Button SaveWeaponInfoButton;
    }
}