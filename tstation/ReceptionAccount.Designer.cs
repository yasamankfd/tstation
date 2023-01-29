using System.ComponentModel;

namespace tstation
{
    partial class ReceptionAccount
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
            this.Reserve = new System.Windows.Forms.Button();
            this.Profile = new System.Windows.Forms.Button();
            this.Make_passenger = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Passengers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Reserve
            // 
            this.Reserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (178)));
            this.Reserve.Location = new System.Drawing.Point(89, 176);
            this.Reserve.Name = "Reserve";
            this.Reserve.Size = new System.Drawing.Size(271, 65);
            this.Reserve.TabIndex = 1;
            this.Reserve.Text = "رزرو بلیط";
            this.Reserve.UseVisualStyleBackColor = true;
            this.Reserve.Click += new System.EventHandler(this.Reserve_Click);
            // 
            // Profile
            // 
            this.Profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (178)));
            this.Profile.Location = new System.Drawing.Point(89, 105);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(271, 65);
            this.Profile.TabIndex = 0;
            this.Profile.Text = "پروفایل";
            this.Profile.UseVisualStyleBackColor = true;
            this.Profile.Click += new System.EventHandler(this.Profile_Click);
            // 
            // Make_passenger
            // 
            this.Make_passenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (178)));
            this.Make_passenger.Location = new System.Drawing.Point(425, 105);
            this.Make_passenger.Name = "Make_passenger";
            this.Make_passenger.Size = new System.Drawing.Size(271, 65);
            this.Make_passenger.TabIndex = 2;
            this.Make_passenger.Text = "ثبت مسافر";
            this.Make_passenger.UseVisualStyleBackColor = true;
            this.Make_passenger.Click += new System.EventHandler(this.Make_passenger_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (178)));
            this.Exit.Location = new System.Drawing.Point(12, 397);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(101, 41);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "خروج";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Passengers
            // 
            this.Passengers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (178)));
            this.Passengers.Location = new System.Drawing.Point(426, 176);
            this.Passengers.Name = "Passengers";
            this.Passengers.Size = new System.Drawing.Size(270, 65);
            this.Passengers.TabIndex = 3;
            this.Passengers.Text = "مسافران";
            this.Passengers.UseVisualStyleBackColor = true;
            this.Passengers.Click += new System.EventHandler(this.Passengers_Click);
            // 
            // ReceptionAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Passengers);
            this.Controls.Add(this.Make_passenger);
            this.Controls.Add(this.Profile);
            this.Controls.Add(this.Reserve);
            this.Name = "ReceptionAccount";
            this.Text = "ReceptionAccount";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Profile;
        private System.Windows.Forms.Button Make_passenger;
        private System.Windows.Forms.Button Passengers;
        private System.Windows.Forms.Button Reserve;


        #endregion
    }
}