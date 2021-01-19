using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace TimStreamingTools
{
    public partial class MainWindow : Form
    {
        
        public Settings settings = new Settings();

        public class Settings
        {
            public string musicfile { get; set; }
            public string timefile { get; set; }
            public int paddingspacenum { get; set; }

        }

        bool ToggleStart = true;
        public string musictextfile;
        public string timetextfile;
        public int padspace;

        public void SaveSettings()
        {
            string jsonstring = JsonSerializer.Serialize(settings);
            File.WriteAllText(Directory.GetCurrentDirectory() + @"\settings.json", jsonstring);
            Console.WriteLine(Directory.GetCurrentDirectory());
            Console.WriteLine(jsonstring);
        }

        public void LoadSettings()
        {
            //string settingsfile = File.ReadAllText(Directory.GetCurrentDirectory() + @"\settings.json");

            if (File.Exists(Directory.GetCurrentDirectory() + @"\settings.json"))
            {
                string settingsfile = File.ReadAllText(Directory.GetCurrentDirectory() + @"\settings.json");
                Settings settingsjson = JsonSerializer.Deserialize<Settings>(settingsfile);
                musictextfile = settingsjson.musicfile;
                outputfiletextbox.Text = settingsjson.musicfile;
                textBox4.Text = settingsjson.timefile;
                timetextfile = settingsjson.timefile;
                padspace = settingsjson.paddingspacenum;
                PaddingSpacesUpAndDown.Value = padspace;
            }
        }

        public MainWindow()
        {
            InitializeComponent();



            padspace = 0;
            comboBoxMusicSelection.SelectedIndex = 0;
            outputfiletextbox.Text = musictextfile; //do this but gooder
            textBox4.Text = timetextfile;

            PaddingSpacesUpAndDown.Enabled = radioButtonPaddingSpaces.Checked;
            paddingCharactersTextBox.Enabled = radioButtonCharacterPadding.Checked;
            PaddingCharactersUpAndDown.Enabled = radioButtonCharacterPadding.Checked;

            LoadSettings();

            CurrentTimeTimer.Start();
            
        }

        //
        // Music Part
        //
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

        private void PaddingSpacesUpAndDown_ValueChanged(object sender, EventArgs e)
        {
            padspace = (int)PaddingSpacesUpAndDown.Value;
        }

        public string PaddingString()
        {
            if(radioButtonPaddingSpaces.Checked)
            {
                if(!(padspace == 0))
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
            //Get all the Spotify Processes in the Machine
            var SpotifyList = Process.GetProcessesByName("Spotify");

            // Loop through all the Processes and find the Spotify one
            foreach (Process process in SpotifyList)
            {
                if (process.ProcessName == "Spotify")
                {
                    if (process.MainWindowTitle != "")
                    {
                        if(process.MainWindowTitle == "Spotify Free")
                        {
                            musiccontent = "Paused    ";
                        }
                        else if(process.MainWindowTitle == "Advertisement")
                        {
                            musiccontent = process.MainWindowTitle + "   ";
                        }
                        else
                        {
                            musiccontent = process.MainWindowTitle + PaddingString();
                        }


                        musicOutputTextbox.Text = musiccontent;
                        File.WriteAllText(musictextfile, musiccontent);
                    }
                }
            }
        }

        

        public bool bMusicFile = false;
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
                    bMusicFile = true;
                }
                else
                {
                    bMusicFile = true;
                }
                
            }
            
            if(ToggleStart && bMusicFile)
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
            MusicOutputFileDialog.ShowDialog();

            musictextfile = MusicOutputFileDialog.FileName;

            outputfiletextbox.Text = musictextfile;
        }


        //
        // Time Part
        //

        Regex hourPadding = new Regex(@"![hHmMsS]");
        private void button1_Click(object sender, EventArgs e)
        {
            TimeOutputFileDialog.ShowDialog();

            timetextfile = TimeOutputFileDialog.FileName;

            textBox4.Text = timetextfile;
        }
        private string TimeFormat(string s,DateTime time,TimeZoneInfo timezone)
        {
            string sum = "";
            
            if(timezone.GetUtcOffset(time).TotalHours < 0)
            {
                sum = time.ToLongTimeString() + " (GMT" + timezone.GetUtcOffset(time).TotalHours.ToString() + ")";
            }
            else
            {
                sum = time.ToLongTimeString() + " (GMT+" + timezone.GetUtcOffset(time).TotalHours.ToString() + ")";
            }

            return sum;
        }

        private void CurrentTimeTimer_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            TimeZoneInfo timezone = TimeZoneInfo.Local;

            string outputstring = TimeFormat(textBox1.Text,time,timezone);

            textBox3.Text = outputstring;
            
            string hms = time.ToLongTimeString();
            textBox2.Text = hms;


            if (timetextfile == null || timetextfile == "")
            {

            }
            else
            {

                if (!File.Exists(timetextfile))
                {
                    File.Create(timetextfile);

                }
                else
                {
                    File.WriteAllText(timetextfile, outputstring);
                }

            }

            


        }

        private void formatResetBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        //
        // Misc Part
        //

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            settings.paddingspacenum = padspace;
            settings.musicfile = musictextfile;
            settings.timefile = timetextfile;
            
            
            SaveSettings();
        }

        
    }
}
