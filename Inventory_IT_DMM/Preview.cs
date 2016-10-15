#region Using
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using OutlookStyleControls;
using Excel = Microsoft.Office.Interop.Excel;
using FastExcelExportingDemoCs;
using Inventory_IT_DMM.Class;
#endregion

namespace Inventory_IT_DMM
{
    public partial class Preview : Form
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
        #endregion Grouping & Sorting
        
        #region Load
        public Preview()
        {
            InitializeComponent();
        }

        private void Preview_Load(object sender, EventArgs e)
        {
            Vasko.FillCombo("SELECT Description FROM ComboDef WHERE Grupa = 1 ORDER BY Description", cbProductGroup, "Description");
            Vasko.FillCombo("SELECT Description FROM ComboDef WHERE Grupa = 2 ORDER BY Description", cbStatus, "Description");
            Vasko.FillCombo("SELECT Description FROM ComboDef WHERE Grupa = 3 ORDER BY Description", cbAssignedToDep, "Description");

            tbSelectedProduct.Text = "";
            tbSelectedStatus.Text = "";
            calenderDatum.Text = "";
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
            String SQL = @"SELECT ItemId, ProductGroup, Description, SerialNumber as [Serial Number], DMMPropertyNum as [DMM Property Number],
                           Status, AssignedToDep as [Assigned To Department], AssignedTo as [Assigned To], Quantity, IPAddress as [IP Address], Vreme as [Date of change], UserName as [Changed by], Serviser as [Supplier/Servicer], AssignementNumber as [Assignment Form], i.AssignementId, RelatedBDA as [Related BDA], Notes FROM Items i LEFT OUTER JOIN Assignement as a on a.AssignementId = i.AssignementID";
            
            String WherePart = FillWherePart();
            SQL += WherePart;

            dt = Vasko.ReturnDataTable(SQL);
            MyDs.Tables.Add(dt);

            if (MyDs.Tables[0].Rows.Count > 0)
            {
                int ColumnIndex = 1;
                outlookGrid1.BindData(MyDs, MyDs.Tables[0].TableName);
                outlookGrid1.GroupTemplate.Column = outlookGrid1.Columns[ColumnIndex];
            
                ListSortDirection lsd = ListSortDirection.Ascending;
                outlookGrid1.Sort(new DataRowComparer(ColumnIndex, lsd));
                outlookGrid1.ColumnHeadersHeight = 40;
                outlookGrid1.Columns[0].Visible = false;
                outlookGrid1.Columns[1].Visible = false;
                outlookGrid1.Columns[2].Width = 220;
                outlookGrid1.Columns[5].Width = 70;
                outlookGrid1.Columns[8].Width = 30;
                outlookGrid1.Columns[9].Width = 70;
                outlookGrid1.Columns[10].Width = 70;
                outlookGrid1.Columns[11].Width = 70;
                outlookGrid1.Columns["AssignementId"].Visible = false;

                lblNoRows.Text = "Total rows: " + MyDs.Tables[0].Rows.Count;
                if (outlookGrid1.Rows[0].Selected)
                    outlookGrid1.Rows[0].Selected = false;
            }
            frmPW.Close();
        }
        private string FillWherePart()
        { 
            String WherePart = "";

            WherePart = VratiWherePart(tbSelectedProduct, "ProductGroup", WherePart);
            WherePart = VratiWherePart(tbDescription, "Description", WherePart);
            WherePart = VratiWherePart(tbSerialNumber, "SerialNumber", WherePart);
            WherePart = VratiWherePart(tbDMMProperty, "DMMPropertyNum", WherePart);
            WherePart = VratiWherePart(tbAssignedTo, "AssignedTo", WherePart);
            WherePart = VratiWherePart(tbSelectedStatus, "Status", WherePart);
            WherePart = VratiWherePart(tbIPAddress, "IPAddress", WherePart);
            WherePart = VratiWherePart(tbAssignedToDep, "AssignedToDep", WherePart);
            WherePart = VratiWherePart(tbAssignementNumber, "AssignementNumber", WherePart);
            WherePart = VratiWherePart(tbModifiedBy, "UserName", WherePart);
            WherePart = VratiWherePart(tbServicer, "Serviser", WherePart);
            WherePart = VratiWherePart(tbRelatedBDA, "RelatedBDA", WherePart);
            WherePart = VratiWherePart(tbNotes, "Notes", WherePart);
            if (calenderDatum.Checked)
            {
                TextBox tbPom = new TextBox();
                tbPom.Text = calenderDatum.Text;
                WherePart = VratiWherePart(tbPom, "Vreme", WherePart);
            }
            String Sign = "=";
            if (cbQuantity.Text.Length > 0) Sign = cbQuantity.Text;
            WherePart = VratiWherePartInteger(tbQuantity, "Quantity", Sign, WherePart);

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
                WherePart1 += " " + Kolona + " " + Sign + " "  + Kontrola.Text + " ";

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
        private void CreateForm(String Type, Boolean Programaticaly = false)
        {
            if (outlookGrid1.SelectedRows.Count > 0)
            {

                PleaseWait frmPW = new PleaseWait();
                frmPW.Show();
                Application.DoEvents();

                String Selected = "";
                String Assigned = "";
                Boolean First = true;
                String SelectedIndexes = "";

                foreach (DataGridViewRow dr in outlookGrid1.Rows)
                {
                    if (dr.Selected && dr.Index>0)
                    {
                        if (SelectedIndexes != "") SelectedIndexes += ",";
                        SelectedIndexes += dr.Index.ToString();

                        if (First)
                        {
                            Assigned = Vasko.ExecuteScalar("SELECT AssignedTo FROM Items WHERE ItemID=" + dr.Cells["ItemID"].Value.ToString());// dr.Cells["Assigned To"].Value.ToString();
                            First = false;
                        }

                        if (Assigned != Vasko.ExecuteScalar("SELECT AssignedTo FROM Items WHERE ItemID=" + dr.Cells["ItemID"].Value.ToString()))//dr.Cells["Assigned To"].Value.ToString())
                        {
                            goto stop;
                        }
                        else
                        {
                            if (Selected.Length > 0) Selected += "," + dr.Cells["ItemId"].Value;
                            else Selected = dr.Cells["ItemId"].Value.ToString();
                        }
                    }
                }

                string[] selektirani_ids = Selected.Split(',');
                string lastInserted = Vasko.ExecuteScalar("SELECT TOP 1 AssignementNumber FROM Assignement ORDER BY AssignedOnDate DESC");
                string lastInsertedDate = Vasko.ExecuteScalar("SELECT TOP 1 AssignedOnDate FROM Assignement ORDER BY AssignedOnDate DESC");
                string NewAssignementNumber = "";
                if (lastInserted != "")
                {
                    if (Convert.ToDateTime(lastInsertedDate).ToShortDateString() == DateTime.Now.ToShortDateString() )
                    {
                        //string lastDigit = lastInserted.Substring(lastInserted.Length - 2, lastInserted.Length - (lastInserted.Length - 2));
                        string lastDigit = lastInserted.Substring(11, lastInserted.Length - 11);
                        int newDigit = Convert.ToInt32(lastDigit) + 1;
                        if (newDigit < 10) NewAssignementNumber = Type + "-" + lastInserted.Substring(2, 8) + "-0" + newDigit.ToString();
                        else NewAssignementNumber = Type + "-" + lastInserted.Substring(2, 8) + "-" + newDigit.ToString();
                    }
                    else
                        NewAssignementNumber = Type + "-"+ DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0') + "-01";
                }
                else
                    NewAssignementNumber = Type + "-" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0') + "-01";

                if(Type == "3")
                {
                    String PreviousAssigned = Vasko.ExecuteScalar("SELECT ReturnPersonTmp FROM Items WHERE ItemID = " + selektirani_ids[0]);
                    Vasko.ExecuteCommand("INSERT INTO Assignement (AssignementNumber, AssignementTo, AssignedOnDate, AssignedBy, Type, AssignementReturnPerson) VALUES ('" + NewAssignementNumber + "','" + Assigned + "',NOW(),'" + MyGlobals.UserName + "'," + Type + ", '" + PreviousAssigned + "');");
                }
                else
                    Vasko.ExecuteCommand("INSERT INTO Assignement (AssignementNumber, AssignementTo, AssignedOnDate, AssignedBy, Type) VALUES ('" + NewAssignementNumber + "','" + Assigned + "',NOW(),'" + MyGlobals.UserName + "'," + Type + ");");
                string newID = Vasko.ExecuteScalar("SELECT MAX(AssignementId) FROM Assignement");

                foreach (string i in selektirani_ids)
                {
                    String SQL = "INSERT INTO History (Description,SerialNumber,DMMPropertyNum,Quantity,AssignedTo,AssignedToDep,Status,ProductGroup,IPAddress,UserName,Vreme,Serviser,AssignementID) SELECT Description,SerialNumber,DMMPropertyNum,Quantity,AssignedTo,AssignedToDep,Status,ProductGroup,IPAddress,UserName,Vreme,Serviser, AssignementID FROM Items WHERE ItemId=" + i;
                    Vasko.ExecuteCommand(SQL);

                    Vasko.ExecuteCommand("INSERT INTO Assignement_Item (AssignementId, ItemID) VALUES(" + newID + "," + i + ")");
                    if(Type =="1" || Type =="2")
                        Vasko.ExecuteCommand("UPDATE Items SET AssignementID = " + newID + ", Status='Assigned', Vreme= Now(), UserName='" + MyGlobals.UserName + "' WHERE ItemID = " + i);
                    else if (Type == "3")
                    {
                        String AssignetTo = "AssignedTo='IT Office',";
                        if (Programaticaly)
                            AssignetTo = "";
                        Vasko.ExecuteCommand("UPDATE Items SET AssignementID = " + newID + ", Status='On Stock', AssignedToDep='IT', " + AssignetTo + " Vreme= Now(), UserName='" + MyGlobals.UserName + "' WHERE ItemID = " + i);
                    }
                }
                //ExecuteSearch();
                string[] splitedIndexes = SelectedIndexes.Split(',');
                foreach (string i in splitedIndexes)
                {
                    foreach (DataGridViewRow dr in outlookGrid1.Rows)
                    {
                        if (dr.Index == Convert.ToInt32(i))
                            dr.Selected = true;
                    }
                }

                if (Type == "1") button1_Click(null,null);
                else if (Type == "2") btnTemporaryForm_Click(null,null);
                else if (Type == "3") btnReturningForm_Click(null,null);
                //String SqlPrint = @"SELECT TOP 1 AssignedTo FROM Items WHERE ItemId IN (" + Selected + "); ";
                //String SqlPrint2 = @"SELECT ProductGroup, Description, DMMPropertyNum, SerialNumber, '' as OrgNum FROM Items WHERE ItemId IN (" + Selected + ") ";
                //f.PrintWord(dbc.TemplatePath() + @"\IT_Assignement_Form.dot", SqlPrint, SqlPrint2);
                goto end;

            stop: MessageBox.Show("The items are not assigned to the same user and can not be grouped!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            end: ;

                frmPW.Close();
            }
        }
        private void PrintForm(String TemplateForm, String Type)
        {
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
                        String AssId = Vasko.ExecuteScalar("SELECT AssignementId FROM Items WHERE ItemID=" + dr.Cells["ItemID"].Value.ToString());
                        if ( AssId != "")
                        {
                            String Tip = Vasko.ExecuteScalar("SELECT [Type] FROM Assignement WHERE AssignementID=" + AssId);//dr.Cells["AssignementId"].Value.ToString());
                            if (Tip == "1") OdbranTip = "Assignement Form";
                            else if (Tip == "2") OdbranTip = "Temporary Form";
                            else if (Tip == "3") OdbranTip = "Return Form";

                            if (Tip != Type) goto error2;
                            else
                            {
                                DataTable dt = new DataTable();
                                dt = Vasko.ReturnDataTable("SELECT ItemId FROM Assignement_Item WHERE AssignementId = " + AssId );//dr.Cells["AssignementId"].Value.ToString());
                                foreach (DataRow drow in dt.Rows)
                                {
                                    if (Selected != "") Selected += ",";
                                    Selected += drow[0].ToString();

                                }
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
                    String SqlPrint = "";
                    if(Type =="3")
                        SqlPrint = @"SELECT AssignementReturnPerson as AssignedTo, AssignementNumber, AssignedBy, Format(AssignedOnDate, 'dd.MM.yyyy') as AssignedOn FROM Assignement WHERE AssignementId=" + str + "; ";
                    else
                        SqlPrint = @"SELECT AssignementTo as AssignedTo, AssignementNumber, AssignedBy, Format(AssignedOnDate, 'dd.MM.yyyy') as AssignedOn FROM Assignement WHERE AssignementId=" + str + "; ";
                    String SqlPrint2 = @"SELECT ProductGroup, Description, DMMPropertyNum, SerialNumber, Quantity FROM Items WHERE ItemId IN (" + Selected + ") ";
                    f.PrintWord(dbc.TemplatePath() + @"\" + TemplateForm, SqlPrint, SqlPrint2);
                }
                goto end;

            error: MessageBox.Show("One of selected items doesn't has a created form! Please create a form first, and after that try to print it!", "Error!", MessageBoxButtons.OK); goto end;
            error2: MessageBox.Show("One of selected items doesn't have created this type of form! You can print just: " + OdbranTip + "!", "Error!", MessageBoxButtons.OK); goto end;
            end: ExecuteSearch();

                frmPW.Close();
            }
        }
        #endregion

        #region Handled Events
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ExecuteSearch();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PrintForm("IT_Assignement_Form.dot", "1");
        }
        private void btnTemporaryForm_Click(object sender, EventArgs e)
        {
            PrintForm("IT_Temporary_Form.dot", "2");
        }
        private void btnReturningForm_Click(object sender, EventArgs e)
        {
            PrintForm("IT_Returning_Form.dot", "3");
        }
        private void Preview_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "\r":
                    ExecuteSearch();
                    break;
            }
        }
        private void cbProductGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProductGroup.Text != "System.Data.DataRowView")
            {
                if (tbSelectedProduct.Text.Length > 0) tbSelectedProduct.Text += ", ";
                tbSelectedProduct.Text += cbProductGroup.Text;
            }

        }
        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.Text != "System.Data.DataRowView")
            {
                if (tbSelectedStatus.Text.Length > 0) tbSelectedStatus.Text += ", ";
                tbSelectedStatus.Text += cbStatus.Text;
            }
        }
        private void tbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (MyDs.Tables.Count > 0)
            {
                if (MyDs.Tables[0].Rows.Count > 0)
                {
                    PleaseWait frmPW = new PleaseWait();
                    frmPW.Show();
                    Application.DoEvents();
                    FastExportingMethod.ExportToExcel(MyDs);//, sfd.FileName);
                    frmPW.Close();
                }
            }
        }
        private void ExportSelected()
        {
            DataSet SelectedDataSet = new DataSet();
            DataTable dt = new DataTable();
            String SQL = @"SELECT ProductGroup, Description, SerialNumber as [Serial Number], DMMPropertyNum as [DMM Property Number],
                           Status, AssignedToDep as [Assigned To Department], AssignedTo as [Assigned To], Quantity, IPAddress as [IP Address], '' as [Date of change], UserName as [Changed by], Serviser as [Supplier/Servicer], AssignementNumber as [Assignement Form], RelatedBDA as [Related BDA], Notes FROM Items i LEFT OUTER JOIN Assignement as a on a.AssignementId = i.AssignementID WHERE 1=2";
            dt = Vasko.ReturnDataTable(SQL);
            SelectedDataSet.Tables.Add(dt);

            foreach (DataGridViewRow dr in outlookGrid1.Rows)
            {   
                if (dr.Selected)
                {
                    DataRow drNew = SelectedDataSet.Tables[0].NewRow();
                    drNew[0] = dr.Cells[1].Value;
                    drNew[1] = dr.Cells[2].Value;
                    drNew[2] = dr.Cells[3].Value;
                    drNew[3] = dr.Cells[4].Value;
                    drNew[4] = dr.Cells[5].Value;
                    drNew[5] = dr.Cells[6].Value;
                    drNew[6] = dr.Cells[7].Value;
                    drNew[7] = dr.Cells[8].Value;
                    drNew[8] = dr.Cells[9].Value;
                    drNew[9] = dr.Cells[10].Value.ToString();
                    drNew[10] = dr.Cells[11].Value;
                    drNew[11] = dr.Cells[12].Value;
                    drNew[12] = dr.Cells[13].Value;
                    drNew[13] = dr.Cells[15].Value;
                    drNew[14] = dr.Cells[16].Value;
                    //drNew[15] = dr.Cells[15].Value;

                    SelectedDataSet.Tables[0].Rows.Add(drNew);
                }
            }

            if (SelectedDataSet.Tables[0].Rows.Count > 0)
            {
                PleaseWait frmPW = new PleaseWait();
                frmPW.Show();
                Application.DoEvents();
                FastExportingMethod.ExportToExcel(SelectedDataSet);//, sfd.FileName);
                frmPW.Close();
            }
        }
        private void outlookGrid1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(outlookGrid1.Rows[e.RowIndex].Cells["ItemId"].Value) > 0)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    DataGridViewRow dr = outlookGrid1.Rows[e.RowIndex];
                    AddItem_Edit ai = new AddItem_Edit(dr);
                    ai.Text = "Edit item";
                    ai.ShowDialog();
                    ExecuteSearch();
                    Cursor.Current = Cursors.Default;
                }
            }
            catch { }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (outlookGrid1.SelectedRows.Count > 0)
            {
                String TekstZaBrisenje = "";
                if (MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    String Selected = "";
                    foreach (DataGridViewRow dr in outlookGrid1.Rows)
                    {
                        if (dr.Selected)
                        {
                            if (Selected.Length > 0) { Selected += "," + dr.Cells["ItemId"].Value;}
                            else { Selected = dr.Cells["ItemId"].Value.ToString(); TekstZaBrisenje = "'" + dr.Cells["ProductGroup"].Value + "'"; }
                        }
                    }

                    try
                    {
                        String SQL = @"DELETE FROM Items WHERE ItemId IN (" + Selected + ")";
                        Vasko.ExecuteCommand(SQL);

                        if (TekstZaBrisenje != "")
                            IzbrishiCombo(TekstZaBrisenje);

                        MessageBox.Show("Successfully deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch { MessageBox.Show("The record was not deleted!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error); }

                    ExecuteSearch();
                }
            }
        }
        private void IzbrishiCombo(String vDescription)
        {
            String SelectCount = "SELECT COUNT(ProductGroup) FROM Items WHERE ProductGroup = " + vDescription + "";
            int Broj = Convert.ToInt32(Vasko.ExecuteScalar(SelectCount));
            if (Broj <= 0)
            {
                String SQL = @"DELETE FROM ComboDef WHERE Description = " + vDescription;
                Vasko.ExecuteCommand(SQL);
            }
        }
        private void btnMultipleEdit_Click(object sender, EventArgs e)
        {
            if (outlookGrid1.SelectedRows.Count > 0)
            {
                    String Selected = "";
                    int R_Index = -1;
                    foreach (DataGridViewRow dr in outlookGrid1.Rows)
                    {
                        if (dr.Selected)
                        {
                            if (R_Index == -1) R_Index = dr.Index;
                            if (Selected.Length > 0) Selected += "," + dr.Cells["ItemId"].Value;
                            else Selected = dr.Cells["ItemId"].Value.ToString();
                        }
                    }

                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        DataGridViewRow dr = outlookGrid1.Rows[R_Index];
                        AddItem_MultiEdit ai = new AddItem_MultiEdit(dr, Selected);
                        ai.Text = "Multi Edit Items";
                        ai.ShowDialog();
                        Cursor.Current = Cursors.Default;
                    }
                    catch { }

                    ExecuteSearch();
                
            }
        }
        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (outlookGrid1.SelectedRows.Count == 1)
            {
                    String Selected = "";
                    foreach (DataGridViewRow dr in outlookGrid1.Rows)
                    {
                        if (dr.Selected)
                        {
                            if (Selected.Length > 0) Selected += "," + dr.Cells["Serial Number"].Value;
                            else Selected = dr.Cells["Serial Number"].Value.ToString();
                        }
                    }

                Cursor.Current = Cursors.WaitCursor;
                History_Open ho = new History_Open(Selected);
                ho.Text = "History";
                ho.ShowDialog();
                Cursor.Current = Cursors.Default;
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
        private void btnItemAction_Click(object sender, EventArgs e)
        {
            Point pt = gbCommands.PointToScreen(btnItemAction.Location);
            cmsItemAction.Show(pt);
        }
        private void miDeleteItems_Click(object sender, EventArgs e)
        {
            btnDelete_Click(sender,e);
        }
        private void miMultipleEdit_Click(object sender, EventArgs e)
        {
            btnMultipleEdit_Click(sender, e);
        }
        private void miItemHistory_Click(object sender, EventArgs e)
        {
            btnHistory_Click(sender, e);
        }
        private void miExportTable_Click(object sender, EventArgs e)
        {
            btnExcel_Click(sender, e);
        }
        private void btnTableAction_Click(object sender, EventArgs e)
        {
            Point pt = gbCommands.PointToScreen(btnTableAction.Location);
            cmsTableAction.Show(pt);
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            Point pt = gbCommands.PointToScreen(btnPrint.Location);
            cmsPrint.Show(pt);
        }
        private void miPrintAssignementForm_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
        private void miPrintTemporary_Click(object sender, EventArgs e)
        {
            btnTemporaryForm_Click(sender, e);
        }
        private void miPrintReturnForm_Click(object sender, EventArgs e)
        {
            btnReturningForm_Click(sender, e);
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            Point pt = gbCommands.PointToScreen(btnCreate.Location);
            cmsCreate.Show(pt);
        }
        private void gbCommands_Enter(object sender, EventArgs e)
        {

        }
        private void miCreateAssignement_Click(object sender, EventArgs e)
        {
            CreateForm("1");
        }
        private void miCreateTemporary_Click(object sender, EventArgs e)
        {
            CreateForm("2");
        }
        private void tmCreateReturn_Click(object sender, EventArgs e)
        {
            CreateForm("3");
        }
        private void miReprint_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ReprintForm rf = new ReprintForm();
            rf.ShowDialog();
            Cursor.Current = Cursors.Default;
        }
        private void gbFilter_Enter(object sender, EventArgs e)
        {

        }
        private void miExportItems_Click(object sender, EventArgs e)
        {
            ExportSelected();
        }
        private void miAssign_Click(object sender, EventArgs e)
        {
            try
            {
                if (outlookGrid1.SelectedRows.Count == 1)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    DataGridViewRow dgvr = outlookGrid1.SelectedRows[0];// Rows[Convert.ToInt32(Selected)];
                    Assign ai = new Assign(dgvr);
                    ai.Text = "Assign Item";
                    ai.ShowDialog();

                    if (ai.CreateAssignment)
                    {
                        miCreateAssignement_Click(sender, e);
                    }
                    else
                        ExecuteSearch();
                    Cursor.Current = Cursors.Default;
                }
                else if (outlookGrid1.SelectedRows.Count > 0)
                {
                    String Selected = "";
                    String Selected_Ids = "";
                    foreach (DataGridViewRow dr in outlookGrid1.Rows)
                    {
                        if (dr.Selected)
                        {
                            if (Selected.Length > 0)
                            {
                                Selected += "," + dr.Index.ToString();
                                Selected_Ids += "," + dr.Cells["ItemID"].Value.ToString();
                            }
                            else
                            {
                                Selected = dr.Index.ToString();
                                Selected_Ids = dr.Cells["ItemID"].Value.ToString();
                            }
                            if (Convert.ToInt32(dr.Cells["Quantity"].Value) > 1)
                                goto end;
                        }
                    }

                    Cursor.Current = Cursors.WaitCursor;
                    AssignMore ai = new AssignMore(Selected_Ids);
                    ai.Text = "Assign Items";
                    ai.ShowDialog();

                    if (ai.CreateAssignment)
                    {
                        miCreateAssignement_Click(sender, e);
                    }
                    else
                    {
                        ExecuteSearch();
                    }
                    end: ;
                    Cursor.Current = Cursors.Default;
                }              
            }
            catch { }
        }
        private void miReturn_Click(object sender, EventArgs e)
        {
            try
            {
                if (outlookGrid1.SelectedRows.Count > 0)
                {
                    String Selected = "";
                    String Selected_Ids = "";
                    foreach (DataGridViewRow dr in outlookGrid1.Rows)
                    {
                        if (dr.Selected)
                        {
                            if (Selected.Length > 0)
                            {
                                Selected += "," + dr.Index.ToString();
                                Selected_Ids += "," + dr.Cells["ItemID"].Value.ToString();
                            }
                            else
                            {
                                Selected = dr.Index.ToString();
                                Selected_Ids = dr.Cells["ItemID"].Value.ToString();
                            }
                        }
                    }

                    Cursor.Current = Cursors.WaitCursor;
                    Return r = new Return(Selected_Ids);
                    r.Text = "Return Items";
                    r.ShowDialog();

                    if (r.CreateAssignment)
                    {
                        CreateForm("3", true);
                    }
                    else
                    {
                        ExecuteSearch();
                    }
                    Cursor.Current = Cursors.Default;
                }
            }
            catch { }
        }
        private void btnAssignReturn_Click(object sender, EventArgs e)
        {
            Point pt = gbCommands.PointToScreen(btnAssignReturn.Location);
            cmsAssignReturn.Show(pt);
        }

        private void btnAssignementForms_Click(object sender, EventArgs e)
        {
            AssignementForm_Preview afp = new AssignementForm_Preview();
            afp.Show();
        }
        #endregion
    }
}