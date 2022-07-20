namespace RedoMKV
{

    using System.Windows.Forms;
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.displayTbox = new System.Windows.Forms.TextBox();
            this.selDirBtn = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.ListBox();
            this.selFileBtn = new System.Windows.Forms.Button();
            this.upBtn = new System.Windows.Forms.Button();
            this.downBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.setMKVBtn = new System.Windows.Forms.Button();
            this.mkvTbox = new System.Windows.Forms.TextBox();
            this.extractBtn = new System.Windows.Forms.Button();
            this.mergeBtn = new System.Windows.Forms.Button();
            this.readBtn = new System.Windows.Forms.Button();
            this.addAttachBtn = new System.Windows.Forms.Button();
            this.renameTitleBtn = new System.Windows.Forms.Button();
            this.changeNameBtn = new System.Windows.Forms.Button();
            this.changeDefaultBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayTbox
            // 
            this.displayTbox.BackColor = System.Drawing.SystemColors.Window;
            this.displayTbox.Location = new System.Drawing.Point(12, 10);
            this.displayTbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.displayTbox.Multiline = true;
            this.displayTbox.Name = "displayTbox";
            this.displayTbox.ReadOnly = true;
            this.displayTbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displayTbox.Size = new System.Drawing.Size(600, 361);
            this.displayTbox.TabIndex = 17;
            // 
            // selDirBtn
            // 
            this.selDirBtn.AutoSize = true;
            this.selDirBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.selDirBtn.Location = new System.Drawing.Point(618, 10);
            this.selDirBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selDirBtn.Name = "selDirBtn";
            this.selDirBtn.Size = new System.Drawing.Size(112, 26);
            this.selDirBtn.TabIndex = 0;
            this.selDirBtn.Text = "Select Directory";
            this.selDirBtn.UseVisualStyleBackColor = true;
            this.selDirBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // list
            // 
            this.list.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.list.FormattingEnabled = true;
            this.list.HorizontalScrollbar = true;
            this.list.ItemHeight = 18;
            this.list.Location = new System.Drawing.Point(618, 38);
            this.list.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list.Name = "list";
            this.list.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.list.Size = new System.Drawing.Size(552, 238);
            this.list.TabIndex = 2;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            this.list.KeyDown += new KeyEventHandler(this.list_KeyEvent);
            // 
            // selFileBtn
            // 
            this.selFileBtn.AutoSize = true;
            this.selFileBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.selFileBtn.Location = new System.Drawing.Point(748, 10);
            this.selFileBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selFileBtn.Name = "selFileBtn";
            this.selFileBtn.Size = new System.Drawing.Size(87, 26);
            this.selFileBtn.TabIndex = 1;
            this.selFileBtn.Text = "Select Files";
            this.selFileBtn.UseVisualStyleBackColor = true;
            this.selFileBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // upBtn
            // 
            this.upBtn.AutoSize = true;
            this.upBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.upBtn.Location = new System.Drawing.Point(618, 286);
            this.upBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.upBtn.Name = "upBtn";
            this.upBtn.Size = new System.Drawing.Size(35, 26);
            this.upBtn.TabIndex = 3;
            this.upBtn.Text = "Up";
            this.upBtn.UseVisualStyleBackColor = true;
            this.upBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // downBtn
            // 
            this.downBtn.AutoSize = true;
            this.downBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.downBtn.Location = new System.Drawing.Point(662, 286);
            this.downBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.downBtn.Name = "downBtn";
            this.downBtn.Size = new System.Drawing.Size(51, 26);
            this.downBtn.TabIndex = 4;
            this.downBtn.Text = "Down";
            this.downBtn.UseVisualStyleBackColor = true;
            this.downBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.AutoSize = true;
            this.removeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removeBtn.Location = new System.Drawing.Point(726, 286);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(69, 26);
            this.removeBtn.TabIndex = 5;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.AutoSize = true;
            this.clearBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearBtn.Location = new System.Drawing.Point(805, 286);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(49, 26);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.button7_Click);
            // 
            // setMKVBtn
            // 
            this.setMKVBtn.AutoSize = true;
            this.setMKVBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.setMKVBtn.Location = new System.Drawing.Point(12, 403);
            this.setMKVBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setMKVBtn.Name = "setMKVBtn";
            this.setMKVBtn.Size = new System.Drawing.Size(132, 26);
            this.setMKVBtn.TabIndex = 15;
            this.setMKVBtn.Text = "Set mkvToolNix Dir";
            this.setMKVBtn.UseVisualStyleBackColor = true;
            this.setMKVBtn.Click += new System.EventHandler(this.button8_Click);
            // 
            // mkvTbox
            // 
            this.mkvTbox.Location = new System.Drawing.Point(165, 406);
            this.mkvTbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mkvTbox.Name = "mkvTbox";
            this.mkvTbox.ReadOnly = true;
            this.mkvTbox.Size = new System.Drawing.Size(447, 22);
            this.mkvTbox.TabIndex = 16;
            // 
            // extractBtn
            // 
            this.extractBtn.AutoSize = true;
            this.extractBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.extractBtn.Location = new System.Drawing.Point(618, 322);
            this.extractBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.extractBtn.Name = "extractBtn";
            this.extractBtn.Size = new System.Drawing.Size(95, 26);
            this.extractBtn.TabIndex = 7;
            this.extractBtn.Text = "Extract Track";
            this.extractBtn.UseVisualStyleBackColor = true;
            this.extractBtn.Click += new System.EventHandler(this.extractBtn_Click);
            // 
            // mergeBtn
            // 
            this.mergeBtn.AutoSize = true;
            this.mergeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mergeBtn.Location = new System.Drawing.Point(727, 322);
            this.mergeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mergeBtn.Name = "mergeBtn";
            this.mergeBtn.Size = new System.Drawing.Size(94, 26);
            this.mergeBtn.TabIndex = 8;
            this.mergeBtn.Text = "Merge Track";
            this.mergeBtn.UseVisualStyleBackColor = true;
            this.mergeBtn.Click += new System.EventHandler(this.mergeBtn_Click);
            // 
            // readBtn
            // 
            this.readBtn.AutoSize = true;
            this.readBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.readBtn.Location = new System.Drawing.Point(834, 322);
            this.readBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(96, 26);
            this.readBtn.TabIndex = 9;
            this.readBtn.Text = "Read Tracks";
            this.readBtn.UseVisualStyleBackColor = true;
            this.readBtn.Click += new System.EventHandler(this.button10_Click);
            // 
            // addAttachBtn
            // 
            this.addAttachBtn.AutoSize = true;
            this.addAttachBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addAttachBtn.Location = new System.Drawing.Point(938, 322);
            this.addAttachBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addAttachBtn.Name = "addAttachBtn";
            this.addAttachBtn.Size = new System.Drawing.Size(118, 26);
            this.addAttachBtn.TabIndex = 10;
            this.addAttachBtn.Text = "Add Attachments";
            this.addAttachBtn.UseVisualStyleBackColor = true;
            this.addAttachBtn.Click += new System.EventHandler(this.addAttachBtn_Click);
            // 
            // renameTitleBtn
            // 
            this.renameTitleBtn.AutoSize = true;
            this.renameTitleBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.renameTitleBtn.Location = new System.Drawing.Point(618, 351);
            this.renameTitleBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.renameTitleBtn.Name = "renameTitleBtn";
            this.renameTitleBtn.Size = new System.Drawing.Size(138, 26);
            this.renameTitleBtn.TabIndex = 11;
            this.renameTitleBtn.Text = "Rename Titles/Files";
            this.renameTitleBtn.UseVisualStyleBackColor = true;
            this.renameTitleBtn.Click += new System.EventHandler(this.renameTitleBtn_Click);
            // 
            // changeNameBtn
            // 
            this.changeNameBtn.AutoSize = true;
            this.changeNameBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.changeNameBtn.Location = new System.Drawing.Point(771, 351);
            this.changeNameBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeNameBtn.Name = "changeNameBtn";
            this.changeNameBtn.Size = new System.Drawing.Size(142, 26);
            this.changeNameBtn.TabIndex = 12;
            this.changeNameBtn.Text = "Change Track Name";
            this.changeNameBtn.UseVisualStyleBackColor = true;
            this.changeNameBtn.Click += new System.EventHandler(this.changeNameBtn_Click);
            // 
            // changeDefaultBtn
            // 
            this.changeDefaultBtn.AutoSize = true;
            this.changeDefaultBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.changeDefaultBtn.Location = new System.Drawing.Point(927, 351);
            this.changeDefaultBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeDefaultBtn.Name = "changeDefaultBtn";
            this.changeDefaultBtn.Size = new System.Drawing.Size(154, 26);
            this.changeDefaultBtn.TabIndex = 13;
            this.changeDefaultBtn.Text = "Change Default Tracks";
            this.changeDefaultBtn.UseVisualStyleBackColor = true;
            this.changeDefaultBtn.Click += new System.EventHandler(this.changeDefaultBtn_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(12, 374);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 26);
            this.button1.TabIndex = 14;
            this.button1.Text = "Clear Display";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 444);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.changeDefaultBtn);
            this.Controls.Add(this.changeNameBtn);
            this.Controls.Add(this.renameTitleBtn);
            this.Controls.Add(this.addAttachBtn);
            this.Controls.Add(this.readBtn);
            this.Controls.Add(this.mergeBtn);
            this.Controls.Add(this.extractBtn);
            this.Controls.Add(this.mkvTbox);
            this.Controls.Add(this.setMKVBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.downBtn);
            this.Controls.Add(this.upBtn);
            this.Controls.Add(this.selFileBtn);
            this.Controls.Add(this.list);
            this.Controls.Add(this.selDirBtn);
            this.Controls.Add(this.displayTbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "Jacob\'s Bulk-MKV Tool v2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox displayTbox;
        private Button selDirBtn;
        private ListBox list;
        private Button selFileBtn;
        private Button upBtn;
        private Button downBtn;
        private Button removeBtn;
        private Button clearBtn;
        private Button setMKVBtn;
        private TextBox mkvTbox;
        private Button extractBtn;
        private Button mergeBtn;
        private Button readBtn;
        private Button addAttachBtn;
        private Button renameTitleBtn;
        private Button changeNameBtn;
        private Button changeDefaultBtn;
        private Button button1;
    }
}