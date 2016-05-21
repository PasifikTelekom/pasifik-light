using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pasifiklib;
using Excel = Microsoft.Office.Interop.Excel;
using System.Collections; 

namespace pasifiklib.core
{
    public class EnvelopeMaker
    {
        public string ExcelFileName {get;set;}
        public int ExcelPhoneColumn { get; set; }
        public string MessageTemplate { get; set; }
        public string[] GSM_Array { get; set; }

        public EnvelopeMaker(string ExcelFileName, int ExcelPhoneColumn, string MessageTemplate, string[] GSM_Array) {
            this.ExcelFileName = ExcelFileName;
            this.ExcelPhoneColumn = ExcelPhoneColumn;
            this.MessageTemplate = MessageTemplate;
            this.GSM_Array = GSM_Array;
        }

        public List<Msisdn> execute()
        {
            List<Msisdn> Envelopes = new List<Msisdn>();
            List<string> Table_Header = new List<string>();
            Dictionary<int, string> Exp_Table_Header = new Dictionary<int, string>();
            string Right_Message = "";
            if (this.ExcelFileName != "")
            {
                Excel.Application xlapp = new Excel.Application();
                Excel.Workbook xlwb = xlapp.Workbooks.Open(this.ExcelFileName);
                Excel.Worksheet xlws = (Excel.Worksheet)xlwb.Worksheets.get_Item(1);
                Excel.Range range = xlws.UsedRange;

                // Add Header to Table_Header array
                foreach (int i in Enumerable.Range(1, range.Columns.Count))
                {
                    Table_Header.Add(Convert.ToString((range.Cells[1, i] as Excel.Range).Value2));
                }

                // Add Expression to Exp_Table_Header Dictionary
                int Y = 0;
                foreach (var item in Table_Header)
                {
                    Exp_Table_Header[Y] = string.Format("[c{0}:{1}]",Y, item);
                    Y += 1;
                }
                foreach (int i in Enumerable.Range(1, range.Rows.Count))
                {
                    Right_Message = this.MessageTemplate;
                    foreach (KeyValuePair<int, string> item in Exp_Table_Header)
                    {
                        int K = item.Key;
                        string V = item.Value;
                        Right_Message = Right_Message.Replace(V, Convert.ToString((range.Cells[i, K + 1] as Excel.Range).Value2));
                    }
                    string number = Convert.ToString((range.Cells[i, this.ExcelPhoneColumn] as Excel.Range).Value2);
                    string gsm_num = "";
                    if (Utils.is_number(number))
                        gsm_num = Utils.clean_phone(number);
                    else
                        continue;
                    int pos = Array.IndexOf(this.GSM_Array, gsm_num);
                    if(pos > -1){
                        Msisdn msisdn = new Msisdn(gsm_num, Right_Message);
                        Envelopes.Add(msisdn);
                    }
                }
                xlwb.Close(true, null, null);
                xlapp.Quit();

                ReleaseOBJ.releaseObject(xlws);
                ReleaseOBJ.releaseObject(xlwb);
                ReleaseOBJ.releaseObject(xlapp);
            }
            return Envelopes;
        }
    }
    public class TemplateMaker
    {
        private string excel_file_name;
        public TemplateMaker(string ExcelFileName)
        {
            this.excel_file_name = ExcelFileName;
        }
        public Dictionary<string, string> Export()
        {
            Dictionary<string, string> TemplateDict = new Dictionary<string, string>();

            List<string> Table_Header = new List<string>();
            if (this.excel_file_name != "")
            {
                Excel.Application xlapp = new Excel.Application();
                Excel.Workbook xlwb = xlapp.Workbooks.Open(this.excel_file_name);
                Excel.Worksheet xlws = (Excel.Worksheet)xlwb.Worksheets.get_Item(1);
                Excel.Range range = xlws.UsedRange;

                // Add Header to Table_Header array
                foreach (int i in Enumerable.Range(1, range.Columns.Count))
                {
                    Table_Header.Add(Convert.ToString((range.Cells[1, i] as Excel.Range).Value2));
                }
                // Add Expression to Exp_Table_Header Dictionary
                int Y = 0;
                foreach (var item in Table_Header)
                {
                    TemplateDict[string.Format("[c{0}:{1}]", Y, item)] = item;
                    Y += 1;
                }
                xlwb.Close(true, null, null);
                xlapp.Quit();

                ReleaseOBJ.releaseObject(xlws);
                ReleaseOBJ.releaseObject(xlwb);
                ReleaseOBJ.releaseObject(xlapp);
            }
            return TemplateDict;
        }
    }
}
