using System.ComponentModel;

namespace tstation
{
    partial class Reception_passengers
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
            this.plist = new System.Windows.Forms.ListBox();
            this.nid = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.listoftickets = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bdate = new System.Windows.Forms.Label();
            this.gen = new System.Windows.Forms.Label();
            this.nid2 = new System.Windows.Forms.Label();
            this.phone2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.lname2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lnamecheck = new System.Windows.Forms.CheckBox();
            this.phonecheck = new System.Windows.Forms.CheckBox();
            this.nidcheck = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plist
            // 
            this.plist.FormattingEnabled = true;
            this.plist.ItemHeight = 20;
            this.plist.Location = new System.Drawing.Point(37, 117);
            this.plist.Name = "plist";
            this.plist.Size = new System.Drawing.Size(382, 204);
            this.plist.TabIndex = 0;
            this.plist.SelectedIndexChanged += new System.EventHandler(this.pass);
            // 
            // nid
            // 
            this.nid.Location = new System.Drawing.Point(48, 50);
            this.nid.Name = "nid";
            this.nid.Size = new System.Drawing.Size(134, 26);
            this.nid.TabIndex = 1;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(268, 50);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(135, 26);
            this.phone.TabIndex = 1;
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(506, 50);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(122, 26);
            this.lname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(268, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "تلفن";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(506, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "نام خانوادگی";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(48, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "کد ملی";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(679, 46);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(73, 36);
            this.search.TabIndex = 4;
            this.search.Text = "جستجو";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // listoftickets
            // 
            this.listoftickets.FormattingEnabled = true;
            this.listoftickets.ItemHeight = 20;
            this.listoftickets.Location = new System.Drawing.Point(440, 353);
            this.listoftickets.Name = "listoftickets";
            this.listoftickets.Size = new System.Drawing.Size(342, 84);
            this.listoftickets.TabIndex = 5;
            this.listoftickets.Click += new System.EventHandler(this.ticket_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(440, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "بلیط ها";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.bdate);
            this.panel1.Controls.Add(this.gen);
            this.panel1.Controls.Add(this.nid2);
            this.panel1.Controls.Add(this.phone2);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.lname2);
            this.panel1.Location = new System.Drawing.Point(425, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 196);
            this.panel1.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(25, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "تاریخ تولد";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(25, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "جنسیت";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(25, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "کدملی";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(25, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "تلفن";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(25, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "نام خانوادگی";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(25, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "نام";
            // 
            // bdate
            // 
            this.bdate.Location = new System.Drawing.Point(154, 151);
            this.bdate.Name = "bdate";
            this.bdate.Size = new System.Drawing.Size(80, 27);
            this.bdate.TabIndex = 2;
            this.bdate.Text = " ";
            // 
            // gen
            // 
            this.gen.Location = new System.Drawing.Point(154, 124);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(80, 27);
            this.gen.TabIndex = 2;
            this.gen.Text = " ";
            // 
            // nid2
            // 
            this.nid2.Location = new System.Drawing.Point(154, 97);
            this.nid2.Name = "nid2";
            this.nid2.Size = new System.Drawing.Size(80, 27);
            this.nid2.TabIndex = 2;
            this.nid2.Text = " ";
            // 
            // phone2
            // 
            this.phone2.Location = new System.Drawing.Point(154, 70);
            this.phone2.Name = "phone2";
            this.phone2.Size = new System.Drawing.Size(80, 27);
            this.phone2.TabIndex = 2;
            this.phone2.Text = " ";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(154, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(78, 24);
            this.name.TabIndex = 1;
            this.name.Text = " ";
            // 
            // lname2
            // 
            this.lname2.Location = new System.Drawing.Point(154, 46);
            this.lname2.Name = "lname2";
            this.lname2.Size = new System.Drawing.Size(78, 24);
            this.lname2.TabIndex = 1;
            this.lname2.Text = " ";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(428, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "اطلاعات مسافر";
            // 
            // lnamecheck
            // 
            this.lnamecheck.Location = new System.Drawing.Point(476, 54);
            this.lnamecheck.Name = "lnamecheck";
            this.lnamecheck.Size = new System.Drawing.Size(24, 22);
            this.lnamecheck.TabIndex = 8;
            this.lnamecheck.UseVisualStyleBackColor = true;
            // 
            // phonecheck
            // 
            this.phonecheck.Location = new System.Drawing.Point(238, 50);
            this.phonecheck.Name = "phonecheck";
            this.phonecheck.Size = new System.Drawing.Size(24, 22);
            this.phonecheck.TabIndex = 8;
            this.phonecheck.UseVisualStyleBackColor = true;
            // 
            // nidcheck
            // 
            this.nidcheck.Location = new System.Drawing.Point(14, 53);
            this.nidcheck.Name = "nidcheck";
            this.nidcheck.Size = new System.Drawing.Size(24, 22);
            this.nidcheck.TabIndex = 8;
            this.nidcheck.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(37, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "مسافران";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(27, 398);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(102, 38);
            this.back.TabIndex = 9;
            this.back.Text = "بازگشت";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Reception_passengers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.nidcheck);
            this.Controls.Add(this.phonecheck);
            this.Controls.Add(this.lnamecheck);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listoftickets);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.nid);
            this.Controls.Add(this.plist);
            this.Name = "Reception_passengers";
            this.Text = "Reception_passengers";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button back;

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.CheckBox phonecheck;


        private System.Windows.Forms.ListBox plist;
        private System.Windows.Forms.ListBox listoftickets;
        private System.Windows.Forms.CheckBox lnamecheck;
        private System.Windows.Forms.CheckBox nidcheck;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label bdate;
        private System.Windows.Forms.Label gen;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label lname2;
        private System.Windows.Forms.Label phone2;
        private System.Windows.Forms.Label nid2;
        private System.Windows.Forms.TextBox nid;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox lname;

        #endregion
    }
}