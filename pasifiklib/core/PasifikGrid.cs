using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pasifiklib.core
{
    public class GeneralReportGridView
    {
        [DisplayName("Mesaj ID")]
        public int sms_id { get; set; }
        [DisplayName("Mesaj Başlık")]
        public string sender { get; set; }
        [DisplayName("Fiyat")]
        public decimal cost { get; set; }
        [DisplayName("Mesaj Metni")]
        public string message { get; set; }
        [DisplayName("Gönderim Tarihi")]
        public DateTime created { get; set; }
        [DisplayName("Mesaj Adedi")]
        public int count { get; set; }
        [DisplayName("Bekleyen")]
        public int waiting_count { get; set; }
        [DisplayName("Başarılı")]
        public int delivered_count { get; set; }
        [DisplayName("Başarısız")]
        public int undelivered_count { get; set; }
        [DisplayName("Gönderilen")]
        public bool succeeded { get; set; }
        public GeneralReportGridView(int sms_id, string sender, decimal cost, string message, 
            DateTime created, int count, int waiting_count, int delivered_count, int undelivered_count, bool succeeded)
        {
            this.sms_id = sms_id;
            this.sender = sender;
            this.cost = cost;
            this.message = message;
            this.created = created;
            this.count = count;
            this.waiting_count = waiting_count;
            this.delivered_count = delivered_count;
            this.undelivered_count = undelivered_count;
            this.succeeded = succeeded;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
