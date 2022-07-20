using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RedoMKV
{
    using Microsoft.WindowsAPICodePack.Dialogs;
    public partial class Attach : Form
    {
        public string[] selectedFiles = null;
        public Attach()
        {
            InitializeComponent();
            button1.Enabled = false;
            list.ScrollAlwaysVisible = true;
        }

        private void selDirBtn_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dialog.InitialDirectory = desktop;
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string[] files = Directory.GetFiles(dialog.FileName);;
                foreach (string file in files)
                {
                    if ((Path.GetExtension(file).CompareTo(".ttf") == 0 || Path.GetExtension(file).CompareTo(".otf") == 0) && !list.Items.Contains(file))
                        list.Items.Add(file);
                }
            }
            verifyRequirements();
        }

        private void selFileBtn_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dialog.InitialDirectory = desktop;
            dialog.Multiselect = true;
            dialog.Filters.Add(new CommonFileDialogFilter("TrueType Font (.ttf) files, OpenType Font (.otf) files", "*.ttf;*.otf"));
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string[] files = dialog.FileNames.ToArray();
                list.Items.Clear();
                foreach (string file in files)
                {
                    if (!list.Items.Contains(file))
                        list.Items.Add(file);
                }
            }
            verifyRequirements();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            for (int i = list.SelectedItems.Count - 1; i >= 0; i--)
            {
                object selected = list.Items[list.SelectedIndices[i]];
                list.Items.Remove(selected);
            }
            verifyRequirements();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            list.Items.Clear();
            verifyRequirements();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedFiles = list.Items.OfType<string>().ToArray();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void verifyRequirements()
        {
            if (list.Items.Count < 1)
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }
    }
}
