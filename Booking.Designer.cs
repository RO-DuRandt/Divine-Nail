namespace Divine_Nail
{
    partial class Booking
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
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.dvgB = new System.Windows.Forms.DataGridView();
            this.Cb1 = new System.Windows.Forms.ComboBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.cBox2 = new System.Windows.Forms.CheckBox();
            this.cBox1 = new System.Windows.Forms.CheckBox();
            this.Cb4 = new System.Windows.Forms.ComboBox();
            this.Cb3 = new System.Windows.Forms.ComboBox();
            this.Cb2 = new System.Windows.Forms.ComboBox();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblt = new System.Windows.Forms.Label();
            this.lbla = new System.Windows.Forms.Label();
            this.lblc = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Request = new System.Windows.Forms.Button();
            this.Client = new System.Windows.Forms.Button();
            this.Treatment = new System.Windows.Forms.Button();
            this.Nail_Assistant = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgB)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(218, 68);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(86, 23);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(218, 36);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(86, 23);
            this.Edit.TabIndex = 7;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(218, 7);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(86, 23);
            this.Create.TabIndex = 6;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // dvgB
            // 
            this.dvgB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgB.Location = new System.Drawing.Point(310, 7);
            this.dvgB.Name = "dvgB";
            this.dvgB.Size = new System.Drawing.Size(857, 216);
            this.dvgB.TabIndex = 12;
            // 
            // Cb1
            // 
            this.Cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb1.FormattingEnabled = true;
            this.Cb1.Location = new System.Drawing.Point(91, 7);
            this.Cb1.Name = "Cb1";
            this.Cb1.Size = new System.Drawing.Size(121, 21);
            this.Cb1.TabIndex = 17;
            this.Cb1.SelectedIndexChanged += new System.EventHandler(this.Cb1_SelectedIndexChanged);
            // 
            // dtp
            // 
            this.dtp.CustomFormat = "HH:mm";
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtp.Location = new System.Drawing.Point(91, 143);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(121, 20);
            this.dtp.TabIndex = 28;
            // 
            // cBox2
            // 
            this.cBox2.AutoSize = true;
            this.cBox2.Location = new System.Drawing.Point(12, 195);
            this.cBox2.Name = "cBox2";
            this.cBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cBox2.Size = new System.Drawing.Size(92, 17);
            this.cBox2.TabIndex = 27;
            this.cBox2.Text = "            Payed";
            this.cBox2.UseVisualStyleBackColor = true;
            // 
            // cBox1
            // 
            this.cBox1.AutoSize = true;
            this.cBox1.Location = new System.Drawing.Point(12, 172);
            this.cBox1.Name = "cBox1";
            this.cBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cBox1.Size = new System.Drawing.Size(93, 17);
            this.cBox1.TabIndex = 26;
            this.cBox1.Text = "        Attended";
            this.cBox1.UseVisualStyleBackColor = true;
            // 
            // Cb4
            // 
            this.Cb4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb4.FormattingEnabled = true;
            this.Cb4.Location = new System.Drawing.Point(91, 90);
            this.Cb4.Name = "Cb4";
            this.Cb4.Size = new System.Drawing.Size(121, 21);
            this.Cb4.TabIndex = 25;
            // 
            // Cb3
            // 
            this.Cb3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb3.FormattingEnabled = true;
            this.Cb3.Location = new System.Drawing.Point(91, 63);
            this.Cb3.Name = "Cb3";
            this.Cb3.Size = new System.Drawing.Size(121, 21);
            this.Cb3.TabIndex = 24;
            // 
            // Cb2
            // 
            this.Cb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb2.FormattingEnabled = true;
            this.Cb2.Location = new System.Drawing.Point(91, 34);
            this.Cb2.Name = "Cb2";
            this.Cb2.Size = new System.Drawing.Size(121, 21);
            this.Cb2.TabIndex = 29;
            this.Cb2.SelectedIndexChanged += new System.EventHandler(this.Cb2_SelectedIndexChanged);
            // 
            // dtp1
            // 
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp1.Location = new System.Drawing.Point(91, 117);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(121, 20);
            this.dtp1.TabIndex = 30;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(19, 123);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(30, 13);
            this.lbl1.TabIndex = 34;
            this.lbl1.Text = "Date";
            // 
            // lblt
            // 
            this.lblt.AutoSize = true;
            this.lblt.Location = new System.Drawing.Point(19, 93);
            this.lblt.Name = "lblt";
            this.lblt.Size = new System.Drawing.Size(69, 13);
            this.lblt.TabIndex = 33;
            this.lblt.Text = "Treatment ID";
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(19, 37);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(63, 13);
            this.lbla.TabIndex = 32;
            this.lbla.Text = "Asisstant ID";
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Location = new System.Drawing.Point(19, 66);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(47, 13);
            this.lblc.TabIndex = 31;
            this.lblc.Text = "Client ID";
            this.lblc.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Location = new System.Drawing.Point(19, 12);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(60, 13);
            this.lblb.TabIndex = 35;
            this.lblb.Text = "Booking ID";
            this.lblb.Click += new System.EventHandler(this.lblb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Time";
            // 
            // Request
            // 
            this.Request.Location = new System.Drawing.Point(205, 200);
            this.Request.Name = "Request";
            this.Request.Size = new System.Drawing.Size(99, 23);
            this.Request.TabIndex = 11;
            this.Request.Text = "Request Report";
            this.Request.UseVisualStyleBackColor = true;
            this.Request.Click += new System.EventHandler(this.Request_Click);
            // 
            // Client
            // 
            this.Client.Location = new System.Drawing.Point(218, 142);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(86, 23);
            this.Client.TabIndex = 14;
            this.Client.Text = "Client";
            this.Client.UseVisualStyleBackColor = true;
            this.Client.Click += new System.EventHandler(this.Client_Click);
            // 
            // Treatment
            // 
            this.Treatment.Location = new System.Drawing.Point(218, 171);
            this.Treatment.Name = "Treatment";
            this.Treatment.Size = new System.Drawing.Size(86, 23);
            this.Treatment.TabIndex = 15;
            this.Treatment.Text = "Treatment";
            this.Treatment.UseVisualStyleBackColor = true;
            this.Treatment.Click += new System.EventHandler(this.Treatment_Click);
            // 
            // Nail_Assistant
            // 
            this.Nail_Assistant.Location = new System.Drawing.Point(218, 113);
            this.Nail_Assistant.Name = "Nail_Assistant";
            this.Nail_Assistant.Size = new System.Drawing.Size(86, 23);
            this.Nail_Assistant.TabIndex = 16;
            this.Nail_Assistant.Text = "Nail Assistant";
            this.Nail_Assistant.UseVisualStyleBackColor = true;
            this.Nail_Assistant.Click += new System.EventHandler(this.Nail_Assistant_Click);
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 229);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblt);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.lblc);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.Cb2);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.cBox2);
            this.Controls.Add(this.cBox1);
            this.Controls.Add(this.Cb4);
            this.Controls.Add(this.Cb3);
            this.Controls.Add(this.Cb1);
            this.Controls.Add(this.Nail_Assistant);
            this.Controls.Add(this.Treatment);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.dvgB);
            this.Controls.Add(this.Request);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Create);
            this.Name = "Booking";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.DataGridView dvgB;
        private System.Windows.Forms.ComboBox Cb1;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.CheckBox cBox2;
        private System.Windows.Forms.CheckBox cBox1;
        private System.Windows.Forms.ComboBox Cb4;
        private System.Windows.Forms.ComboBox Cb3;
        private System.Windows.Forms.ComboBox Cb2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblt;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Request;
        private System.Windows.Forms.Button Client;
        private System.Windows.Forms.Button Treatment;
        private System.Windows.Forms.Button Nail_Assistant;
    }
}

