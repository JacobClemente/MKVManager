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
    public partial class Extract : Form
    {
        public int trackID;
        public string extension = "";
        string trackText = "";
        public Extract()
        {
            InitializeComponent();
            extractBtn.Enabled = false;
        }

        private void extractBtn_Click(object sender, EventArgs e)
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
                if (extension.Length != 0)
                    extractBtn.Enabled = true;
            } catch (Exception)
            {
                trackTbox.Text = trackText;
            } 
            
        }

        private void extTbox_TextChanged(object sender, EventArgs e)
        {
            extension = extTbox.Text;
            if (trackID > -1)
                extractBtn.Enabled = true;
        }
    }
}
