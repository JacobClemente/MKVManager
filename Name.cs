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
    public partial class Name : Form
    {
        public int trackNo = -1;
        public string name = "";
        string trackText = "";
        public Name()
        {
            InitializeComponent();
            renameBtn.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trackNo = Int32.Parse(textBox2.Text);
                trackText = textBox2.Text;
                verifyRequirements();
            } catch (Exception)
            {
                textBox2.Text = trackText;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
            verifyRequirements();
        }

        private void verifyRequirements()
        {
            if (!String.IsNullOrWhiteSpace(name) && trackNo > -1)
                renameBtn.Enabled = true;
            else
                renameBtn.Enabled = false;
        }

        private void renameBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
