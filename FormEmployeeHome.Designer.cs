namespace HotelDBMS
{
    partial class FormEmployeeHome
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
            this.BtnRoom = new System.Windows.Forms.Button();
            this.BtnReservation = new System.Windows.Forms.Button();
            this.BtnGuests = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelGuestCount = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelRoomOccupy = new System.Windows.Forms.Label();
            this.LabelRoomAvail = new System.Windows.Forms.Label();
            this.LabelRoomCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LabelCheckoutCount = new System.Windows.Forms.Label();
            this.LabelCheckinCount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LabelReservationCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnRoom
            // 
            this.BtnRoom.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRoom.Location = new System.Drawing.Point(52, 260);
            this.BtnRoom.Name = "BtnRoom";
            this.BtnRoom.Size = new System.Drawing.Size(136, 47);
            this.BtnRoom.TabIndex = 0;
            this.BtnRoom.Text = "Rooms";
            this.BtnRoom.UseVisualStyleBackColor = true;
            this.BtnRoom.Click += new System.EventHandler(this.BtnRoom_Click);
            // 
            // BtnReservation
            // 
            this.BtnReservation.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReservation.Location = new System.Drawing.Point(22, 260);
            this.BtnReservation.Name = "BtnReservation";
            this.BtnReservation.Size = new System.Drawing.Size(199, 47);
            this.BtnReservation.TabIndex = 1;
            this.BtnReservation.Text = "Reservations";
            this.BtnReservation.UseVisualStyleBackColor = true;
            this.BtnReservation.Click += new System.EventHandler(this.BtnReservation_Click);
            // 
            // BtnGuests
            // 
            this.BtnGuests.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuests.Location = new System.Drawing.Point(46, 260);
            this.BtnGuests.Name = "BtnGuests";
            this.BtnGuests.Size = new System.Drawing.Size(136, 47);
            this.BtnGuests.TabIndex = 2;
            this.BtnGuests.Text = "Guests";
            this.BtnGuests.UseVisualStyleBackColor = true;
            this.BtnGuests.Click += new System.EventHandler(this.BtnGuests_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLogout.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.Location = new System.Drawing.Point(652, 12);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(136, 36);
            this.BtnLogout.TabIndex = 3;
            this.BtnLogout.Text = "LOG OUT";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.LabelGuestCount);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.BtnGuests);
            this.panel1.Location = new System.Drawing.Point(31, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 322);
            this.panel1.TabIndex = 4;
            // 
            // LabelGuestCount
            // 
            this.LabelGuestCount.AutoSize = true;
            this.LabelGuestCount.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGuestCount.Location = new System.Drawing.Point(128, 126);
            this.LabelGuestCount.Name = "LabelGuestCount";
            this.LabelGuestCount.Size = new System.Drawing.Size(77, 24);
            this.LabelGuestCount.TabIndex = 10;
            this.LabelGuestCount.Text = "VALUE";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(41, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 25);
            this.label14.TabIndex = 9;
            this.label14.Text = "(from Past Month)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 32);
            this.label9.TabIndex = 5;
            this.label9.Text = "GUESTS";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 24);
            this.label13.TabIndex = 5;
            this.label13.Text = "Count:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.LabelRoomOccupy);
            this.panel2.Controls.Add(this.LabelRoomAvail);
            this.panel2.Controls.Add(this.LabelRoomCount);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BtnRoom);
            this.panel2.Location = new System.Drawing.Point(263, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 321);
            this.panel2.TabIndex = 5;
            // 
            // LabelRoomOccupy
            // 
            this.LabelRoomOccupy.AutoSize = true;
            this.LabelRoomOccupy.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRoomOccupy.Location = new System.Drawing.Point(131, 176);
            this.LabelRoomOccupy.Name = "LabelRoomOccupy";
            this.LabelRoomOccupy.Size = new System.Drawing.Size(77, 24);
            this.LabelRoomOccupy.TabIndex = 14;
            this.LabelRoomOccupy.Text = "VALUE";
            // 
            // LabelRoomAvail
            // 
            this.LabelRoomAvail.AutoSize = true;
            this.LabelRoomAvail.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRoomAvail.Location = new System.Drawing.Point(131, 142);
            this.LabelRoomAvail.Name = "LabelRoomAvail";
            this.LabelRoomAvail.Size = new System.Drawing.Size(77, 24);
            this.LabelRoomAvail.TabIndex = 13;
            this.LabelRoomAvail.Text = "VALUE";
            // 
            // LabelRoomCount
            // 
            this.LabelRoomCount.AutoSize = true;
            this.LabelRoomCount.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRoomCount.Location = new System.Drawing.Point(131, 108);
            this.LabelRoomCount.Name = "LabelRoomCount";
            this.LabelRoomCount.Size = new System.Drawing.Size(77, 24);
            this.LabelRoomCount.TabIndex = 12;
            this.LabelRoomCount.Text = "VALUE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Occupied: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Available: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "ROOMS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.LabelCheckoutCount);
            this.panel3.Controls.Add(this.LabelCheckinCount);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.LabelReservationCount);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.BtnReservation);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(511, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 320);
            this.panel3.TabIndex = 6;
            // 
            // LabelCheckoutCount
            // 
            this.LabelCheckoutCount.AutoSize = true;
            this.LabelCheckoutCount.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCheckoutCount.Location = new System.Drawing.Point(141, 176);
            this.LabelCheckoutCount.Name = "LabelCheckoutCount";
            this.LabelCheckoutCount.Size = new System.Drawing.Size(77, 24);
            this.LabelCheckoutCount.TabIndex = 17;
            this.LabelCheckoutCount.Text = "VALUE";
            // 
            // LabelCheckinCount
            // 
            this.LabelCheckinCount.AutoSize = true;
            this.LabelCheckinCount.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCheckinCount.Location = new System.Drawing.Point(141, 142);
            this.LabelCheckinCount.Name = "LabelCheckinCount";
            this.LabelCheckinCount.Size = new System.Drawing.Size(77, 24);
            this.LabelCheckinCount.TabIndex = 16;
            this.LabelCheckinCount.Text = "VALUE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(47, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "(from Past Month)";
            // 
            // LabelReservationCount
            // 
            this.LabelReservationCount.AutoSize = true;
            this.LabelReservationCount.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelReservationCount.Location = new System.Drawing.Point(141, 108);
            this.LabelReservationCount.Name = "LabelReservationCount";
            this.LabelReservationCount.Size = new System.Drawing.Size(77, 24);
            this.LabelReservationCount.TabIndex = 15;
            this.LabelReservationCount.Text = "VALUE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 32);
            this.label8.TabIndex = 5;
            this.label8.Text = "RESERVATIONS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Check-outs:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Check-ins: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Current: ";
            // 
            // FormEmployeeHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnLogout);
            this.Name = "FormEmployeeHome";
            this.Text = "FormEmployeeHome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEmployeeHome_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRoom;
        private System.Windows.Forms.Button BtnReservation;
        private System.Windows.Forms.Button BtnGuests;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LabelGuestCount;
        private System.Windows.Forms.Label LabelRoomOccupy;
        private System.Windows.Forms.Label LabelRoomAvail;
        private System.Windows.Forms.Label LabelRoomCount;
        private System.Windows.Forms.Label LabelCheckoutCount;
        private System.Windows.Forms.Label LabelCheckinCount;
        private System.Windows.Forms.Label LabelReservationCount;
    }
}