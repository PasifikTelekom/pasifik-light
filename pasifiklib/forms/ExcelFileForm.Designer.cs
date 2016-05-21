namespace pasifiklib.forms
{
    partial class ExcelFileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelFileForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filename_lbl = new System.Windows.Forms.Label();
            this.excel_lbl = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Button();
            this.upload_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.normalexcel_rdbtn = new System.Windows.Forms.RadioButton();
            this.customexcel_rdbtn = new System.Windows.Forms.RadioButton();
            this.phonenumberclmn_cmbbx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.browse_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filename_lbl);
            this.groupBox1.Controls.Add(this.excel_lbl);
            this.groupBox1.Controls.Add(this.close_btn);
            this.groupBox1.Controls.Add(this.upload_btn);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.phonenumberclmn_cmbbx);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.browse_btn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 214);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Excel Dosyası";
            // 
            // filename_lbl
            // 
            this.filename_lbl.AutoSize = true;
            this.filename_lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filename_lbl.Location = new System.Drawing.Point(30, 99);
            this.filename_lbl.Name = "filename_lbl";
            this.filename_lbl.Size = new System.Drawing.Size(16, 15);
            this.filename_lbl.TabIndex = 12;
            this.filename_lbl.Text = "...";
            this.filename_lbl.Visible = false;
            // 
            // excel_lbl
            // 
            this.excel_lbl.AutoSize = true;
            this.excel_lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.excel_lbl.Location = new System.Drawing.Point(298, 69);
            this.excel_lbl.Name = "excel_lbl";
            this.excel_lbl.Size = new System.Drawing.Size(26, 15);
            this.excel_lbl.TabIndex = 11;
            this.excel_lbl.Text = "Boş";
            // 
            // close_btn
            // 
            this.close_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.close_btn.Location = new System.Drawing.Point(677, 154);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(104, 40);
            this.close_btn.TabIndex = 10;
            this.close_btn.Text = "&Kapat";
            this.close_btn.UseVisualStyleBackColor = true;
            // 
            // upload_btn
            // 
            this.upload_btn.Location = new System.Drawing.Point(537, 154);
            this.upload_btn.Name = "upload_btn";
            this.upload_btn.Size = new System.Drawing.Size(104, 40);
            this.upload_btn.TabIndex = 9;
            this.upload_btn.Text = "&Yükle";
            this.upload_btn.UseVisualStyleBackColor = true;
            this.upload_btn.Click += new System.EventHandler(this.upload_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.normalexcel_rdbtn);
            this.panel1.Controls.Add(this.customexcel_rdbtn);
            this.panel1.Location = new System.Drawing.Point(505, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 67);
            this.panel1.TabIndex = 8;
            // 
            // normalexcel_rdbtn
            // 
            this.normalexcel_rdbtn.AutoSize = true;
            this.normalexcel_rdbtn.Checked = true;
            this.normalexcel_rdbtn.Location = new System.Drawing.Point(32, 5);
            this.normalexcel_rdbtn.Name = "normalexcel_rdbtn";
            this.normalexcel_rdbtn.Size = new System.Drawing.Size(115, 24);
            this.normalexcel_rdbtn.TabIndex = 6;
            this.normalexcel_rdbtn.TabStop = true;
            this.normalexcel_rdbtn.Text = "Normal Excel";
            this.normalexcel_rdbtn.UseVisualStyleBackColor = true;
            // 
            // customexcel_rdbtn
            // 
            this.customexcel_rdbtn.AutoSize = true;
            this.customexcel_rdbtn.Location = new System.Drawing.Point(32, 35);
            this.customexcel_rdbtn.Name = "customexcel_rdbtn";
            this.customexcel_rdbtn.Size = new System.Drawing.Size(95, 24);
            this.customexcel_rdbtn.TabIndex = 7;
            this.customexcel_rdbtn.Text = "Özel Excel";
            this.customexcel_rdbtn.UseVisualStyleBackColor = true;
            // 
            // phonenumberclmn_cmbbx
            // 
            this.phonenumberclmn_cmbbx.AutoCompleteCustomSource.AddRange(new string[] {
            "A"});
            this.phonenumberclmn_cmbbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.phonenumberclmn_cmbbx.Location = new System.Drawing.Point(200, 138);
            this.phonenumberclmn_cmbbx.Name = "phonenumberclmn_cmbbx";
            this.phonenumberclmn_cmbbx.Size = new System.Drawing.Size(92, 28);
            this.phonenumberclmn_cmbbx.TabIndex = 5;
            this.phonenumberclmn_cmbbx.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = " Olduğu Sütünü Seçin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mobil Numaraların";
            // 
            // browse_btn
            // 
            this.browse_btn.Location = new System.Drawing.Point(200, 58);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Size = new System.Drawing.Size(92, 34);
            this.browse_btn.TabIndex = 2;
            this.browse_btn.Text = "Dosya seç";
            this.browse_btn.UseVisualStyleBackColor = true;
            this.browse_btn.Click += new System.EventHandler(this.browse_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dosyayı seçiniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desteklenen dosya türleri : Excel (*.xls, *.xlsx). İlk satırda kolan adları olmal" +
    "ı Örnek: Adı , Soyadı , Numara, Borc";
            // 
            // ExcelFileForm
            // 
            this.AcceptButton = this.upload_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.close_btn;
            this.ClientSize = new System.Drawing.Size(824, 238);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ExcelFileForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel Dosyası";
            this.Load += new System.EventHandler(this.ExcelFileForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label filename_lbl;
        private System.Windows.Forms.Label excel_lbl;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button upload_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton normalexcel_rdbtn;
        private System.Windows.Forms.RadioButton customexcel_rdbtn;
        private System.Windows.Forms.ComboBox phonenumberclmn_cmbbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button browse_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}