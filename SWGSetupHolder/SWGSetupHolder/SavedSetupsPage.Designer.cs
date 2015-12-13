namespace SWGSetupHolder
{
    partial class SavedSetupsPage
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
            this.SetupSelection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadSetupButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SetupSelection
            // 
            this.SetupSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SetupSelection.FormattingEnabled = true;
            this.SetupSelection.Location = new System.Drawing.Point(73, 42);
            this.SetupSelection.Name = "SetupSelection";
            this.SetupSelection.Size = new System.Drawing.Size(121, 21);
            this.SetupSelection.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Your Setup Below.";
            // 
            // LoadSetupButton
            // 
            this.LoadSetupButton.Location = new System.Drawing.Point(94, 69);
            this.LoadSetupButton.Name = "LoadSetupButton";
            this.LoadSetupButton.Size = new System.Drawing.Size(75, 23);
            this.LoadSetupButton.TabIndex = 2;
            this.LoadSetupButton.Text = "Load";
            this.LoadSetupButton.UseVisualStyleBackColor = true;
            this.LoadSetupButton.Click += new System.EventHandler(this.LoadSetupButton_Click);
            // 
            // SavedSetupsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LoadSetupButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetupSelection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SavedSetupsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saved Setups";
            this.Load += new System.EventHandler(this.SavedSetupsPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SetupSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoadSetupButton;
    }
}