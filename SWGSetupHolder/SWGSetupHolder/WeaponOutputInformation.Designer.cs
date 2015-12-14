namespace SWGSetupHolder
{
    partial class WeaponOutputInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeaponOutputInformation));
            this.label4 = new System.Windows.Forms.Label();
            this.WeaponExoticsOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WeaponElementOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WeaponNameOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WeaponDPSOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Weapon Exotics";
            // 
            // WeaponExoticsOutput
            // 
            this.WeaponExoticsOutput.Location = new System.Drawing.Point(169, 106);
            this.WeaponExoticsOutput.Name = "WeaponExoticsOutput";
            this.WeaponExoticsOutput.ReadOnly = true;
            this.WeaponExoticsOutput.Size = new System.Drawing.Size(100, 20);
            this.WeaponExoticsOutput.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Weapon Element";
            // 
            // WeaponElementOutput
            // 
            this.WeaponElementOutput.Location = new System.Drawing.Point(16, 106);
            this.WeaponElementOutput.Name = "WeaponElementOutput";
            this.WeaponElementOutput.ReadOnly = true;
            this.WeaponElementOutput.Size = new System.Drawing.Size(100, 20);
            this.WeaponElementOutput.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Weapon DPS";
            // 
            // WeaponNameOutput
            // 
            this.WeaponNameOutput.Location = new System.Drawing.Point(16, 32);
            this.WeaponNameOutput.Name = "WeaponNameOutput";
            this.WeaponNameOutput.ReadOnly = true;
            this.WeaponNameOutput.Size = new System.Drawing.Size(100, 20);
            this.WeaponNameOutput.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Weapon Name";
            // 
            // WeaponDPSOutput
            // 
            this.WeaponDPSOutput.Location = new System.Drawing.Point(170, 32);
            this.WeaponDPSOutput.Name = "WeaponDPSOutput";
            this.WeaponDPSOutput.ReadOnly = true;
            this.WeaponDPSOutput.Size = new System.Drawing.Size(100, 20);
            this.WeaponDPSOutput.TabIndex = 18;
            // 
            // WeaponOutputInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WeaponExoticsOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WeaponElementOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WeaponNameOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WeaponDPSOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WeaponOutputInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weapon Setup";
            this.Load += new System.EventHandler(this.WeaponOutputInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WeaponExoticsOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WeaponElementOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WeaponNameOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WeaponDPSOutput;
    }
}