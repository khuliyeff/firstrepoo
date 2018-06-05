namespace Home_sell
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxbFloor = new System.Windows.Forms.TextBox();
            this.TxbArea = new System.Windows.Forms.TextBox();
            this.CmbAdType = new System.Windows.Forms.ComboBox();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.TxbRCount = new System.Windows.Forms.TextBox();
            this.CmbType = new System.Windows.Forms.ComboBox();
            this.CmbStreet = new System.Windows.Forms.ComboBox();
            this.Dgvv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelet = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(248, 543);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(240, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtnDelet);
            this.tabPage2.Controls.Add(this.BtnUpdate);
            this.tabPage2.Controls.Add(this.BtnAdd);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.TxbFloor);
            this.tabPage2.Controls.Add(this.TxbArea);
            this.tabPage2.Controls.Add(this.CmbAdType);
            this.tabPage2.Controls.Add(this.TxtPrice);
            this.tabPage2.Controls.Add(this.TxbRCount);
            this.tabPage2.Controls.Add(this.CmbType);
            this.tabPage2.Controls.Add(this.CmbStreet);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(240, 517);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(6, 398);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(177, 36);
            this.BtnAdd.TabIndex = 14;
            this.BtnAdd.Text = "ADD";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Floor *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Area*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ad Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Price*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Room Count*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Street";
            // 
            // TxbFloor
            // 
            this.TxbFloor.Location = new System.Drawing.Point(6, 362);
            this.TxbFloor.Name = "TxbFloor";
            this.TxbFloor.Size = new System.Drawing.Size(177, 20);
            this.TxbFloor.TabIndex = 6;
            // 
            // TxbArea
            // 
            this.TxbArea.Location = new System.Drawing.Point(6, 317);
            this.TxbArea.Name = "TxbArea";
            this.TxbArea.Size = new System.Drawing.Size(177, 20);
            this.TxbArea.TabIndex = 5;
            // 
            // CmbAdType
            // 
            this.CmbAdType.FormattingEnabled = true;
            this.CmbAdType.Location = new System.Drawing.Point(6, 260);
            this.CmbAdType.Name = "CmbAdType";
            this.CmbAdType.Size = new System.Drawing.Size(177, 21);
            this.CmbAdType.TabIndex = 4;
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(6, 209);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(177, 20);
            this.TxtPrice.TabIndex = 3;
            // 
            // TxbRCount
            // 
            this.TxbRCount.Location = new System.Drawing.Point(6, 159);
            this.TxbRCount.Name = "TxbRCount";
            this.TxbRCount.Size = new System.Drawing.Size(177, 20);
            this.TxbRCount.TabIndex = 2;
            // 
            // CmbType
            // 
            this.CmbType.FormattingEnabled = true;
            this.CmbType.Location = new System.Drawing.Point(6, 98);
            this.CmbType.Name = "CmbType";
            this.CmbType.Size = new System.Drawing.Size(177, 21);
            this.CmbType.TabIndex = 1;
            // 
            // CmbStreet
            // 
            this.CmbStreet.FormattingEnabled = true;
            this.CmbStreet.Location = new System.Drawing.Point(6, 37);
            this.CmbStreet.Name = "CmbStreet";
            this.CmbStreet.Size = new System.Drawing.Size(177, 21);
            this.CmbStreet.TabIndex = 0;
            // 
            // Dgvv
            // 
            this.Dgvv.AllowUserToAddRows = false;
            this.Dgvv.AllowUserToDeleteRows = false;
            this.Dgvv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgvv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.Dgvv.Location = new System.Drawing.Point(282, 50);
            this.Dgvv.Name = "Dgvv";
            this.Dgvv.ReadOnly = true;
            this.Dgvv.Size = new System.Drawing.Size(720, 401);
            this.Dgvv.TabIndex = 2;
            this.Dgvv.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgvv_RowHeaderMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Street";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Type";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Room Count";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Price";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ad Type";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Area";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Floor";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(6, 398);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(177, 36);
            this.BtnUpdate.TabIndex = 15;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Visible = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelet
            // 
            this.BtnDelet.Location = new System.Drawing.Point(6, 440);
            this.BtnDelet.Name = "BtnDelet";
            this.BtnDelet.Size = new System.Drawing.Size(177, 36);
            this.BtnDelet.TabIndex = 16;
            this.BtnDelet.Text = "DELETE";
            this.BtnDelet.UseVisualStyleBackColor = true;
            this.BtnDelet.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 579);
            this.Controls.Add(this.Dgvv);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbFloor;
        private System.Windows.Forms.TextBox TxbArea;
        private System.Windows.Forms.ComboBox CmbAdType;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.TextBox TxbRCount;
        private System.Windows.Forms.ComboBox CmbType;
        private System.Windows.Forms.ComboBox CmbStreet;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView Dgvv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button BtnDelet;
        private System.Windows.Forms.Button BtnUpdate;
    }
}

