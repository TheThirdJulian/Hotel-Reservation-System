namespace HotelDBMS
{
    partial class FormEmployeeReservations
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCheckOut = new System.Windows.Forms.Button();
            this.BtnCheckIn = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelGuestName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LabelRoomName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LabelOutDate = new System.Windows.Forms.Label();
            this.LabelInDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LabelGuestsCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LabelDaysAfterCheckin = new System.Windows.Forms.Label();
            this.LabelHasOut = new System.Windows.Forms.Label();
            this.LabelHasIn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelCheckout = new System.Windows.Forms.Label();
            this.LabelCheckin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvReservations = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.BtnCheckOut);
            this.panel2.Controls.Add(this.BtnCheckIn);
            this.panel2.Controls.Add(this.BtnHome);
            this.panel2.Controls.Add(this.BtnClear);
            this.panel2.Controls.Add(this.BtnLogout);
            this.panel2.Location = new System.Drawing.Point(1093, 32);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 565);
            this.panel2.TabIndex = 16;
            // 
            // BtnCheckOut
            // 
            this.BtnCheckOut.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnCheckOut.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheckOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCheckOut.Location = new System.Drawing.Point(4, 63);
            this.BtnCheckOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCheckOut.Name = "BtnCheckOut";
            this.BtnCheckOut.Size = new System.Drawing.Size(260, 42);
            this.BtnCheckOut.TabIndex = 7;
            this.BtnCheckOut.Text = "Confirm Check-out";
            this.BtnCheckOut.UseVisualStyleBackColor = false;
            this.BtnCheckOut.Click += new System.EventHandler(this.BtnCheckOut_Click);
            // 
            // BtnCheckIn
            // 
            this.BtnCheckIn.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnCheckIn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheckIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCheckIn.Location = new System.Drawing.Point(4, 14);
            this.BtnCheckIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCheckIn.Name = "BtnCheckIn";
            this.BtnCheckIn.Size = new System.Drawing.Size(260, 42);
            this.BtnCheckIn.TabIndex = 6;
            this.BtnCheckIn.Text = "Confirm Check-in";
            this.BtnCheckIn.UseVisualStyleBackColor = false;
            this.BtnCheckIn.Click += new System.EventHandler(this.BtnCheckIn_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnHome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.Location = new System.Drawing.Point(4, 454);
            this.BtnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(260, 42);
            this.BtnHome.TabIndex = 5;
            this.BtnHome.Text = "Back to Home";
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.SystemColors.Control;
            this.BtnClear.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(4, 262);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(260, 42);
            this.BtnClear.TabIndex = 4;
            this.BtnClear.Text = "Clear Details";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLogout.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.Location = new System.Drawing.Point(4, 503);
            this.BtnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(260, 42);
            this.BtnLogout.TabIndex = 0;
            this.BtnLogout.Text = "LOG OUT";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.LabelGuestName);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.LabelRoomName);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.LabelOutDate);
            this.panel1.Controls.Add(this.LabelInDate);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.LabelGuestsCount);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.LabelDaysAfterCheckin);
            this.panel1.Controls.Add(this.LabelHasOut);
            this.panel1.Controls.Add(this.LabelHasIn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LabelCheckout);
            this.panel1.Controls.Add(this.LabelCheckin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DgvReservations);
            this.panel1.Location = new System.Drawing.Point(36, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 565);
            this.panel1.TabIndex = 15;
            // 
            // LabelGuestName
            // 
            this.LabelGuestName.AutoSize = true;
            this.LabelGuestName.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGuestName.Location = new System.Drawing.Point(232, 218);
            this.LabelGuestName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelGuestName.Name = "LabelGuestName";
            this.LabelGuestName.Size = new System.Drawing.Size(109, 32);
            this.LabelGuestName.TabIndex = 30;
            this.LabelGuestName.Text = "GUEST";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 217);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 32);
            this.label11.TabIndex = 29;
            this.label11.Text = "Guest Name: ";
            // 
            // LabelRoomName
            // 
            this.LabelRoomName.AutoSize = true;
            this.LabelRoomName.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRoomName.Location = new System.Drawing.Point(232, 175);
            this.LabelRoomName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelRoomName.Name = "LabelRoomName";
            this.LabelRoomName.Size = new System.Drawing.Size(97, 32);
            this.LabelRoomName.TabIndex = 28;
            this.LabelRoomName.Text = "ROOM";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 175);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 32);
            this.label10.TabIndex = 27;
            this.label10.Text = "Room Name: ";
            // 
            // LabelOutDate
            // 
            this.LabelOutDate.AutoSize = true;
            this.LabelOutDate.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOutDate.Location = new System.Drawing.Point(872, 159);
            this.LabelOutDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelOutDate.Name = "LabelOutDate";
            this.LabelOutDate.Size = new System.Drawing.Size(87, 32);
            this.LabelOutDate.TabIndex = 26;
            this.LabelOutDate.Text = "DATE";
            // 
            // LabelInDate
            // 
            this.LabelInDate.AutoSize = true;
            this.LabelInDate.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInDate.Location = new System.Drawing.Point(872, 57);
            this.LabelInDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelInDate.Name = "LabelInDate";
            this.LabelInDate.Size = new System.Drawing.Size(87, 32);
            this.LabelInDate.TabIndex = 25;
            this.LabelInDate.Text = "DATE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(576, 159);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 32);
            this.label8.TabIndex = 24;
            this.label8.Text = "Check-Out Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(576, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 32);
            this.label7.TabIndex = 23;
            this.label7.Text = "Check-In Date:";
            // 
            // LabelGuestsCount
            // 
            this.LabelGuestsCount.AutoSize = true;
            this.LabelGuestsCount.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGuestsCount.Location = new System.Drawing.Point(141, 96);
            this.LabelGuestsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelGuestsCount.Name = "LabelGuestsCount";
            this.LabelGuestsCount.Size = new System.Drawing.Size(230, 32);
            this.LabelGuestsCount.TabIndex = 22;
            this.LabelGuestsCount.Text = "2 Adults, 1 Child";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 32);
            this.label6.TabIndex = 21;
            this.label6.Text = "Guests:";
            // 
            // LabelDaysAfterCheckin
            // 
            this.LabelDaysAfterCheckin.AutoSize = true;
            this.LabelDaysAfterCheckin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDaysAfterCheckin.Location = new System.Drawing.Point(576, 217);
            this.LabelDaysAfterCheckin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDaysAfterCheckin.Name = "LabelDaysAfterCheckin";
            this.LabelDaysAfterCheckin.Size = new System.Drawing.Size(346, 32);
            this.LabelDaysAfterCheckin.TabIndex = 20;
            this.LabelDaysAfterCheckin.Text = "Days Since Check-In: N/A";
            // 
            // LabelHasOut
            // 
            this.LabelHasOut.AutoSize = true;
            this.LabelHasOut.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHasOut.Location = new System.Drawing.Point(872, 118);
            this.LabelHasOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelHasOut.Name = "LabelHasOut";
            this.LabelHasOut.Size = new System.Drawing.Size(55, 32);
            this.LabelHasOut.TabIndex = 19;
            this.LabelHasOut.Text = "NO";
            // 
            // LabelHasIn
            // 
            this.LabelHasIn.AutoSize = true;
            this.LabelHasIn.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHasIn.Location = new System.Drawing.Point(872, 15);
            this.LabelHasIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelHasIn.Name = "LabelHasIn";
            this.LabelHasIn.Size = new System.Drawing.Size(68, 32);
            this.LabelHasIn.TabIndex = 18;
            this.LabelHasIn.Text = "YES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(576, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 32);
            this.label4.TabIndex = 17;
            this.label4.Text = "Has Checked Out:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(576, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "Has Checked In:";
            // 
            // LabelCheckout
            // 
            this.LabelCheckout.AutoSize = true;
            this.LabelCheckout.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCheckout.Location = new System.Drawing.Point(341, 55);
            this.LabelCheckout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCheckout.Name = "LabelCheckout";
            this.LabelCheckout.Size = new System.Drawing.Size(87, 32);
            this.LabelCheckout.TabIndex = 15;
            this.LabelCheckout.Text = "DATE";
            // 
            // LabelCheckin
            // 
            this.LabelCheckin.AutoSize = true;
            this.LabelCheckin.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCheckin.Location = new System.Drawing.Point(341, 15);
            this.LabelCheckin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCheckin.Name = "LabelCheckin";
            this.LabelCheckin.Size = new System.Drawing.Size(87, 32);
            this.LabelCheckin.TabIndex = 14;
            this.LabelCheckin.Text = "DATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Scheduled Check-Out: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Scheduled Check-In: ";
            // 
            // DgvReservations
            // 
            this.DgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvReservations.Location = new System.Drawing.Point(21, 262);
            this.DgvReservations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvReservations.Name = "DgvReservations";
            this.DgvReservations.RowHeadersWidth = 51;
            this.DgvReservations.Size = new System.Drawing.Size(1011, 283);
            this.DgvReservations.TabIndex = 11;
            this.DgvReservations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvReservations_CellClick);
            // 
            // FormEmployeeReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1393, 612);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEmployeeReservations";
            this.Text = "FormEmployeeReservations";
            this.Load += new System.EventHandler(this.FormEmployeeReservations_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReservations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgvReservations;
        private System.Windows.Forms.Button BtnCheckOut;
        private System.Windows.Forms.Button BtnCheckIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelCheckin;
        private System.Windows.Forms.Label LabelCheckout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelHasIn;
        private System.Windows.Forms.Label LabelHasOut;
        private System.Windows.Forms.Label LabelDaysAfterCheckin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LabelGuestsCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LabelInDate;
        private System.Windows.Forms.Label LabelOutDate;
        private System.Windows.Forms.Label LabelRoomName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LabelGuestName;
    }
}