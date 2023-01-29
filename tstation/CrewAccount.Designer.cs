using System.ComponentModel;

namespace tstation
{
    partial class CrewAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Cprofile = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(34, 29);
            this.toolStripMenuItem1.Text = "  ";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(12, 29);
            // 
            // Cprofile
            // 
            this.Cprofile.Location = new System.Drawing.Point(12, 36);
            this.Cprofile.Name = "Cprofile";
            this.Cprofile.Size = new System.Drawing.Size(197, 54);
            this.Cprofile.TabIndex = 1;
            this.Cprofile.Text = "پروفایل\r\n";
            this.Cprofile.UseVisualStyleBackColor = true;
            this.Cprofile.Click += new System.EventHandler(this.Profile_click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(12, 371);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(197, 50);
            this.exit.TabIndex = 2;
            this.exit.Text = "بازگشت";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // CrewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 433);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Cprofile);
            this.Name = "CrewAccount";
            this.Text = "CrewAccount";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button exit;
        
        private System.Windows.Forms.Button Cprofile;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

        #endregion
    }
}