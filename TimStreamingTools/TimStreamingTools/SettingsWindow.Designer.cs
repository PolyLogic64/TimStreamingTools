namespace TimStreamingTools
{
    partial class SettingsWindow
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
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DefaultOutputFileTextBox = new System.Windows.Forms.TextBox();
            this.btnBrowseOutputFile = new System.Windows.Forms.Button();
            this.DefaultMusicOutputFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(701, 13);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(87, 23);
            this.btnSaveSettings.TabIndex = 0;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Default Music Output File";
            // 
            // DefaultOutputFileTextBox
            // 
            this.DefaultOutputFileTextBox.Location = new System.Drawing.Point(15, 25);
            this.DefaultOutputFileTextBox.Name = "DefaultOutputFileTextBox";
            this.DefaultOutputFileTextBox.Size = new System.Drawing.Size(173, 20);
            this.DefaultOutputFileTextBox.TabIndex = 2;
            // 
            // btnBrowseOutputFile
            // 
            this.btnBrowseOutputFile.Location = new System.Drawing.Point(194, 25);
            this.btnBrowseOutputFile.Name = "btnBrowseOutputFile";
            this.btnBrowseOutputFile.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseOutputFile.TabIndex = 3;
            this.btnBrowseOutputFile.Text = "Browse";
            this.btnBrowseOutputFile.UseVisualStyleBackColor = true;
            this.btnBrowseOutputFile.Click += new System.EventHandler(this.btnBrowseOutputFile_Click);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBrowseOutputFile);
            this.Controls.Add(this.DefaultOutputFileTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SettingsWindow";
            this.Text = "SettingsWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DefaultOutputFileTextBox;
        private System.Windows.Forms.Button btnBrowseOutputFile;
        private System.Windows.Forms.SaveFileDialog DefaultMusicOutputFileDialog;
    }
}