using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using pasifiklib.core;

namespace pasifiklib
{
    public abstract class PasifikBase{
        private string username;
        private string password;
        private string host;
        private string lang;

        public string Username { get { return this.username; } set { this.username = value; } }
        public string Password { get { return this.password; } set { this.password = value; } }
        public string Host { get { return this.host; } set { this.host = value; } }
        public string Lang { get { return this.lang; } set { this.lang = value; } }
        public bool Is_Passed { get; set; }
        public PasifikBase(string username, string password, string host, string lang)
        {
            this.username = username;
            this.password = password;
            this.host = host;
            this.lang = lang;
        }
        public abstract string execute();

    }
    public class SendSMS : PasifikBase
    {
        private string sender;
        private string message;
        private string msisdn_list;
        private string alphabet;
        private bool universal;
        private string scheduled_delivery_time;
        private string period;
        private int level;

        public string Sender { get { return this.sender; } set { this.sender = value; } }
        public string Message { get { return this.message; } set { this.message = value; } }
        public string Msisdn_list { get { return this.msisdn_list; } set { this.msisdn_list = value; } }

        public SendSMS(string username, string password, string host, string lang, string sender, string message, string msisdn_list)
            : base(username, password, host, lang)
        {
            this.sender = sender;
            this.message = message;
            this.msisdn_list = msisdn_list;
            this.level = 1;
        }
        public SendSMS(string username, string password, string host, string lang, string sender, string message, string msisdn_list, string alphabet, bool universal)
            : base(username, password, host, lang)
        {
            this.sender = sender;
            this.message = message;
            this.msisdn_list = msisdn_list;
            this.alphabet = alphabet;
            this.universal = universal;
            this.level = 2;
        }
        public SendSMS(string username, string password, string host, string lang, string sender, string message, string msisdn_list, string alphabet, bool universal, string scheduled_delivery_time, string period)
            : base(username, password, host, lang)
        {
            this.sender = sender;
            this.message = message;
            this.msisdn_list = msisdn_list;
            this.alphabet = alphabet;
            this.universal = universal;
            this.scheduled_delivery_time = scheduled_delivery_time;
            this.period = period;
            this.level = 3;
        }

