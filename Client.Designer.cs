namespace Divine_Nail
{
    partial class Client
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
            this.components = new System.ComponentModel.Container();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.cba = new System.Windows.Forms.ComboBox();
            this.tba = new System.Windows.Forms.TextBox();
            this.tbb = new System.Windows.Forms.TextBox();
            this.tbc = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.ep1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(204, 12);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(601, 206);
            this.dgv1.TabIndex = 0;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // cba
            // 
            this.cba.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cba.FormattingEnabled = true;
            this.cba.Location = new System.Drawing.Point(87, 9);
            this.cba.Name = "cba";
            this.cba.Size = new System.Drawing.Size(95, 21);
            this.cba.TabIndex = 1;
            this.cba.SelectedIndexChanged += new System.EventHandler(this.cba_SelectedIndexChanged);
            // 
            // tba
            // 
            this.tba.Location = new System.Drawing.Point(87, 39);
            this.tba.Name = "tba";
            this.tba.Size = new System.Drawing.Size(95, 20);
            this.tba.TabIndex = 2;
            // 
            // tbb
            // 
            this.tbb.Location = new System.Drawing.Point(87, 65);
            this.tbb.Name = "tbb";
            this.tbb.Size = new System.Drawing.Size(95, 20);
            this.tbb.TabIndex = 3;
            // 
            // tbc
            // 
            this.tbc.Location = new System.Drawing.Point(87, 90);
            this.tbc.Name = "tbc";
            this.tbc.Size = new System.Drawing.Size(95, 20);
            this.tbc.TabIndex = 4;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(87, 116);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(87, 145);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(87, 203);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(87, 174);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ep1
            // 
            this.ep1.ContainerControl = this;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(6, 12);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(47, 13);
            this.lbl1.TabIndex = 9;
            this.lbl1.Text = "Client ID";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(6, 42);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(57, 13);
            this.lbl2.TabIndex = 10;
            this.lbl2.Text = "First Name";
            this.lbl2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(6, 68);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(58, 13);
            this.lbl3.TabIndex = 11;
            this.lbl3.Text = "Last Name";
            this.lbl3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(6, 93);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(75, 13);
            this.lbl4.TabIndex = 12;
            this.lbl4.Text = "Contact Numb";
            this.lbl4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Client
            // 
            this.ClientSize = new System.Drawing.Size(806, 230);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.tbc);
            this.Controls.Add(this.tbb);
            this.Controls.Add(this.tba);
            this.Controls.Add(this.cba);
            this.Controls.Add(this.dgv1);
            this.Name = "Client";
            this.Load += new System.EventHandler(this.Client_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.DataGridView dvgC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.ComboBox Cb1;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.ComboBox cba;
        private System.Windows.Forms.TextBox tba;
        private System.Windows.Forms.TextBox tbb;
        private System.Windows.Forms.TextBox tbc;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ErrorProvider ep1;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
    }
}