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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.MakeNewSetupButton = new System.Windows.Forms.Button();
            this.ViewSavedSetupsButton = new System.Windows.Forms.Button();
            this.DeleteAllSetupsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MakeNewSetupButton
            // 
            this.MakeNewSetupButton.Location = new System.Drawing.Point(154, 147);
            this.MakeNewSetupButton.Name = "MakeNewSetupButton";
            this.MakeNewSetupButton.Size = new System.Drawing.Size(120, 30);
            this.MakeNewSetupButton.TabIndex = 0;
            this.MakeNewSetupButton.Text = "Make New Setup";
            this.MakeNewSetupButton.UseVisualStyleBackColor = true;
            this.MakeNewSetupButton.Click += new System.EventHandler(this.MakeNewSetupButton_Click);
            // 
            // ViewSavedSetupsButton
            // 
            this.ViewSavedSetupsButton.Location = new System.Drawing.Point(154, 183);
            this.ViewSavedSetupsButton.Name = "ViewSavedSetupsButton";
            this.ViewSavedSetupsButton.Size = new System.Drawing.Size(120, 30);
            this.ViewSavedSetupsButton.TabIndex = 1;
            this.ViewSavedSetupsButton.Text = "View Saved Setups";
            this.ViewSavedSetupsButton.UseVisualStyleBackColor = true;
            this.ViewSavedSetupsButton.Click += new System.EventHandler(this.ViewSavedSetupsButton_Click);
            // 
            // DeleteAllSetupsButton
            // 
            this.DeleteAllSetupsButton.Location = new System.Drawing.Point(154, 219);
            this.DeleteAllSetupsButton.Name = "DeleteAllSetupsButton";
            this.DeleteAllSetupsButton.Size = new System.Drawing.Size(120, 30);
            this.DeleteAllSetupsButton.TabIndex = 2;
            this.DeleteAllSetupsButton.Text = "Delete All Setups";
            this.DeleteAllSetupsButton.UseVisualStyleBackColor = true;
            this.DeleteAllSetupsButton.Click += new System.EventHandler(this.DeleteAllSetupsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Star Jedi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-1, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "trooper setup";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Star Jedi", 11F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "made by:\r\niosnowore kun";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ViewSavedSetupsButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteAllSetupsButton);
            this.Controls.Add(this.MakeNewSetupButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SWG Setup Organizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MakeNewSetupButton;
        private System.Windows.Forms.Button ViewSavedSetupsButton;
        private System.Windows.Forms.Button DeleteAllSetupsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

