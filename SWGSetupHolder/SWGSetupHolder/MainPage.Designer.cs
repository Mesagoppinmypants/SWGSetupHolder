namespace SWGSetupHolder
{
    partial class MainPage
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
            this.MakeNewSetupButton = new System.Windows.Forms.Button();
            this.ViewSavedSetupsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MakeNewSetupButton
            // 
            this.MakeNewSetupButton.Location = new System.Drawing.Point(79, 72);
            this.MakeNewSetupButton.Name = "MakeNewSetupButton";
            this.MakeNewSetupButton.Size = new System.Drawing.Size(120, 30);
            this.MakeNewSetupButton.TabIndex = 0;
            this.MakeNewSetupButton.Text = "Make New Setup";
            this.MakeNewSetupButton.UseVisualStyleBackColor = true;
            this.MakeNewSetupButton.Click += new System.EventHandler(this.MakeNewSetupButton_Click);
            // 
            // ViewSavedSetupsButton
            // 
            this.ViewSavedSetupsButton.Location = new System.Drawing.Point(79, 137);
            this.ViewSavedSetupsButton.Name = "ViewSavedSetupsButton";
            this.ViewSavedSetupsButton.Size = new System.Drawing.Size(120, 30);
            this.ViewSavedSetupsButton.TabIndex = 1;
            this.ViewSavedSetupsButton.Text = "View Saved Setups";
            this.ViewSavedSetupsButton.UseVisualStyleBackColor = true;
            this.ViewSavedSetupsButton.Click += new System.EventHandler(this.ViewSavedSetupsButton_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ViewSavedSetupsButton);
            this.Controls.Add(this.MakeNewSetupButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup Holder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MakeNewSetupButton;
        private System.Windows.Forms.Button ViewSavedSetupsButton;
    }
}

