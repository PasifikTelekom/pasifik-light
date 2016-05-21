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
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics; 

namespace pasifiklib.forms
{
    public partial class ExcelFileForm : Form
    {
        string ExcelFileName = "";
        MainForm MF = null;
        public ExcelFileForm(MainForm MF)
        {
            this.MF = MF;
            InitializeComponent();
        }

        private void ExcelFileForm_Load(object sender, EventArgs e)
        {
            phonenumberclmn_cmbbx.DataSource = new BindingSource(Utils.excel_header_dic, null);
            phonenumberclmn_cmbbx.DisplayMember = "Key";
            phonenumberclmn_cmbbx.ValueMember = "Value";
        }

        bool GetExcelFile(string FilePath)
        {
            bool state = false;
            try
            {
                if (FilePath.Length == 0) throw new Exception("Excel dosyası ekleyiniz");
                Excel.Application xlapp = new Excel.Application();
                Excel.Workbook xlwb = xlapp.Workbooks.Open(FilePath);
                Excel.Worksheet xlws = (Excel.Worksheet)xlwb.Worksheets.get_Item(1);
                Excel.Range range = xlws.UsedRange;
                int phonenumberclmn = Utils.excel_header_dic[phonenumberclmn_cmbbx.Text];

                int errorcounter = 0;
                if (normalexcel_rdbtn.Checked)
                {
                    foreach (int i in Enumerable.Range(1, range.Rows.Count))
                    {
                        string numb = Convert.ToString((range.Cells[i, phonenumberclmn] as Excel.Range).Value2);
                        //Console.WriteLine(numb);
                        if (numb.Length < 15)
                            numb = Utils.clean_phone(numb);
                        if (numb.Length == 10)
                            MF.phoneset_rchtxtbx.AppendText(string.Format("{0}\r\n", numb));
                        else
                            errorcounter += 1;
                    }
                }
                else if (customexcel_rdbtn.Checked)
                {
                    List<string> GSM_List = new List<string>();
                    foreach (int i in Enumerable.Range(1, range.Rows.Count))
                    {
                        string numb = Convert.ToString((range.Cells[i, phonenumberclmn] as Excel.Range).Value2);
                        if (numb.Length < 15)
                            numb = Utils.clean_phone(numb);
                        if (numb.Length == 10)
                        {
                            MF.phoneset_rchtxtbx.AppendText(string.Format("{0}\r\n", numb));
                            GSM_List.Add(numb);
                        }
                        else
                            errorcounter += 1;
                    }
                    this.MF.phoneset_rchtxtbx.ReadOnly = true;
                    this.MF.ExcelFileName = FilePath;
                    this.MF.ExcelPhoneColumn = phonenumberclmn;
                    this.MF.GSM_Array = GSM_List.ToArray();
                    this.MF.Is_SMSCustom = true;
                    this.MF.AutoCompleteMenu_Builter();
                }
                xlwb.Close(true, null, null);
                xlapp.Quit();

                ReleaseOBJ.releaseObject(xlws);
                ReleaseOBJ.releaseObject(xlwb);
                ReleaseOBJ.releaseObject(xlapp);
                state = true;
            }
            catch (Exception ex) {
                // Get stack trace for the exception with source file information
                var st = new StackTrace(ex, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();
                string message_err = string.Format("Message: {0}\nStack Trace:{1}\nTop Stack Frame:{2}\nLine Number:{3}\n", 
                    ex.Message, st, frame, line);
                MessageBox.Show(message_err, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            return state;
        }

        private void upload_btn_Click(object sender, EventArgs e)
        {
            bool ishandled = GetExcelFile(filename_lbl.Text);
            if (ishandled)
            {
                this.Close();
            }
        }

        private void browse_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog OFD = new OpenFileDialog();
                OFD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                OFD.Multiselect = false;
                OFD.ValidateNames = true;
                OFD.DereferenceLinks = false; // will return .lnk in shortcuts
                OFD.Filter = " Microsoft Excel |*.xls;*.xlsx;*.xlsm";//" Microsoft Excel |*.xls| Microsoft Excel |*.xlsx| Microsoft Excel |*.xlsm";
                if (OFD.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    ExcelFileName = OFD.FileName.Remove(0, OFD.InitialDirectory.Length + 1);
                    excel_lbl.Text = ExcelFileName;
                    filename_lbl.Text = OFD.FileName;
                }

            }
            catch (Exception E) { MessageBox.Show(E.Message, "Error File", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
