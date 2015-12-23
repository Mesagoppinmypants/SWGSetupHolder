namespace TrooperSetupOrganizer
{
    partial class RobeInputInformation
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RobeNameLabel = new System.Windows.Forms.Label();
            this.RobeCheckbox = new System.Windows.Forms.CheckBox();
            this.CloakCheckbox = new System.Windows.Forms.CheckBox();
            this.HoodDownCheckbox = new System.Windows.Forms.CheckBox();
            this.SaveRobeInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // RobeNameLabel
            // 
            this.RobeNameLabel.AutoSize = true;
            this.RobeNameLabel.Location = new System.Drawing.Point(102, 109);
            this.RobeNameLabel.Name = "RobeNameLabel";
            this.RobeNameLabel.Size = new System.Drawing.Size(64, 13);
            this.RobeNameLabel.TabIndex = 1;
            this.RobeNameLabel.Text = "Robe Name";
            // 
            // RobeCheckbox
            // 
            this.RobeCheckbox.AutoSize = true;
            this.RobeCheckbox.Checked = true;
            this.RobeCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RobeCheckbox.Location = new System.Drawing.Point(12, 12);
            this.RobeCheckbox.Name = "RobeCheckbox";
            this.RobeCheckbox.Size = new System.Drawing.Size(52, 17);
            this.RobeCheckbox.TabIndex = 2;
            this.RobeCheckbox.Text = "Robe";
            this.RobeCheckbox.UseVisualStyleBackColor = true;
            this.RobeCheckbox.CheckedChanged += new System.EventHandler(this.RobeCheckbox_CheckedChanged);
            // 
            // CloakCheckbox
            // 
            this.CloakCheckbox.AutoSize = true;
            this.CloakCheckbox.Location = new System.Drawing.Point(70, 12);
            this.CloakCheckbox.Name = "CloakCheckbox";
            this.CloakCheckbox.Size = new System.Drawing.Size(53, 17);
            this.CloakCheckbox.TabIndex = 3;
            this.CloakCheckbox.Text = "Cloak";
            this.CloakCheckbox.UseVisualStyleBackColor = true;
            this.CloakCheckbox.CheckedChanged += new System.EventHandler(this.CloakCheckbox_CheckedChanged);
            // 
            // HoodDownCheckbox
            // 
            this.HoodDownCheckbox.AutoSize = true;
            this.HoodDownCheckbox.Location = new System.Drawing.Point(86, 35);
            this.HoodDownCheckbox.Name = "HoodDownCheckbox";
            this.HoodDownCheckbox.Size = new System.Drawing.Size(83, 17);
            this.HoodDownCheckbox.TabIndex = 4;
            this.HoodDownCheckbox.Text = "Hood Down";
            this.HoodDownCheckbox.UseVisualStyleBackColor = true;
            this.HoodDownCheckbox.CheckedChanged += new System.EventHandler(this.HoodDownCheckbox_CheckedChanged);
            // 
            // SaveRobeInfoButton
            // 
            this.SaveRobeInfoButton.Location = new System.Drawing.Point(105, 226);
            this.SaveRobeInfoButton.Name = "SaveRobeInfoButton";
            this.SaveRobeInfoButton.Size = new System.Drawing.Size(75, 23);
            this.SaveRobeInfoButton.TabIndex = 19;
            this.SaveRobeInfoButton.Text = "Save";
            this.SaveRobeInfoButton.UseVisualStyleBackColor = true;
            this.SaveRobeInfoButton.Click += new System.EventHandler(this.SaveRobeInfoButton_Click);
            // 
            // RobeInputInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.SaveRobeInfoButton);
            this.Controls.Add(this.HoodDownCheckbox);
            this.Controls.Add(this.CloakCheckbox);
            this.Controls.Add(this.RobeCheckbox);
            this.Controls.Add(this.RobeNameLabel);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RobeInputInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robe Information";
            this.Load += new System.EventHandler(this.RobeInputInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label RobeNameLabel;
        private System.Windows.Forms.CheckBox RobeCheckbox;
        private System.Windows.Forms.CheckBox CloakCheckbox;
        private System.Windows.Forms.CheckBox HoodDownCheckbox;
        private System.Windows.Forms.Button SaveRobeInfoButton;
    }
}