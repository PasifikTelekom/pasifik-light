namespace pasifiklib.forms
{
    partial class AddressbookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddressbookForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.close_btn = new System.Windows.Forms.Button();
            this.upload_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chkBxSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtBxfullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBxmobile1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search_txtbx = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.close_btn);
            this.groupBox1.Controls.Add(this.upload_btn);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.search_txtbx);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 485);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Listesi";
            // 
            // close_btn
            // 
            this.close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.close_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.close_btn.Location = new System.Drawing.Point(496, 422);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(104, 40);
            this.close_btn.TabIndex = 12;
            this.close_btn.Text = "&Kapat";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // upload_btn
            // 
            this.upload_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.upload_btn.Location = new System.Drawing.Point(356, 422);
            this.upload_btn.Name = "upload_btn";
            this.upload_btn.Size = new System.Drawing.Size(104, 40);
            this.upload_btn.TabIndex = 11;
            this.upload_btn.Text = "&Tamam";
            this.upload_btn.UseVisualStyleBackColor = true;
            this.upload_btn.Click += new System.EventHandler(this.upload_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkBxSelect,
            this.txtBxfullname,
            this.txtBxmobile1});
            this.dataGridView1.Location = new System.Drawing.Point(21, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(579, 330);
            this.dataGridView1.TabIndex = 1;
            // 
            // chkBxSelect
            // 
            this.chkBxSelect.DataPropertyName = "IsChecked";
            this.chkBxSelect.HeaderText = "";
            this.chkBxSelect.Name = "chkBxSelect";
            // 
            // txtBxfullname
            // 
            this.txtBxfullname.DataPropertyName = "fullname";
            this.txtBxfullname.HeaderText = "Ad Soyad";
            this.txtBxfullname.Name = "txtBxfullname";
            this.txtBxfullname.ReadOnly = true;
            // 
            // txtBxmobile1
            // 
            this.txtBxmobile1.DataPropertyName = "mobile1";
            this.txtBxmobile1.HeaderText = "Cep Telefonu";
            this.txtBxmobile1.Name = "txtBxmobile1";
            this.txtBxmobile1.ReadOnly = true;
            // 
            // search_txtbx
            // 
            this.search_txtbx.Location = new System.Drawing.Point(21, 36);
            this.search_txtbx.Name = "search_txtbx";
            this.search_txtbx.Size = new System.Drawing.Size(579, 27);
            this.search_txtbx.TabIndex = 0;
            this.search_txtbx.KeyUp += new System.Windows.Forms.KeyEventHandler(this.search_txtbx_KeyUp);
            // 
            // AddressbookForm
            // 
            this.AcceptButton = this.upload_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.close_btn;
            this.ClientSize = new System.Drawing.Size(647, 509);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddressbookForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kişi Listesi";
            this.Load += new System.EventHandler(this.AddressbookForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button upload_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkBxSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBxfullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBxmobile1;
        private System.Windows.Forms.TextBox search_txtbx;
    }
}