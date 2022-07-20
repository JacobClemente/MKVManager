using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace RedoMKV
{
    public partial class Default : Form
    {
        public int[] promotes = null;
        public int[] demotes = null;
        string promoteText = "";
        string demoteText = "";
        public Default()
        {
            InitializeComponent();
            commitBtn.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox2.Text, @"^[0-9, ]*$"))
            {
                promoteText = textBox2.Text;
                verifyRequirements();
            }
            else
                textBox2.Text = promoteText;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox2.Text, @"^[0-9, ]*$"))
            {
                demoteText = textBox1.Text;
                verifyRequirements();
            }
            else
                textBox1.Text = demoteText;
        }

        private void verifyRequirements()
        {
            if (!String.IsNullOrWhiteSpace(promoteText) || !String.IsNullOrWhiteSpace(demoteText))
                commitBtn.Enabled = true;
            else
                commitBtn.Enabled = false;
        }

        private void commitBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(promoteText))
            {
                string[] promoteStrings = promoteText.Split(',');
                promotes = new int[promoteStrings.Length];
                for (int i = 0; i < promoteStrings.Length; i++)
                {
                    promotes[i] = Int32.Parse(promoteStrings[i].Trim());
                }
            }
            if (!String.IsNullOrWhiteSpace(demoteText))
            {
                string[] demoteStrings = demoteText.Split(',');
                demotes = new int[demoteStrings.Length];
                for (int i = 0; i < demoteStrings.Length; i++)
                {
                    demotes[i] = Int32.Parse(demoteStrings[i].Trim());
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
