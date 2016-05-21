using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pasifiklib;
using pasifiklib.core;
using System.Diagnostics;
using System.Web.Script.Serialization;
using System.Web.UI.WebControls;
using autocompletemenu;

namespace pasifiklib.forms
{
    public partial class MainForm : Form
    {
        public bool Is_SMSCustom = false;
        public string ExcelFileName = "";
        public int ExcelPhoneColumn = 0;
        public string[] GSM_Array = null;

        public void AutoCompleteMenu_Builter()
        {
            //message_img_list.Images.SetKeyName(0, "Resource/img/icon23.png");
            message_auto_complete_menu.MaximumSize = new Size(250, 200);
            var columnWidth = new int[] { 50, 200 };
            TemplateMaker TM = new TemplateMaker(this.ExcelFileName);
            Dictionary<string, string> TemplateDict = TM.Export();
            foreach (KeyValuePair<string, string> item in TemplateDict)
            {
                message_auto_complete_menu.AddItem(new MulticolumnAutocompleteItem(new[] { item.Key, item.Value }, item.Key) { ColumnWidth = columnWidth, ImageIndex = 0});
            }
        }
        public void refresh_items(){
            GetSettings get_settings = new GetSettings(General.settings.username, General.settings.password, General.settings.host, General.settings.lang);
            string data = get_settings.execute();
            General.user = new JavaScriptSerializer().DeserializeObject(data) as IDictionary<string, object>;
            SMSHeaders SH = new SMSHeaders(General.settings.username, General.settings.password, General.settings.host, General.settings.lang);
            string data1 = SH.execute();
            General.headers = new JavaScriptSerializer().Deserialize<IList<string>>(data1);
            if (General.user != null)
            {
                fullname_lbl.Text = General.user["fullname"].ToString();
                username_lbl.Text = General.user["username"].ToString();
                total_waiting_lbl.Text = General.user["waiting_all"].ToString();
                total_delivered_lbl.Text = General.user["delivered_all"].ToString();
                total_undelivered_lbl.Text = General.user["undelivered_all"].ToString();
                total_count_lbl.Text = General.user["count_all"].ToString();
                pkt_balance_tsslbl.Text = string.Format("{0} SMS, {1} TELEFON", General.user["sms_balance_pkt"].ToString(), General.user["tel_balance_pkt"].ToString());
                balance_tsslbl.Text = string.Format("{0} {1} BAKİYE", General.user["balance"].ToString(), General.user["currency"].ToString());
                try
                {
                    var Pbox = new PictureBox();
                    Pbox.Load(string.Format("http://{0}/media/profile_pictures/{1}.jpg", General.settings.host, General.user["username"].ToString()));
                    picture_pnl.BackgroundImage = Pbox.Image;
                }
                catch { }
                sms_header_cmbbx.DataSource = General.headers;
            }
            message_rchtxtbx.Text = phoneset_rchtxtbx.Text = "";
            mainform_sttsstrp.BackColor = SystemColors.Highlight;
            this.phoneset_rchtxtbx.ReadOnly = false;
            ready_tsslbl.Text = "Ready";
            this.Is_SMSCustom = false;
            this.ExcelFileName = "";
            this.ExcelPhoneColumn = 0;
            this.GSM_Array = null;
            this.message_auto_complete_menu.RemoveItems();
        }
        public MainForm()
        {
            LoginForm LF = new LoginForm(this);
            LF.ShowDialog();
            InitializeComponent();
            scheduled_delivery_date_dtpckr.Format = DateTimePickerFormat.Custom;
            scheduled_delivery_date_dtpckr.CustomFormat = "dd.MM.yyyy";
            scheduled_delivery_time_dtpckr.Format = DateTimePickerFormat.Time;
            scheduled_delivery_time_dtpckr.CustomFormat = "hh:mm";
            period_cmbbx.DataSource = new BindingSource(Utils.period_dict.Reverse(), null);
            period_cmbbx.DisplayMember = "Value";
            period_cmbbx.ValueMember = "Key";
            alphabet_cmbbx.DataSource = new BindingSource(Utils.alphabet_dic, null);
            alphabet_cmbbx.DisplayMember = "Key";
            alphabet_cmbbx.ValueMember = "Value";
            if (General.user != null)
            {
                fullname_lbl.Text = General.user["fullname"].ToString();
                username_lbl.Text = General.user["username"].ToString();
                total_waiting_lbl.Text = General.user["waiting_all"].ToString();
                total_delivered_lbl.Text = General.user["delivered_all"].ToString();
                total_undelivered_lbl.Text = General.user["undelivered_all"].ToString();
                total_count_lbl.Text = General.user["count_all"].ToString();
                pkt_balance_tsslbl.Text = string.Format("{0} SMS, {1} TELEFON", General.user["sms_balance_pkt"].ToString(), General.user["tel_balance_pkt"].ToString());
                balance_tsslbl.Text = string.Format("{0} {1} BAKİYE", General.user["balance"].ToString(), General.user["currency"].ToString());
                try
                {
                    var Pbox = new PictureBox();
                    Pbox.Load(string.Format("http://{0}/media/profile_pictures/{1}.jpg", General.settings.host, General.user["username"].ToString()));
                    picture_pnl.BackgroundImage = Pbox.Image;
                }
                catch { }
                sms_header_cmbbx.DataSource = General.headers;
            }
        }

