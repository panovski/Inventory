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
#endregion

namespace Inventory_IT_DMM
{
    public partial class AssignementForm_Preview : Form
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
                if (Convert.ToInt32(outlookGrid1.Rows[e.RowIndex].Cells["AssignementId"].Value) > 0)
                {
                    PrintForm();
                }
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
        public AssignementForm_Preview()
        {
            InitializeComponent();
        }

        private void AssignementForm_Preview_Load(object sender, EventArgs e)
        {
            Vasko.FillCombo("SELECT Description FROM ComboDef WHERE Grupa = 3 ORDER BY Description", cbAssignedToDep, "Description");
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
            String SQL = @"SELECT a.AssignementId, a.Type, AssignementNumber as [Assignment Number], AssignementTo as [Assigned To], AssignedOnDate as [Assigned on Date], AssignedBy as [Assigned By] FROM (Assignement a LEFT OUTER JOIN Assignement_Item ai on ai.AssignementId = a.AssignementId) LEFT OUTER JOIN Items i on i.ItemId = ai.ItemId";

            String WherePart = FillWherePart();
            SQL += WherePart;

            dt = Vasko.ReturnDataTable(SQL);
            MyDs.Tables.Add(dt);

            if (MyDs.Tables[0].Rows.Count > 0)
            {
                int ColumnIndex = 3;
                outlookGrid1.BindData(MyDs, MyDs.Tables[0].TableName);
                outlookGrid1.GroupTemplate.Column = outlookGrid1.Columns[ColumnIndex];

                ListSortDirection lsd = ListSortDirection.Ascending;
                outlookGrid1.Sort(new DataRowComparer(ColumnIndex, lsd));
                outlookGrid1.ColumnHeadersHeight = 40;
                outlookGrid1.Columns[0].Visible = false;
                outlookGrid1.Columns[1].Visible = false;

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
            WherePart = VratiWherePart(tbAssignedTo, "i.AssignedTo", WherePart);
            WherePart = VratiWherePart(tbAssignedToDep, "i.AssignedToDep", WherePart);
            WherePart = VratiWherePart(tbAssignementNumber, "a.AssignementNumber", WherePart);

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

        private void PrintForm()
        {
            String TemplateForm = "";
            if (outlookGrid1.SelectedRows.Count > 0)
            {
                PleaseWait frmPW = new PleaseWait();
                frmPW.Show();
                Application.DoEvents();

                String Selected = "";
                String SelectedAssignements = "";
                String Assigned = "";
                String OdbranTip = "";

                foreach (DataGridViewRow dr in outlookGrid1.Rows)
                {
                    if (dr.Selected && dr.Index > 0)
                    {

                        //if (dr.Cells["Assignement Form"].Value.ToString() != "")
                        String AssId = dr.Cells["AssignementId"].Value.ToString();//Vasko.ExecuteScalar("SELECT AssignementId FROM Items WHERE ItemID=" + dr.Cells["ItemID"].Value.ToString());
                        if (AssId != "")
                        {
                            String Tip = dr.Cells["Type"].Value.ToString();// Vasko.ExecuteScalar("SELECT [Type] FROM Assignement WHERE AssignementID=" + AssId);//dr.Cells["AssignementId"].Value.ToString());
                            if (Tip == "1") { OdbranTip = "Assignement Form"; TemplateForm = "IT_Assignement_Form.dot"; }
                            else if (Tip == "2") { OdbranTip = "Temporary Form"; TemplateForm = "IT_Temporary_Form.dot"; }
                            else if (Tip == "3") { OdbranTip = "Return Form"; TemplateForm = "IT_Returning_Form.dot"; }

                            DataTable dt = new DataTable();
                            dt = Vasko.ReturnDataTable("SELECT ItemId FROM Assignement_Item WHERE AssignementId = " + AssId);//dr.Cells["AssignementId"].Value.ToString());
                            foreach (DataRow drow in dt.Rows)
                            {
                                if (Selected != "") Selected += ",";
                                Selected += drow[0].ToString();

                            }

                            if (SelectedAssignements != "") SelectedAssignements += ",";
                            {
                                if (!SelectedAssignements.Contains(AssId))//dr.Cells["AssignementId"].Value.ToString()))
                                    SelectedAssignements += AssId;// dr.Cells["AssignementId"].Value.ToString();
                            }
                        }
                        else goto error;
                        goto stop;

                    }
                }
            stop:
                Funkcii f = new Funkcii();
                DatabaseConn dbc = new DatabaseConn();
                string[] AllAssignements = SelectedAssignements.Split(',');
                foreach (string str in AllAssignements)
                {
                    String SqlPrint = @"SELECT AssignementTo as AssignedTo, AssignementNumber, AssignedBy, Format(AssignedOnDate, 'dd.MM.yyyy') as AssignedOn FROM Assignement WHERE AssignementId=" + str + "; ";
                    String SqlPrint2 = @"SELECT ProductGroup, Description, DMMPropertyNum, SerialNumber, Quantity FROM Items WHERE ItemId IN (" + Selected + ") ";
                    f.PrintWord(dbc.TemplatePath() + @"\" + TemplateForm, SqlPrint, SqlPrint2);
                }
                goto end;

            error: MessageBox.Show("One of selected items doesn't has a created form! Please create a form first, and after that try to print it!", "Error!", MessageBoxButtons.OK); goto end;
            end: ;

                frmPW.Close();
            }
        }
        
        #endregion

        #region HandledEvents
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ExecuteSearch();
        }

        private void AssignementForm_Preview_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "\r":
                    ExecuteSearch();
                    break;
            }
        }

        private void cbAssignedToDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAssignedToDep.Text != "System.Data.DataRowView")
            {
                if (tbAssignedToDep.Text.Length > 0) tbAssignedToDep.Text += ", ";
                tbAssignedToDep.Text += cbAssignedToDep.Text;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintForm();
        }

        private void btnDeleteAssignment_Click(object sender, EventArgs e)
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
                            if (Selected.Length > 0) { Selected += "," + dr.Cells["AssignementId"].Value; }
                            else { Selected = dr.Cells["AssignementId"].Value.ToString(); }
                        }
                    }

                    try
                    {
                        String SQL = @"DELETE FROM Assignement WHERE AssignementId IN (" + Selected + ")";
                        Vasko.ExecuteCommand(SQL);

                        SQL = "DELETE FROM Assignement_Item WHERE AssignementId IN (" + Selected + ")";
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
