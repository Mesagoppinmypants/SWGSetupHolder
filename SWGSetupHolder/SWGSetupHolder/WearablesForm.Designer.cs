namespace TrooperSetupOrganizer
{
    partial class WearablesForm
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
            this.ArmorInputButton = new System.Windows.Forms.Button();
            this.ArmorCheckbox = new System.Windows.Forms.CheckBox();
            this.RobeCheckbox = new System.Windows.Forms.CheckBox();
            this.ClothingInputButton = new System.Windows.Forms.Button();
            this.WeaponInputButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ArmorInputButton
            // 
            this.ArmorInputButton.Location = new System.Drawing.Point(92, 43);
            this.ArmorInputButton.Name = "ArmorInputButton";
            this.ArmorInputButton.Size = new System.Drawing.Size(100, 50);
            this.ArmorInputButton.TabIndex = 0;
            this.ArmorInputButton.Text = "Armor";
            this.ArmorInputButton.UseVisualStyleBackColor = true;
            this.ArmorInputButton.Click += new System.EventHandler(this.ArmorInputButton_Click);
            // 
            // ArmorCheckbox
            // 
            this.ArmorCheckbox.AutoSize = true;
            this.ArmorCheckbox.Checked = true;
            this.ArmorCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ArmorCheckbox.Location = new System.Drawing.Point(12, 12);
            this.ArmorCheckbox.Name = "ArmorCheckbox";
            this.ArmorCheckbox.Size = new System.Drawing.Size(53, 17);
            this.ArmorCheckbox.TabIndex = 1;
            this.ArmorCheckbox.Text = "Armor";
            this.ArmorCheckbox.UseVisualStyleBackColor = true;
            this.ArmorCheckbox.CheckedChanged += new System.EventHandler(this.ArmorCheckbox_CheckedChanged);
            // 
            // RobeCheckbox
            // 
            this.RobeCheckbox.AutoSize = true;
            this.RobeCheckbox.Location = new System.Drawing.Point(71, 12);
            this.RobeCheckbox.Name = "RobeCheckbox";
            this.RobeCheckbox.Size = new System.Drawing.Size(106, 17);
            this.RobeCheckbox.TabIndex = 2;
            this.RobeCheckbox.Text = "Jedi Robe/Cloak";
            this.RobeCheckbox.UseVisualStyleBackColor = true;
            this.RobeCheckbox.CheckedChanged += new System.EventHandler(this.RobeCheckbox_CheckedChanged);
            // 
            // ClothingInputButton
            // 
            this.ClothingInputButton.Location = new System.Drawing.Point(92, 119);
            this.ClothingInputButton.Name = "ClothingInputButton";
            this.ClothingInputButton.Size = new System.Drawing.Size(100, 50);
            this.ClothingInputButton.TabIndex = 3;
            this.ClothingInputButton.Text = "Clothing";
            this.ClothingInputButton.UseVisualStyleBackColor = true;
            this.ClothingInputButton.Click += new System.EventHandler(this.ClothingInputButton_Click);
            // 
            // WeaponInputButton
            // 
            this.WeaponInputButton.Location = new System.Drawing.Point(92, 195);
            this.WeaponInputButton.Name = "WeaponInputButton";
            this.WeaponInputButton.Size = new System.Drawing.Size(100, 50);
            this.WeaponInputButton.TabIndex = 4;
            this.WeaponInputButton.Text = "Weapon";
            this.WeaponInputButton.UseVisualStyleBackColor = true;
            this.WeaponInputButton.Click += new System.EventHandler(this.WeaponInputButton_Click);
            // 
            // WearablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.WeaponInputButton);
            this.Controls.Add(this.ClothingInputButton);
            this.Controls.Add(this.RobeCheckbox);
            this.Controls.Add(this.ArmorCheckbox);
            this.Controls.Add(this.ArmorInputButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WearablesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wearables Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ArmorInputButton;
        private System.Windows.Forms.CheckBox ArmorCheckbox;
        private System.Windows.Forms.CheckBox RobeCheckbox;
        private System.Windows.Forms.Button ClothingInputButton;
        private System.Windows.Forms.Button WeaponInputButton;
    }
}