using System.ComponentModel;

namespace tstation
{
    partial class Reception_ticket_reservation
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.trips = new System.Windows.Forms.ListBox();
            this.show = new System.Windows.Forms.Button();
            this.d = new System.Windows.Forms.ComboBox();
            this.m = new System.Windows.Forms.ComboBox();
            this.y = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 26);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(469, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 26);
            this.textBox2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(97, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "مبدا";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(412, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "مقصد\r\n";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(164, 151);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(122, 34);
            this.search.TabIndex = 2;
            this.search.Text = "جستجو";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // trips
            // 
            this.trips.FormattingEnabled = true;
            this.trips.ItemHeight = 20;
            this.trips.Location = new System.Drawing.Point(26, 191);
            this.trips.Name = "trips";
            this.trips.Size = new System.Drawing.Size(740, 204);
            this.trips.TabIndex = 3;
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(613, 401);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(161, 43);
            this.show.TabIndex = 4;
            this.show.Text = "نمایش";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // d
            // 
            this.d.Location = new System.Drawing.Point(410, 109);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(101, 28);
            this.d.TabIndex = 4;
            // 
            // m
            // 
            this.m.Location = new System.Drawing.Point(293, 109);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(101, 28);
            this.m.TabIndex = 3;
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(166, 109);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(107, 28);
            this.y.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(204, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "سال";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(451, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "روز";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(331, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "ماه";
            // 
            // Reception_ticket_reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.d);
            this.Controls.Add(this.m);
            this.Controls.Add(this.y);
            this.Controls.Add(this.show);
            this.Controls.Add(this.trips);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Reception_ticket_reservation";
            this.Text = "Reception_ticket_reservation";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;


        private System.Windows.Forms.Button show;

        private System.Windows.Forms.ListBox trips;

        private System.Windows.Forms.Button search;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox y,m,d;

        #endregion
    }
}