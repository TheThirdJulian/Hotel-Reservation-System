namespace HotelDBMS
{
    partial class FormGuestHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.Panel_ReservationDetails = new System.Windows.Forms.Panel();
            this.LabelCheckout = new System.Windows.Forms.Label();
            this.LabelCheckin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.Panel_ReservationDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.BtnLogout);
            this.panel1.Controls.Add(this.Panel_ReservationDetails);
            this.panel1.Controls.Add(this.BtnStart);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(39, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 365);
            this.panel1.TabIndex = 0;
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLogout.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.Location = new System.Drawing.Point(570, 0);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(136, 36);
            this.BtnLogout.TabIndex = 4;
            this.BtnLogout.Text = "LOG OUT";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // Panel_ReservationDetails
            // 
            this.Panel_ReservationDetails.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Panel_ReservationDetails.Controls.Add(this.LabelCheckout);
            this.Panel_ReservationDetails.Controls.Add(this.LabelCheckin);
            this.Panel_ReservationDetails.Controls.Add(this.label4);
            this.Panel_ReservationDetails.Controls.Add(this.label3);
            this.Panel_ReservationDetails.Controls.Add(this.label2);
            this.Panel_ReservationDetails.Location = new System.Drawing.Point(115, 206);
            this.Panel_ReservationDetails.Name = "Panel_ReservationDetails";
            this.Panel_ReservationDetails.Size = new System.Drawing.Size(484, 121);
            this.Panel_ReservationDetails.TabIndex = 2;
            this.Panel_ReservationDetails.Visible = false;
            // 
            // LabelCheckout
            // 
            this.LabelCheckout.AutoSize = true;
            this.LabelCheckout.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCheckout.Location = new System.Drawing.Point(179, 80);
            this.LabelCheckout.Name = "LabelCheckout";
            this.LabelCheckout.Size = new System.Drawing.Size(58, 25);
            this.LabelCheckout.TabIndex = 4;
            this.LabelCheckout.Text = "DATE";
            // 
            // LabelCheckin
            // 
            this.LabelCheckin.AutoSize = true;
            this.LabelCheckin.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCheckin.Location = new System.Drawing.Point(179, 46);
            this.LabelCheckin.Name = "LabelCheckin";
            this.LabelCheckin.Size = new System.Drawing.Size(58, 25);
            this.LabelCheckin.TabIndex = 3;
            this.LabelCheckin.Text = "DATE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Check-Out:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Check-In:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "CURRENT RESERVATION DETAILS";
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(225, 122);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(265, 40);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "Book an Appointment";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOTEL RESERVATION SYSTEM";
            // 
            // FormGuestHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormGuestHome";
            this.Text = "FormGuestHome";
            this.Load += new System.EventHandler(this.FormGuestHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Panel_ReservationDetails.ResumeLayout(false);
            this.Panel_ReservationDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Panel Panel_ReservationDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelCheckin;
        private System.Windows.Forms.Label LabelCheckout;
        private System.Windows.Forms.Button BtnLogout;
    }
}