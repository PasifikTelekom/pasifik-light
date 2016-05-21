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
    public partial class AddressbookForm : Form
    {
        int TotalCheckBoxes = 0;
        int TotalCheckedCheckBoxes = 0;
        CheckBox HeaderCheckBox = null;
        bool IsHeaderCheckBoxClicked = false;

        MainForm MF = null;
        public AddressbookForm(MainForm MF)
        {
            this.MF = MF;
            InitializeComponent();
            PlaceHolder.SendMessage(search_txtbx.Handle, PlaceHolder.EM_SETCUEBANNER, 0, " Ara ...");
        }

        DataTable GetDataSource(string search)
        {
            DataTable DT = new DataTable();
            AddressBook AB = new AddressBook(General.settings.username, General.settings.password,
                                General.settings.host, General.settings.lang, search);
            string json = AB.execute();
            IList<IDictionary<string, object>> list_of_dict = new JavaScriptSerializer().Deserialize<IList<IDictionary<string, object>>>(json);
            DataRow dRow = null;
            DT.Columns.Add("IsChecked", System.Type.GetType("System.Boolean"));
            DT.Columns.Add("fullname");
            DT.Columns.Add("mobile1");
            foreach (Dictionary<string, object> dict in list_of_dict)
            {
                dRow = DT.NewRow();
                dRow["IsChecked"] = "false";
                dRow["fullname"] = dict["fullname"].ToString();
                dRow["mobile1"] = dict["mobile1"].ToString();
                DT.Rows.Add(dRow);
                DT.AcceptChanges();
            }
            return DT;
        }
        private void search_txtbx_KeyUp(object sender, KeyEventArgs e)
        {
            string search = search_txtbx.Text;
            /*Console.WriteLine(search);
            string json = GetAddressBook(User.username, User.password, search);
            List<Dictionary<string, object>> listofdict = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(json);
            List<AddressBook> listofAB = new List<AddressBook>();
            foreach (Dictionary<string, object> dict in listofdict)
            {
                AddressBook AB = new AddressBook();
                AB.fullname = dict["fullname"].ToString();
                AB.mobile1 = dict["mobile1"].ToString();
                listofAB.Add(AB);
            }
            dataGridView1.DataSource = listofAB;*/
            dataGridView1.DataSource = GetDataSource(search);
            TotalCheckBoxes = dataGridView1.RowCount;
            TotalCheckedCheckBoxes = 0;
        }

        private void AddressbookForm_Load(object sender, EventArgs e)
        {
            AddHeaderCheckBox();

            HeaderCheckBox.KeyUp += new KeyEventHandler(HeaderCheckBox_KeyUp);
            HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);
            dataGridView1.CellValueChanged += new DataGridViewCellEventHandler(dataGridView1_CellValueChanged);
            dataGridView1.CurrentCellDirtyStateChanged += new EventHandler(dataGridView1_CurrentCellDirtyStateChanged);
            dataGridView1.CellPainting += new DataGridViewCellPaintingEventHandler(dataGridView1_CellPainting);

            BindGridView();
        }
        private void BindGridView()
        {
            dataGridView1.DataSource = GetDataSource("");

            TotalCheckBoxes = dataGridView1.RowCount;
            TotalCheckedCheckBoxes = 0;
        }

        void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex == 0)
                ResetHeaderCheckBoxLocation(e.ColumnIndex, e.RowIndex);
        }

        private void AddHeaderCheckBox()
        {
            HeaderCheckBox = new CheckBox();

            HeaderCheckBox.Size = new Size(15, 15);

            //Add the CheckBox into the DataGridView
            this.dataGridView1.Controls.Add(HeaderCheckBox);
        }

        private void ResetHeaderCheckBoxLocation(int ColumnIndex, int RowIndex)
        {
            //Get the column header cell bounds
            Rectangle oRectangle = this.dataGridView1.GetCellDisplayRectangle(ColumnIndex, RowIndex, true);

            Point oPoint = new Point();

            oPoint.X = oRectangle.Location.X + (oRectangle.Width - HeaderCheckBox.Width) / 2 + 1;
            oPoint.Y = oRectangle.Location.Y + (oRectangle.Height - HeaderCheckBox.Height) / 2 + 1;

            //Change the location of the CheckBox to make it stay on the header
            HeaderCheckBox.Location = oPoint;
        }

        private void HeaderCheckBoxClick(CheckBox HCheckBox)
        {
            IsHeaderCheckBoxClicked = true;

            foreach (DataGridViewRow Row in dataGridView1.Rows)
                ((DataGridViewCheckBoxCell)Row.Cells["chkBxSelect"]).Value = HCheckBox.Checked;

            dataGridView1.RefreshEdit();

            TotalCheckedCheckBoxes = HCheckBox.Checked ? TotalCheckBoxes : 0;

            IsHeaderCheckBoxClicked = false;
        }

        private void RowCheckBoxClick(DataGridViewCheckBoxCell RCheckBox)
        {
            if (RCheckBox != null)
            {
                //Modifiy Counter;            
                if ((bool)RCheckBox.Value && TotalCheckedCheckBoxes < TotalCheckBoxes)
                    TotalCheckedCheckBoxes++;
                else if (TotalCheckedCheckBoxes > 0)
                    TotalCheckedCheckBoxes--;

                //Change state of the header CheckBox.
                if (TotalCheckedCheckBoxes < TotalCheckBoxes)
                    HeaderCheckBox.Checked = false;
                else if (TotalCheckedCheckBoxes == TotalCheckBoxes)
                    HeaderCheckBox.Checked = true;
            }
        }

        void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell is DataGridViewCheckBoxCell)
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!IsHeaderCheckBoxClicked)
                RowCheckBoxClick((DataGridViewCheckBoxCell)dataGridView1[e.ColumnIndex, e.RowIndex]);
        }

        void HeaderCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            HeaderCheckBoxClick((CheckBox)sender);
        }

        void HeaderCheckBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                HeaderCheckBoxClick((CheckBox)sender);
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void upload_btn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(item.Cells[0].Value))
                {
                    this.MF.phoneset_rchtxtbx.Text += string.Format("{0}\r\n", item.Cells[2].Value.ToString());
                }
            }
            this.Close();
        }
    }
}
