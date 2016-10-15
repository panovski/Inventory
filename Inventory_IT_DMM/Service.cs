#region Using
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Inventory_IT_DMM.Class;
using FastExcelExportingDemoCs;
#endregion

namespace Inventory_IT_DMM
{
    public partial class Service : Form
    {
        #region Variables
        DataSet MyDs = new DataSet();

        // specifies the current data view (bound/unbound, dataset)
        private string View;

        // remember the column index that was last sorted on
        private int prevColIndex = -1;

        // remember the direction the rows were last sorted on (ascending/descending)
        private ListSortDirection prevSortDirection = ListSortDirection.Ascending;
        #endregion

        #region Class-a za Grid-ot
        public class DataRowComparer : System.Collections.IComparer
        {
            ListSortDirection direction;
            int columnIndex;

            public DataRowComparer(int columnIndex, ListSortDirection direction)
            {
                this.columnIndex = columnIndex;
                this.direction = direction;
            }

            #region IComparer Members

            public int Compare(object x, object y)
            {

                DataRow obj1 = (DataRow)x;
                DataRow obj2 = (DataRow)y;
                return string.Compare(obj1[columnIndex].ToString(), obj2[columnIndex].ToString()) * (direction == ListSortDirection.Ascending ? 1 : -1);
            }
            #endregion
        }
        #endregion

