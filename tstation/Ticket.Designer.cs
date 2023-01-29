using System.ComponentModel;

namespace tstation
{
    partial class Ticket
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
            this.start = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dest = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.train = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cabin = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.seat = new System.Windows.Forms.Label();
            this.wagon = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.reserve = new System.Windows.Forms.Button();
            this.trip_code = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nid
            // 
            this.nid.Location = new System.Drawing.Point(127, 26);
            this.nid.Name = "nid";
            this.nid.Size = new System.Drawing.Size(207, 26);
            this.nid.TabIndex = 0;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(146, 83);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(263, 46);
            this.start.TabIndex = 1;
            this.start.Text = "start";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(45, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "کدملی مسافر";
            // 
            // dest
            // 
            this.dest.Location = new System.Drawing.Point(146, 159);
            this.dest.Name = "dest";
            this.dest.Size = new System.Drawing.Size(263, 46);
            this.dest.TabIndex = 1;
            this.dest.Text = "dest";
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(146, 239);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(263, 46);
            this.time.TabIndex = 1;
            this.time.Text = "time";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(146, 309);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(263, 46);
            this.date.TabIndex = 1;
            this.date.Text = "label1";
            // 
            // train
            // 
            this.train.Location = new System.Drawing.Point(146, 381);
            this.train.Name = "train";
            this.train.Size = new System.Drawing.Size(263, 46);
            this.train.TabIndex = 1;
            this.train.Text = "label1";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(509, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 46);
            this.label7.TabIndex = 1;
            this.label7.Text = "label1";
            // 
            // cabin
            // 
            this.cabin.Location = new System.Drawing.Point(509, 207);
            this.cabin.Name = "cabin";
            this.cabin.Size = new System.Drawing.Size(263, 46);
            this.cabin.TabIndex = 1;
            this.cabin.Text = "label1";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(509, 349);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(263, 46);
            this.price.TabIndex = 1;
            this.price.Text = "label1";
            // 
            // seat
            // 
            this.seat.Location = new System.Drawing.Point(509, 277);
            this.seat.Name = "seat";
            this.seat.Size = new System.Drawing.Size(263, 46);
            this.seat.TabIndex = 1;
            this.seat.Text = "label1";
            // 
            // wagon
            // 
            this.wagon.Location = new System.Drawing.Point(509, 127);
            this.wagon.Name = "wagon";
            this.wagon.Size = new System.Drawing.Size(263, 46);
            this.wagon.TabIndex = 1;
            this.wagon.Text = "label1";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(51, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 32);
            this.label12.TabIndex = 7;
            this.label12.Text = "مبدا";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(51, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 32);
            this.label13.TabIndex = 7;
            this.label13.Text = "مقصد";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(51, 239);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 32);
            this.label14.TabIndex = 7;
            this.label14.Text = "ساعت";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(51, 309);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 32);
            this.label15.TabIndex = 7;
            this.label15.Text = "تاریخ";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(51, 381);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 32);
            this.label16.TabIndex = 7;
            this.label16.Text = "قطار";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(410, 349);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 32);
            this.label17.TabIndex = 7;
            this.label17.Text = "قیمت";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(410, 277);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 32);
            this.label18.TabIndex = 7;
            this.label18.Text = "صندلی";
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(410, 207);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 32);
            this.label19.TabIndex = 7;
            this.label19.Text = "کابین";
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(410, 127);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(93, 32);
            this.label20.TabIndex = 7;
            this.label20.Text = "واگن";
            // 
            // reserve
            // 
            this.reserve.Location = new System.Drawing.Point(637, 391);
            this.reserve.Name = "reserve";
            this.reserve.Size = new System.Drawing.Size(134, 45);
            this.reserve.TabIndex = 8;
            this.reserve.Text = "رزرو بلیط";
            this.reserve.UseVisualStyleBackColor = true;
            this.reserve.Click += new System.EventHandler(this.reserve_Click);
            // 
            // trip_code
            // 
            this.trip_code.Location = new System.Drawing.Point(508, 63);
            this.trip_code.Name = "trip_code";
            this.trip_code.Size = new System.Drawing.Size(263, 46);
            this.trip_code.TabIndex = 1;
            this.trip_code.Text = "label1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(409, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "کد سفر";
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reserve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.seat);
            this.Controls.Add(this.price);
            this.Controls.Add(this.trip_code);
            this.Controls.Add(this.wagon);
            this.Controls.Add(this.cabin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.train);
            this.Controls.Add(this.date);
            this.Controls.Add(this.time);
            this.Controls.Add(this.dest);
            this.Controls.Add(this.start);
            this.Controls.Add(this.nid);
            this.Name = "Ticket";
            this.Text = "Ticket";
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        private System.Windows.Forms.Button reserve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;


        private System.Windows.Forms.TextBox nid;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.Label dest;
        private System.Windows.Forms.Label wagon;
        private System.Windows.Forms.Label cabin;
        private System.Windows.Forms.Label seat;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label train;
        private System.Windows.Forms.Label trip_code;

        #endregion
    }
}