using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pasifiklib.core;
using pasifiklib;
using System.Web.Script.Serialization;

namespace pasifiklib.forms
{
    public partial class LoginForm : Form
    {
        MainForm MF = null;
        bool AllowEnter = false;
        public LoginForm(MainForm MF)
        {
            this.MF = MF;
            InitializeComponent();
            PlaceHolder.SendMessage(username_txtbx.Handle, PlaceHolder.EM_SETCUEBANNER, 0, " Kullanıcı adı");
            PlaceHolder.SendMessage(password_txtbx.Handle, PlaceHolder.EM_SETCUEBANNER, 0, " Şifre");
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            General.settings.username = username_txtbx.Text.Trim();
            General.settings.password = password_txtbx.Text;
            GetSettings get_settings = new GetSettings(General.settings.username, General.settings.password, General.settings.host, General.settings.lang);
            string data = get_settings.execute();
            if (get_settings.Is_Passed)
            {
                AllowEnter = true;
                General.user = new JavaScriptSerializer().DeserializeObject(data) as IDictionary<string, object>;
                SMSHeaders SH = new SMSHeaders(General.settings.username, General.settings.password, General.settings.host, General.settings.lang);
                string data1 = SH.execute();
                General.headers = new JavaScriptSerializer().Deserialize<IList<string>>(data1);
                //Console.WriteLine(General.headers);
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya Şifre hata!", data, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!AllowEnter)
                Application.Exit();
        }
    }
}
