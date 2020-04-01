namespace TimStreamingTools
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.musicOutputTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PaddingCharactersUpAndDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PaddingSpacesUpAndDown = new System.Windows.Forms.NumericUpDown();
            this.paddingCharactersTextBox = new System.Windows.Forms.TextBox();
            this.radioButtonPaddingSpaces = new System.Windows.Forms.RadioButton();
            this.radioButtonCharacterPadding = new System.Windows.Forms.RadioButton();
            this.btnBrowseForOutputFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.outputfiletextbox = new System.Windows.Forms.TextBox();
            this.btnMusicTextStart = new System.Windows.Forms.Button();
            this.comboBoxMusicSelection = new System.Windows.Forms.ComboBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.SpotifyTimer = new System.Windows.Forms.Timer(this.components);
            this.MusicOutputFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CurrentTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.TimeOutputFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PaddingCharactersUpAndDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaddingSpacesUpAndDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // musicOutputTextbox
            // 
            this.musicOutputTextbox.ForeColor = System.Drawing.Color.Black;
            this.musicOutputTextbox.Location = new System.Drawing.Point(3, 243);
            this.musicOutputTextbox.Name = "musicOutputTextbox";
            this.musicOutputTextbox.ReadOnly = true;
            this.musicOutputTextbox.Size = new System.Drawing.Size(188, 20);
            this.musicOutputTextbox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Output";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Padding Amount";
            // 
            // PaddingCharactersUpAndDown
            // 
            this.PaddingCharactersUpAndDown.ForeColor = System.Drawing.Color.Black;
            this.PaddingCharactersUpAndDown.Location = new System.Drawing.Point(89, 185);
            this.PaddingCharactersUpAndDown.Name = "PaddingCharactersUpAndDown";
            this.PaddingCharactersUpAndDown.Size = new System.Drawing.Size(38, 20);
            this.PaddingCharactersUpAndDown.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Padding Characters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(146, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Padding Amount";
            // 
            // PaddingSpacesUpAndDown
            // 
            this.PaddingSpacesUpAndDown.ForeColor = System.Drawing.Color.Black;
            this.PaddingSpacesUpAndDown.Location = new System.Drawing.Point(237, 144);
            this.PaddingSpacesUpAndDown.Name = "PaddingSpacesUpAndDown";
            this.PaddingSpacesUpAndDown.Size = new System.Drawing.Size(35, 20);
            this.PaddingSpacesUpAndDown.TabIndex = 9;
            // 
            // paddingCharactersTextBox
            // 
            this.paddingCharactersTextBox.ForeColor = System.Drawing.Color.Black;
            this.paddingCharactersTextBox.Location = new System.Drawing.Point(6, 159);
            this.paddingCharactersTextBox.Name = "paddingCharactersTextBox";
            this.paddingCharactersTextBox.Size = new System.Drawing.Size(100, 20);
            this.paddingCharactersTextBox.TabIndex = 12;
            // 
            // radioButtonPaddingSpaces
            // 
            this.radioButtonPaddingSpaces.AutoSize = true;
            this.radioButtonPaddingSpaces.Checked = true;
            this.radioButtonPaddingSpaces.ForeColor = System.Drawing.Color.White;
            this.radioButtonPaddingSpaces.Location = new System.Drawing.Point(147, 121);
            this.radioButtonPaddingSpaces.Name = "radioButtonPaddingSpaces";
            this.radioButtonPaddingSpaces.Size = new System.Drawing.Size(125, 17);
            this.radioButtonPaddingSpaces.TabIndex = 8;
            this.radioButtonPaddingSpaces.TabStop = true;
            this.radioButtonPaddingSpaces.Text = "Add Padding Spaces";
            this.radioButtonPaddingSpaces.UseVisualStyleBackColor = true;
            this.radioButtonPaddingSpaces.CheckedChanged += new System.EventHandler(this.radioButtonPaddingSpaces_CheckedChanged);
            // 
            // radioButtonCharacterPadding
            // 
            this.radioButtonCharacterPadding.ForeColor = System.Drawing.Color.White;
            this.radioButtonCharacterPadding.Location = new System.Drawing.Point(6, 117);
            this.radioButtonCharacterPadding.Name = "radioButtonCharacterPadding";
            this.radioButtonCharacterPadding.Size = new System.Drawing.Size(135, 24);
            this.radioButtonCharacterPadding.TabIndex = 11;
            this.radioButtonCharacterPadding.Text = "Add Character Padding";
            this.radioButtonCharacterPadding.CheckedChanged += new System.EventHandler(this.radioButtonCharacterPadding_CheckedChanged);
            // 
            // btnBrowseForOutputFile
            // 
            this.btnBrowseForOutputFile.ForeColor = System.Drawing.Color.Black;
            this.btnBrowseForOutputFile.Location = new System.Drawing.Point(197, 68);
            this.btnBrowseForOutputFile.Name = "btnBrowseForOutputFile";
            this.btnBrowseForOutputFile.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseForOutputFile.TabIndex = 6;
            this.btnBrowseForOutputFile.Text = "Browse";
            this.btnBrowseForOutputFile.UseVisualStyleBackColor = true;
            this.btnBrowseForOutputFile.Click += new System.EventHandler(this.btnBrowseForOutputFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output File";
            // 
            // outputfiletextbox
            // 
            this.outputfiletextbox.ForeColor = System.Drawing.Color.Black;
            this.outputfiletextbox.Location = new System.Drawing.Point(6, 70);
            this.outputfiletextbox.Name = "outputfiletextbox";
            this.outputfiletextbox.ReadOnly = true;
            this.outputfiletextbox.Size = new System.Drawing.Size(185, 20);
            this.outputfiletextbox.TabIndex = 4;
            // 
            // btnMusicTextStart
            // 
            this.btnMusicTextStart.ForeColor = System.Drawing.Color.Black;
            this.btnMusicTextStart.Location = new System.Drawing.Point(101, 283);
            this.btnMusicTextStart.Name = "btnMusicTextStart";
            this.btnMusicTextStart.Size = new System.Drawing.Size(75, 23);
            this.btnMusicTextStart.TabIndex = 3;
            this.btnMusicTextStart.Text = "Start";
            this.btnMusicTextStart.UseVisualStyleBackColor = true;
            this.btnMusicTextStart.Click += new System.EventHandler(this.btnMusicTextStart_Click);
            // 
            // comboBoxMusicSelection
            // 
            this.comboBoxMusicSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMusicSelection.ForeColor = System.Drawing.Color.Black;
            this.comboBoxMusicSelection.FormattingEnabled = true;
            this.comboBoxMusicSelection.Items.AddRange(new object[] {
            "Spotify",
            "This does not work",
            "It really doesnt"});
            this.comboBoxMusicSelection.Location = new System.Drawing.Point(6, 19);
            this.comboBoxMusicSelection.Name = "comboBoxMusicSelection";
            this.comboBoxMusicSelection.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMusicSelection.TabIndex = 2;
            // 
            // btnSettings
            // 
            this.btnSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSettings.Location = new System.Drawing.Point(695, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // SpotifyTimer
            // 
            this.SpotifyTimer.Interval = 500;
            this.SpotifyTimer.Tick += new System.EventHandler(this.SpotifyTimer_Tick);
            // 
            // MusicOutputFileDialog
            // 
            this.MusicOutputFileDialog.DefaultExt = "txt";
            this.MusicOutputFileDialog.FileName = "tstmusictext.txt";
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(293, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Format Keys";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(212, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(212, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(106, 181);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(106, 144);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(156, 19);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(104, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Standard Format";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(106, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(16, 223);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(178, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Remove leading zero from hours";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(16, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "OutputFile";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(13, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Live Output";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(13, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Current PC Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Output Format";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(301, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 321);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time Text";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.musicOutputTextbox);
            this.groupBox2.Controls.Add(this.comboBoxMusicSelection);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnMusicTextStart);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.outputfiletextbox);
            this.groupBox2.Controls.Add(this.PaddingCharactersUpAndDown);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnBrowseForOutputFile);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.radioButtonCharacterPadding);
            this.groupBox2.Controls.Add(this.PaddingSpacesUpAndDown);
            this.groupBox2.Controls.Add(this.radioButtonPaddingSpaces);
            this.groupBox2.Controls.Add(this.paddingCharactersTextBox);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 321);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Music Text";
            // 
            // groupBox3
            // 
            this.groupBox3.Enabled = false;
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(695, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(38, 23);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Countdown Text";
            this.groupBox3.Visible = false;
            // 
            // CurrentTimeTimer
            // 
            this.CurrentTimeTimer.Interval = 500;
            this.CurrentTimeTimer.Tick += new System.EventHandler(this.CurrentTimeTimer_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(784, 344);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSettings);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tim\'s Streaming Tools";
            ((System.ComponentModel.ISupportInitialize)(this.PaddingCharactersUpAndDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaddingSpacesUpAndDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxMusicSelection;
        private System.Windows.Forms.Button btnBrowseForOutputFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outputfiletextbox;
        private System.Windows.Forms.Button btnMusicTextStart;
        private System.Windows.Forms.RadioButton radioButtonPaddingSpaces;
        private System.Windows.Forms.RadioButton radioButtonCharacterPadding;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown PaddingSpacesUpAndDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown PaddingCharactersUpAndDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox paddingCharactersTextBox;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Timer SpotifyTimer;
        private System.Windows.Forms.SaveFileDialog MusicOutputFileDialog;
        private System.Windows.Forms.TextBox musicOutputTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer CurrentTimeTimer;
        private System.Windows.Forms.SaveFileDialog TimeOutputFileDialog;
    }
}

