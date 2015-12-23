namespace TrooperSetupOrganizer
{
    partial class ArmorOutputInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArmorOutputInformation));
            this.label4 = new System.Windows.Forms.Label();
            this.ArmorExoticsOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ArmorProtectionOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ArmorNameOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ArmorTypeOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Armor Exotics";
            // 
            // ArmorExoticsOutput
            // 
            this.ArmorExoticsOutput.Location = new System.Drawing.Point(168, 107);
            this.ArmorExoticsOutput.Name = "ArmorExoticsOutput";
            this.ArmorExoticsOutput.ReadOnly = true;
            this.ArmorExoticsOutput.Size = new System.Drawing.Size(100, 20);
            this.ArmorExoticsOutput.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Armor Protection";
            // 
            // ArmorProtectionOutput
            // 
            this.ArmorProtectionOutput.Location = new System.Drawing.Point(15, 107);
            this.ArmorProtectionOutput.Name = "ArmorProtectionOutput";
            this.ArmorProtectionOutput.ReadOnly = true;
            this.ArmorProtectionOutput.Size = new System.Drawing.Size(100, 20);
            this.ArmorProtectionOutput.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Armor Type";
            // 
            // ArmorNameOutput
            // 
            this.ArmorNameOutput.Location = new System.Drawing.Point(15, 33);
            this.ArmorNameOutput.Name = "ArmorNameOutput";
            this.ArmorNameOutput.ReadOnly = true;
            this.ArmorNameOutput.Size = new System.Drawing.Size(100, 20);
            this.ArmorNameOutput.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Armor Name";
            // 
            // ArmorTypeOutput
            // 
            this.ArmorTypeOutput.Location = new System.Drawing.Point(169, 33);
            this.ArmorTypeOutput.Name = "ArmorTypeOutput";
            this.ArmorTypeOutput.ReadOnly = true;
            this.ArmorTypeOutput.Size = new System.Drawing.Size(100, 20);
            this.ArmorTypeOutput.TabIndex = 28;
            // 
            // ArmorOutputInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ArmorExoticsOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ArmorProtectionOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArmorNameOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ArmorTypeOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArmorOutputInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Armor Output Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ArmorOutputInformation_FormClosing);
            this.Load += new System.EventHandler(this.ArmorOutputInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ArmorExoticsOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ArmorProtectionOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ArmorNameOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ArmorTypeOutput;
    }
}