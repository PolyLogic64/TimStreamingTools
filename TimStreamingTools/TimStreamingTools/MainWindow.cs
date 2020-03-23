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
using System.IO;

namespace TimStreamingTools
{
    public partial class MainWindow : Form
    {

        bool ToggleStart = true;
        public string musictextfile;
        public MainWindow()
        {
            InitializeComponent();

            comboBoxMusicSelection.SelectedIndex = 0;

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

        public void MusicText(string s)
        {
            string musicplayer = comboBoxMusicSelection.Items[comboBoxMusicSelection.SelectedIndex].ToString();

            switch (s)
            {
                default:
                    break;
                case "on":
                    switch (musicplayer)
                    {
                        default:
                            MessageBox.Show("No Music Player Selected");
                            break;
                        case "Spotify":
                            SpotifyTimer.Start();
                            break;
                    }
                    break;

                case "off":
                    switch (musicplayer)
                    {
                        default:
                            break;
                        case "Spotify":
                            SpotifyTimer.Stop();
                            break;
                    }
                    break;
            }
            
        }

        public string PaddingString()
        {
            if(radioButtonPaddingSpaces.Checked)
            {
                if(!(PaddingSpacesUpAndDown.Value == 0))
                {
                    string spacestring = new string(' ', Convert.ToInt32(PaddingSpacesUpAndDown.Value));
                    return spacestring;
                }
                else
                {
                    return "";
                }
            }
            if (radioButtonCharacterPadding.Checked)
            {
                if(!(PaddingCharactersUpAndDown.Value == 0))
                {
                    if(!(paddingCharactersTextBox.Text == ""))
                    {
                        int characterrepeat = Convert.ToInt32(PaddingCharactersUpAndDown.Value);
                        string characterpadding = "";

                        for (int i = 0; i < characterrepeat; i++)
                        {
                            characterpadding += paddingCharactersTextBox.Text;
                        }

                        return characterpadding;
                    }
                    else
                    {
                        return "";
                    }
                    
                }
                else
                {
                    return "";
                }
            }
            
            
            return "";
        }

        public string musiccontent;
        private void SpotifyTimer_Tick(object sender, EventArgs e)
        {
            var SpotifyList = Process.GetProcessesByName("Spotify");

            foreach (Process process in SpotifyList)
            {
                if (process.ProcessName == "Spotify")
                {
                    if (process.MainWindowTitle != "")
                    {
                        Console.WriteLine(process.MainWindowTitle);

                        musiccontent = process.MainWindowTitle + PaddingString();

                        File.WriteAllText(musictextfile, musiccontent);
                    }
                }
            }
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

        public bool bFile = false;
        private void btnMusicTextStart_Click(object sender, EventArgs e)
        {
            
            if(musictextfile == null)
            {
                MessageBox.Show("No Output File Selected");
            }
            else 
            {
                if (!File.Exists(musictextfile))
                {
                    File.Create(musictextfile);
                    bFile = true;
                }
                else
                {
                    bFile = true;
                }
                
            }
            
            if(ToggleStart && bFile)
            {
                MusicText("on");
                ToggleStart = false;
                btnMusicTextStart.Text = "Stop";
            }else
            {
                MusicText("off");
                ToggleStart = true;
                btnMusicTextStart.Text = "Start";
            }
            
            

            
        }
        private void btnBrowseForOutputFile_Click(object sender, EventArgs e)
        {
            OutputFileDialog.ShowDialog();

            musictextfile = OutputFileDialog.FileName;

            outputfiletextbox.Text = musictextfile;
        }
    }
}