        private void message_rchtxtbx_TextChanged(object sender, EventArgs e)
        {
            int message_length = message_rchtxtbx.Text.Length;
            int message_n = Utils.sms_count_calc(message_rchtxtbx.Text, this.alphabet_cmbbx.SelectedValue.ToString()); //message_length <= 160 ? 1 : Convert.ToInt32(Math.Ceiling(message_length / 153.0));
            message_count_lbl.Text = string.Format("Karakter sayısı: {0} / 612. SMS sayısı: {1} / 4", message_length, message_n);
        }

        private void hesapMakinasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }

        private void panelaGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo nfo = new ProcessStartInfo("http://pasifiktelekom.com.tr");
            nfo.UseShellExecute = true;
            Process.Start(nfo);
        }

        private void clean_btn_Click(object sender, EventArgs e)
        {
            message_rchtxtbx.Text = phoneset_rchtxtbx.Text = "";
            mainform_sttsstrp.BackColor = SystemColors.Highlight;
            this.phoneset_rchtxtbx.ReadOnly = false;
            ready_tsslbl.Text = "Ready";
            this.Is_SMSCustom = false;
            this.ExcelFileName = "";
            this.ExcelPhoneColumn = 0;
            this.GSM_Array = null;
            this.message_auto_complete_menu.RemoveItems();
        }

        private void sendsms_btn_Click(object sender, EventArgs e)
        {
            if (sms_header_cmbbx.Text == "")
            {
                mainform_sttsstrp.BackColor = ColorTranslator.FromHtml("#e74c3c");//SystemColors.Highlight;
                ready_tsslbl.Text = "SMS başlık yok :(";
            }
            else if (message_rchtxtbx.Text == "")
            {
                mainform_sttsstrp.BackColor = ColorTranslator.FromHtml("#e74c3c");//SystemColors.Highlight;
                ready_tsslbl.Text = "SMS mesaj yok :(";
            }
            else if (phoneset_rchtxtbx.Text == "")
            {
                mainform_sttsstrp.BackColor = ColorTranslator.FromHtml("#e74c3c");//SystemColors.Highlight;
                ready_tsslbl.Text = "Telefon numara yok :(";
            }
            else
            {
                string response_data = "";
                string[] phone_list = phoneset_rchtxtbx.Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
                phone_list = Utils.clean_phone_list(phone_list);
                string phone_numbers = string.Join(",", phone_list);
                var confirmResult = MessageBox.Show("Eğer sms göndermek için emin misiniz?", 
                "SMS Gönder",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    //DateTime scheduled_delivery_datetime = scheduled_delivery_date_dtpckr.Value.Date + scheduled_delivery_time_dtpckr.Value.TimeOfDay;
                    DateTime scheduled_delivery_datetime = new DateTime(
                       scheduled_delivery_date_dtpckr.Value.Year,
                       scheduled_delivery_date_dtpckr.Value.Month,
                       scheduled_delivery_date_dtpckr.Value.Day,
                       scheduled_delivery_time_dtpckr.Value.Hour,
                       scheduled_delivery_time_dtpckr.Value.Minute,
                       scheduled_delivery_time_dtpckr.Value.Second
                       );
                    DateTime datetime_now = DateTime.Now;
                    string alphabet = alphabet_cmbbx.SelectedValue.ToString();
                    bool universal = universal_chkbx.Checked;
                    if (this.Is_SMSCustom)
                    {
                        SendSMSCustom send_sms_custom = null;
                        EnvelopeMaker env_mak = new EnvelopeMaker(this.ExcelFileName, this.ExcelPhoneColumn, this.message_rchtxtbx.Text, this.GSM_Array);
                        List<Msisdn> msisdn_set = env_mak.execute();
                        if (scheduled_delivery_datetime > datetime_now)
                        {
                            send_sms_custom = new SendSMSCustom(General.settings.username, General.settings.password,
                                General.settings.host, General.settings.lang,sms_header_cmbbx.Text, msisdn_set, alphabet, universal,
                                scheduled_delivery_datetime.ToString("yyyy-MM-ddTHH:MM:ssZ"), period_cmbbx.SelectedValue.ToString());
                            response_data = send_sms_custom.execute();
                        }
                        else
                        {
                            send_sms_custom = new SendSMSCustom(General.settings.username, General.settings.password,
                                General.settings.host, General.settings.lang, sms_header_cmbbx.Text, msisdn_set, alphabet, universal,
                                datetime_now.ToString("yyyy-MM-ddTHH:MM:ssZ"), period_cmbbx.SelectedValue.ToString());
                            response_data = send_sms_custom.execute();
                        }
                        IDictionary<string, object> response_dict = new JavaScriptSerializer().DeserializeObject(response_data) as IDictionary<string, object>;
                        this.message_rchtxtbx.Text = this.phoneset_rchtxtbx.Text = "";
                        this.Is_SMSCustom = false;
                        this.ExcelFileName = "";
                        this.ExcelPhoneColumn = 0;
                        this.GSM_Array = null;
                        this.message_auto_complete_menu.RemoveItems();
                        if (send_sms_custom.Is_Passed)
                        {
                            mainform_sttsstrp.BackColor = ColorTranslator.FromHtml("#2ecc71");
                            ready_tsslbl.Text = string.Format("{0} SMS başarıyla gönderildi, ID {1}", response_dict["response_status_code"], response_dict["response_message_id"]);
                        }
                        else
                        {
                            mainform_sttsstrp.BackColor = ColorTranslator.FromHtml("#e74c3c");
                            try { ready_tsslbl.Text = string.Format("{0} {1}", response_dict["response_status_code"], response_dict["response_status_description"]); }
                            catch { ready_tsslbl.Text = string.Format("{0}", response_dict["detail"]);}
                            
                        }
                    }
                    else
                    {
                        SendSMS send_sms = null;
                        if (scheduled_delivery_datetime > datetime_now)
                        {
                            send_sms = new SendSMS(General.settings.username, General.settings.password,
                                General.settings.host, General.settings.lang, sms_header_cmbbx.Text, message_rchtxtbx.Text,
                                phone_numbers, alphabet, universal, scheduled_delivery_datetime.ToString("yyyy-MM-ddTHH:MM:ssZ"), period_cmbbx.SelectedValue.ToString());
                            response_data = send_sms.execute();
                        }
                        else
                        {
                            send_sms = new SendSMS(General.settings.username, General.settings.password,
                                General.settings.host, General.settings.lang, sms_header_cmbbx.Text, message_rchtxtbx.Text,
                                phone_numbers, alphabet, universal, datetime_now.ToString("yyyy-MM-ddTHH:MM:ssZ"), period_cmbbx.SelectedValue.ToString());
                            response_data = send_sms.execute();
                        }
                        IDictionary<string, object> response_dict = new JavaScriptSerializer().DeserializeObject(response_data) as IDictionary<string, object>;
                        this.message_rchtxtbx.Text = this.phoneset_rchtxtbx.Text = "";
                        this.Is_SMSCustom = false;
                        this.ExcelFileName = "";
                        this.ExcelPhoneColumn = 0;
                        this.GSM_Array = null;
                        this.message_auto_complete_menu.RemoveItems();
                        if (send_sms.Is_Passed)
                        {
                            mainform_sttsstrp.BackColor = ColorTranslator.FromHtml("#2ecc71");
                            ready_tsslbl.Text = string.Format("{0} SMS başarıyla gönderildi, ID {1}", response_dict["response_status_code"], response_dict["response_message_id"]);
                        }
                        else
                        {
                            mainform_sttsstrp.BackColor = ColorTranslator.FromHtml("#e74c3c");
                            try { ready_tsslbl.Text = string.Format("{0} {1}", response_dict["response_status_code"], response_dict["response_status_description"]); }
                            catch { ready_tsslbl.Text = string.Format("{0}", response_dict["detail"]); }
                        }
                    }
                }
            }
        }

        private void excelfile_btn_Click(object sender, EventArgs e)
        {
            ExcelFileForm EFF = new ExcelFileForm(this);
            EFF.ShowDialog();
        }

        private void addressbook_btn_Click(object sender, EventArgs e)
        {
            AddressbookForm ABF = new AddressbookForm(this);
            ABF.ShowDialog();
        }

        private void raporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm RF = new ReportForm();
            RF.ShowDialog();
        }

        private void yenilemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refresh_items();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (message_rchtxtbx.Text.Length > 0 || phoneset_rchtxtbx.Text.Length > 0)
            {
                var confirmMessage = MessageBox.Show("Çıkmak ister misiniz?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmMessage == System.Windows.Forms.DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void hakkımdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm AF = new AboutForm();
            AF.ShowDialog();
        }

        private void sms_template_btn_Click(object sender, EventArgs e)
        {
            SMSTemplatesForm STF = new SMSTemplatesForm(this);
            STF.ShowDialog();
        }
    }
}
