using System.ComponentModel;

namespace tstation
{
    partial class Add_trip
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
            this.tcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gen_code = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.ComboBox();
            this.c1 = new System.Windows.Forms.ComboBox();
            this.c2 = new System.Windows.Forms.ComboBox();
            this.c3 = new System.Windows.Forms.ComboBox();
            this.h = new System.Windows.Forms.ComboBox();
            this.m = new System.Windows.Forms.ComboBox();
            this.start = new System.Windows.Forms.ComboBox();
            this.dest = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.ComboBox();
            this.mo = new System.Windows.Forms.ComboBox();
            this.day = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.find_driver = new System.Windows.Forms.Button();
            this.find_c1 = new System.Windows.Forms.Button();
            this.find_c2 = new System.Windows.Forms.Button();
            this.find_c3 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.train = new System.Windows.Forms.ComboBox();
            this.find_train = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tcode
            // 
            this.tcode.Location = new System.Drawing.Point(52, 36);
            this.tcode.Name = "tcode";
            this.tcode.Size = new System.Drawing.Size(187, 26);
            this.tcode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(56, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "کد سفر";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(306, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "خدمه1";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(557, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "راننده";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(52, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "زمان";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(306, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "خدمه2";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(306, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "خدمه3";
            // 
            // gen_code
            // 
            this.gen_code.Location = new System.Drawing.Point(52, 69);
            this.gen_code.Name = "gen_code";
            this.gen_code.Size = new System.Drawing.Size(186, 43);
            this.gen_code.TabIndex = 2;
            this.gen_code.Text = "ایجاد کد";
            this.gen_code.UseVisualStyleBackColor = true;
            this.gen_code.Click += new System.EventHandler(this.generate_code);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(52, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "مبدا";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(52, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "مقصد";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(557, 146);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(180, 26);
            this.price.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(561, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "قیمت";
            // 
            // d
            // 
            this.d.Location = new System.Drawing.Point(561, 40);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(175, 28);
            this.d.TabIndex = 4;
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(308, 34);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(175, 28);
            this.c1.TabIndex = 4;
            // 
            // c2
            // 
            this.c2.Location = new System.Drawing.Point(306, 166);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(175, 28);
            this.c2.TabIndex = 4;
            // 
            // c3
            // 
            this.c3.Location = new System.Drawing.Point(306, 295);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(175, 28);
            this.c3.TabIndex = 4;
            // 
            // h
            // 
            this.h.Location = new System.Drawing.Point(52, 166);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(82, 28);
            this.h.TabIndex = 4;
            // 
            // m
            // 
            this.m.Location = new System.Drawing.Point(140, 166);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(82, 28);
            this.m.TabIndex = 4;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(56, 298);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(175, 28);
            this.start.TabIndex = 4;
            // 
            // dest
            // 
            this.dest.Location = new System.Drawing.Point(56, 362);
            this.dest.Name = "dest";
            this.dest.Size = new System.Drawing.Size(175, 28);
            this.dest.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(516, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "تاریخ";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(52, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "ساعت";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(140, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "دقیقه";
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(516, 360);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(82, 28);
            this.y.TabIndex = 4;
            // 
            // mo
            // 
            this.mo.Location = new System.Drawing.Point(604, 360);
            this.mo.Name = "mo";
            this.mo.Size = new System.Drawing.Size(82, 28);
            this.mo.TabIndex = 4;
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(692, 360);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(82, 28);
            this.day.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(516, 330);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 25);
            this.label13.TabIndex = 1;
            this.label13.Text = "سال";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(604, 332);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 25);
            this.label14.TabIndex = 1;
            this.label14.Text = "ماه";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(692, 332);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 25);
            this.label15.TabIndex = 1;
            this.label15.Text = "روز";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(660, 394);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(114, 45);
            this.submit.TabIndex = 5;
            this.submit.Text = "ثبت";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.sub_click);
            // 
            // find_driver
            // 
            this.find_driver.Location = new System.Drawing.Point(562, 73);
            this.find_driver.Name = "find_driver";
            this.find_driver.Size = new System.Drawing.Size(173, 39);
            this.find_driver.TabIndex = 6;
            this.find_driver.Text = "یافتن راننده";
            this.find_driver.UseVisualStyleBackColor = true;
            this.find_driver.Click += new System.EventHandler(this.d_click);
            // 
            // find_c1
            // 
            this.find_c1.Location = new System.Drawing.Point(308, 71);
            this.find_c1.Name = "find_c1";
            this.find_c1.Size = new System.Drawing.Size(173, 39);
            this.find_c1.TabIndex = 6;
            this.find_c1.Text = "یافتن خدمه 1";
            this.find_c1.UseVisualStyleBackColor = true;
            this.find_c1.Click += new System.EventHandler(this.c1_click);
            // 
            // find_c2
            // 
            this.find_c2.Location = new System.Drawing.Point(308, 200);
            this.find_c2.Name = "find_c2";
            this.find_c2.Size = new System.Drawing.Size(173, 39);
            this.find_c2.TabIndex = 6;
            this.find_c2.Text = "یافتن خدمه 2";
            this.find_c2.UseVisualStyleBackColor = true;
            this.find_c2.Click += new System.EventHandler(this.c2_click);
            // 
            // find_c3
            // 
            this.find_c3.Location = new System.Drawing.Point(308, 329);
            this.find_c3.Name = "find_c3";
            this.find_c3.Size = new System.Drawing.Size(173, 39);
            this.find_c3.TabIndex = 6;
            this.find_c3.Text = "یافتن خدمه 3";
            this.find_c3.UseVisualStyleBackColor = true;
            this.find_c3.Click += new System.EventHandler(this.c3_click);
            // 
            // label16
            // 
            this.label16.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label16.Location = new System.Drawing.Point(230, 406);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(340, 35);
            this.label16.TabIndex = 7;
            this.label16.Text = "برای یافتن خدمه یا راننده ابتدا تاریخ سفر را وارد کنید";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(563, 191);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 25);
            this.label17.TabIndex = 1;
            this.label17.Text = "قطار";
            // 
            // train
            // 
            this.train.Location = new System.Drawing.Point(567, 220);
            this.train.Name = "train";
            this.train.Size = new System.Drawing.Size(175, 28);
            this.train.TabIndex = 4;
            // 
            // find_train
            // 
            this.find_train.Location = new System.Drawing.Point(568, 253);
            this.find_train.Name = "find_train";
            this.find_train.Size = new System.Drawing.Size(173, 39);
            this.find_train.TabIndex = 6;
            this.find_train.Text = "یافتن قطار";
            this.find_train.UseVisualStyleBackColor = true;
            this.find_train.Click += new System.EventHandler(this.train_click);
            // 
            // Add_trip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.find_c3);
            this.Controls.Add(this.find_c2);
            this.Controls.Add(this.find_c1);
            this.Controls.Add(this.find_train);
            this.Controls.Add(this.find_driver);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.start);
            this.Controls.Add(this.dest);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.day);
            this.Controls.Add(this.m);
            this.Controls.Add(this.y);
            this.Controls.Add(this.mo);
            this.Controls.Add(this.h);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.train);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.d);
            this.Controls.Add(this.price);
            this.Controls.Add(this.gen_code);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tcode);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Add_trip";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox train;
        private System.Windows.Forms.Button find_train;

        private System.Windows.Forms.Button find_driver;
        private System.Windows.Forms.Button find_c1;
        private System.Windows.Forms.Button find_c2;
        private System.Windows.Forms.Button find_c3;
        private System.Windows.Forms.Label label16;

        private System.Windows.Forms.ComboBox y;
        private System.Windows.Forms.ComboBox mo;
        private System.Windows.Forms.ComboBox day;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button submit;

        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.ComboBox d;
        private System.Windows.Forms.ComboBox m;
        private System.Windows.Forms.ComboBox h;
        private System.Windows.Forms.ComboBox c1;
        private System.Windows.Forms.ComboBox c2;
        private System.Windows.Forms.ComboBox c3;

        private System.Windows.Forms.TextBox price;

        private System.Windows.Forms.ComboBox dest;
        private System.Windows.Forms.ComboBox start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button gen_code;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tcode;

        #endregion
    }
}