using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimStreamingTools
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
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

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
