namespace RedoMKV
{
    using System.Windows.Forms;
    partial class Titles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Titles));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.countLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.renameBtn = new System.Windows.Forms.Button();
            this.titlesTbox = new System.Windows.Forms.TextBox();
            this.cbTitles = new System.Windows.Forms.CheckBox();
            this.cbFiles = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 7);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 22);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Base Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(12, 36);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(80, 16);
            this.countLabel.TabIndex = 7;
            this.countLabel.Text = "Count Prefix:";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(12, 60);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Titles Text File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // renameBtn
            // 
            this.renameBtn.AutoSize = true;
            this.renameBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.renameBtn.Location = new System.Drawing.Point(12, 163);
            this.renameBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.renameBtn.Name = "renameBtn";
            this.renameBtn.Size = new System.Drawing.Size(69, 26);
            this.renameBtn.TabIndex = 5;
            this.renameBtn.Text = "Rename";
            this.renameBtn.UseVisualStyleBackColor = true;
            this.renameBtn.Click += new System.EventHandler(this.renameBtn_click);
            // 
            // titlesTbox
            // 
            this.titlesTbox.Location = new System.Drawing.Point(12, 89);
            this.titlesTbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titlesTbox.Name = "titlesTbox";
            this.titlesTbox.ReadOnly = true;
            this.titlesTbox.Size = new System.Drawing.Size(308, 22);
            this.titlesTbox.TabIndex = 8;
            // 
            // cbTitles
            // 
            this.cbTitles.AutoSize = true;
            this.cbTitles.Location = new System.Drawing.Point(12, 115);
            this.cbTitles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTitles.Name = "cbTitles";
            this.cbTitles.Size = new System.Drawing.Size(185, 20);
            this.cbTitles.TabIndex = 3;
            this.cbTitles.Text = "Rename Titles (Metadata)";
            this.cbTitles.UseVisualStyleBackColor = true;
            this.cbTitles.CheckedChanged += new System.EventHandler(this.cbTitles_CheckedChanged);
            // 
            // cbFiles
            // 
            this.cbFiles.AutoSize = true;
            this.cbFiles.Location = new System.Drawing.Point(12, 139);
            this.cbFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFiles.Name = "cbFiles";
            this.cbFiles.Size = new System.Drawing.Size(113, 20);
            this.cbFiles.TabIndex = 4;
            this.cbFiles.Text = "Rename Files";
            this.cbFiles.UseVisualStyleBackColor = true;
            this.cbFiles.CheckedChanged += new System.EventHandler(this.cbFiles_CheckedChanged);
            // 
            // Titles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 204);
            this.Controls.Add(this.cbFiles);
            this.Controls.Add(this.cbTitles);
            this.Controls.Add(this.titlesTbox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.renameBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Titles";
            this.Text = "Titles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Label countLabel;
        private Button button1;
        private Button renameBtn;
        private TextBox titlesTbox;
        private CheckBox cbTitles;
        private CheckBox cbFiles;
    }
}