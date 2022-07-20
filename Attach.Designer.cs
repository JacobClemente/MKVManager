namespace RedoMKV
{
    using System.Windows.Forms;
    partial class Attach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attach));
            this.clearBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.selFileBtn = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.ListBox();
            this.selDirBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clearBtn
            // 
            this.clearBtn.AutoSize = true;
            this.clearBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearBtn.Location = new System.Drawing.Point(91, 286);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(49, 26);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.AutoSize = true;
            this.removeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removeBtn.Location = new System.Drawing.Point(12, 286);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(69, 26);
            this.removeBtn.TabIndex = 3;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // selFileBtn
            // 
            this.selFileBtn.AutoSize = true;
            this.selFileBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.selFileBtn.Location = new System.Drawing.Point(142, 10);
            this.selFileBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selFileBtn.Name = "selFileBtn";
            this.selFileBtn.Size = new System.Drawing.Size(87, 26);
            this.selFileBtn.TabIndex = 1;
            this.selFileBtn.Text = "Select Files";
            this.selFileBtn.UseVisualStyleBackColor = true;
            this.selFileBtn.Click += new System.EventHandler(this.selFileBtn_Click);
            // 
            // list
            // 
            this.list.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.list.FormattingEnabled = true;
            this.list.HorizontalScrollbar = true;
            this.list.ItemHeight = 18;
            this.list.Location = new System.Drawing.Point(12, 38);
            this.list.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list.Name = "list";
            this.list.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.list.Size = new System.Drawing.Size(283, 238);
            this.list.TabIndex = 2;
            // 
            // selDirBtn
            // 
            this.selDirBtn.AutoSize = true;
            this.selDirBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.selDirBtn.Location = new System.Drawing.Point(12, 10);
            this.selDirBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selDirBtn.Name = "selDirBtn";
            this.selDirBtn.Size = new System.Drawing.Size(112, 26);
            this.selDirBtn.TabIndex = 0;
            this.selDirBtn.Text = "Select Directory";
            this.selDirBtn.UseVisualStyleBackColor = true;
            this.selDirBtn.Click += new System.EventHandler(this.selDirBtn_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(150, 286);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add Attachments";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Attach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 324);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.selFileBtn);
            this.Controls.Add(this.list);
            this.Controls.Add(this.selDirBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Attach";
            this.Text = "Attach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button clearBtn;
        private Button removeBtn;
        private Button selFileBtn;
        private ListBox list;
        private Button selDirBtn;
        private Button button1;
    }
}