        #region Grouping & Sorting
        private void outlookGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 && e.ColumnIndex >= 0)
            {
                ListSortDirection direction = ListSortDirection.Ascending;
                if (e.ColumnIndex == prevColIndex) // reverse sort order
                    direction = prevSortDirection == ListSortDirection.Descending ? ListSortDirection.Ascending : ListSortDirection.Descending;

                // remember the column that was clicked and in which direction is ordered
                prevColIndex = e.ColumnIndex;
                prevSortDirection = direction;

                outlookGrid1.Sort(new DataRowComparer(e.ColumnIndex, direction));
            }
            CountSelectedRows();
        }

        private void outlookGrid1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
             
            }
            catch { }
        }
     
        private void CountSelectedRows()
        {
            if (outlookGrid1.SelectedRows.Count > 0)
            {
                int noSelected = 0;
                int R_Index = -1;
                foreach (DataGridViewRow dr in outlookGrid1.Rows)
                {
                    if (dr.Selected)
                    {
                        if (R_Index == -1) R_Index = dr.Index;
                        noSelected += 1;
                    }
                }
                lblSelectedRows.Text = ",  Selected rows:" + noSelected.ToString();
            }
        }
        #endregion Grouping & Sorting

        #region PageLoad
        public Service()
        {
            InitializeComponent();
        }
        private void Service_Load(object sender, EventArgs e)
        {
            ExecuteSearch();
        }
        #endregion

        #region Functions
        private void ExecuteSearch()
        {
            PleaseWait frmPW = new PleaseWait();
            frmPW.Show();
            Application.DoEvents();

            MyDs.Tables.Clear();
            outlookGrid1.Rows.Clear();

            DataTable dt = new DataTable();
            String SQL = @"SELECT s.ServiceId, i.ItemId, i.Description, i.SerialNumber as [Serial Number], i.DMMPropertyNum as [DMM Number], s.SentOnDate as [Sent on Date], s.ReturnedOnDate as [Returned on Date], s.Problem as [Problem with the item], s.SentBy as [Sent on service by], s.ReturnedBy as [Returned from service by], s.ReturnInformation as [Information after servicing], s.Servicer, s.ServicerContact as [Servicer Contact information], s.CostCenter as [Cost Center], s.RelatedBDAService as [Related BDA] FROM Service s LEFT OUTER JOIN Items i ON s.ItemId = i.ItemId";

            String WherePart = FillWherePart();
            SQL += WherePart;

            dt = Vasko.ReturnDataTable(SQL);
            MyDs.Tables.Add(dt);

            if (MyDs.Tables[0].Rows.Count > 0)
            {
                int ColumnIndex = 2;
                outlookGrid1.BindData(MyDs, MyDs.Tables[0].TableName);
                outlookGrid1.GroupTemplate.Column = outlookGrid1.Columns[ColumnIndex];

                ListSortDirection lsd = ListSortDirection.Ascending;
                outlookGrid1.Sort(new DataRowComparer(ColumnIndex, lsd));
                outlookGrid1.ColumnHeadersHeight = 40;
                outlookGrid1.Columns[0].Visible = false;
                outlookGrid1.Columns[1].Visible = false;

                outlookGrid1.Columns[3].Width = 100;
                outlookGrid1.Columns[4].Width = 70;
                outlookGrid1.Columns[5].Width = 75;
                outlookGrid1.Columns[6].Width = 75;
                outlookGrid1.Columns[7].Width = 200;
                outlookGrid1.Columns[8].Width = 85;
                outlookGrid1.Columns[9].Width = 85;
                outlookGrid1.Columns[10].Width = 200;

                lblNoRows.Text = "Total rows: " + MyDs.Tables[0].Rows.Count;
                if (outlookGrid1.Rows[0].Selected)
                    outlookGrid1.Rows[0].Selected = false;
            }
            frmPW.Close();
        }
        private string FillWherePart()
        {
            String WherePart = "";
            WherePart = VratiWherePart(tbSerialNumber, "i.SerialNumber", WherePart);
            WherePart = VratiWherePart(tbDMMProperty, "i.DMMPropertyNum", WherePart);
            WherePart = VratiWherePart(tbDescription, "i.Description", WherePart);
            WherePart = VratiWherePart(tbServicer, "s.Servicer", WherePart);
            if (cbStillOnService.Checked)
            {
                if (WherePart.Length > 0)
                    WherePart += " AND ";
                WherePart += " s.ReturnedOnDate IS NULL ";
            }
            if (WherePart.Length > 0) WherePart = " WHERE " + WherePart;
            return WherePart;
        }
        private string VratiWherePart(TextBox Kontrola, String Kolona, String WherePart)
        {
            String WherePart1 = "";
            if (Kontrola.Text.Length > 0)
            {
                string[] Lista = Kontrola.Text.ToString().Split(',');
                foreach (string word in Lista)
                {
                    String tWord = word.Trim();
                    if (WherePart1.Length > 0) WherePart1 += " OR ";
                    WherePart1 += " " + Kolona + " LIKE '%" + tWord + "%' ";
                }

                if (WherePart.Length > 0)
                {
                    if (WherePart1.Length > 0)
                        WherePart += " AND (" + WherePart1 + ") ";
                }
                else
                {
                    if (WherePart1.Length > 0)
                        WherePart += " (" + WherePart1 + ") ";
                }
            }

            return WherePart;
        }
        private string VratiWherePartInteger(TextBox Kontrola, String Kolona, String Sign, String WherePart)
        {
            String WherePart1 = "";
            if (Kontrola.Text.Length > 0)
            {
                WherePart1 += " " + Kolona + " " + Sign + " " + Kontrola.Text + " ";

                if (WherePart.Length > 0)
                {
                    if (WherePart1.Length > 0)
                        WherePart += " AND (" + WherePart1 + ") ";
                }
                else
                {
                    if (WherePart1.Length > 0)
                        WherePart += " (" + WherePart1 + ") ";
                }
            }

            return WherePart;
        }
        
        #endregion

        #region HandledEvents
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ExecuteSearch();
        }
        
        private void Service_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "\r":
                    ExecuteSearch();
                    break;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
        }
      
        private void btnSendService_Click(object sender, System.EventArgs e)
        {
            SendOnService sos = new SendOnService();
            sos.ShowDialog();
            if (sos.PrintReverse)
                PrintReverse(sos.NewId);
            if (sos.PrintAddress)
                PrintAddress(sos.NewId);

            ExecuteSearch();
        }

        private void btnReturnService_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (outlookGrid1.SelectedRows.Count == 1)
                {
                    ReturnFromService rfs = new ReturnFromService();
                    rfs.inSerialNumber = outlookGrid1.SelectedRows[0].Cells["Serial Number"].Value.ToString();
                    rfs.itemId = outlookGrid1.SelectedRows[0].Cells["ItemId"].Value.ToString();
                    rfs.serviceId = outlookGrid1.SelectedRows[0].Cells["ServiceId"].Value.ToString();
                    rfs.ShowDialog();
                    ExecuteSearch();
                }
            }
            catch { }            
        }

        private void btnPrint_Click_1(object sender, System.EventArgs e)
        {
            Point pt = gbCommands.PointToScreen(btnPrint.Location);
            cmsPrint.Show(pt);
        }

        private void miExportTable_Click(object sender, System.EventArgs e)
        {
            if (MyDs.Tables.Count > 0)
            {
                if (MyDs.Tables[0].Rows.Count > 0)
                {
                    PleaseWait frmPW = new PleaseWait();
                    frmPW.Show();
                    Application.DoEvents();
                    FastExportingMethod.ExportToExcel(MyDs);
                    frmPW.Close();
                }
            }
        }

        private void miPrintReverseForm_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (outlookGrid1.SelectedRows.Count == 1)
                {
                    PrintReverse(outlookGrid1.SelectedRows[0].Cells["ServiceId"].Value.ToString());
                }
            }
            catch { }             
        }

        private void miPrintAddress_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (outlookGrid1.SelectedRows.Count == 1)
                {
                    PrintAddress(outlookGrid1.SelectedRows[0].Cells["ServiceId"].Value.ToString());
                }
            }
            catch { } 
        }

        private void PrintReverse(String OpId)
        {
            Funkcii f = new Funkcii();
            DatabaseConn dbc = new DatabaseConn();
            String Adresa = Vasko.ExecuteScalar("SELECT ServicerContact FROM Service WHERE ServiceID=" + OpId);
            Adresa = Adresa.Substring(Adresa.IndexOf("ul"));
            Adresa = Adresa.Substring(0, Adresa.IndexOf("www"));
            String Datum = DateTime.Now.ToShortDateString();
            f.PrintWord(dbc.TemplatePath() + @"\IT_Reverse_Form.dot",
            "SELECT i.ProductGroup, i.Description, i.SerialNumber, s.Servicer, '" + Adresa + "' as ServicerContact, '" + Datum + "' as Datum FROM Service as s LEFT OUTER JOIN Items as i ON i.ItemId=s.ItemId WHERE s.ServiceID=" + OpId, "");
        }

        private void PrintAddress(String OpId)
        {
            Funkcii f = new Funkcii();
            DatabaseConn dbc = new DatabaseConn();
            String Adresa = Vasko.ExecuteScalar("SELECT ServicerContact FROM Service WHERE ServiceID=" + OpId);
            Adresa = Adresa.Substring(Adresa.IndexOf("ul"));
            Adresa = Adresa.Substring(0, Adresa.IndexOf("www"));
            String Datum = DateTime.Now.ToShortDateString();
            f.PrintWord(dbc.TemplatePath() + @"\IT_Servicer_Address.dot",
            "SELECT i.ProductGroup, i.Description, i.SerialNumber, s.Servicer, '" + Adresa + "' as Address, s.Problem FROM Service as s LEFT OUTER JOIN Items as i ON i.ItemId=s.ItemId WHERE s.ServiceID=" + OpId, "");
        }

        private void btnDeleteService_Click(object sender, System.EventArgs e)
        {
            if (outlookGrid1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    String Selected = "";
                    foreach (DataGridViewRow dr in outlookGrid1.Rows)
                    {
                        if (dr.Selected)
                        {
                            if (Selected.Length > 0) { Selected += "," + dr.Cells["ServiceId"].Value; }
                            else { Selected = dr.Cells["ServiceId"].Value.ToString(); }
                        }
                    }

                    try
                    {
                        String SQL = @"DELETE FROM Service WHERE ServiceId IN (" + Selected + ")";
                        Vasko.ExecuteCommand(SQL);

                        MessageBox.Show("Successfully deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch { MessageBox.Show("The record was not deleted!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error); }

                    ExecuteSearch();
                }
            }
        }
        #endregion
    }
}
