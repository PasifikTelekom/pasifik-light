using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using pasifiklib.core;

namespace pasifiklib.forms
{
    public partial class ReportForm : Form
    {
        private LinkLabel message_lnklbl = new LinkLabel();
        public ReportForm()
        {
            InitializeComponent();
            DataGridViewLinkColumn dgvlnklbl = new DataGridViewLinkColumn();
            dgvlnklbl.UseColumnTextForLinkValue = true;
            dgvlnklbl.LinkBehavior = LinkBehavior.HoverUnderline;
            dgvlnklbl.LinkColor = Color.AliceBlue;
            dgvlnklbl.TrackVisitedState = true;
            dgvlnklbl.Text = "Link";
            dgvlnklbl.UseColumnTextForLinkValue = true;
        }
        private List<GeneralReportGridView> GetGeneralReport(string start_date, string end_date)
        {
            GeneralReport GR = new GeneralReport(General.settings.username, General.settings.password, General.settings.host, General.settings.lang, start_date, end_date);
            string json = GR.execute();
            IList<IDictionary<string, object>> list_of_dict = new JavaScriptSerializer().Deserialize<IList<IDictionary<string, object>>>(json);
            List<GeneralReportGridView> GRGV_List = new List<GeneralReportGridView>();
            foreach (IDictionary<string, object> dict in list_of_dict)
            {
                GeneralReportGridView GRGV = new GeneralReportGridView(
                    Convert.ToInt32(dict["sms_id"]),
                    dict["sender"].ToString(),
                    Convert.ToDecimal(dict["cost"]),
                    dict["message"].ToString(),
                    DateTime.ParseExact(dict["created"].ToString(), "dd.MM.yyyy - HH:mm", System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToInt32(dict["count"]),
                    Convert.ToInt32(dict["waiting_count"]),
                    Convert.ToInt32(dict["delivered_count"]),
                    Convert.ToInt32(dict["undelivered_count"]),
                    Convert.ToBoolean(dict["succeeded"])
                    );
                GRGV_List.Add(GRGV);
            }
            return GRGV_List;
        }
        private void ReportForm_Load(object sender, EventArgs e)
        {
            string start_date = DateTime.Today.ToString("dd.MM.yyyy");
            string end_date = DateTime.Today.AddDays(1).ToString("dd.MM.yyyy");
            dataGridView1.DataSource = GetGeneralReport(start_date, end_date);
            start_date_dttmpkr.Value = DateTime.Today;
            end_date_dttmpkr.Value = DateTime.Today.AddDays(1);
        }

        private void filter_btn_Click(object sender, EventArgs e)
        {
            string start_date = start_date_dttmpkr.Value.ToString("dd.MM.yyyy");
            string end_date = end_date_dttmpkr.Value.ToString("dd.MM.yyyy");
            dataGridView1.DataSource = GetGeneralReport(start_date, end_date);
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
