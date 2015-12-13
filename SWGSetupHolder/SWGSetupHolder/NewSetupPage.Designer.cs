namespace SWGSetupHolder
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveNewSetupButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SetupNameInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 9);
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
            this.label2.Location = new System.Drawing.Point(12, 9);
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
            // NewSetupPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SetupNameInput);
            this.Controls.Add(this.SaveNewSetupButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveNewSetupButton;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox SetupNameInput;
    }
}