using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedoMKV
{
    using Microsoft.WindowsAPICodePack.Dialogs;
    public partial class Titles : Form
    {
        public string name = "";
        public string prefix = "";
        public string titleFile = "";
        public bool isFile;
        public bool isTitle;
        public Titles()
        {
            InitializeComponent();
            renameBtn.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            name = textBox2.Text;
            verifyRequirements();
        }

        private void verifyRequirements()
        {
            if (!String.IsNullOrWhiteSpace(name) && (cbFiles.Checked || cbTitles.Checked))
            {
                renameBtn.Enabled = true;
            } else
                renameBtn.Enabled = false;
                
        }

        private void renameBtn_click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cbTitles_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTitles.Checked)
                isTitle = true;
            else
                isTitle = false;
            verifyRequirements();
        }

        private void cbFiles_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFiles.Checked)
                isFile = true;
            else
                isFile = false;
            verifyRequirements();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            prefix = textBox1.Text;
        }
    }
}
