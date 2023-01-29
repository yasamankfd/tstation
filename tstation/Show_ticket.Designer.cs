using System.ComponentModel;

namespace tstation
{
    partial class Show_ticket
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
            this.list_of_trains = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.list_of_seats = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reserve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_of_trains
            // 
            this.list_of_trains.FormattingEnabled = true;
            this.list_of_trains.ItemHeight = 20;
            this.list_of_trains.Location = new System.Drawing.Point(35, 201);
            this.list_of_trains.Name = "list_of_trains";
            this.list_of_trains.Size = new System.Drawing.Size(256, 344);
            this.list_of_trains.TabIndex = 0;
            this.list_of_trains.SelectedIndexChanged += new System.EventHandler(this.item_train_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(35, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "قطار ها";
            // 
            // list_of_seats
            // 
            this.list_of_seats.FormattingEnabled = true;
            this.list_of_seats.ItemHeight = 20;
            this.list_of_seats.Location = new System.Drawing.Point(333, 201);
            this.list_of_seats.Name = "list_of_seats";
            this.list_of_seats.Size = new System.Drawing.Size(534, 344);
            this.list_of_seats.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(658, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "صندلی ها";
            // 
            // reserve
            // 
            this.reserve.Location = new System.Drawing.Point(705, 585);
            this.reserve.Name = "reserve";
            this.reserve.Size = new System.Drawing.Size(174, 54);
            this.reserve.TabIndex = 2;
            this.reserve.Text = "رزرو بلیط";
            this.reserve.UseVisualStyleBackColor = true;
            this.reserve.Click += new System.EventHandler(this.reserve_Clicking);
            // 
            // Show_ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 666);
            this.Controls.Add(this.reserve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_of_seats);
            this.Controls.Add(this.list_of_trains);
            this.Name = "Show_ticket";
            this.Text = "Show_ticket";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button reserve;
        private System.Windows.Forms.ListBox list_of_trains;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list_of_seats;
        private System.Windows.Forms.Label label2;

        #endregion
    }
}