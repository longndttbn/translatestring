namespace TranslateString
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnInputFile = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.listDataInput = new System.Windows.Forms.DataGridView();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSoLuongMuonChay = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalCurrent = new System.Windows.Forms.Label();
            this.txtCurrentLoop = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.translated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listDataInput)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInputFile
            // 
            this.btnInputFile.Location = new System.Drawing.Point(129, 19);
            this.btnInputFile.Name = "btnInputFile";
            this.btnInputFile.Size = new System.Drawing.Size(531, 36);
            this.btnInputFile.TabIndex = 12;
            this.btnInputFile.Text = "Nhập file string";
            this.btnInputFile.UseVisualStyleBackColor = true;
            this.btnInputFile.Click += new System.EventHandler(this.btnInputFile_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.comboBoxTo);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.comboBoxFrom);
            this.groupBox3.Controls.Add(this.btnStart);
            this.groupBox3.Controls.Add(this.btnDownload);
            this.groupBox3.Controls.Add(this.btnInputFile);
            this.groupBox3.Controls.Add(this.listDataInput);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(759, 529);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Input";
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(74, 465);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(266, 52);
            this.btnStart.TabIndex = 19;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Location = new System.Drawing.Point(393, 465);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(288, 52);
            this.btnDownload.TabIndex = 20;
            this.btnDownload.Text = "EXPORT FILE";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // listDataInput
            // 
            this.listDataInput.AllowUserToAddRows = false;
            this.listDataInput.AllowUserToDeleteRows = false;
            this.listDataInput.AllowUserToResizeRows = false;
            this.listDataInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listDataInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.name,
            this.text,
            this.translated,
            this.status});
            this.listDataInput.Location = new System.Drawing.Point(6, 106);
            this.listDataInput.Name = "listDataInput";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listDataInput.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.listDataInput.RowHeadersVisible = false;
            this.listDataInput.RowHeadersWidth = 51;
            this.listDataInput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listDataInput.Size = new System.Drawing.Size(748, 278);
            this.listDataInput.TabIndex = 0;
            this.listDataInput.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listDataInput_CellContentClick);
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Items.AddRange(new object[] {
            "en",
            "vi",
            "ja"});
            this.comboBoxFrom.Location = new System.Drawing.Point(179, 76);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFrom.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(133, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "From";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(320, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "To";
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Items.AddRange(new object[] {
            "en",
            "vi",
            "id",
            "hi",
            "ko",
            "ja"});
            this.comboBoxTo.Location = new System.Drawing.Point(350, 76);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTo.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(56, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Translate";
            // 
            // lblSoLuongMuonChay
            // 
            this.lblSoLuongMuonChay.AutoSize = true;
            this.lblSoLuongMuonChay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblSoLuongMuonChay.Location = new System.Drawing.Point(142, 27);
            this.lblSoLuongMuonChay.Name = "lblSoLuongMuonChay";
            this.lblSoLuongMuonChay.Size = new System.Drawing.Size(41, 16);
            this.lblSoLuongMuonChay.TabIndex = 1;
            this.lblSoLuongMuonChay.Text = "Loop:";
            this.lblSoLuongMuonChay.Click += new System.EventHandler(this.lblSoLuongMuonChay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTotalCurrent);
            this.groupBox1.Controls.Add(this.txtCurrentLoop);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.lblSoLuongMuonChay);
            this.groupBox1.Location = new System.Drawing.Point(84, 390);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 62);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label4.Location = new System.Drawing.Point(395, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "/";
            // 
            // txtTotalCurrent
            // 
            this.txtTotalCurrent.AutoSize = true;
            this.txtTotalCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtTotalCurrent.Location = new System.Drawing.Point(412, 27);
            this.txtTotalCurrent.Name = "txtTotalCurrent";
            this.txtTotalCurrent.Size = new System.Drawing.Size(14, 16);
            this.txtTotalCurrent.TabIndex = 8;
            this.txtTotalCurrent.Text = "3";
            // 
            // txtCurrentLoop
            // 
            this.txtCurrentLoop.AutoSize = true;
            this.txtCurrentLoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtCurrentLoop.Location = new System.Drawing.Point(364, 27);
            this.txtCurrentLoop.Name = "txtCurrentLoop";
            this.txtCurrentLoop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCurrentLoop.Size = new System.Drawing.Size(14, 16);
            this.txtCurrentLoop.TabIndex = 7;
            this.txtCurrentLoop.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label5.Location = new System.Drawing.Point(306, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Current:";
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtTotal.Location = new System.Drawing.Point(189, 27);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(14, 16);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.Text = "3";
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.Width = 50;
            // 
            // name
            // 
            this.name.HeaderText = "NAME";
            this.name.Name = "name";
            this.name.Width = 150;
            // 
            // text
            // 
            this.text.HeaderText = "TEXT";
            this.text.Name = "text";
            this.text.Width = 250;
            // 
            // translated
            // 
            this.translated.HeaderText = "TRANSLATED";
            this.translated.Name = "translated";
            this.translated.Width = 250;
            // 
            // status
            // 
            this.status.HeaderText = "STATUS";
            this.status.Name = "status";
            this.status.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 529);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Translate - LongND - v1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listDataInput)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInputFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.DataGridView listDataInput;
        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtTotalCurrent;
        private System.Windows.Forms.Label txtCurrentLoop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Label lblSoLuongMuonChay;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn text;
        private System.Windows.Forms.DataGridViewTextBoxColumn translated;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}

