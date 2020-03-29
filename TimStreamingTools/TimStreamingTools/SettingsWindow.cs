using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace TimStreamingTools
{
    public partial class SettingsWindow : Form
    {
        public string defaultmusicfile;

        Settings settings = new Settings();
        
        public class Settings
        {
            public string musicfile { get; set; }

        }

        public void LoadSettings()
        {
            if (File.Exists(Directory.GetCurrentDirectory() + @"\settings.json"))
            {
                string settingsfile = File.ReadAllText(Directory.GetCurrentDirectory() + @"\settings.json");
                Settings settingsjson = JsonSerializer.Deserialize<Settings>(settingsfile);
                DefaultOutputFileTextBox.Text = settingsjson.musicfile;
                defaultmusicfile = settingsjson.musicfile;
            }
        }

        public SettingsWindow()
        {
            InitializeComponent();

            LoadSettings();
        }

        public bool IsOpened()
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if(frm.Name == this.Name)
                {
                    return true;
                }else
                {
                    return false;
                }
            }

            return false;
        }

        

        private void btnBrowseOutputFile_Click(object sender, EventArgs e)
        {
            DefaultMusicOutputFileDialog.ShowDialog();

            defaultmusicfile = DefaultMusicOutputFileDialog.FileName;
            DefaultOutputFileTextBox.Text = defaultmusicfile;

            settings.musicfile = defaultmusicfile;
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            string jsonstring = JsonSerializer.Serialize(settings);
            File.WriteAllText(Directory.GetCurrentDirectory() + @"\settings.json", jsonstring);
            Console.WriteLine(Directory.GetCurrentDirectory());
            Console.WriteLine(jsonstring);







            this.Close();

        }
    }
}
