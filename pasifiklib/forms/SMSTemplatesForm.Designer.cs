namespace pasifiklib.forms
{
    partial class SMSTemplatesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMSTemplatesForm));
            this.sms_template_lstbx = new System.Windows.Forms.ListBox();
            this.close_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sms_template_lstbx
            // 
            this.sms_template_lstbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sms_template_lstbx.FormattingEnabled = true;
            this.sms_template_lstbx.ItemHeight = 20;
            this.sms_template_lstbx.Location = new System.Drawing.Point(12, 14);
            this.sms_template_lstbx.Name = "sms_template_lstbx";
            this.sms_template_lstbx.Size = new System.Drawing.Size(591, 284);
            this.sms_template_lstbx.TabIndex = 0;
            this.sms_template_lstbx.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.sms_template_lstbx_MouseDoubleClick);
            // 
            // close_btn
            // 
            this.close_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.close_btn.Location = new System.Drawing.Point(499, 311);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(104, 40);
            this.close_btn.TabIndex = 11;
            this.close_btn.Text = "&Kapat";
            this.close_btn.UseVisualStyleBackColor = true;
            // 
            // SMSTemplatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.close_btn;
            this.ClientSize = new System.Drawing.Size(615, 363);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.sms_template_lstbx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SMSTemplatesForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hazır Mesaj";
            this.Load += new System.EventHandler(this.SMSTemplatesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox sms_template_lstbx;
        private System.Windows.Forms.Button close_btn;
    }
}