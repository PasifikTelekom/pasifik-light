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
using System.Web.Script.Serialization;

namespace pasifiklib.forms
{
    public partial class SMSTemplatesForm : Form
    {
        MainForm MF = null;
        public SMSTemplatesForm(MainForm MF)
        {
            this.MF = MF;
            InitializeComponent();
        }

        private void SMSTemplatesForm_Load(object sender, EventArgs e)
        {
            SMSTemplates ST = new SMSTemplates(General.settings.username, General.settings.password, General.settings.host, General.settings.lang);
            string data = ST.execute();
            IList<IDictionary<string, object>> list_of_dict = new JavaScriptSerializer().Deserialize<IList<IDictionary<string, object>>>(data);
            int i = 0;
            foreach (IDictionary<string, object> item in list_of_dict)
            {
                sms_template_lstbx.Items.Insert(i, item["message"].ToString());
                i++;
            }
        }

        private void sms_template_lstbx_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.sms_template_lstbx.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                //MessageBox.Show(index.ToString());
                //do your stuff here
                this.MF.message_rchtxtbx.Text = sms_template_lstbx.SelectedItem.ToString();
                this.Close();
            }
        }
    }
}
