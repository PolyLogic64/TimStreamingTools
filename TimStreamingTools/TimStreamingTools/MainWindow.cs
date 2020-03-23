using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace TimStreamingTools
{
    public partial class MainWindow : Form
    {

        bool ToggleStart = true;
        public MainWindow()
        {
            InitializeComponent();

            PaddingSpacesUpAndDown.Enabled = radioButtonPaddingSpaces.Checked;
            paddingCharactersTextBox.Enabled = radioButtonCharacterPadding.Checked;
            PaddingCharactersUpAndDown.Enabled = radioButtonCharacterPadding.Checked;
        }

        private void radioButtonPaddingSpaces_CheckedChanged(object sender, EventArgs e)
        {
            PaddingSpacesUpAndDown.Enabled = radioButtonPaddingSpaces.Checked;
        }
        private void radioButtonCharacterPadding_CheckedChanged(object sender, EventArgs e)
        {
            paddingCharactersTextBox.Enabled = radioButtonCharacterPadding.Checked;
            PaddingCharactersUpAndDown.Enabled = radioButtonCharacterPadding.Checked;

        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsWindow settingsWindow;
            
            settingsWindow = new SettingsWindow();

            if (!settingsWindow.IsOpened())
            {
               settingsWindow.ShowDialog();
            }
            
        }

        private void btnMusicTextStart_Click(object sender, EventArgs e)
        {
            if(ToggleStart)
            {
                SpotifyTimer.Start();
                ToggleStart = false;
                btnMusicTextStart.Text = "Stop";
            }else
            {
                SpotifyTimer.Stop();
                ToggleStart = true;
                btnMusicTextStart.Text = "Start";
            }
            
            

            
        }

        private void SpotifyTimer_Tick(object sender, EventArgs e)
        {
            var SpotifyList = Process.GetProcessesByName("Spotify");

            foreach(Process process in SpotifyList)
            {
                if(process.ProcessName == "Spotify")
                {
                    if(process.MainWindowTitle != "")
                    {
                        Console.WriteLine(process.MainWindowTitle);
                    }
                }
            }
        }
    }
}
