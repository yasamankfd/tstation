using System.ComponentModel;
using System.Windows.Forms;

namespace tstation
{
    partial class Add_reception
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
            this.register = new System.Windows.Forms.Button();
            this.nid = new System.Windows.Forms.TextBox();
            this.pid = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.single = new System.Windows.Forms.CheckBox();
            this.genm = new System.Windows.Forms.CheckBox();
            this.genw = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.married = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lll = new System.Windows.Forms.Label();
            this.ll = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.ComboBox();
            this.m = new System.Windows.Forms.ComboBox();
            this.y = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(695, 383);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(93, 45);
            this.register.TabIndex = 0;
            this.register.Text = "ثبت";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_click);
            // 
            // nid
            // 
            this.nid.Location = new System.Drawing.Point(63, 51);
            this.nid.Name = "nid";
            this.nid.Size = new System.Drawing.Size(242, 26);
            this.nid.TabIndex = 1;
            // 
            // pid
            // 
            this.pid.Location = new System.Drawing.Point(63, 121);
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(242, 26);
            this.pid.TabIndex = 1;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(63, 201);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(242, 26);
            this.name.TabIndex = 1;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(422, 51);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(242, 26);
            this.phone.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(64, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "کد ملی";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(407, 224);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(366, 26);
            this.add.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(64, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "کد پرسنلی";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(63, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "نام";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(422, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "جنسیت";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(407, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "تاریخ تولد";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(63, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 31);
            this.label6.TabIndex = 2;
            this.label6.Text = "نام خانوادگی";
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(63, 287);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(242, 26);
            this.lname.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(422, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 31);
            this.label7.TabIndex = 2;
            this.label7.Text = "تلفن";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(407, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 31);
            this.label8.TabIndex = 2;
            this.label8.Text = "ادرس";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(63, 369);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(242, 26);
            this.email.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(63, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 31);
            this.label9.TabIndex = 2;
            this.label9.Text = "ایمیل";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(422, 349);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 31);
            this.label10.TabIndex = 2;
            this.label10.Text = "وضعیت تاهل";
            // 
            // single
            // 
            this.single.Location = new System.Drawing.Point(572, 378);
            this.single.Name = "single";
            this.single.Size = new System.Drawing.Size(30, 29);
            this.single.TabIndex = 3;
            this.single.Text = "radioButton1";
            this.single.UseVisualStyleBackColor = true;
            // 
            // genm
            // 
            this.genm.Location = new System.Drawing.Point(422, 300);
            this.genm.Name = "genm";
            this.genm.Size = new System.Drawing.Size(30, 29);
            this.genm.TabIndex = 3;
            this.genm.Text = "radioButton1";
            this.genm.UseVisualStyleBackColor = true;
            // 
            // genw
            // 
            this.genw.Location = new System.Drawing.Point(572, 300);
            this.genw.Name = "genw";
            this.genw.Size = new System.Drawing.Size(30, 29);
            this.genw.TabIndex = 3;
            this.genw.Text = "radioButton1";
            this.genw.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(624, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 21);
            this.label11.TabIndex = 4;
            this.label11.Text = "زن";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(458, 308);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 21);
            this.label12.TabIndex = 4;
            this.label12.Text = "مرد";
            // 
            // married
            // 
            this.married.Location = new System.Drawing.Point(422, 383);
            this.married.Name = "married";
            this.married.Size = new System.Drawing.Size(77, 26);
            this.married.TabIndex = 4;
            this.married.Text = " متاهل      ";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(624, 383);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 21);
            this.label14.TabIndex = 4;
            this.label14.Text = "مجرد";
            // 
            // lll
            // 
            this.lll.Location = new System.Drawing.Point(685, 124);
            this.lll.Name = "lll";
            this.lll.Size = new System.Drawing.Size(56, 27);
            this.lll.TabIndex = 12;
            this.lll.Text = "روز";
            // 
            // ll
            // 
            this.ll.Location = new System.Drawing.Point(557, 124);
            this.ll.Name = "ll";
            this.ll.Size = new System.Drawing.Size(56, 27);
            this.ll.TabIndex = 13;
            this.ll.Text = "ماه";
            // 
            // l
            // 
            this.l.Location = new System.Drawing.Point(433, 124);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(56, 27);
            this.l.TabIndex = 14;
            this.l.Text = "سال";
            // 
            // d
            // 
            this.d.Location = new System.Drawing.Point(657, 154);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(101, 28);
            this.d.TabIndex = 10;
            // 
            // m
            // 
            this.m.Location = new System.Drawing.Point(540, 154);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(101, 28);
            this.m.TabIndex = 9;
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(413, 154);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(107, 28);
            this.y.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(453, 380);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 29);
            this.label13.TabIndex = 15;
            this.label13.Text = "متاهل";
            // 
            // Add_reception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lll);
            this.Controls.Add(this.ll);
            this.Controls.Add(this.l);
            this.Controls.Add(this.d);
            this.Controls.Add(this.m);
            this.Controls.Add(this.y);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.married);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.genw);
            this.Controls.Add(this.genm);
            this.Controls.Add(this.single);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pid);
            this.Controls.Add(this.nid);
            this.Controls.Add(this.register);
            this.Name = "Add_reception";
            this.Text = "Add_reception";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label13;

        private System.Windows.Forms.Label lll;
        private System.Windows.Forms.Label ll;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.ComboBox d;
        private System.Windows.Forms.ComboBox m;
        private System.Windows.Forms.ComboBox y;

        private System.Windows.Forms.CheckBox genm;
        private System.Windows.Forms.CheckBox genw;
        private System.Windows.Forms.CheckBox single;
        private System.Windows.Forms.CheckBox married;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;

        #endregion
    }
}