namespace Divine_Nail
{
    partial class Report
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
            this.button1 = new System.Windows.Forms.Button();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.cb3 = new System.Windows.Forms.ComboBox();
            this.cb4 = new System.Windows.Forms.ComboBox();
            this.cba = new System.Windows.Forms.CheckBox();
            this.cbp = new System.Windows.Forms.CheckBox();
            this.cb6 = new System.Windows.Forms.ComboBox();
            this.cb7 = new System.Windows.Forms.ComboBox();
            this.dtpD1 = new System.Windows.Forms.DateTimePicker();
            this.dvgR = new System.Windows.Forms.DataGridView();
            this.dtpT2 = new System.Windows.Forms.DateTimePicker();
            this.dtpD2 = new System.Windows.Forms.DateTimePicker();
            this.cb5 = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.tbOut = new System.Windows.Forms.TextBox();
            this.btnT5 = new System.Windows.Forms.Button();
            this.btnCI = new System.Windows.Forms.Button();
            this.dtpT1 = new System.Windows.Forms.DateTimePicker();
            this.lblT = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.cbD = new System.Windows.Forms.CheckBox();
            this.cbT = new System.Windows.Forms.CheckBox();
            this.cbC = new System.Windows.Forms.CheckBox();
            this.btnRep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgR)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "Booking_ID",
            "Assistant_ID",
            "Client_ID",
            "Treatment_ID"});
            this.cb1.Location = new System.Drawing.Point(12, 12);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(121, 21);
            this.cb1.TabIndex = 1;
            this.cb1.Text = "Booking_ID";
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cb2
            // 
            this.cb2.FormattingEnabled = true;
            this.cb2.Items.AddRange(new object[] {
            "Off",
            "Assistant_ID"});
            this.cb2.Location = new System.Drawing.Point(139, 12);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(121, 21);
            this.cb2.TabIndex = 2;
            this.cb2.Text = "Assistant_ID";
            this.cb2.SelectedIndexChanged += new System.EventHandler(this.cb2_SelectedIndexChanged);
            // 
            // cb3
            // 
            this.cb3.FormattingEnabled = true;
            this.cb3.Items.AddRange(new object[] {
            "Off",
            "Client_ID"});
            this.cb3.Location = new System.Drawing.Point(12, 39);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(121, 21);
            this.cb3.TabIndex = 3;
            this.cb3.Text = "Client_ID";
            this.cb3.SelectedIndexChanged += new System.EventHandler(this.cb3_SelectedIndexChanged);
            // 
            // cb4
            // 
            this.cb4.FormattingEnabled = true;
            this.cb4.Items.AddRange(new object[] {
            "Off",
            "Treatment_ID"});
            this.cb4.Location = new System.Drawing.Point(139, 39);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(121, 21);
            this.cb4.TabIndex = 4;
            this.cb4.Text = "Treatment_ID";
            this.cb4.SelectedIndexChanged += new System.EventHandler(this.cb4_SelectedIndexChanged);
            // 
            // cba
            // 
            this.cba.AutoSize = true;
            this.cba.Location = new System.Drawing.Point(129, 253);
            this.cba.Name = "cba";
            this.cba.Size = new System.Drawing.Size(76, 17);
            this.cba.TabIndex = 5;
            this.cba.Text = "isAttended";
            this.cba.UseVisualStyleBackColor = true;
            this.cba.Visible = false;
            this.cba.CheckedChanged += new System.EventHandler(this.cba_CheckedChanged);
            // 
            // cbp
            // 
            this.cbp.AutoSize = true;
            this.cbp.Location = new System.Drawing.Point(212, 253);
            this.cbp.Name = "cbp";
            this.cbp.Size = new System.Drawing.Size(63, 17);
            this.cbp.TabIndex = 6;
            this.cbp.Text = "isPayed";
            this.cbp.UseVisualStyleBackColor = true;
            this.cbp.Visible = false;
            this.cbp.CheckedChanged += new System.EventHandler(this.cbp_CheckedChanged);
            // 
            // cb6
            // 
            this.cb6.FormattingEnabled = true;
            this.cb6.Items.AddRange(new object[] {
            "Off",
            "Attended",
            "Payed",
            "Attended/Payed"});
            this.cb6.Location = new System.Drawing.Point(139, 226);
            this.cb6.Name = "cb6";
            this.cb6.Size = new System.Drawing.Size(121, 21);
            this.cb6.TabIndex = 10;
            this.cb6.Text = "Off";
            this.cb6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // cb7
            // 
            this.cb7.FormattingEnabled = true;
            this.cb7.Items.AddRange(new object[] {
            "Off",
            "Date"});
            this.cb7.Location = new System.Drawing.Point(12, 66);
            this.cb7.Name = "cb7";
            this.cb7.Size = new System.Drawing.Size(121, 21);
            this.cb7.TabIndex = 11;
            this.cb7.Text = "Off";
            this.cb7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // dtpD1
            // 
            this.dtpD1.CustomFormat = "HH:mm";
            this.dtpD1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpD1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtpD1.Location = new System.Drawing.Point(139, 89);
            this.dtpD1.Name = "dtpD1";
            this.dtpD1.Size = new System.Drawing.Size(121, 20);
            this.dtpD1.TabIndex = 29;
            this.dtpD1.Visible = false;
            this.dtpD1.ValueChanged += new System.EventHandler(this.dtpD1_ValueChanged);
            // 
            // dvgR
            // 
            this.dvgR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgR.Location = new System.Drawing.Point(352, 12);
            this.dvgR.Name = "dvgR";
            this.dvgR.Size = new System.Drawing.Size(883, 109);
            this.dvgR.TabIndex = 30;
            // 
            // dtpT2
            // 
            this.dtpT2.CustomFormat = "HH:mm";
            this.dtpT2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpT2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtpT2.Location = new System.Drawing.Point(139, 191);
            this.dtpT2.Name = "dtpT2";
            this.dtpT2.Size = new System.Drawing.Size(121, 20);
            this.dtpT2.TabIndex = 31;
            this.dtpT2.Visible = false;
            this.dtpT2.ValueChanged += new System.EventHandler(this.dtpT_ValueChanged);
            // 
            // dtpD2
            // 
            this.dtpD2.CustomFormat = "HH:mm";
            this.dtpD2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpD2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtpD2.Location = new System.Drawing.Point(139, 115);
            this.dtpD2.Name = "dtpD2";
            this.dtpD2.Size = new System.Drawing.Size(121, 20);
            this.dtpD2.TabIndex = 33;
            this.dtpD2.Visible = false;
            this.dtpD2.ValueChanged += new System.EventHandler(this.dtpD2_ValueChanged);
            // 
            // cb5
            // 
            this.cb5.FormattingEnabled = true;
            this.cb5.Items.AddRange(new object[] {
            "Off",
            "Time"});
            this.cb5.Location = new System.Drawing.Point(12, 144);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(121, 21);
            this.cb5.TabIndex = 34;
            this.cb5.Text = "Off";
            this.cb5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(49, 102);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(33, 13);
            this.lbl1.TabIndex = 35;
            this.lbl1.Text = "From:";
            this.lbl1.Visible = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(49, 128);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(23, 13);
            this.lbl2.TabIndex = 36;
            this.lbl2.Text = "To:";
            this.lbl2.Visible = false;
            // 
            // tbOut
            // 
            this.tbOut.Location = new System.Drawing.Point(352, 128);
            this.tbOut.Multiline = true;
            this.tbOut.Name = "tbOut";
            this.tbOut.Size = new System.Drawing.Size(883, 181);
            this.tbOut.TabIndex = 38;
            // 
            // btnT5
            // 
            this.btnT5.Location = new System.Drawing.Point(266, 14);
            this.btnT5.Name = "btnT5";
            this.btnT5.Size = new System.Drawing.Size(75, 46);
            this.btnT5.TabIndex = 40;
            this.btnT5.Text = "Top 5 Treatments";
            this.btnT5.UseVisualStyleBackColor = true;
            this.btnT5.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCI
            // 
            this.btnCI.Location = new System.Drawing.Point(265, 83);
            this.btnCI.Name = "btnCI";
            this.btnCI.Size = new System.Drawing.Size(76, 50);
            this.btnCI.TabIndex = 41;
            this.btnCI.Text = "Calculate Income ";
            this.btnCI.UseVisualStyleBackColor = true;
            this.btnCI.Visible = false;
            this.btnCI.Click += new System.EventHandler(this.btnCI_Click);
            // 
            // dtpT1
            // 
            this.dtpT1.CustomFormat = "HH:mm";
            this.dtpT1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpT1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtpT1.Location = new System.Drawing.Point(139, 165);
            this.dtpT1.Name = "dtpT1";
            this.dtpT1.Size = new System.Drawing.Size(121, 20);
            this.dtpT1.TabIndex = 42;
            this.dtpT1.Visible = false;
            this.dtpT1.ValueChanged += new System.EventHandler(this.dtpT1_ValueChanged);
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Location = new System.Drawing.Point(49, 197);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(23, 13);
            this.lblT.TabIndex = 44;
            this.lblT.Text = "To:";
            this.lblT.Visible = false;
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Location = new System.Drawing.Point(49, 171);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(33, 13);
            this.lblF.TabIndex = 43;
            this.lblF.Text = "From:";
            this.lblF.Visible = false;
            this.lblF.Click += new System.EventHandler(this.lblF_Click);
            // 
            // cbD
            // 
            this.cbD.AutoSize = true;
            this.cbD.Location = new System.Drawing.Point(140, 66);
            this.cbD.Name = "cbD";
            this.cbD.Size = new System.Drawing.Size(51, 17);
            this.cbD.TabIndex = 45;
            this.cbD.Text = "Filter:";
            this.cbD.UseVisualStyleBackColor = true;
            this.cbD.Visible = false;
            this.cbD.CheckedChanged += new System.EventHandler(this.cbD_CheckedChanged);
            // 
            // cbT
            // 
            this.cbT.AutoSize = true;
            this.cbT.Location = new System.Drawing.Point(139, 144);
            this.cbT.Name = "cbT";
            this.cbT.Size = new System.Drawing.Size(51, 17);
            this.cbT.TabIndex = 46;
            this.cbT.Text = "Filter:";
            this.cbT.UseVisualStyleBackColor = true;
            this.cbT.Visible = false;
            this.cbT.CheckedChanged += new System.EventHandler(this.cbT_CheckedChanged);
            // 
            // cbC
            // 
            this.cbC.AutoSize = true;
            this.cbC.Location = new System.Drawing.Point(266, 228);
            this.cbC.Name = "cbC";
            this.cbC.Size = new System.Drawing.Size(51, 17);
            this.cbC.TabIndex = 47;
            this.cbC.Text = "Filter:";
            this.cbC.UseVisualStyleBackColor = true;
            this.cbC.Visible = false;
            this.cbC.CheckedChanged += new System.EventHandler(this.cbC_CheckedChanged);
            // 
            // btnRep
            // 
            this.btnRep.Location = new System.Drawing.Point(265, 160);
            this.btnRep.Name = "btnRep";
            this.btnRep.Size = new System.Drawing.Size(76, 50);
            this.btnRep.TabIndex = 48;
            this.btnRep.Text = "Request Report";
            this.btnRep.UseVisualStyleBackColor = true;
            this.btnRep.Click += new System.EventHandler(this.btnRep_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 321);
            this.Controls.Add(this.btnRep);
            this.Controls.Add(this.cbC);
            this.Controls.Add(this.cbT);
            this.Controls.Add(this.cbD);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.lblF);
            this.Controls.Add(this.dtpT1);
            this.Controls.Add(this.btnCI);
            this.Controls.Add(this.btnT5);
            this.Controls.Add(this.tbOut);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.cb5);
            this.Controls.Add(this.dtpD2);
            this.Controls.Add(this.dtpT2);
            this.Controls.Add(this.dvgR);
            this.Controls.Add(this.dtpD1);
            this.Controls.Add(this.cb7);
            this.Controls.Add(this.cb6);
            this.Controls.Add(this.cbp);
            this.Controls.Add(this.cba);
            this.Controls.Add(this.cb4);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.button1);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.ComboBox cb3;
        private System.Windows.Forms.ComboBox cb4;
        private System.Windows.Forms.CheckBox cba;
        private System.Windows.Forms.CheckBox cbp;
        private System.Windows.Forms.ComboBox cb6;
        private System.Windows.Forms.ComboBox cb7;
        private System.Windows.Forms.DateTimePicker dtpD1;
        private System.Windows.Forms.DataGridView dvgR;
        private System.Windows.Forms.DateTimePicker dtpT2;
        private System.Windows.Forms.DateTimePicker dtpD2;
        private System.Windows.Forms.ComboBox cb5;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox tbOut;
        private System.Windows.Forms.Button btnT5;
        private System.Windows.Forms.Button btnCI;
        private System.Windows.Forms.DateTimePicker dtpT1;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.CheckBox cbD;
        private System.Windows.Forms.CheckBox cbT;
        private System.Windows.Forms.CheckBox cbC;
        private System.Windows.Forms.Button btnRep;
    }
}