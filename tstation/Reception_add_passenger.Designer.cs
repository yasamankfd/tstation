using System.ComponentModel;

namespace tstation
{
    partial class Reception_add_passenger
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
            this.nid = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.woman = new System.Windows.Forms.RadioButton();
            this.man = new System.Windows.Forms.RadioButton();
            this.submit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.ComboBox();
            this.m = new System.Windows.Forms.ComboBox();
            this.y = new System.Windows.Forms.ComboBox();
            this.l = new System.Windows.Forms.Label();
            this.ll = new System.Windows.Forms.Label();
            this.lll = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nid
            // 
            this.nid.Location = new System.Drawing.Point(168, 75);
            this.nid.Name = "nid";
            this.nid.Size = new System.Drawing.Size(212, 26);
            this.nid.TabIndex = 0;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(168, 158);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(212, 26);
            this.name.TabIndex = 1;
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(168, 242);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(212, 26);
            this.lname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(73, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "کدملی";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(73, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(56, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "نام خانوادگی";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(520, 158);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(202, 26);
            this.phone.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(410, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "جنسیت";
            // 
            // woman
            // 
            this.woman.Location = new System.Drawing.Point(480, 74);
            this.woman.Name = "woman";
            this.woman.Size = new System.Drawing.Size(74, 26);
            this.woman.TabIndex = 4;
            this.woman.TabStop = true;
            this.woman.Text = "زن";
            this.woman.UseVisualStyleBackColor = true;
            this.woman.Click += new System.EventHandler(this.w_click);
            // 
            // man
            // 
            this.man.Location = new System.Drawing.Point(600, 76);
            this.man.Name = "man";
            this.man.Size = new System.Drawing.Size(81, 26);
            this.man.TabIndex = 5;
            this.man.TabStop = true;
            this.man.Text = "مرد";
            this.man.UseVisualStyleBackColor = true;
            this.man.Click += new System.EventHandler(this.m_click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(627, 385);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(153, 42);
            this.submit.TabIndex = 7;
            this.submit.Text = "ثبت";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(438, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "تلفن";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(56, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "تاریخ تولد";
            // 
            // d
            // 
            this.d.Location = new System.Drawing.Point(410, 329);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(101, 28);
            this.d.TabIndex = 4;
            // 
            // m
            // 
            this.m.Location = new System.Drawing.Point(293, 329);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(101, 28);
            this.m.TabIndex = 3;
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(166, 329);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(107, 28);
            this.y.TabIndex = 5;
            // 
            // l
            // 
            this.l.Location = new System.Drawing.Point(190, 302);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(56, 27);
            this.l.TabIndex = 8;
            this.l.Text = "سال";
            // 
            // ll
            // 
            this.ll.Location = new System.Drawing.Point(311, 302);
            this.ll.Name = "ll";
            this.ll.Size = new System.Drawing.Size(56, 27);
            this.ll.TabIndex = 8;
            this.ll.Text = "ماه";
            // 
            // lll
            // 
            this.lll.Location = new System.Drawing.Point(438, 299);
            this.lll.Name = "lll";
            this.lll.Size = new System.Drawing.Size(56, 27);
            this.lll.TabIndex = 8;
            this.lll.Text = "روز";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(31, 397);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(105, 41);
            this.back.TabIndex = 9;
            this.back.Text = "بازگشت";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Reception_add_passenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.lll);
            this.Controls.Add(this.ll);
            this.Controls.Add(this.l);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.man);
            this.Controls.Add(this.woman);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nid);
            this.Controls.Add(this.d);
            this.Controls.Add(this.m);
            this.Controls.Add(this.y);
            this.Name = "Reception_add_passenger";
            this.Text = "Reception_add_passenger";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button back;

        private System.Windows.Forms.RadioButton man;
        private System.Windows.Forms.RadioButton woman;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6,l,ll,lll;
        private System.Windows.Forms.ComboBox y,m,d;
        private System.Windows.Forms.TextBox nid;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox phone;

        #endregion
    }
}