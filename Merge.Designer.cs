namespace RedoMKV
{
    using System.Windows.Forms;
    partial class Merge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Merge));
            this.trackLbl = new System.Windows.Forms.Label();
            this.trackTbox = new System.Windows.Forms.TextBox();
            this.extTbox = new System.Windows.Forms.TextBox();
            this.extLbl = new System.Windows.Forms.Label();
            this.mergeBtn = new System.Windows.Forms.Button();
            this.defaultCbox = new System.Windows.Forms.CheckBox();
            this.overrideCbox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.titlesTbox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.countLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioAudio = new System.Windows.Forms.RadioButton();
            this.radioVideo = new System.Windows.Forms.RadioButton();
            this.radioSubtitle = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackLbl
            // 
            this.trackLbl.AutoSize = true;
            this.trackLbl.Location = new System.Drawing.Point(12, 7);
            this.trackLbl.Name = "trackLbl";
            this.trackLbl.Size = new System.Drawing.Size(55, 16);
            this.trackLbl.TabIndex = 11;
            this.trackLbl.Text = "Track #:";
            // 
            // trackTbox
            // 
            this.trackTbox.Location = new System.Drawing.Point(78, 5);
            this.trackTbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackTbox.Name = "trackTbox";
            this.trackTbox.Size = new System.Drawing.Size(125, 22);
            this.trackTbox.TabIndex = 0;
            this.trackTbox.TextChanged += new System.EventHandler(this.trackTbox_TextChanged);
            // 
            // extTbox
            // 
            this.extTbox.Location = new System.Drawing.Point(97, 31);
            this.extTbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.extTbox.Name = "extTbox";
            this.extTbox.Size = new System.Drawing.Size(106, 22);
            this.extTbox.TabIndex = 1;
            this.extTbox.TextChanged += new System.EventHandler(this.extTbox_TextChanged);
            // 
            // extLbl
            // 
            this.extLbl.AutoSize = true;
            this.extLbl.Location = new System.Drawing.Point(12, 34);
            this.extLbl.Name = "extLbl";
            this.extLbl.Size = new System.Drawing.Size(71, 16);
            this.extLbl.TabIndex = 12;
            this.extLbl.Text = "Extension: ";
            // 
            // mergeBtn
            // 
            this.mergeBtn.AutoSize = true;
            this.mergeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mergeBtn.Location = new System.Drawing.Point(12, 268);
            this.mergeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mergeBtn.Name = "mergeBtn";
            this.mergeBtn.Size = new System.Drawing.Size(94, 26);
            this.mergeBtn.TabIndex = 10;
            this.mergeBtn.Text = "Merge Track";
            this.mergeBtn.UseVisualStyleBackColor = true;
            this.mergeBtn.Click += new System.EventHandler(this.mergeBtn_Click);
            // 
            // defaultCbox
            // 
            this.defaultCbox.AutoSize = true;
            this.defaultCbox.Location = new System.Drawing.Point(12, 58);
            this.defaultCbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.defaultCbox.Name = "defaultCbox";
            this.defaultCbox.Size = new System.Drawing.Size(109, 20);
            this.defaultCbox.TabIndex = 2;
            this.defaultCbox.Text = "Default Track";
            this.defaultCbox.UseVisualStyleBackColor = true;
            this.defaultCbox.CheckedChanged += new System.EventHandler(this.defaultCbox_CheckedChanged);
            // 
            // overrideCbox
            // 
            this.overrideCbox.AutoSize = true;
            this.overrideCbox.Location = new System.Drawing.Point(12, 82);
            this.overrideCbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.overrideCbox.Name = "overrideCbox";
            this.overrideCbox.Size = new System.Drawing.Size(168, 20);
            this.overrideCbox.TabIndex = 3;
            this.overrideCbox.Text = "Override Existing Track";
            this.overrideCbox.UseVisualStyleBackColor = true;
            this.overrideCbox.CheckedChanged += new System.EventHandler(this.overrideCbox_CheckedChanged);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(12, 106);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Titles Text File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // titlesTbox
            // 
            this.titlesTbox.Location = new System.Drawing.Point(12, 134);
            this.titlesTbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titlesTbox.Name = "titlesTbox";
            this.titlesTbox.ReadOnly = true;
            this.titlesTbox.Size = new System.Drawing.Size(308, 22);
            this.titlesTbox.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 185);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(12, 187);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(80, 16);
            this.countLabel.TabIndex = 15;
            this.countLabel.Text = "Count Prefix:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioAudio);
            this.groupBox1.Controls.Add(this.radioVideo);
            this.groupBox1.Controls.Add(this.radioSubtitle);
            this.groupBox1.Location = new System.Drawing.Point(209, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(111, 120);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Track Type:";
            // 
            // radioAudio
            // 
            this.radioAudio.AutoSize = true;
            this.radioAudio.Location = new System.Drawing.Point(6, 45);
            this.radioAudio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioAudio.Name = "radioAudio";
            this.radioAudio.Size = new System.Drawing.Size(63, 20);
            this.radioAudio.TabIndex = 1;
            this.radioAudio.TabStop = true;
            this.radioAudio.Text = "Audio";
            this.radioAudio.UseVisualStyleBackColor = true;
            this.radioAudio.CheckedChanged += new System.EventHandler(this.radioAudio_CheckedChanged);
            // 
            // radioVideo
            // 
            this.radioVideo.AutoSize = true;
            this.radioVideo.Location = new System.Drawing.Point(6, 21);
            this.radioVideo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioVideo.Name = "radioVideo";
            this.radioVideo.Size = new System.Drawing.Size(64, 20);
            this.radioVideo.TabIndex = 0;
            this.radioVideo.TabStop = true;
            this.radioVideo.Text = "Video";
            this.radioVideo.UseVisualStyleBackColor = true;
            this.radioVideo.CheckedChanged += new System.EventHandler(this.radioVideo_CheckedChanged);
            // 
            // radioSubtitle
            // 
            this.radioSubtitle.AutoSize = true;
            this.radioSubtitle.Location = new System.Drawing.Point(6, 69);
            this.radioSubtitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioSubtitle.Name = "radioSubtitle";
            this.radioSubtitle.Size = new System.Drawing.Size(72, 20);
            this.radioSubtitle.TabIndex = 2;
            this.radioSubtitle.TabStop = true;
            this.radioSubtitle.Text = "Subtitle";
            this.radioSubtitle.UseVisualStyleBackColor = true;
            this.radioSubtitle.CheckedChanged += new System.EventHandler(this.radioSubtitle_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 158);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Base Name:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(105, 211);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(215, 22);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Track Name:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(209, 238);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(111, 22);
            this.textBox4.TabIndex = 9;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Track Language (ISO 369-2):";
            // 
            // Merge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 302);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.titlesTbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.overrideCbox);
            this.Controls.Add(this.defaultCbox);
            this.Controls.Add(this.mergeBtn);
            this.Controls.Add(this.extTbox);
            this.Controls.Add(this.extLbl);
            this.Controls.Add(this.trackTbox);
            this.Controls.Add(this.trackLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Merge";
            this.Text = "Merge";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label trackLbl;
        private TextBox trackTbox;
        private TextBox extTbox;
        private Label extLbl;
        private Button mergeBtn;
        private CheckBox defaultCbox;
        private CheckBox overrideCbox;
        private Button button1;
        private TextBox titlesTbox;
        private TextBox textBox1;
        private Label countLabel;
        private GroupBox groupBox1;
        private RadioButton radioAudio;
        private RadioButton radioVideo;
        private RadioButton radioSubtitle;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox4;
        private Label label3;
    }
}