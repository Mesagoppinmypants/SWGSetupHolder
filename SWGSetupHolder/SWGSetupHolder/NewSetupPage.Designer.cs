namespace TrooperSetupOrganizer
{
    partial class NewSetupPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewSetupPage));
            this.ProfessionInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveNewSetupButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SetupNameInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ExpertiseInput = new System.Windows.Forms.TextBox();
            this.ArmorInput = new System.Windows.Forms.Button();
            this.WeaponInput = new System.Windows.Forms.Button();
            this.SetupNumberInput = new System.Windows.Forms.TextBox();
            this.CreateExpertiseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProfessionInput
            // 
            this.ProfessionInput.Location = new System.Drawing.Point(16, 99);
            this.ProfessionInput.Name = "ProfessionInput";
            this.ProfessionInput.Size = new System.Drawing.Size(100, 20);
            this.ProfessionInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Profession";
            // 
            // SaveNewSetupButton
            // 
            this.SaveNewSetupButton.Location = new System.Drawing.Point(101, 226);
            this.SaveNewSetupButton.Name = "SaveNewSetupButton";
            this.SaveNewSetupButton.Size = new System.Drawing.Size(75, 23);
            this.SaveNewSetupButton.TabIndex = 8;
            this.SaveNewSetupButton.Text = "Save";
            this.SaveNewSetupButton.UseVisualStyleBackColor = true;
            this.SaveNewSetupButton.Click += new System.EventHandler(this.SaveNewSetupButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Setup Name";
            // 
            // SetupNameInput
            // 
            this.SetupNameInput.Location = new System.Drawing.Point(16, 32);
            this.SetupNameInput.Name = "SetupNameInput";
            this.SetupNameInput.Size = new System.Drawing.Size(100, 20);
            this.SetupNameInput.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Setup Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(177, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Expertise";
            // 
            // ExpertiseInput
            // 
            this.ExpertiseInput.Location = new System.Drawing.Point(166, 99);
            this.ExpertiseInput.Name = "ExpertiseInput";
            this.ExpertiseInput.Size = new System.Drawing.Size(100, 20);
            this.ExpertiseInput.TabIndex = 18;
            // 
            // ArmorInput
            // 
            this.ArmorInput.Location = new System.Drawing.Point(16, 163);
            this.ArmorInput.Name = "ArmorInput";
            this.ArmorInput.Size = new System.Drawing.Size(95, 35);
            this.ArmorInput.TabIndex = 20;
            this.ArmorInput.Text = "Armor";
            this.ArmorInput.UseVisualStyleBackColor = true;
            this.ArmorInput.Click += new System.EventHandler(this.ArmorInput_Click);
            // 
            // WeaponInput
            // 
            this.WeaponInput.Location = new System.Drawing.Point(171, 163);
            this.WeaponInput.Name = "WeaponInput";
            this.WeaponInput.Size = new System.Drawing.Size(95, 35);
            this.WeaponInput.TabIndex = 21;
            this.WeaponInput.Text = "Weapon";
            this.WeaponInput.UseVisualStyleBackColor = true;
            this.WeaponInput.Click += new System.EventHandler(this.WeaponInput_Click);
            // 
            // SetupNumberInput
            // 
            this.SetupNumberInput.Location = new System.Drawing.Point(166, 32);
            this.SetupNumberInput.Name = "SetupNumberInput";
            this.SetupNumberInput.ReadOnly = true;
            this.SetupNumberInput.Size = new System.Drawing.Size(100, 20);
            this.SetupNumberInput.TabIndex = 33;
            // 
            // CreateExpertiseButton
            // 
            this.CreateExpertiseButton.Location = new System.Drawing.Point(166, 125);
            this.CreateExpertiseButton.Name = "CreateExpertiseButton";
            this.CreateExpertiseButton.Size = new System.Drawing.Size(100, 23);
            this.CreateExpertiseButton.TabIndex = 34;
            this.CreateExpertiseButton.Text = "Create Expertise";
            this.CreateExpertiseButton.UseVisualStyleBackColor = true;
            this.CreateExpertiseButton.Click += new System.EventHandler(this.CreateExpertiseButton_Click);
            // 
            // NewSetupPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CreateExpertiseButton);
            this.Controls.Add(this.SetupNumberInput);
            this.Controls.Add(this.WeaponInput);
            this.Controls.Add(this.ArmorInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ExpertiseInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SetupNameInput);
            this.Controls.Add(this.SaveNewSetupButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProfessionInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewSetupPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Setup";
            this.Load += new System.EventHandler(this.NewSetupPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProfessionInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveNewSetupButton;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox SetupNameInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ExpertiseInput;
        private System.Windows.Forms.Button ArmorInput;
        private System.Windows.Forms.Button WeaponInput;
        public System.Windows.Forms.TextBox SetupNumberInput;
        private System.Windows.Forms.Button CreateExpertiseButton;
    }
}