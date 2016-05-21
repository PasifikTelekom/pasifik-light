namespace pasifiklib.forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label4 = new System.Windows.Forms.Label();
            this.message_count_lbl = new System.Windows.Forms.Label();
            this.phoneset_rchtxtbx = new System.Windows.Forms.TextBox();
            this.message_rchtxtbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clean_btn = new System.Windows.Forms.Button();
            this.sms_header_cmbbx = new System.Windows.Forms.ComboBox();
            this.sendsms_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sms_template_btn = new System.Windows.Forms.Button();
            this.scheduled_delivery_time_dtpckr = new System.Windows.Forms.DateTimePicker();
            this.period_cmbbx = new System.Windows.Forms.ComboBox();
            this.period_lbl = new System.Windows.Forms.Label();
            this.scheduled_delivery_time_lbl = new System.Windows.Forms.Label();
            this.scheduled_delivery_date_dtpckr = new System.Windows.Forms.DateTimePicker();
            this.universal_chkbx = new System.Windows.Forms.CheckBox();
            this.excelfile_btn = new System.Windows.Forms.Button();
            this.addressbook_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.total_count_lbl = new System.Windows.Forms.Label();
            this.total_undelivered_lbl = new System.Windows.Forms.Label();
            this.total_delivered_lbl = new System.Windows.Forms.Label();
            this.total_waiting_lbl = new System.Windows.Forms.Label();
            this.mesajadedi_lbl = new System.Windows.Forms.Label();
            this.line1_lbl = new System.Windows.Forms.Label();
            this.bekleyen_lbl = new System.Windows.Forms.Label();
            this.basarsiz_lbl = new System.Windows.Forms.Label();
            this.basarli_lbl = new System.Windows.Forms.Label();
            this.username_lbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yenilemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelaGitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapMakinasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainform_sttsstrp = new System.Windows.Forms.StatusStrip();
            this.ready_tsslbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.pkt_balance_tsslbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.balance_tsslbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fullname_lbl = new System.Windows.Forms.Label();
            this.picture_pnl = new System.Windows.Forms.Panel();
            this.message_auto_complete_menu = new autocompletemenu.AutocompleteMenu();
            this.message_img_list = new System.Windows.Forms.ImageList(this.components);
            this.alphabet_cmbbx = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.mainform_sttsstrp.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(667, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Numaraları";
            // 
            // message_count_lbl
            // 
            this.message_count_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.message_count_lbl.AutoSize = true;
            this.message_count_lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.message_count_lbl.Location = new System.Drawing.Point(140, 392);
            this.message_count_lbl.Name = "message_count_lbl";
            this.message_count_lbl.Size = new System.Drawing.Size(211, 15);
            this.message_count_lbl.TabIndex = 10;
            this.message_count_lbl.Text = "Karakter sayısı: 0 / 612. SMS sayısı: 1 / 4";
            // 
            // phoneset_rchtxtbx
            // 
            this.phoneset_rchtxtbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.message_auto_complete_menu.SetAutocompleteMenu(this.phoneset_rchtxtbx, null);
            this.phoneset_rchtxtbx.Location = new System.Drawing.Point(756, 152);
            this.phoneset_rchtxtbx.MinimumSize = new System.Drawing.Size(131, 128);
            this.phoneset_rchtxtbx.Multiline = true;
            this.phoneset_rchtxtbx.Name = "phoneset_rchtxtbx";
            this.phoneset_rchtxtbx.Size = new System.Drawing.Size(229, 427);
            this.phoneset_rchtxtbx.TabIndex = 9;
            // 
            // message_rchtxtbx
            // 
            this.message_rchtxtbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.message_auto_complete_menu.SetAutocompleteMenu(this.message_rchtxtbx, this.message_auto_complete_menu);
            this.message_rchtxtbx.Location = new System.Drawing.Point(143, 152);
            this.message_rchtxtbx.MaxLength = 612;
            this.message_rchtxtbx.MinimumSize = new System.Drawing.Size(199, 128);
            this.message_rchtxtbx.Multiline = true;
            this.message_rchtxtbx.Name = "message_rchtxtbx";
            this.message_rchtxtbx.Size = new System.Drawing.Size(494, 237);
            this.message_rchtxtbx.TabIndex = 8;
            this.message_rchtxtbx.TextChanged += new System.EventHandler(this.message_rchtxtbx_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(692, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mesaj";
            // 
            // clean_btn
            // 
            this.clean_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clean_btn.BackColor = System.Drawing.SystemColors.Window;
            this.clean_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clean_btn.Location = new System.Drawing.Point(19, 598);
            this.clean_btn.Name = "clean_btn";
            this.clean_btn.Size = new System.Drawing.Size(145, 40);
            this.clean_btn.TabIndex = 3;
            this.clean_btn.Text = "&Temiz";
            this.clean_btn.UseVisualStyleBackColor = true;
            this.clean_btn.Click += new System.EventHandler(this.clean_btn_Click);
            // 
            // sms_header_cmbbx
            // 
            this.sms_header_cmbbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sms_header_cmbbx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sms_header_cmbbx.FormattingEnabled = true;
            this.sms_header_cmbbx.Location = new System.Drawing.Point(143, 36);
            this.sms_header_cmbbx.Name = "sms_header_cmbbx";
            this.sms_header_cmbbx.Size = new System.Drawing.Size(269, 28);
            this.sms_header_cmbbx.TabIndex = 1;
            // 
            // sendsms_btn
            // 
            this.sendsms_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendsms_btn.BackColor = System.Drawing.SystemColors.Window;
            this.sendsms_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sendsms_btn.Location = new System.Drawing.Point(840, 598);
            this.sendsms_btn.Name = "sendsms_btn";
            this.sendsms_btn.Size = new System.Drawing.Size(145, 40);
            this.sendsms_btn.TabIndex = 2;
            this.sendsms_btn.Text = "SMS &Gönder";
            this.sendsms_btn.UseVisualStyleBackColor = true;
            this.sendsms_btn.Click += new System.EventHandler(this.sendsms_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.alphabet_cmbbx);
            this.groupBox1.Controls.Add(this.sms_template_btn);
            this.groupBox1.Controls.Add(this.scheduled_delivery_time_dtpckr);
            this.groupBox1.Controls.Add(this.period_cmbbx);
            this.groupBox1.Controls.Add(this.period_lbl);
            this.groupBox1.Controls.Add(this.scheduled_delivery_time_lbl);
            this.groupBox1.Controls.Add(this.scheduled_delivery_date_dtpckr);
            this.groupBox1.Controls.Add(this.universal_chkbx);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.excelfile_btn);
            this.groupBox1.Controls.Add(this.addressbook_btn);
            this.groupBox1.Controls.Add(this.message_count_lbl);
            this.groupBox1.Controls.Add(this.phoneset_rchtxtbx);
            this.groupBox1.Controls.Add(this.message_rchtxtbx);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.clean_btn);
            this.groupBox1.Controls.Add(this.sms_header_cmbbx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sendsms_btn);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(276, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1004, 657);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SMS Gönder";
            // 
            // sms_template_btn
            // 
            this.sms_template_btn.Image = global::pasifiklib.Properties.Resources.sms_templates;
            this.sms_template_btn.Location = new System.Drawing.Point(143, 89);
            this.sms_template_btn.Name = "sms_template_btn";
            this.sms_template_btn.Size = new System.Drawing.Size(269, 47);
            this.sms_template_btn.TabIndex = 22;
            this.sms_template_btn.Text = "Hazır Mesajlari";
            this.sms_template_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sms_template_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sms_template_btn.UseVisualStyleBackColor = true;
            this.sms_template_btn.Click += new System.EventHandler(this.sms_template_btn_Click);
            // 
            // scheduled_delivery_time_dtpckr
            // 
            this.scheduled_delivery_time_dtpckr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.scheduled_delivery_time_dtpckr.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.scheduled_delivery_time_dtpckr.Location = new System.Drawing.Point(357, 504);
            this.scheduled_delivery_time_dtpckr.Name = "scheduled_delivery_time_dtpckr";
            this.scheduled_delivery_time_dtpckr.ShowUpDown = true;
            this.scheduled_delivery_time_dtpckr.Size = new System.Drawing.Size(154, 27);
            this.scheduled_delivery_time_dtpckr.TabIndex = 21;
            // 
            // period_cmbbx
            // 
            this.period_cmbbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.period_cmbbx.AutoCompleteCustomSource.AddRange(new string[] {
            "24 Saat"});
            this.period_cmbbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.period_cmbbx.FormattingEnabled = true;
            this.period_cmbbx.Items.AddRange(new object[] {
            "24 Saat"});
            this.period_cmbbx.Location = new System.Drawing.Point(143, 551);
            this.period_cmbbx.Name = "period_cmbbx";
            this.period_cmbbx.Size = new System.Drawing.Size(121, 28);
            this.period_cmbbx.TabIndex = 20;
            // 
            // period_lbl
            // 
            this.period_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.period_lbl.AutoSize = true;
            this.period_lbl.Location = new System.Drawing.Point(44, 554);
            this.period_lbl.Name = "period_lbl";
            this.period_lbl.Size = new System.Drawing.Size(93, 20);
            this.period_lbl.TabIndex = 19;
            this.period_lbl.Text = "Teslim süresi";
            // 
            // scheduled_delivery_time_lbl
            // 
            this.scheduled_delivery_time_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.scheduled_delivery_time_lbl.AutoSize = true;
            this.scheduled_delivery_time_lbl.Location = new System.Drawing.Point(61, 509);
            this.scheduled_delivery_time_lbl.Name = "scheduled_delivery_time_lbl";
            this.scheduled_delivery_time_lbl.Size = new System.Drawing.Size(76, 20);
            this.scheduled_delivery_time_lbl.TabIndex = 18;
            this.scheduled_delivery_time_lbl.Text = "İleri tarihli";
            // 
            // scheduled_delivery_date_dtpckr
            // 
            this.scheduled_delivery_date_dtpckr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.scheduled_delivery_date_dtpckr.Location = new System.Drawing.Point(143, 504);
            this.scheduled_delivery_date_dtpckr.Name = "scheduled_delivery_date_dtpckr";
            this.scheduled_delivery_date_dtpckr.Size = new System.Drawing.Size(208, 27);
            this.scheduled_delivery_date_dtpckr.TabIndex = 16;
            // 
            // universal_chkbx
            // 
            this.universal_chkbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.universal_chkbx.AutoSize = true;
            this.universal_chkbx.Location = new System.Drawing.Point(143, 463);
            this.universal_chkbx.Name = "universal_chkbx";
            this.universal_chkbx.Size = new System.Drawing.Size(186, 24);
            this.universal_chkbx.TabIndex = 15;
            this.universal_chkbx.Text = "Yurt Dışı SMS Gönderim";
            this.universal_chkbx.UseVisualStyleBackColor = true;
            // 
            // excelfile_btn
            // 
            this.excelfile_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.excelfile_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.excelfile_btn.Image = global::pasifiklib.Properties.Resources.excel;
            this.excelfile_btn.Location = new System.Drawing.Point(887, 36);
            this.excelfile_btn.Name = "excelfile_btn";
            this.excelfile_btn.Size = new System.Drawing.Size(98, 68);
            this.excelfile_btn.TabIndex = 12;
            this.excelfile_btn.Text = "Excel Dosyası";
            this.excelfile_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.excelfile_btn.UseVisualStyleBackColor = true;
            this.excelfile_btn.Click += new System.EventHandler(this.excelfile_btn_Click);
            // 
            // addressbook_btn
            // 
            this.addressbook_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addressbook_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addressbook_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addressbook_btn.Image = global::pasifiklib.Properties.Resources.users;
            this.addressbook_btn.Location = new System.Drawing.Point(756, 36);
            this.addressbook_btn.Name = "addressbook_btn";
            this.addressbook_btn.Size = new System.Drawing.Size(98, 68);
            this.addressbook_btn.TabIndex = 11;
            this.addressbook_btn.Text = "Kişi Listesi";
            this.addressbook_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addressbook_btn.UseVisualStyleBackColor = true;
            this.addressbook_btn.Click += new System.EventHandler(this.addressbook_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mesaj Başlık";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.total_count_lbl);
            this.groupBox3.Controls.Add(this.total_undelivered_lbl);
            this.groupBox3.Controls.Add(this.total_delivered_lbl);
            this.groupBox3.Controls.Add(this.total_waiting_lbl);
            this.groupBox3.Controls.Add(this.mesajadedi_lbl);
            this.groupBox3.Controls.Add(this.line1_lbl);
            this.groupBox3.Controls.Add(this.bekleyen_lbl);
            this.groupBox3.Controls.Add(this.basarsiz_lbl);
            this.groupBox3.Controls.Add(this.basarli_lbl);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(13, 287);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 147);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SMS";
            // 
            // total_count_lbl
            // 
            this.total_count_lbl.AutoSize = true;
            this.total_count_lbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.total_count_lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.total_count_lbl.Location = new System.Drawing.Point(115, 116);
            this.total_count_lbl.Name = "total_count_lbl";
            this.total_count_lbl.Size = new System.Drawing.Size(13, 13);
            this.total_count_lbl.TabIndex = 18;
            this.total_count_lbl.Text = "0";
            // 
            // total_undelivered_lbl
            // 
            this.total_undelivered_lbl.AutoSize = true;
            this.total_undelivered_lbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.total_undelivered_lbl.ForeColor = System.Drawing.Color.Red;
            this.total_undelivered_lbl.Location = new System.Drawing.Point(115, 79);
            this.total_undelivered_lbl.Name = "total_undelivered_lbl";
            this.total_undelivered_lbl.Size = new System.Drawing.Size(13, 13);
            this.total_undelivered_lbl.TabIndex = 17;
            this.total_undelivered_lbl.Text = "0";
            // 
            // total_delivered_lbl
            // 
            this.total_delivered_lbl.AutoSize = true;
            this.total_delivered_lbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.total_delivered_lbl.ForeColor = System.Drawing.Color.Green;
            this.total_delivered_lbl.Location = new System.Drawing.Point(115, 52);
            this.total_delivered_lbl.Name = "total_delivered_lbl";
            this.total_delivered_lbl.Size = new System.Drawing.Size(13, 13);
            this.total_delivered_lbl.TabIndex = 16;
            this.total_delivered_lbl.Text = "0";
            // 
            // total_waiting_lbl
            // 
            this.total_waiting_lbl.AutoSize = true;
            this.total_waiting_lbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.total_waiting_lbl.ForeColor = System.Drawing.Color.Orange;
            this.total_waiting_lbl.Location = new System.Drawing.Point(115, 25);
            this.total_waiting_lbl.Name = "total_waiting_lbl";
            this.total_waiting_lbl.Size = new System.Drawing.Size(13, 13);
            this.total_waiting_lbl.TabIndex = 15;
            this.total_waiting_lbl.Text = "0";
            // 
            // mesajadedi_lbl
            // 
            this.mesajadedi_lbl.AutoSize = true;
            this.mesajadedi_lbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mesajadedi_lbl.Location = new System.Drawing.Point(19, 116);
            this.mesajadedi_lbl.Name = "mesajadedi_lbl";
            this.mesajadedi_lbl.Size = new System.Drawing.Size(73, 13);
            this.mesajadedi_lbl.TabIndex = 14;
            this.mesajadedi_lbl.Text = "Mesaj Adedi:";
            // 
            // line1_lbl
            // 
            this.line1_lbl.AutoSize = true;
            this.line1_lbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.line1_lbl.Location = new System.Drawing.Point(19, 96);
            this.line1_lbl.Name = "line1_lbl";
            this.line1_lbl.Size = new System.Drawing.Size(217, 13);
            this.line1_lbl.TabIndex = 13;
            this.line1_lbl.Text = "__________________________________________";
            // 
            // bekleyen_lbl
            // 
            this.bekleyen_lbl.AutoSize = true;
            this.bekleyen_lbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bekleyen_lbl.Location = new System.Drawing.Point(19, 25);
            this.bekleyen_lbl.Name = "bekleyen_lbl";
            this.bekleyen_lbl.Size = new System.Drawing.Size(56, 13);
            this.bekleyen_lbl.TabIndex = 12;
            this.bekleyen_lbl.Text = "Bekleyen:";
            // 
            // basarsiz_lbl
            // 
            this.basarsiz_lbl.AutoSize = true;
            this.basarsiz_lbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.basarsiz_lbl.Location = new System.Drawing.Point(19, 79);
            this.basarsiz_lbl.Name = "basarsiz_lbl";
            this.basarsiz_lbl.Size = new System.Drawing.Size(54, 13);
            this.basarsiz_lbl.TabIndex = 11;
            this.basarsiz_lbl.Text = "Başarısız:";
            // 
            // basarli_lbl
            // 
            this.basarli_lbl.AutoSize = true;
            this.basarli_lbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.basarli_lbl.Location = new System.Drawing.Point(19, 52);
            this.basarli_lbl.Name = "basarli_lbl";
            this.basarli_lbl.Size = new System.Drawing.Size(47, 13);
            this.basarli_lbl.TabIndex = 10;
            this.basarli_lbl.Text = "Başarılı:";
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.username_lbl.Location = new System.Drawing.Point(46, 226);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(63, 13);
            this.username_lbl.TabIndex = 9;
            this.username_lbl.Text = "Kullancıadı";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1292, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.AliceBlue;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yenilemeToolStripMenuItem,
            this.raporToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(79, 20);
            this.toolStripMenuItem1.Text = "&ANASAYFA";
            // 
            // yenilemeToolStripMenuItem
            // 
            this.yenilemeToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.yenilemeToolStripMenuItem.Name = "yenilemeToolStripMenuItem";
            this.yenilemeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.yenilemeToolStripMenuItem.Text = "Y&enileme";
            this.yenilemeToolStripMenuItem.Click += new System.EventHandler(this.yenilemeToolStripMenuItem_Click);
            // 
            // raporToolStripMenuItem
            // 
            this.raporToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            this.raporToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.raporToolStripMenuItem.Text = "&Rapor";
            this.raporToolStripMenuItem.Click += new System.EventHandler(this.raporToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.çıkışToolStripMenuItem.Text = "&Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.AliceBlue;
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panelaGitToolStripMenuItem,
            this.hesapMakinasiToolStripMenuItem,
            this.hakkımdaToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(63, 20);
            this.toolStripMenuItem2.Text = "&YARDIM";
            // 
            // panelaGitToolStripMenuItem
            // 
            this.panelaGitToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.panelaGitToolStripMenuItem.Name = "panelaGitToolStripMenuItem";
            this.panelaGitToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.panelaGitToolStripMenuItem.Text = "Panela &Git";
            this.panelaGitToolStripMenuItem.Click += new System.EventHandler(this.panelaGitToolStripMenuItem_Click);
            // 
            // hesapMakinasiToolStripMenuItem
            // 
            this.hesapMakinasiToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.hesapMakinasiToolStripMenuItem.Name = "hesapMakinasiToolStripMenuItem";
            this.hesapMakinasiToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.hesapMakinasiToolStripMenuItem.Text = "Hesap &Makinesi";
            this.hesapMakinasiToolStripMenuItem.Click += new System.EventHandler(this.hesapMakinasiToolStripMenuItem_Click);
            // 
            // hakkımdaToolStripMenuItem
            // 
            this.hakkımdaToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.hakkımdaToolStripMenuItem.Name = "hakkımdaToolStripMenuItem";
            this.hakkımdaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.hakkımdaToolStripMenuItem.Text = "&Hakkımızda";
            this.hakkımdaToolStripMenuItem.Click += new System.EventHandler(this.hakkımdaToolStripMenuItem_Click);
            // 
            // mainform_sttsstrp
            // 
            this.mainform_sttsstrp.BackColor = System.Drawing.SystemColors.Highlight;
            this.mainform_sttsstrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ready_tsslbl,
            this.pkt_balance_tsslbl,
            this.balance_tsslbl});
            this.mainform_sttsstrp.Location = new System.Drawing.Point(0, 697);
            this.mainform_sttsstrp.Name = "mainform_sttsstrp";
            this.mainform_sttsstrp.Size = new System.Drawing.Size(1292, 22);
            this.mainform_sttsstrp.SizingGrip = false;
            this.mainform_sttsstrp.TabIndex = 7;
            this.mainform_sttsstrp.Text = "statusStrip1";
            // 
            // ready_tsslbl
            // 
            this.ready_tsslbl.BackColor = System.Drawing.SystemColors.Control;
            this.ready_tsslbl.ForeColor = System.Drawing.SystemColors.Window;
            this.ready_tsslbl.Name = "ready_tsslbl";
            this.ready_tsslbl.Size = new System.Drawing.Size(39, 17);
            this.ready_tsslbl.Text = "Ready";
            this.ready_tsslbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pkt_balance_tsslbl
            // 
            this.pkt_balance_tsslbl.BackColor = System.Drawing.SystemColors.Control;
            this.pkt_balance_tsslbl.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.pkt_balance_tsslbl.ForeColor = System.Drawing.SystemColors.Window;
            this.pkt_balance_tsslbl.Name = "pkt_balance_tsslbl";
            this.pkt_balance_tsslbl.Size = new System.Drawing.Size(619, 17);
            this.pkt_balance_tsslbl.Spring = true;
            this.pkt_balance_tsslbl.Text = "0 SMS, 0 TELEFONE";
            this.pkt_balance_tsslbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // balance_tsslbl
            // 
            this.balance_tsslbl.BackColor = System.Drawing.SystemColors.Control;
            this.balance_tsslbl.ForeColor = System.Drawing.SystemColors.Window;
            this.balance_tsslbl.Name = "balance_tsslbl";
            this.balance_tsslbl.Size = new System.Drawing.Size(619, 17);
            this.balance_tsslbl.Spring = true;
            this.balance_tsslbl.Text = "0 BAKİYE";
            this.balance_tsslbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fullname_lbl);
            this.groupBox2.Controls.Add(this.picture_pnl);
            this.groupBox2.Controls.Add(this.username_lbl);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(13, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 254);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sizin Hesap";
            // 
            // fullname_lbl
            // 
            this.fullname_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullname_lbl.AutoSize = true;
            this.fullname_lbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fullname_lbl.Location = new System.Drawing.Point(45, 202);
            this.fullname_lbl.Name = "fullname_lbl";
            this.fullname_lbl.Size = new System.Drawing.Size(142, 20);
            this.fullname_lbl.TabIndex = 8;
            this.fullname_lbl.Text = "My Awesome Name";
            this.fullname_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picture_pnl
            // 
            this.picture_pnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_pnl.BackgroundImage")));
            this.picture_pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_pnl.Location = new System.Drawing.Point(49, 27);
            this.picture_pnl.Name = "picture_pnl";
            this.picture_pnl.Size = new System.Drawing.Size(164, 163);
            this.picture_pnl.TabIndex = 7;
            // 
            // message_auto_complete_menu
            // 
            this.message_auto_complete_menu.Colors = ((autocompletemenu.Colors)(resources.GetObject("message_auto_complete_menu.Colors")));
            this.message_auto_complete_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.message_auto_complete_menu.ImageList = this.message_img_list;
            this.message_auto_complete_menu.Items = new string[0];
            this.message_auto_complete_menu.MinFragmentLength = 1;
            this.message_auto_complete_menu.TargetControlWrapper = null;
            // 
            // message_img_list
            // 
            this.message_img_list.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("message_img_list.ImageStream")));
            this.message_img_list.TransparentColor = System.Drawing.Color.Transparent;
            this.message_img_list.Images.SetKeyName(0, "icon23.png");
            // 
            // alphabet_cmbbx
            // 
            this.alphabet_cmbbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.alphabet_cmbbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alphabet_cmbbx.FormattingEnabled = true;
            this.alphabet_cmbbx.Items.AddRange(new object[] {
            "Default",
            "DefaultMclass0",
            "TurkishSingleShift",
            "UCS2"});
            this.alphabet_cmbbx.Location = new System.Drawing.Point(143, 419);
            this.alphabet_cmbbx.Name = "alphabet_cmbbx";
            this.alphabet_cmbbx.Size = new System.Drawing.Size(368, 28);
            this.alphabet_cmbbx.TabIndex = 23;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1292, 719);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.mainform_sttsstrp);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Pasifik Light";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainform_sttsstrp.ResumeLayout(false);
            this.mainform_sttsstrp.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button excelfile_btn;
        private System.Windows.Forms.Button addressbook_btn;
        private System.Windows.Forms.Label message_count_lbl;
        public System.Windows.Forms.TextBox phoneset_rchtxtbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clean_btn;
        private System.Windows.Forms.ComboBox sms_header_cmbbx;
        private System.Windows.Forms.Button sendsms_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label total_count_lbl;
        private System.Windows.Forms.Label total_undelivered_lbl;
        private System.Windows.Forms.Label total_delivered_lbl;
        private System.Windows.Forms.Label total_waiting_lbl;
        private System.Windows.Forms.Label mesajadedi_lbl;
        private System.Windows.Forms.Label line1_lbl;
        private System.Windows.Forms.Label bekleyen_lbl;
        private System.Windows.Forms.Label basarsiz_lbl;
        private System.Windows.Forms.Label basarli_lbl;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yenilemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem panelaGitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapMakinasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımdaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip mainform_sttsstrp;
        private System.Windows.Forms.ToolStripStatusLabel ready_tsslbl;
        private System.Windows.Forms.ToolStripStatusLabel pkt_balance_tsslbl;
        private System.Windows.Forms.ToolStripStatusLabel balance_tsslbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label fullname_lbl;
        private System.Windows.Forms.Panel picture_pnl;
        private System.Windows.Forms.CheckBox universal_chkbx;
        private System.Windows.Forms.Label period_lbl;
        private System.Windows.Forms.Label scheduled_delivery_time_lbl;
        private System.Windows.Forms.DateTimePicker scheduled_delivery_date_dtpckr;
        private System.Windows.Forms.ComboBox period_cmbbx;
        public System.Windows.Forms.TextBox message_rchtxtbx;
        private System.Windows.Forms.DateTimePicker scheduled_delivery_time_dtpckr;
        private autocompletemenu.AutocompleteMenu message_auto_complete_menu;
        private System.Windows.Forms.ImageList message_img_list;
        private System.Windows.Forms.Button sms_template_btn;
        private System.Windows.Forms.ComboBox alphabet_cmbbx;
    }
}