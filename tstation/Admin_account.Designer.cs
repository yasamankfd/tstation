using System.ComponentModel;

namespace tstation
{
    partial class Admin_account
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
            this.crew = new System.Windows.Forms.Button();
            this.driver = new System.Windows.Forms.Button();
            this.reception = new System.Windows.Forms.Button();
            this.occurrence = new System.Windows.Forms.Button();
            this.deltrip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crew
            // 
            this.crew.Location = new System.Drawing.Point(398, 126);
            this.crew.Name = "crew";
            this.crew.Size = new System.Drawing.Size(264, 64);
            this.crew.TabIndex = 0;
            this.crew.Text = "ثبت نام خدمه";
            this.crew.UseVisualStyleBackColor = true;
            this.crew.Click += new System.EventHandler(this.crew_add);
            // 
            // driver
            // 
            this.driver.Location = new System.Drawing.Point(87, 126);
            this.driver.Name = "driver";
            this.driver.Size = new System.Drawing.Size(264, 64);
            this.driver.TabIndex = 0;
            this.driver.Text = "ثبت نام راننده";
            this.driver.UseVisualStyleBackColor = true;
            this.driver.Click += new System.EventHandler(this.driver_add);
            // 
            // reception
            // 
            this.reception.Location = new System.Drawing.Point(398, 228);
            this.reception.Name = "reception";
            this.reception.Size = new System.Drawing.Size(264, 64);
            this.reception.TabIndex = 0;
            this.reception.Text = "ثبت نام پذیرش";
            this.reception.UseVisualStyleBackColor = true;
            this.reception.Click += new System.EventHandler(this.reception_add);
            // 
            // occurrence
            // 
            this.occurrence.Location = new System.Drawing.Point(87, 228);
            this.occurrence.Name = "occurrence";
            this.occurrence.Size = new System.Drawing.Size(264, 64);
            this.occurrence.TabIndex = 0;
            this.occurrence.Text = "ایجاد سفر";
            this.occurrence.UseVisualStyleBackColor = true;
            this.occurrence.Click += new System.EventHandler(this.occurence_add);
            // 
            // deltrip
            // 
            this.deltrip.Location = new System.Drawing.Point(250, 330);
            this.deltrip.Name = "deltrip";
            this.deltrip.Size = new System.Drawing.Size(264, 64);
            this.deltrip.TabIndex = 0;
            this.deltrip.Text = "حذف سفر";
            this.deltrip.UseVisualStyleBackColor = true;
            // 
            // Admin_account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deltrip);
            this.Controls.Add(this.occurrence);
            this.Controls.Add(this.reception);
            this.Controls.Add(this.driver);
            this.Controls.Add(this.crew);
            this.Name = "Admin_account";
            this.Text = "Admin_account";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button crew;
        private System.Windows.Forms.Button driver;
        private System.Windows.Forms.Button reception;
        private System.Windows.Forms.Button occurrence;
        private System.Windows.Forms.Button deltrip;

        #endregion
    }
}