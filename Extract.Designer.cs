namespace RedoMKV
{
    using System.Windows.Forms;
    partial class Extract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Extract));
            this.trackLbl = new System.Windows.Forms.Label();
            this.trackTbox = new System.Windows.Forms.TextBox();
            this.extTbox = new System.Windows.Forms.TextBox();
            this.extLbl = new System.Windows.Forms.Label();
            this.extractBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trackLbl
            // 
            this.trackLbl.AutoSize = true;
            this.trackLbl.Location = new System.Drawing.Point(12, 7);
            this.trackLbl.Name = "trackLbl";
            this.trackLbl.Size = new System.Drawing.Size(55, 16);
            this.trackLbl.TabIndex = 3;
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
            this.extLbl.TabIndex = 4;
            this.extLbl.Text = "Extension: ";
            // 
            // extractBtn
            // 
            this.extractBtn.AutoSize = true;
            this.extractBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.extractBtn.Location = new System.Drawing.Point(12, 58);
            this.extractBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.extractBtn.Name = "extractBtn";
            this.extractBtn.Size = new System.Drawing.Size(95, 26);
            this.extractBtn.TabIndex = 2;
            this.extractBtn.Text = "Extract Track";
            this.extractBtn.UseVisualStyleBackColor = true;
            this.extractBtn.Click += new System.EventHandler(this.extractBtn_Click);
            // 
            // Extract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 92);
            this.Controls.Add(this.extractBtn);
            this.Controls.Add(this.extTbox);
            this.Controls.Add(this.extLbl);
            this.Controls.Add(this.trackTbox);
            this.Controls.Add(this.trackLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Extract";
            this.Text = "Extract";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label trackLbl;
        private TextBox trackTbox;
        private TextBox extTbox;
        private Label extLbl;
        private Button extractBtn;
    }
}