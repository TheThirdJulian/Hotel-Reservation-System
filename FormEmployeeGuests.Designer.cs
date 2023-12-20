namespace HotelDBMS
{
    partial class FormEmployeeGuests
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
            this.BtnHome = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MonCalBdate = new System.Windows.Forms.MonthCalendar();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CbxGender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtln = new System.Windows.Forms.TextBox();
            this.DgvGuests = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtfn = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.BtnHome);
            this.panel2.Controls.Add(this.BtnClear);
            this.panel2.Controls.Add(this.BtnDelete);
            this.panel2.Controls.Add(this.BtnUpdate);
            this.panel2.Controls.Add(this.BtnLogout);
            this.panel2.Location = new System.Drawing.Point(785, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 422);
            this.panel2.TabIndex = 14;
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnHome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.Location = new System.Drawing.Point(15, 337);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(154, 34);
            this.BtnHome.TabIndex = 5;
            this.BtnHome.Text = "Back to Home";
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.SystemColors.Control;
            this.BtnClear.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(15, 182);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(154, 34);
            this.BtnClear.TabIndex = 4;
            this.BtnClear.Text = "Clear Inputs";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.BtnDelete.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(15, 52);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(154, 34);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Delete Guest";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.BtnUpdate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(15, 12);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(154, 34);
            this.BtnUpdate.TabIndex = 2;
            this.BtnUpdate.Text = "Update Guest";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLogout.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.Location = new System.Drawing.Point(15, 377);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(154, 34);
            this.BtnLogout.TabIndex = 0;
            this.BtnLogout.Text = "LOG OUT";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TxtBdate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.MonCalBdate);
            this.panel1.Controls.Add(this.LabelStatus);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CbxGender);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Txtln);
            this.panel1.Controls.Add(this.DgvGuests);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Txtfn);
            this.panel1.Location = new System.Drawing.Point(29, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 423);
            this.panel1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(223, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Birthdate Text";
            // 
            // TxtBdate
            // 
            this.TxtBdate.Enabled = false;
            this.TxtBdate.Font = new System.Drawing.Font("Arial", 16F);
            this.TxtBdate.Location = new System.Drawing.Point(227, 104);
            this.TxtBdate.Name = "TxtBdate";
            this.TxtBdate.Size = new System.Drawing.Size(203, 32);
            this.TxtBdate.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(493, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Birthdate";
            // 
            // MonCalBdate
            // 
            this.MonCalBdate.Location = new System.Drawing.Point(497, 39);
            this.MonCalBdate.MaxSelectionCount = 1;
            this.MonCalBdate.Name = "MonCalBdate";
            this.MonCalBdate.TabIndex = 18;
            this.MonCalBdate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonCalBdate_DateChanged);
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStatus.Location = new System.Drawing.Point(8, 171);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(241, 30);
            this.LabelStatus.TabIndex = 17;
            this.LabelStatus.Text = "AWAY FROM HOTEL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Reservation Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 15;
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
            this.CbxGender.Location = new System.Drawing.Point(16, 104);
            this.CbxGender.Name = "CbxGender";
            this.CbxGender.Size = new System.Drawing.Size(205, 32);
            this.CbxGender.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Last Name";
            // 
            // Txtln
            // 
            this.Txtln.Font = new System.Drawing.Font("Arial", 16F);
            this.Txtln.Location = new System.Drawing.Point(227, 39);
            this.Txtln.Name = "Txtln";
            this.Txtln.Size = new System.Drawing.Size(203, 32);
            this.Txtln.TabIndex = 12;
            // 
            // DgvGuests
            // 
            this.DgvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGuests.Location = new System.Drawing.Point(16, 213);
            this.DgvGuests.Name = "DgvGuests";
            this.DgvGuests.Size = new System.Drawing.Size(708, 198);
            this.DgvGuests.TabIndex = 11;
            this.DgvGuests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGuests_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name";
            // 
            // Txtfn
            // 
            this.Txtfn.Font = new System.Drawing.Font("Arial", 16F);
            this.Txtfn.Location = new System.Drawing.Point(16, 39);
            this.Txtfn.Name = "Txtfn";
            this.Txtfn.Size = new System.Drawing.Size(205, 32);
            this.Txtfn.TabIndex = 3;
            // 
            // FormEmployeeGuests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(998, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormEmployeeGuests";
            this.Text = "FormEmployeeGuests";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGuests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgvGuests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtfn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtln;
        private System.Windows.Forms.ComboBox CbxGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.MonthCalendar MonCalBdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtBdate;
    }
}