        public override string execute()
        {
            string data = "";
            try
            {
                string json = "";
                switch (level)
                {
                    case 1:
                        json = string.Format(
                            "{{ \"username\": \"{0}\", \"password\": \"{1}\", \"sender\": \"{2}\", \"message\": \"{3}\", \"msisdn_list\": \"{4}\", \"name\": \"C1\" }}",
                            this.Username, this.Password, this.sender, Utils.EscapeStringValue(this.message), this.msisdn_list);
                        break;
                    case 2:
                        json = string.Format(
                            "{{ \"username\": \"{0}\", \"password\": \"{1}\", \"sender\": \"{2}\", \"message\": \"{3}\", \"msisdn_list\": \"{4}\", \"alphabet\": \"{5}\", \"universal\": {6}, \"name\": \"C1\" }}",
                            this.Username, this.Password, this.sender, Utils.EscapeStringValue(this.message), this.msisdn_list, this.alphabet, this.universal.ToString().ToLower());
                        break;
                    case 3:
                        json = string.Format(
                            "{{ \"username\": \"{0}\", \"password\": \"{1}\", \"sender\": \"{2}\", \"message\": \"{3}\", \"msisdn_list\": \"{4}\", \"alphabet\": \"{5}\", \"universal\": {6},  \"scheduled_delivery_time\": \"{7}\", \"period\": \"{8}\", \"name\": \"C1\" }}",
                            this.Username, this.Password, this.sender, Utils.EscapeStringValue(this.message), this.msisdn_list, this.alphabet, this.universal.ToString().ToLower(), this.scheduled_delivery_time, this.period);
                        break;
                }
                
                string url = string.Format("http://{0}/{1}/api/sendsms/", this.Host, this.Lang);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.ContentType = "application/json; charset=UTF=8";
                request.Accept = "application/json";
                //request.ContentLength = json.Length;
                request.Method = "POST";
                Stream requestStream = request.GetRequestStream();
                //requestStream.Write(Encoding.UTF8.GetBytes(json), 0, json.Length);
                byte[] sss = Encoding.UTF8.GetBytes(json);
                requestStream.Write(sss, 0, sss.Length);
                requestStream.Close();
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    Stream responseStream = response.GetResponseStream();
                    data = new StreamReader(responseStream).ReadToEnd();
                    this.Is_Passed = true;
                }
            }
            catch (WebException e)
            {
                using (HttpWebResponse response = (HttpWebResponse)e.Response)
                {
                    Stream responseStream = response.GetResponseStream();
                    data = new StreamReader(responseStream).ReadToEnd();
                    this.Is_Passed = false;
                }
            }
            return data;
        }
    }
    public class Msisdn
    {
        public string number { get; set; }
        public string message { get; set; }
        public Msisdn(string number, string message)
        {
            this.number = number;
            this.message = message;
        }
    }
    public class SendSMSCustom : PasifikBase
    {
        private string sender;
        private List<Msisdn> msisdn;
        private string alphabet;
        private bool universal;
        private string scheduled_delivery_time;
        private string period;
        private int level;
        public SendSMSCustom(string username, string password, string host, string lang, string sender, List<Msisdn> msisdn)
            : base(username, password, host, lang)
        {
            this.sender = sender;
            this.msisdn = msisdn;
            this.level = 1;
        }
        public SendSMSCustom(string username, string password, string host, string lang, string sender, List<Msisdn> msisdn, string alphabet, bool universal)
            : base(username, password, host, lang)
        {
            this.sender = sender;
            this.msisdn = msisdn;
            this.alphabet = alphabet;
            this.universal = universal;
            this.level = 2;
        }
        public SendSMSCustom(string username, string password, string host, string lang, string sender, List<Msisdn> msisdn, string alphabet, bool universal, string scheduled_delivery_time, string period)
            : base(username, password, host, lang)
        {
            this.sender = sender;
            this.msisdn = msisdn;
            this.alphabet = alphabet;
            this.universal = universal;
            this.scheduled_delivery_time = scheduled_delivery_time;
            this.period = period;
            this.level = 3;
        }

        private string msisdn_builder()
        {
            string data_raw = "[";
            foreach (var item in this.msisdn)
            {
                data_raw += string.Format("{{\"number\": \"{0}\",\"message\": \"{1}\"}},", item.number, Utils.EscapeStringValue(item.message));
            }
            data_raw = data_raw.Remove(data_raw.Length - 1);//Delete last char of string
            data_raw += "]";
            Console.WriteLine(data_raw);
            return data_raw;
        }
        public override string execute()
        {
            string data = "";
            try
            {
                string json = "";
                switch (level)
                {
                    case 1:
                        json = string.Format(
                            "{{ \"username\": \"{0}\", \"password\": \"{1}\", \"sender\": \"{2}\", \"msisdn\": {3}, \"name\": \"C2\" }}",
                            this.Username, this.Password, this.sender, this.msisdn_builder());
                        break;
                    case 2:
                        json = string.Format(
                            "{{ \"username\": \"{0}\", \"password\": \"{1}\", \"sender\": \"{2}\", \"msisdn\": {3}, \"alphabet\": \"{4}\", \"universal\": {5}, \"name\": \"C2\" }}",
                            this.Username, this.Password, this.sender, this.msisdn_builder(), this.alphabet, this.universal.ToString().ToLower());
                        break;
                    case 3:
                        json = string.Format(
                            "{{ \"username\": \"{0}\", \"password\": \"{1}\", \"sender\": \"{2}\", \"msisdn\": {3}, \"alphabet\": \"{4}\", \"universal\": {5},  \"scheduled_delivery_time\": \"{6}\", \"period\": \"{7}\", \"name\": \"C2\" }}",
                            this.Username, this.Password, this.sender, this.msisdn_builder(), this.alphabet, this.universal.ToString().ToLower(), this.scheduled_delivery_time, this.period);
                        break;
                }
                string url = string.Format("http://{0}/{1}/api/sendsms/custom/", this.Host, this.Lang);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.ContentType = "application/json; charset=UTF=8";
                request.Accept = "application/json";
                //request.ContentLength = json.Length;
                request.Method = "POST";
                Stream requestStream = request.GetRequestStream();
                //requestStream.Write(Encoding.UTF8.GetBytes(json), 0, json.Length);
                byte[] sss = Encoding.UTF8.GetBytes(json);
                requestStream.Write(sss, 0, sss.Length);
                requestStream.Close();
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    Stream responseStream = response.GetResponseStream();
                    data = new StreamReader(responseStream, Encoding.UTF8).ReadToEnd();
                    this.Is_Passed = true;
                }
            }
            catch (WebException e)
            {
                using (HttpWebResponse response = (HttpWebResponse)e.Response)
                {
                    Stream responseStream = response.GetResponseStream();
                    data = new StreamReader(responseStream, Encoding.UTF8).ReadToEnd();
                    this.Is_Passed = false;
                }
            }
            return data;
        }
    }
    public class GeneralReport : PasifikBase
    {
        private string start_date;
        private string end_date;
        public GeneralReport(string username, string password, string host, string lang, string start_date, string end_date)
            : base(username, password, host, lang)
        {
            this.start_date = start_date;
            this.end_date = end_date;
        }
        public override string execute()
        {
            string data = "";
            try
            {
                string json = string.Format("{{ \"username\": \"{0}\", \"password\": \"{1}\" , \"start_date\": \"{2}\", \"end_date\": \"{3}\" }}", this.Username, this.Password, this.start_date, this.end_date);
                string url = string.Format("http://{0}/{1}/api/generalreport/", this.Host, this.Lang);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.ContentType = "application/json; charset=UTF=8";
                request.Accept = "application/json";
                request.ContentLength = json.Length;
                request.Method = "POST";
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(Encoding.UTF8.GetBytes(json), 0, json.Length);
                requestStream.Close();
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    Stream responseStream = response.GetResponseStream();
                    data = new StreamReader(responseStream).ReadToEnd();
                    this.Is_Passed = true;
                }
            }
            catch (WebException e)
            {
                using (HttpWebResponse response = (HttpWebResponse)e.Response)
                {
                    Stream responseStream = response.GetResponseStream();
                    data = new StreamReader(responseStream).ReadToEnd();
                    this.Is_Passed = false;
                }
            }
            return data;
        }
    }
    public class GeneralReportID : PasifikBase
    {
        private string sms_id;
        public GeneralReportID(string username, string password, string host, string lang, string sms_id)
            : base(username, password, host, lang)
        {
            this.sms_id = sms_id;
        }
        public override string execute()
        {
            throw new NotImplementedException();
        }
    }
    public class DetailedReport : PasifikBase
    {
        private string sms_id;
        public DetailedReport(string username, string password, string host, string lang, string sms_id)
            : base(username, password, host, lang)
        {
            this.sms_id = sms_id;
        }
        public override string execute()
        {
            throw new NotImplementedException();
        }
    }
    public class AddressBook : PasifikBase
    {
        private string search;
        public AddressBook(string username, string password, string host, string lang, string search)
            : base(username, password, host, lang)
        {
            this.search = search;
        }
        public override string execute()
        {
            string data = "";
            try
            {
                string json = string.Format("{{ \"username\": \"{0}\", \"password\": \"{1}\" , \"search\": \"{2}\" }}", this.Username, this.Password, this.search);
                string url = string.Format("http://{0}/{1}/api/addressbook/", this.Host, this.Lang);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.ContentType = "application/json; charset=UTF=8";
                request.Accept = "application/json";
                //request.ContentLength = json.Length;
                request.Method = "POST";
                Stream requestStream = request.GetRequestStream();
                //requestStream.Write(Encoding.UTF8.GetBytes(json), 0, json.Length);
                byte[] sss = Encoding.UTF8.GetBytes(json);
                requestStream.Write(sss, 0, sss.Length);
                requestStream.Close();
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    Stream responseStream = response.GetResponseStream();
                    data = new StreamReader(responseStream).ReadToEnd();
                    this.Is_Passed = true;
                }
            }
            catch (WebException e)
            {
                using (HttpWebResponse response = (HttpWebResponse)e.Response)
                {
                    Stream responseStream = response.GetResponseStream();
                    data = new StreamReader(responseStream).ReadToEnd();
                    this.Is_Passed = false;
                }
            }
            return data;
        }
    }
    public class SMSTemplates : PasifikBase
    {
        public SMSTemplates(string username, string password, string host, string lang) : base(username, password, host, lang) { }
        public override string execute()
        {
            string data = "";
            try
            {
                string json = string.Format("{{ \"username\": \"{0}\", \"password\": \"{1}\" }}", this.Username, this.Password);
                string url = string.Format("http://{0}/{1}/api/smstemplates/", this.Host, this.Lang);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.ContentType = "application/json; charset=UTF=8";
                request.Accept = "application/json";
                request.ContentLength = json.Length;
                request.Method = "POST";
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(Encoding.UTF8.GetBytes(json), 0, json.Length);
                requestStream.Close();
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    Stream responseStream = response.GetResponseStream();
                    data = new StreamReader(responseStream).ReadToEnd();
                    this.Is_Passed = true;
                }
            }
            catch (WebException e)
            {
                using (HttpWebResponse response = (HttpWebResponse)e.Response)
                {
                    Stream responseStream = response.GetResponseStream();
                    data = new StreamReader(responseStream).ReadToEnd();
                    this.Is_Passed = false;
                }
            }
            return data;
        }
    }
    public class SMSHeaders : PasifikBase
    {
        public SMSHeaders(string username, string password, string host, string lang) : base(username, password, host, lang) { }
        public override string execute()
        {
            string data = "";
            try
            {
                string json = string.Format("{{ \"username\": \"{0}\", \"password\": \"{1}\" }}", this.Username, this.Password);
                string url = string.Format("http://{0}/{1}/api/smsheaders/", this.Host, this.Lang);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.ContentType = "application/json; charset=UTF=8";
                request.Accept = "application/json";
                request.ContentLength = json.Length;
                request.Method = "POST";
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(Encoding.UTF8.GetBytes(json), 0, json.Length);
                requestStream.Close();
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    Stream responseStream = response.GetResponseStream();
                    data = new StreamReader(responseStream).ReadToEnd();
                    this.Is_Passed = true;
                }
            }
            catch (WebException e)
            {
                using (HttpWebResponse response = (HttpWebResponse)e.Response)
                {
                    Stream responseStream = response.GetResponseStream();
                    data = new StreamReader(responseStream).ReadToEnd();
                    this.Is_Passed = false;
                }
            }
            return data;
        }
    }
    public class GetSettings : PasifikBase
    {
        public GetSettings(string username, string password, string host, string lang) : base(username, password, host, lang) { }
        public override string execute()
        {
            string data = "";
            try
            {
                string json = string.Format("{{ \"username\": \"{0}\", \"password\": \"{1}\" }}", this.Username, this.Password);
                string url = string.Format("http://{0}/{1}/api/getsettings/", this.Host, this.Lang);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.ContentType = "application/json; charset=UTF=8";
                request.Accept = "application/json";
                //request.ContentLength = json.Length;
                request.Method = "POST";
                Stream requestStream = request.GetRequestStream();
                //requestStream.Write(Encoding.UTF8.GetBytes(json), 0, json.Length);
                byte[] sss = Encoding.UTF8.GetBytes(json);
                requestStream.Write(sss, 0, sss.Length);
                requestStream.Close();
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    Stream responseStream = response.GetResponseStream();
                    data = new StreamReader(responseStream).ReadToEnd();
                    this.Is_Passed = true;
                }
            }
            catch(WebException e)
            {
                using (HttpWebResponse response = (HttpWebResponse)e.Response)
                {
                    Stream responseStream = response.GetResponseStream();
                    data = new StreamReader(responseStream).ReadToEnd();
                    this.Is_Passed = false;
                }
            }
            return data;
        }
    }
}
