namespace HotelDBMS
{
    partial class FormGuestReserve
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
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MonCalBdate = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.CbxGender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtln = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txtfn = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DudChildCount = new System.Windows.Forms.DomainUpDown();
            this.DudAdultCount = new System.Windows.Forms.DomainUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtCheckout = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCheckin = new System.Windows.Forms.TextBox();
            this.MonCalChecking = new System.Windows.Forms.MonthCalendar();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.CbxRooms = new System.Windows.Forms.ComboBox();
            this.TxtDesc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtType = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TxtBdate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.MonCalBdate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CbxGender);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Txtln);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Txtfn);
            this.panel1.Location = new System.Drawing.Point(31, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 257);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(303, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 32);
            this.label6.TabIndex = 31;
            this.label6.Text = "Birthdate Text";
            // 
            // TxtBdate
            // 
            this.TxtBdate.Enabled = false;
            this.TxtBdate.Font = new System.Drawing.Font("Arial", 16F);
            this.TxtBdate.Location = new System.Drawing.Point(308, 208);
            this.TxtBdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtBdate.Name = "TxtBdate";
            this.TxtBdate.Size = new System.Drawing.Size(269, 38);
            this.TxtBdate.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Guest Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(693, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 32);
            this.label5.TabIndex = 29;
            this.label5.Text = "Birthdate";
            // 
            // MonCalBdate
            // 
            this.MonCalBdate.Location = new System.Drawing.Point(612, 48);
            this.MonCalBdate.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.MonCalBdate.MaxSelectionCount = 1;
            this.MonCalBdate.Name = "MonCalBdate";
            this.MonCalBdate.TabIndex = 28;
            this.MonCalBdate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonCalBdate_DateChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 32);
            this.label3.TabIndex = 27;
            this.label3.Text = "Gender:";
            // 
            // CbxGender
            // 
            this.CbxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxGender.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxGender.FormattingEnabled = true;
            this.CbxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Prefer not to say"});
            this.CbxGender.Location = new System.Drawing.Point(27, 208);
            this.CbxGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbxGender.Name = "CbxGender";
            this.CbxGender.Size = new System.Drawing.Size(272, 38);
            this.CbxGender.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 32);
            this.label2.TabIndex = 25;
            this.label2.Text = "Last Name";
            // 
            // Txtln
            // 
            this.Txtln.Font = new System.Drawing.Font("Arial", 16F);
            this.Txtln.Location = new System.Drawing.Point(308, 132);
            this.Txtln.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txtln.Name = "Txtln";
            this.Txtln.Size = new System.Drawing.Size(269, 38);
            this.Txtln.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 32);
            this.label4.TabIndex = 23;
            this.label4.Text = "First Name";
            // 
            // Txtfn
            // 
            this.Txtfn.Font = new System.Drawing.Font("Arial", 16F);
            this.Txtfn.Location = new System.Drawing.Point(27, 132);
            this.Txtfn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txtfn.Name = "Txtfn";
            this.Txtfn.Size = new System.Drawing.Size(272, 38);
            this.Txtfn.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.DudChildCount);
            this.panel2.Controls.Add(this.DudAdultCount);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.TxtCheckout);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.TxtCheckin);
            this.panel2.Controls.Add(this.MonCalChecking);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(31, 327);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(936, 257);
            this.panel2.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 201);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 32);
            this.label13.TabIndex = 40;
            this.label13.Text = "Children:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 155);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 32);
            this.label11.TabIndex = 39;
            this.label11.Text = "Adults:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 98);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 32);
            this.label10.TabIndex = 38;
            this.label10.Text = "Guests Count";
            // 
            // DudChildCount
            // 
            this.DudChildCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DudChildCount.Items.Add("1");
            this.DudChildCount.Items.Add("2");
            this.DudChildCount.Items.Add("3");
            this.DudChildCount.Items.Add("4");
            this.DudChildCount.Items.Add("5");
            this.DudChildCount.Location = new System.Drawing.Point(179, 196);
            this.DudChildCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DudChildCount.Name = "DudChildCount";
            this.DudChildCount.Size = new System.Drawing.Size(121, 37);
            this.DudChildCount.TabIndex = 37;
            this.DudChildCount.Text = "1";
            // 
            // DudAdultCount
            // 
            this.DudAdultCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DudAdultCount.Items.Add("1");
            this.DudAdultCount.Items.Add("2");
            this.DudAdultCount.Items.Add("3");
            this.DudAdultCount.Items.Add("4");
            this.DudAdultCount.Items.Add("5");
            this.DudAdultCount.Location = new System.Drawing.Point(179, 150);
            this.DudAdultCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DudAdultCount.Name = "DudAdultCount";
            this.DudAdultCount.Size = new System.Drawing.Size(121, 37);
            this.DudAdultCount.TabIndex = 36;
            this.DudAdultCount.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(320, 175);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 32);
            this.label9.TabIndex = 35;
            this.label9.Text = "Check-Out Date";
            // 
            // TxtCheckout
            // 
            this.TxtCheckout.Enabled = false;
            this.TxtCheckout.Font = new System.Drawing.Font("Arial", 16F);
            this.TxtCheckout.Location = new System.Drawing.Point(325, 208);
            this.TxtCheckout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCheckout.Name = "TxtCheckout";
            this.TxtCheckout.Size = new System.Drawing.Size(269, 38);
            this.TxtCheckout.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(320, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 32);
            this.label7.TabIndex = 33;
            this.label7.Text = "Check-In Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(607, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 32);
            this.label8.TabIndex = 29;
            this.label8.Text = "Stay Period";
            // 
            // TxtCheckin
            // 
            this.TxtCheckin.Enabled = false;
            this.TxtCheckin.Font = new System.Drawing.Font("Arial", 16F);
            this.TxtCheckin.Location = new System.Drawing.Point(325, 132);
            this.TxtCheckin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCheckin.Name = "TxtCheckin";
            this.TxtCheckin.Size = new System.Drawing.Size(269, 38);
            this.TxtCheckin.TabIndex = 32;
            // 
            // MonCalChecking
            // 
            this.MonCalChecking.Location = new System.Drawing.Point(612, 48);
            this.MonCalChecking.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.MonCalChecking.MaxSelectionCount = 14;
            this.MonCalChecking.Name = "MonCalChecking";
            this.MonCalChecking.TabIndex = 28;
            this.MonCalChecking.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonCalChecking_DateChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 16);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(332, 40);
            this.label12.TabIndex = 1;
            this.label12.Text = "Reservation Details";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.CbxRooms);
            this.panel3.Controls.Add(this.TxtDesc);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.TxtPrice);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.TxtType);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(31, 592);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(936, 228);
            this.panel3.TabIndex = 32;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(21, 69);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(178, 32);
            this.label18.TabIndex = 33;
            this.label18.Text = "Room Name";
            // 
            // CbxRooms
            // 
            this.CbxRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxRooms.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxRooms.FormattingEnabled = true;
            this.CbxRooms.Location = new System.Drawing.Point(27, 102);
            this.CbxRooms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbxRooms.Name = "CbxRooms";
            this.CbxRooms.Size = new System.Drawing.Size(347, 38);
            this.CbxRooms.TabIndex = 32;
            this.CbxRooms.SelectedIndexChanged += new System.EventHandler(this.CbxRooms_SelectedIndexChanged);
            // 
            // TxtDesc
            // 
            this.TxtDesc.Enabled = false;
            this.TxtDesc.Font = new System.Drawing.Font("Arial", 16F);
            this.TxtDesc.Location = new System.Drawing.Point(27, 175);
            this.TxtDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.Size = new System.Drawing.Size(887, 38);
            this.TxtDesc.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 142);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(166, 32);
            this.label14.TabIndex = 15;
            this.label14.Text = "Description";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(668, 69);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 32);
            this.label16.TabIndex = 14;
            this.label16.Text = "Price";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Enabled = false;
            this.TxtPrice.Font = new System.Drawing.Font("Arial", 16F);
            this.TxtPrice.Location = new System.Drawing.Point(673, 102);
            this.TxtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(240, 38);
            this.TxtPrice.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(401, 69);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 32);
            this.label17.TabIndex = 12;
            this.label17.Text = "Type";
            // 
            // TxtType
            // 
            this.TxtType.Enabled = false;
            this.TxtType.Font = new System.Drawing.Font("Arial", 16F);
            this.TxtType.Location = new System.Drawing.Point(407, 102);
            this.TxtType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtType.Name = "TxtType";
            this.TxtType.Size = new System.Drawing.Size(240, 38);
            this.TxtType.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(19, 15);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(235, 40);
            this.label15.TabIndex = 1;
            this.label15.Text = "Room Details";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(353, 12);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(308, 46);
            this.label19.TabIndex = 32;
            this.label19.Text = "APPOINTMENT";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.Location = new System.Drawing.Point(285, 831);
            this.BtnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(437, 49);
            this.BtnSubmit.TabIndex = 34;
            this.BtnSubmit.Text = "CONFIRM RESERVATION";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.Location = new System.Drawing.Point(764, 6);
            this.BtnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(203, 49);
            this.BtnHome.TabIndex = 35;
            this.BtnHome.Text = "Back to Home";
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // FormGuestReserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1004, 889);
            this.Controls.Add(this.BtnHome);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormGuestReserve";
            this.Text = "FormGuestReserve";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtBdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar MonCalBdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbxGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtln;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txtfn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MonthCalendar MonCalChecking;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtCheckin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtCheckout;
        private System.Windows.Forms.DomainUpDown DudAdultCount;
        private System.Windows.Forms.DomainUpDown DudChildCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtDesc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TxtType;
        private System.Windows.Forms.ComboBox CbxRooms;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Button BtnHome;
    }
}