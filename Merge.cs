using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace RedoMKV
{
    public partial class Merge : Form
    {
        public int trackID;
        public string extension = "";
        public string countPrefix = "";
        public string titleFile = "";
        public string type = "";
        public string name = "";
        public string trackName = "";
        public string language = "";
        public bool isDefault;
        public bool isOverride;
        bool isTypeSelected = false;
        string trackText = "";

        public Merge()
        {
            InitializeComponent();
            mergeBtn.Enabled = false;
            groupBox1.Controls.Add(radioVideo);
            groupBox1.Controls.Add(radioAudio);
            groupBox1.Controls.Add(radioSubtitle);
        }

        private void mergeBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void trackTbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trackID = Int32.Parse(trackTbox.Text);
                trackText = trackTbox.Text;
                checkRequirements();
            } catch (Exception)
            {
                trackTbox.Text = trackText;
            } 
            
        }

        private void extTbox_TextChanged(object sender, EventArgs e)
        {
            extension = extTbox.Text;
            checkRequirements();
        }

        private void defaultCbox_CheckedChanged(object sender, EventArgs e)
        {
            isDefault = defaultCbox.Checked;
        }

        private void overrideCbox_CheckedChanged(object sender, EventArgs e)
        {
            isOverride = overrideCbox.Checked;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            countPrefix = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dialog.InitialDirectory = desktop;
            dialog.Filters.Add(new CommonFileDialogFilter("Text (.txt) files", "*.txt"));
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                titleFile = dialog.FileName;
                titlesTbox.Text = titleFile;
            }
        }

        private void radioVideo_CheckedChanged(object sender, EventArgs e)
        {
            type = "d";
            isTypeSelected = true;
            checkRequirements();
        }

        private void radioAudio_CheckedChanged(object sender, EventArgs e)
        {
            type = "a";
            isTypeSelected = true;
            checkRequirements();
        }

        private void radioSubtitle_CheckedChanged(object sender, EventArgs e)
        {
            type = "s";
            isTypeSelected = true;
            checkRequirements();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            name = textBox2.Text;
            checkRequirements();
        }

        private void checkRequirements()
        {
            if (!String.IsNullOrWhiteSpace(extension) && !String.IsNullOrWhiteSpace(name) && trackID >= 0 && isTypeSelected)
                mergeBtn.Enabled = true;
            else
                mergeBtn.Enabled = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            trackName = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            language = textBox4.Text;
        }
    }
}
